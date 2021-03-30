using AudenTest.CoreUI;
using AudenTest.Pages;
using System;
using TechTalk.SpecFlow;

namespace AudenTest.Steps
{

    [Binding]
    public class ShortTermLoanSteps
    {

        private PageObjectFactory _page;
        public ShortTermLoanSteps(PageObjectFactory page)
        {
            _page = page;
        }
        [Given(@"I navigate into Auden")]
        public void GivenINavigateIntoAuden()
        {
            BasePage.NavigateToUrl(AppConfigManager.BaseUrl());
            _page.ShortTermLoanPage().ClickAccept();
        }

        [Given(@"I select repayment date as '(.*)'")]
        public void GivenISelectRepaymentDateAs(int day)
        {
            _page.ShortTermLoanPage().SelectRepaymentDay(day);
        }

        [When(@"I select the amount form the slider '(.*)' and '(.*)'")]
        public void WhenISelectTheAmountFormTheSliderAnd(int x, int y)
        {
            _page.ShortTermLoanPage().ClickSliderAmount(x, y);
        }

        [Then(@"I verify the selected amount as '(.*)'")]
        public void ThenIVerifyTheSelectedAmountAs(string amount)
        {
            _page.ShortTermLoanPage().VerifyHeaderAmount(amount);

        }
        [Then(@"I verify the loan amount as '(.*)'")]
        public void ThenIVerifyTheLoanAmountAs(string amount)
        {
            _page.ShortTermLoanPage().VerifyLoanAmount(amount);
        }
        [Then(@"I verify the selected date '(.*)' is highlighted")]
        public void ThenIVerifyTheSelectedDateIsHighlighted(int day)
        {
            _page.ShortTermLoanPage().VerifySelectedDateSelection(3);
           
        }



    }
}
