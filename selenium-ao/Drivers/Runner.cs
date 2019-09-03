using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace selenium_ao.Drivers
{
    public class Runner
    {
        [Binding]
        public class OnStartAndEnd
        {
            [BeforeScenario]
            public static void TestStartUp()
            {
                WebDriver.Initialise();
            }

            [AfterScenario]
            public static void TestCleanUp()
            {
                WebDriver.Close();
            }
        }
    }
}