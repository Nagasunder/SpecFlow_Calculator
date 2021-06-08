using FluentAssertions;
//using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowDateCalculator.Features
{
    [Binding]
    public class CalculatorSteps
    {

        private WindowsDriver<WindowsElement> _driver;
        private object calculatorResult;

        [Given(@"Launch Calculator in DateCalculator Mode")]
        public void GivenLaunchCalculatorInDateCalculatorMode()
        {
            var options = new AppiumOptions();
            options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            options.AddAdditionalCapability("deviceName", "WindowsPC");
            _driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);
            _driver.FindElementByName("Open Navigation").Click();
            _driver.FindElementByName("Date Calculation Calculator").Click();
            //_driver.FindElementByName("Clear").Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        //[Given(@"Screen Clear")]
        //public void GivenScreenClear()
        //{
        //    _driver.FindElementByName("Clear").Click();
        //}
        
        [Given(@"Click From")]
        public void GivenClickFrom()
        {
            _driver.FindElementByName("From").Click();
        }
        
        [Given(@"Click Previous")]
        public void GivenClickPrevious()
        {
            
            _driver.FindElementByName("Previous").Click();
        }
        
        [Given(@"Select (.*)")]
        public void GivenSelect()
        {
            Thread.Sleep(5000);
            _driver.FindElementByName("4").Click();
        }
        
        [Given(@"Click To")]
        public void GivenClickTo()
        {
            _driver.FindElementByName("To").Click();
        }
        
        [Given(@"ClickPrevious")]
        public void GivenClickprevious()
        {
            _driver.FindElementByName("Previous").Click();
        }

        [Given(@"Select (.*)")]
        public void Givenselect(int p0)
        {
            _driver.FindElementByName("10").Click();
        }
        [Then(@"The result should be (.*) week, (.*) day")]
        public object ThenTheResultShouldBeWeekDay(int p0, int p1)
        {
            return calculatorResult;
        }
        
        [Then(@"End Calculator")]
        public void ThenEndCalculator()
        {
            _driver.FindElementByName("Close Calculator").Click();
        }
    }
}
