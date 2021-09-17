using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

namespace SeleniumProject1
{
    class Titledemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASSIGNMENT 3");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("F:\\Zensar\\selenium_session\\Selenium_Webdriver");

            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://www.google.co.in/";

            string title = driver.Title;
            Console.WriteLine(title);

            driver.FindElement(By.LinkText("Gmail")).Click();
            Console.WriteLine(title);
            //Thread.Sleep(3000);
            //Closing Browser
            //driver.Close();
        }
    }
}