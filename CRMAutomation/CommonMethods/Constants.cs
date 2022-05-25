using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAutomation.CommonMethods
{
    public class Constants:Driver
    {
        public Constants() : this(null)
        {
        }
        public Constants(IWebDriver webDriver) : base(webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebDriver WebDriver { get; }

        public const int lowWaitTime = 1000 ;
        public const int mediumWaitTime = 6000;
        public const int highWaitTime = 10000;
    }
}
