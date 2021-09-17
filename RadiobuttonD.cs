using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject1
{
    class RadiobuttonD
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //Launch Chrome
            IWebDriver driver = new ChromeDriver("F:\\Zensar\\selenium_session\\Selenium_Webdriver");
            //Maximize the Browser
            driver.Manage().Window.Maximize();
            //Launch Url
            driver.Url = "https://www.seleniumeasy.com/test/basic-radiobutton-demo.html";
            //IReadOnlyCollection<IWebElement> Radiobtn = driver.FindElements(By.Name("optradio"));
            ReadOnlyCollection<IWebElement> radio_buttons = driver.FindElements(By.Name("optradio"));
            radio_buttons[1].Click();
            radio_buttons[1].Click();


        }

    }
}
