using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Momondo
{
    

        public class CheckIfTextFieldExists
            {
                public string url { get; set; }
                public string name { get; set; }
                

                public bool checkIfTextFieldExists()
                            {

                             IWebDriver driver = new ChromeDriver();
                             IWebElement element;

                            

                            driver.Navigate().GoToUrl(url);
                            element = driver.FindElement(By.Name(name));
                                
                                    if (element.Displayed)
                                        {
                                            return true;
                                        } else
                                            {
                                                return false;
                                            }
                            driver.Quit();
                            }
            
            }


}
