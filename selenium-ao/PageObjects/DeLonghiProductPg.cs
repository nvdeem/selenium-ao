﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_ao.PageObjects
{
    class DeLonghiProductPg
    {
        /* Elements */
        
        private IWebElement DeLonghiProductName()
        {
            return WebDriver.Browser.FindElement(By.XPath("//h1[@class='title']"));
        }

        public bool DeLonghiProductNameDisplayed()
        {
            return DeLonghiProductName().Displayed;
        }
    }
}