using AudenTest.CoreUI;
using AudenTest.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;


namespace AudenTest.Pages
{
    public class ShortTermLoanPage
    {
        protected WebDriverSupport _driverSupport = new WebDriverSupport();
        #region ShortTermLoanPage Elements
        [FindsBy(How = How.Id, Using = "consent_prompt_submit")]
        private IWebElement AcceptAllButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='date-selector__flex']//*[text()='3']")]
        private IWebElement MonthSelection { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='range']")]
        private IWebElement AmountSlider { get; set; }

        public bool HeaderAmountTest(string amount)
        {
            return _driverSupport.FindNewElement(By.XPath($"//*[@class='loan-amount__header__amount']/span[contains(text(), '{amount}')]")).WaitUntilDisplayed();
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='loan-summary__column__amount__value'][0]")]
        private IWebElement LoanAmount { get; set; }
        public bool LoanAmountTest(string amount)
        {
            return _driverSupport.FindNewElement(By.XPath($"//*[@class='loan-summary__column__amount']//following-sibling::span[contains(text(), '{amount}')]")).WaitUntilDisplayed();
        }
        #endregion

        #region ShortTermLoanPage Actions
        public void ClickAccept()
        {
            AcceptAllButton.ClickElement();
        }
        public void SelectMonth()
        {
            MonthSelection.ClickElement();
        }

        public void ClickSliderAmount(int x, int y)
        {
            WebDriverSupport.SliderAmountClick(AmountSlider, x, y);
        }

        public void VerifyHeaderAmount(string amount)
        {
            Assert.IsTrue(HeaderAmountTest(amount));
        }

        public void VerifyLoanAmount(string amount)
        {
          //  Assert.IsTrue(LoanAmountTest(amount));
        }
        #endregion
    }
}
