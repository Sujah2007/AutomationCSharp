using OpenQA.Selenium;
using SampleAutomation.UI.CommonMethods;
using SampleAutomation.UI.PageObjectModel;
using System;
using TechTalk.SpecFlow;

namespace SampleAutomation.UI.StepBindings
{
    [Binding]
    public class SampleLoginSteps
    {

        public static IWebDriver myDriver;
        public Driver myLogin = new Driver(myDriver);
        CommonHelper helper = new CommonHelper();
        HomePage home = new HomePage();
        [Given(@"The browser home page is open")]
        public void GivenTheBrowserHomePageIsOpen()
        {
            myDriver = myLogin.Initialize("chrome", myDriver);
            myLogin.StartWalmart(myDriver, helper.readConfig("url"));
            
        }

        [When(@"Enter the username and password")]
                public void WhenEnterTheUsernameAndPassword()
                {
            home.useSearch(myDriver, helper.readConfig("searchText"));
                   
                }
                
        [Then(@"validate the successful logins")]
        public void ThenValidateTheSuccessfulLogins()
        {
            myDriver.Close();
            myDriver.Quit();
        }
    }
}
