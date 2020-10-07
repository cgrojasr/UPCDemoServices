using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UPC.Demo.BE;
using System.Runtime.InteropServices;

namespace UPC.Demo.DA.UT
{
    /// <summary>
    /// Summary description for UserUT
    /// </summary>
    [TestClass]
    public class UserUT
    {

        UserDA objUserDA;
        public UserUT()
        {
            objUserDA = new UserDA();
        }        

        [TestMethod]
        public void Register()
        {
            var objUserBE = new UserBE();

            objUserBE.UserName = "pciscroj";
            objUserBE.Password = Encoding.ASCII.GetBytes("Camila1101");
            objUserBE.Email = "pciscroj@upc.edu.pe";

            var result = objUserDA.Register(objUserBE);

            Assert.AreEqual(1, result.Id);
        }
    }
}
