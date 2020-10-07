using System;
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
            objUserBE.Password = Encoding.ASCII.GetBytes("Camila1101");
            objUserBE.Email = "pciscroj@upc.edu.pe";
            objUserBE.UserModifyId = 0;

            var result = objUserBL.Register(objUserBE);

            Assert.AreEqual(1, result.Id);
        }
    }
}
