//using selenium_ao.PageObjects;
//using System;
//using System.Threading;
//using NUnit.Framework;

//namespace selenium_ao.Steps
//{
//    public class Steps
//    {
//        private readonly SmallAppliancesPg smallAppliancesPage = new SmallAppliancesPg();
//        private readonly CoffeeMachinesPg coffeeMachinesPage = new CoffeeMachinesPg();
//        private readonly EspressoListerPg espressoListerPage = new EspressoListerPg();
//        private readonly DeLonghiProductPg deLonghiProductPage = new DeLonghiProductPg();

//public void CheckIAmOnTheSmallAppliancesPg()
//{
//    try
//    {
//        var onSmallAppliancesPg = smallAppliancesPage.ThenIAmOnTheSmallAppliancesPg();
//        Assert.AreEqual(onSmallAppliancesPg, true);
//        Console.WriteLine("Assertion: The small appliances title is present");
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine("I cannot assert the small appliance title is present" + Environment.NewLine +
//            "---------------------------------------" + Environment.NewLine + e.StackTrace);
//    }
//}

//        public void ClickTheCoffeeMachinesBtn()
//        {
//            try
//            {
//                var coffeeMachinesBtnIsPresent = smallAppliancesPage.CheckCoffeeMachinesBtn();
//                Assert.AreEqual(coffeeMachinesBtnIsPresent, true);
//                Thread.Sleep(2000);
//                smallAppliancesPage.ClickCoffeeBtn();
//                Console.WriteLine("Assertion: The coffee machines button is present and working");
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("I cannot assert that the coffee machines button is present/working" + Environment.NewLine +
//                    "---------------------------------------" + Environment.NewLine + e.StackTrace);
//            }
//        }

//        public void CheckIAmOnTheCoffeeMachinesPg()
//        {
//            try
//            {
//                var onCoffeeMachinesPage = coffeeMachinesPage.ThenIAmOnTheCoffeeMachinesPg();
//                Assert.AreEqual(onCoffeeMachinesPage, true);
//                Console.WriteLine("Assertion: I am on the coffee machines page");
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("I cannot assert that I am on the coffee machines page" + Environment.NewLine +
//                    "---------------------------------------" + Environment.NewLine + e.StackTrace);
//            }
//        }

//        public void ClickEspressoBtn()
//        {
//            try
//            {
//                coffeeMachinesPage.ClickEspressoBtn();
//                Thread.Sleep(2000);
//                Assert.IsTrue(espressoListerPage.EspressoListerDisplayed());
//                Console.WriteLine("Assertion: The espresso button is working");
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("I cannot assert that the espresso machines button is working" + Environment.NewLine +
//                    "---------------------------------------" + Environment.NewLine + e.StackTrace);
//            }
//        }

//        public void ClickGridView()
//        {
//            try
//            {
//                espressoListerPage.ClickGridView();
//                Thread.Sleep(2000);
//                Assert.IsTrue(espressoListerPage.EspressoListerDisplayed());
//                Console.WriteLine("Assertion: The grid view toggle is functioning");
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("I cannot assert that the grid view button is working" + Environment.NewLine +
//                    "---------------------------------------" + Environment.NewLine + e.StackTrace);
//            }
//        }

//        public void ClickDeLonghiMoreInfo()
//        {
//            try
//            {
//                espressoListerPage.ClickMoreInfoDeLonghi();
//                Thread.Sleep(2000);
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("Fail" + e.StackTrace);
//            }
//        }

//        public void CheckDeLonghiProductHeadingExists()
//        {
//            try
//            {
//                Assert.IsTrue(deLonghiProductPage.DeLonghiProductNameDisplayed());
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("Fail" + e.StackTrace);
//            }
//        }
//    }
//}