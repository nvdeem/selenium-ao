﻿using OpenQA.Selenium;
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
            ChromeOptions runHeadless = new ChromeOptions();
            runHeadless.AddArgument("--headless");

            /*** UNCOMMENT TO RUN HEADLESS ***/
            Browser = new ChromeDriver(/*runHeadless*/);
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