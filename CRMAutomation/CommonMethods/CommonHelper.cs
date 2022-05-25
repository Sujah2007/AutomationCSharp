using SampleAutomation.Config;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace SampleAutomation.UI.CommonMethods
{
    public class CommonHelper : Driver
    {


        public static string sessionID = "";
        //public static string response = "";
        public CommonHelper() : this(null)
        {
        }

        public CommonHelper(IWebDriver myDriver) : base(myDriver)
        {
            this.myDriver = myDriver;
        }
        
        public string readConfig(string item)
        {
            
            ExeConfigurationFileMap map = new ExeConfigurationFileMap { ExeConfigFilename = @"..\..\..\App.UAT.config" };
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
            string keyValue = config.AppSettings.Settings[item].Value;
            Console.WriteLine(keyValue);
            return keyValue;
        }


        public string readTextFile(string filePath)
        {
            string text = File.ReadAllText(filePath);
            return text;
        }
        


       

        
        }


    }
