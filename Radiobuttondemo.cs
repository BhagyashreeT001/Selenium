using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject1
{
    class Radiobuttondemo
    {
        static void Main(string[] args)
        {
            
            
            IWebDriver driver = new ChromeDriver("F:\\Zensar\\selenium_session\\Selenium_Webdriver");
            //Maximize the Browser
            driver.Manage().Window.Maximize();

            driver.Url = ("https://www.seleniumeasy.com/test/basic-radiobutton-demo.html");
            ReadOnlyCollection<IWebElement> radiobutton1 = driver.FindElements(By.Name("gender"));
            radiobutton1[0].Click();
            Thread.Sleep(3000);
            ReadOnlyCollection<IWebElement> radiobutton2 = driver.FindElements(By.Name("gender"));
            radiobutton2[0].Click();
            Thread.Sleep(3000);

        }
    }
}
   
