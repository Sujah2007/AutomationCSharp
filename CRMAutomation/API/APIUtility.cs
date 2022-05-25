using Newtonsoft.Json;
using OpenQA.Selenium;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SampleAutomation.API
{
    public class APIUtility:Driver
    {
        public APIUtility() : this(null)
        {
        }

        public APIUtility(IWebDriver myDriver) : base(myDriver)
        {
            this.myDriver = myDriver;
        }
        List<string> ids = new List<string>();

         
   
    }
}
