using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace Selenium.Framework.Core
{
    public class LoginPage
    {
        private static string Url => "https://antecipa.net.br/jbs/";
        private static string Title => "Portal de Antecipações";

        [FindsBy(How = How.Name, Using = "usuario")]
        private IWebElement usuarioInput;

        [FindsBy(How = How.Name, Using = "senha")]
        private IWebElement senhaInput;

        public void Goto()
        {
            Browser.GoTo(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == Title;
        }

        public void SignIn(string login, string senha)
        {
            throw new NotImplementedException();
        }
    }
}