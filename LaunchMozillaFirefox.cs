using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace SeleniumProjecta
{
    class LaunchMozillaFirefox
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Mozilla-Firefox browser is launched");
            //Launch Browser
            IWebDriver driver = new FirefoxDriver("F:\\Zensar\\selenium_session\\Selenium_Webdriver");

            //Maximize browser
            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://www.instagram.com/";

            //Close Browser
            //driver.Close();
        }
    }
}

