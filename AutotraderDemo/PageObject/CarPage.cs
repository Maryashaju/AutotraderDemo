using AutotraderDemo.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutotraderDemo.PageObject
{
    class CarPage
    {
            public CarPage()
            {
                driver = Hooks1.driver;
            }

        IWebDriver driver;

        IWebElement postcode => driver.FindElement(By.CssSelector("#postcode"));

        IWebElement cookies => driver.FindElement(By.CssSelector("/html/body/div/div[3]/div[3]/div[2]/button[2]"));

        IWebElement distance => driver.FindElement(By.XPath("//*[@id='distance']"));

        IWebElement make => driver.FindElement(By.XPath("//*[@id='make']"));

        IWebElement model => driver.FindElement(By.XPath("//*[@id='model']"));

        IWebElement variant => driver.FindElement(By.XPath("//*[@id='aggregatedTrim']"));

        IWebElement mini => driver.FindElement(By.XPath("//*[@id='minPrice']"));

        IWebElement maxi => driver.FindElement(By.XPath("//*[@id='maxPrice']"));

        IWebElement remote => driver.FindElement(By.CssSelector("#content > div > form > section.search-form__quick-search > fieldset:nth-child(5) > div > div:nth-child(1) > label > span"));

        IWebElement keyword => driver.FindElement(By.XPath("//*[@id='keywords']"));

        IWebElement bodytype => driver.FindElement(By.CssSelector("#content > div > form > section.search-form__second-col > fieldset.body-type-selector.search-form__field-wrapper > ul > li:nth-child(3) > label > span"));

        IWebElement mileage => driver.FindElement(By.XPath("//*[@id='maxMileage']"));

        IWebElement gearbox => driver.FindElement(By.XPath("//*[@id='transmission']"));

        IWebElement fuel => driver.FindElement(By.CssSelector("#content > div > form > section.search-form__second-col > fieldset.field-panel.field-panel--sub.search-form__field-wrapper > div > div > label > span"));

        IWebElement search => driver.FindElement(By.CssSelector("#content > div > form > div > button.atds-button.atds-button--primary.atds-type-fiesta.sfb-submit__button.search-form__cta-btn.search-form__cta-btn--submit"));









        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

      
        public void EnterPostcode(string pcode)
        {
            postcode.SendKeys(pcode);
        }

        public void SelectDistance()
        {
            SelectElement select = new SelectElement(distance);
            select.SelectByValue("70");
        }

        public void ClickOnAccept()
        {
            cookies.Click();
        }

        public void SelectMake()
        {
            SelectElement select = new SelectElement(make);
            select.SelectByValue("FORD");
        }

        public void SelectModel()
        {
            SelectElement select = new SelectElement(model);
            select.SelectByValue("ECOSPORT");
        }

        public void SelectVariant()
        {
            SelectElement select = new SelectElement(variant);
            select.SelectByValue("Titanium");
        }

        public void SelectMini()
        {
            SelectElement select = new SelectElement(mini);
            select.SelectByValue("5500");
        }

        public void SelectMaxi()
        {
            SelectElement select = new SelectElement(maxi);
            select.SelectByValue("15000");
        }

        public void ClickOnRemote()
        {
            remote.Click();
        }

        public void EnterKeyword(string kword)
        {
            keyword.SendKeys(kword);
        }

        public void ClickOnBodytype()
        {
            bodytype.Click();
        }

        public void SelectMileage()
        {
            SelectElement select = new SelectElement(mileage);
            select.SelectByValue("15000");
        }

        public void SelectGearbox()
        {
            SelectElement select = new SelectElement(gearbox);
            select.SelectByValue("Automatic");
        }

        public void ClickOnFuel()
        {
            fuel.Click();
        }

        public void ClickOnSearch()
        {
            search.Click();
        }

    }
}
