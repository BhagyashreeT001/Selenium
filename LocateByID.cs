using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject1
{
    class LocateByID
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is locate by ID Practical");

            IWebDriver driver = new ChromeDriver("F:\\Zensar\\selenium_session\\Selenium_Webdriver");
            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://accounts.google.com/signup/v2/webcreateaccount?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&biz=false&flowName=GlifWebSignIn&flowEntry=SignUp";

            //Enter FirstName in input box
            // IWebElement inputbox = driver.FindElement(By.Id("firstName"));
            // inputbox.SendKeys("Bhagyashree");

            //driver.FindElement(By.Id("firstName")).SendKeys("Bhagyashree");
            driver.FindElement(By.CssSelector("#firstName")).SendKeys("Bhagyashree");
            driver.FindElement(By.CssSelector("#lastName")).SendKeys("Tipare");
            //driver.Close();
        }
    }
}
