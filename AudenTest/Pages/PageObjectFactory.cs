using AudenTest.CoreUI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AudenTest.Pages
{
  public  class PageObjectFactory
    {
        public IWebDriver _driver;
        public BasePage _basePage;
        public PageObjectFactory(IWebDriver driver, BasePage basePage)
        {
            _driver = driver;
            _basePage = basePage;
        }

        public ShortTermLoanPage ShortTermLoanPage()
        {
            return _basePage.GetPage<ShortTermLoanPage>(_driver);
        }
    }
}
