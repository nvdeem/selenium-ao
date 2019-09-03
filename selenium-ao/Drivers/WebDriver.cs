using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_ao
{
    public static class WebDriver
    {
       public static IWebDriver Browser { get; set; }

       public static void Initialise()
        {
            Browser = new ChromeDriver();
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("https://beta-aol.ao-qa.com/small-appliances");
        } 

        public static void Close()
        {
            Browser.Quit();
            Browser = null;
        }
    }
}