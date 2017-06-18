
using OpenQA.Selenium;

namespace WorldNomads.UITests
{
    public class SeleniumSetMethods
    {
        public static void EnterInputNumber(IWebDriver driver,string element,int value,string elementType)
        {

            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value.ToString());
            }
            if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value.ToString());
            }

        }

        public static void ClickCalculateButton(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).Click();
            }
            if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).Click();
            }
        }
    }
}
