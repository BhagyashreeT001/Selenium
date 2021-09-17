using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject1
{
    class checkboxDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //Launch Chrome
            IWebDriver driver = new ChromeDriver("F:\\Zensar\\selenium_session\\Selenium_Webdriver");
            //Maximize the Browser
            driver.Manage().Window.Maximize();
            //Launch Url
            //driver.Url = "https://accounts.google.com/signup/v2/webcreateaccount?continue=https%3A%2F%2Fmyaccount.google.com%3Futm_source%3Daccount-marketing-page%26utm_medium%3Dcreate-account-button&flowName=GlifWebSignIn&flowEntry=SignUp";
            driver.Url = "https://preview.colorlib.com/theme/bootstrap/checkbox-01/";
            IWebElement check_box = driver.FindElement(By.ClassName("col-md-4"));
            check_box.Click();


        }
    }
}
