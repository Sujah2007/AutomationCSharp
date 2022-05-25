using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SampleAutomation.UI.PageObjectModel
{
    public class HomePage : Driver
    {
        public HomePage() : this(null)
        {
        }
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebDriver WebDriver { get; }

        public IWebElement txtSerachBar => WebDriver.FindElement(By.Id("content"));
        

        public HomePage useSearch(IWebDriver myDriver,string searchText)
        {
            txtSerachBar.SendKeys(searchText);
            txtSerachBar.SendKeys(Keys.Enter);
                
            return new HomePage(myDriver);
        }
    }
}
