using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium_ao
{
    public static class WebDriver
    {
        public static IWebDriver Browser { get; set; }

        public static void Initialise()
        {
            ChromeOptions runHeadless = new ChromeOptions();
            runHeadless.AddArgument("--headless");

            /*** UNCOMMENT TO RUN HEADLESS/RUN AS NORMAL ***/
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