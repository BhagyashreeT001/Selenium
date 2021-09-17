using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumProject1
{
    class MultiSelectDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASSIGNMENT 4");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("F:\\Zensar\\selenium_session\\Selenium_Webdriver");

            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = ("https://formstone.it/components/dropdown/demo/");
            IWebElement select_box = driver.FindElement(By.Name("demo_multiple"));
            SelectElement select = new SelectElement(select_box);
            Boolean stutus_multiselct = select.IsMultiple;
            Console.WriteLine(stutus_multiselct);
            select.SelectByIndex(1);
            select.SelectByValue("2");
            select.SelectByText("Two");
            //select.SelectByText("One");



            //Thread.Sleep(3000);
            //Closing Browser
            //driver.Close();
        }


    }

   
}
