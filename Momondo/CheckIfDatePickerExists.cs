using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Momondo
{
    public class CheckIfDatePickerExists
    {

        public string url { get; set; }
        public string xPath { get; set; }


        public bool checkIfDatePickerExists()
                    {

                        IWebDriver driver = new ChromeDriver();
                        IWebElement element;
                        

                        driver.Navigate().GoToUrl(url);
                        element = driver.FindElement(By.XPath(xPath));

                                    if (element.Displayed)
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        return false;
                                    }
                        driver.Quit();
                    }

        
    }
}
