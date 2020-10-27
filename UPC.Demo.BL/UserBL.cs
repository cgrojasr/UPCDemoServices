using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.Demo.BE;
using UPC.Demo.DA;

namespace UPC.Demo.BL
{
    public interface IUserDA
    {
        UserBE.Login Login(UserBE.Authentication objUserBE);
        UserBE.Entity Register(UserBE.Entity objUserBE);
        UserBE.Entity Update(UserBE.Entity objUserBE);
        IEnumerable<UserBE.Entity> ListWithFilters(bool? active);
        bool ChangePassword(UserBE.ChangePassword objUserBE);
    }

    public class UserBL : IUserDA
    {
        UserDA objUserDA;

        public UserBL()
        {
            objUserDA = new UserDA();
        }

        public bool ChangePassword(UserBE.ChangePassword objUserBE)
        {
            try
            {
                var objUserBEAuth = new UserBE.Authentication {
                    UserName = objUserBE.UserName,
                    Password = objUserBE.OldPassword
                };

                var result = objUserDA.Login(objUserBEAuth);
                return objUserDA.ChangePassword(result.Id, objUserBE.NewPassword);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<UserBE.Entity> ListWithFilters(bool? active)
        {
            try
            {
                return objUserDA.ListWithFilters(active);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public UserBE.Login Login(UserBE.Authentication objUserBE)
        {
            try
            {
                return objUserDA.Login(objUserBE);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public UserBE.Entity Register(UserBE.Entity objUserBE)
        {
            try
            {
                return objUserDA.Register(objUserBE);
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
                return objUserDA.Update(objUserBE);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
