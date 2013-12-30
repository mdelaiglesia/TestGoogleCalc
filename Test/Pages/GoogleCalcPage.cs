using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Test.Pages
{
    public class GoogleCalcPage
    {
        public decimal Result { get { return Convert.ToDecimal(result.Text); } }

        [FindsBy(How = How.Id, Using = "cwbt34")]
        private IWebElement two;

        [FindsBy(How = How.Id, Using = "cwbt46")]
        private IWebElement add;

        [FindsBy(How = How.Id, Using = "cwbt45")]
        private IWebElement equals;

        [FindsBy(How = How.Id, Using = "cwos")]
        private IWebElement result;

        public GoogleCalcPage(IWebDriver driver) { }

        public GoogleCalcPage EnterNumber(double number)
        {
            two.Click();

            return this;
        }

        public GoogleCalcPage PressAdd() 
        {
            add.Click();

            return this;
        }

        public GoogleCalcPage PressEquals()
        {
            equals.Click();

            return this;
        }
    }
}
