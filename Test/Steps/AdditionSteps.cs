using System;
using TechTalk.SpecFlow;
using Test.Pages;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Test.Steps
{
    [Binding]
    public class AdditionSteps
    {
        private GoogleCalcPage googleCalcPage;

        [BeforeFeature]
        public static void BeforeFeature()
        {
            BasePageObject.CreateDriver();
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            BasePageObject.QuitDriver();
        }

        public AdditionSteps()
        {
            googleCalcPage = PageFactory.InitElements<GoogleCalcPage>(BasePageObject.Driver);
        }

        [Given(@"I have entered into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator()
        {
            BasePageObject.Driver.Navigate().GoToUrl("http://www.google.com/search?q=0%2B0");
        }

        [When(@"I enter number '(.*)'")]
        public void WhenIEnterNumber(int p0)
        {
            googleCalcPage.EnterNumber(p0);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            googleCalcPage.PressAdd();
        }

        [When(@"I press equals")]
        public void WhenIPressEquals()
        {
            googleCalcPage.PressEquals();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, googleCalcPage.Result);
        }
    }
}
