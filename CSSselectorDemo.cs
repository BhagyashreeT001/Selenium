using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumProject1
{
    class CSSselectorDemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello");
            //Launch Browser
            IWebDriver driver = new ChromeDriver("F:\\Zensar\\selenium_session\\Selenium_Webdriver");

            driver.Manage().Window.Maximize();

            //Open url(open google)
            driver.Url = "https://www.google.co.in/";

            //driver.Url = "https://accounts.google.com/signup/v2/webcreateaccount?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&biz=false&flowName=GlifWebSignIn&flowEntry=SignUp";
            //By LinkText

            //driver.FindElement(By.CssSelector("input.whsOnd")).SendKeys("Bhagyashree");
            //driver.FindElement(By.CssSelector(".whsOnd")).SendKeys("Tipare");
            //driver.FindElement(By.CssSelector("input#firstName")).SendKeys("Bhagyashree");
            //driver.FindElement(By.CssSelector("#lastName")).SendKeys("Tipare");

            //By  atrribute
            driver.FindElement(By.CssSelector("input[role='combobox']")).SendKeys("Selenium");

            //starts with
            //driver.FindElement(By.CssSelector("input[role^='comb']")).SendKeys("Selenium");

            //contains
            //driver.FindElement(By.CssSelector("input[role*='com']")).SendKeys("Selenium");

            //ends with
            //driver.FindElement(By.CssSelector("input[role$='box']")).SendKeys("Selenium");


            Thread.Sleep(3000);
            //Close Browser
            driver.Close();
        }
    }
}
