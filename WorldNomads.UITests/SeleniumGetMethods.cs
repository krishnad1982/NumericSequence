
using OpenQA.Selenium;

namespace WorldNomads.UITests
{
    public class SeleniumGetMethods
    {
        public static string GetInputNumber(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
            {
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            }
            if (elementType == "Name")
            {
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            }
            else
                return string.Empty;
        }

        public static string GetSequence(IWebDriver driver, string element, string elementType)
        {

            if (elementType == "Id")
            {
                return driver.FindElement(By.Id(element)).Text;
            }
            else
                return string.Empty;
            
        }


    }
}
