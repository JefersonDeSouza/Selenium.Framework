using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;

namespace Selenium.Framework
{
    public class LoginPage
    {
        private static string Url => "https://antecipa.net.br/jbs/";
        private static string Title => "Portal de Antecipações";

        [FindsBy(How = How.CssSelector, Using = "#formulario-login > div > form > div:nth-child(1) > div > div > input")]
        private IWebElement usuarioInput;

        [FindsBy(How = How.CssSelector, Using = "#formulario-login > div > form > div:nth-child(2) > div > div > input")]
        private IWebElement senhaInput;

        [FindsBy(How = How.CssSelector, Priority = 1, Using = "#formulario-login > div > form > div:nth-child(3) > div > div > botao > button")]
        private IWebElement botaoEntrar;
        
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
            usuarioInput.SendKeys(login);
            senhaInput.SendKeys(senha);
            //botaoEntrar.Click();

            //driver.findElement(By.xpath("//span[text()='Submit']")).click();

             IWebElement elementButton = Browser.Driver.FindElement(By.CssSelector("#formulario-login > div > form > div:nth-child(3) > div > div > botao > button.btn-primary"));

            Actions actions = new Actions(Browser.Driver);
            actions.MoveToElement(elementButton).Click().Build().Perform();
            actions.Click();            
        }
    }
}