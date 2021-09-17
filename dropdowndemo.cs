﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject1
{
    class dropdowndemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //Launch Chrome
            IWebDriver driver = new ChromeDriver("F:\\Zensar\\selenium_session\\Selenium_Webdriver");
            //Maximize the Browser
            driver.Manage().Window.Maximize();
            //Launch Url
            driver.Url = ("https://formstone.it/components/dropdown/demo/");
            IWebElement select_box = driver.FindElement(By.Id("demo_basic"));
            SelectElement select = new SelectElement(select_box);
            //select.SelectByIndex(1);
            //select.SelectByValue("2");
            //select.SelectByText("Two");
            select.SelectByText("One");
        }

    }
}
