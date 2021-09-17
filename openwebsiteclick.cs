using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumProject1
{
    class openwebsiteclick
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //Launch Chrome
            IWebDriver driver = new ChromeDriver("F:\\Zensar\\selenium_session\\Selenium_Webdriver");
            //Maximize the Browser
            driver.Manage().Window.Maximize();
            //Launch Url
            //driver.Url = ("https://www.google.co.in/");
            //Open Link
            driver.Url = "https://www.w3schools.com/jsref/met_win_alert.asp";
            driver.FindElement(By.LinkText("Try it Yourself »")).Click();
            driver.FindElement(By.LinkText("Try it")).Click();
            // Close the Browser
            // driver.Close();

        }
    }
}
