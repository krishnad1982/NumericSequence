using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace WorldNomads.UITests
{
    [TestFixture]
    class Program
    {
        //Create reference for our browser
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to Google page
            driver.Navigate().GoToUrl("http://localhost:57524/");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            try
            {
                CheckIfInputNumberFieldIsDisplayed();

                CheckIfCalculateButtonIsDisplayed();

                SeleniumSetMethods.EnterInputNumber(driver, "txtNumber", 10, "Id");
                SeleniumSetMethods.ClickCalculateButton(driver, "btnSubmit", "Id");

                var inputNumber = SeleniumGetMethods.GetInputNumber(driver, "txtNumber", "Id");
                Console.WriteLine("Value of input number is {0} ", inputNumber);

                var numericSequence = SeleniumGetMethods.GetSequence(driver, "sequence", "Id");
                Console.WriteLine("{0}", numericSequence);

                var evenSequence = SeleniumGetMethods.GetSequence(driver, "evenSequence", "Id");
                Console.WriteLine("{0}", evenSequence);

                var oddSequence = SeleniumGetMethods.GetSequence(driver, "oddSequence", "Id");
                Console.WriteLine("{0}", oddSequence);

                var fibSequence = SeleniumGetMethods.GetSequence(driver, "fibSequence", "Id");
                Console.WriteLine("{0}", fibSequence);


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed URL");
        }

        private void CheckIfInputNumberFieldIsDisplayed()
        {
            try
            {
                IWebElement element = driver.FindElement(By.Name("inputNumber"));
                if (element.Displayed)
                {
                    Console.WriteLine("InputNumber field is displayed on the web page");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("There is no Input Number field on the web page");
            }
        }

        private void CheckIfCalculateButtonIsDisplayed()
        {
            try
            {
                IWebElement element = driver.FindElement(By.Name("btnCalculate"));
                if (element.Displayed)
                {
                    Console.WriteLine("Calculate button is displayed on the web page");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No Calculate button on the webpage!");
            }

        }

    }
}
