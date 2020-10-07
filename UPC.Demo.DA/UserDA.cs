using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UPC.Demo.BE;

namespace UPC.Demo.DA
{
    public interface IUserDA {
        UserBE.Entity Login(UserBE.Authentication objUserBE);
        UserBE.Entity Register(UserBE.Entity objUserBE);
        UserBE.Entity Update(UserBE.Entity objUserBE);
        IEnumerable<UserBE.Entity> ListWithFilters(bool? active);
        bool ChangePassword(int idUser, byte[] newPassword);
    }

    public class UserDA : IUserDA
    {
        private readonly dmUPCDemoDataContext db;
        public UserDA()
        {
            db = new dmUPCDemoDataContext();
        }

        public IEnumerable<UserBE.Entity> ListWithFilters(bool? active)
        {
            try
            {
                var query = from user in db.userApps
                            where (user.active.Equals(active) || active == null)
                            select new UserBE.Entity
                            {
                                Id = user.id,
                                UserName = user.username,
                                Email = user.email,
                                Active = user.active
                            };

                return query;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public UserBE.Entity Login(UserBE.Authentication objUserBE)
        {
            try
            {
                var query = from user in db.userApps
                            where user.username.Equals(objUserBE.UserName) && user.password.Equals(objUserBE.Password)
                            select new UserBE.Entity
                            {
                                Id = user.id,
                                UserName = user.username,
                                Email = user.email,
                                Active = user.active
                            };

                return query.Single();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool ChangePassword(int idUser, byte[] newPassword)
        {
            try
            {
                var entity = (from user in db.userApps
                              where user.id.Equals(idUser)
                              select user).Single();

                entity.password = newPassword;
                entity.idUserModify = idUser;
                entity.dateModify = DateTime.Now;
                db.SubmitChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public UserBE.Entity Register(UserBE.Entity objUserBE)
        {
            try
            {
                var entity = new userApp();

                entity.username = objUserBE.UserName;
                entity.email = objUserBE.Email;
                entity.password = objUserBE.Password;
                entity.active = true;
                entity.idUserCreated = objUserBE.UserModifyId;
                entity.dateCreated = DateTime.Now;
                entity.idUserModify = objUserBE.UserModifyId;
                entity.dateModify = DateTime.Now;

                db.userApps.InsertOnSubmit(entity);
                db.SubmitChanges();

                objUserBE.Id = entity.id;
                objUserBE.Active = true;
                return objUserBE;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public UserBE.Entity Update(UserBE.Entity objUserBE)
        {
            try
            {
                var entity = (from user in db.userApps
                             where user.id.Equals(objUserBE.Id)
                             select user).Single();

                entity.username = objUserBE.UserName;
                entity.password = objUserBE.Password;
                entity.email = objUserBE.Email;
                entity.active = objUserBE.Active;
                entity.idUserModify = objUserBE.UserModifyId;
                entity.dateModify = DateTime.Now;

                db.SubmitChanges();

                return objUserBE;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
