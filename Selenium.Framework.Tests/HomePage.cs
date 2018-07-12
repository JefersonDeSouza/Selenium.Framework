using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace Selenium.Framework
{
    public class HomePage
    {
        private static string Url => "https://antecipa.net.br/jbs/home";
        private static string Title => "Portal de Antecipações";

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main - content\"]/section/home-component/daycoval-header/header/div/div/div[3]/p/text()")]
        private IWebElement clienteTexto;

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
            return clienteTexto.Text == cliente;
        }
    }
}
