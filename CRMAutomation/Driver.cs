using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAutomation
{
    public class Driver
    {
        protected IWebDriver myDriver;
        public static bool isInitialized = false;

        public Driver(IWebDriver myDriver)
        {
            this.myDriver = myDriver;
        }

        public IWebDriver Initialize(string browserName, IWebDriver myDriver)
        {
            if (browserName.Equals("chrome"))

            {

                ChromeOptions options = new ChromeOptions();
                IWebDriver driverChrome = new ChromeDriver(options);

                myDriver = driverChrome;

                myDriver.Manage().Window.Maximize();
                isInitialized = true;
            }

            return myDriver;
        }

        public void StartWalmart(IWebDriver myDriver,string item)
        {

            myDriver.Navigate().GoToUrl(item);
            //return new LoginPage(myDriver);
        }
        public void Finalize(IWebDriver myDriver)
        {
            isInitialized = false;
            myDriver.Close();
            myDriver.Quit();
        }
    }
}
