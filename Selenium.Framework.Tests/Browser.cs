using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace Selenium.Framework
{
    public static class Browser
    {
        private static IWebDriver webDriver = new FirefoxDriver(@"C:\Users\Jeferson\source\repos\TestFramework\TestFramework\bin\Debug\netstandard2.0\");
        public static string Title => webDriver.Title;

        public static IWebDriver Driver { get { return webDriver; } }

        public static void GoTo(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Close();
        }
    }
}