using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium.Framework;

namespace Selenium.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Go_To_HomePage()
        {
            Pages.LoginPage.Goto();
            Assert.IsTrue(Pages.LoginPage.IsAt());
        }

        [TestMethod]
        public void Can_Go_To_SignIn()
        {
            Pages.LoginPage.Goto();
            Pages.LoginPage.SignIn("jeferson.souza@bancodaycoval.com.br", "123");
            Assert.IsTrue(Pages.HomePage.IsAtSignIn("JBS"));
        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}
