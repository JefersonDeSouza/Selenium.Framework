using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace Selenium.Framework.Core
{
    public class HomePage
    {
        private static string Url => "https://antecipa.net.br/jbs/home";
        private static string Title => "Portal de Antecipações";

        public void Goto()
        {
            Browser.GoTo(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == Title;
        }

        public bool IsAtSignIn(string cliente)
        {
            throw new NotImplementedException();
        }
    }
}
