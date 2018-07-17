using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace Selenium.Framework
{
    public static class Pages
    {
        public static LoginPage LoginPage
        {
            get
            {
                var loginPage = new LoginPage();
                PageFactory.InitElements(Browser.Driver, loginPage);
                return loginPage;
            }
        }

        public static HomePage HomePage
        {
            get
            {
                var HomePage = new HomePage();
                return HomePage;
            }
        }
    }
}
