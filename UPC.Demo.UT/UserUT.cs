using System;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UPC.Demo.BE;
using UPC.Demo.BL;

namespace UPC.Demo.UT
{
    [TestClass]
    public class UserUT
    {

        UserBL objUserBL;
        public UserUT()
        {
            objUserBL = new UserBL();
        }

        [TestMethod]
        public void Register()
        {
            var objUserBE = new UserBE.Entity();

            objUserBE.UserName = "pciscroj";
            var arrbyte = Encoding.ASCII.GetBytes("Camila1101");
            var str = arrbyte.ToString();
            objUserBE.Password = Encoding.ASCII.GetBytes("Camila1101");
            objUserBE.Email = "pciscroj@upc.edu.pe";
            objUserBE.UserModifyId = 0;

            var result = objUserBL.Register(objUserBE);

            Assert.AreEqual(1, result.Id);
        }

        [TestMethod]
        public void ListWithFilters()
        {
            var result = objUserBL.ListWithFilters(true);

            Assert.AreEqual(3, result.Count());
        }

        [TestMethod]
        public void ChangePassword()
        {
            var request = new UserBE.ChangePassword();
            request.UserName = "pciscroj";
            request.OldPassword = Encoding.ASCII.GetBytes("Camila1101");
            request.NewPassword = Encoding.ASCII.GetBytes("Camila1101");

            var response = objUserBL.ChangePassword(request);

            Assert.AreEqual(true, response);
        }
    }
}
