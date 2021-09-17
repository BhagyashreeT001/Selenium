using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumProject1
{
    class SelectDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASSIGNMENT 4");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("F:\\Zensar\\selenium_session\\Selenium_Webdriver");

            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://formstone.it/components/dropdown/demo/";
            IWebElement select_box = driver.FindElement(By.Id("demo_basic"));
            SelectElement select = new SelectElement(select_box);
            //select.SelectByIndex(1);
            //select.SelectByValue("1");
            select.SelectByText("Two");




            //Thread.Sleep(3000);
            //Closing Browser
            //driver.Close();
        }

       
    }

   
}
