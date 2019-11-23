using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace apiPhoneTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestControllerExistePhoneExists()
        {
            //organizar
            var controller = new apiPhone.Controllers.PhonesController ();
            //ejecuto
            bool reponse = controller.PhoneExists(1);
            //actuar
            Assert.AreEqual(false, reponse);


        }
    }
}
