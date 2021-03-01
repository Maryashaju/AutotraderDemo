using AutotraderDemo.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AutotraderDemo.StepDefinition
{
    [Binding]
    public class CarChoiceSteps
    {
        CarPage carPage;
        public CarChoiceSteps()
            {
               carPage = new CarPage();
            }




        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            carPage.NavigateToWebsite(url);
        }
        
        [Given(@"I enter my postcode ""(.*)""")]
        public void GivenIEnterMyPostcode(string pcode)
        {
            carPage.EnterPostcode(pcode);
        }


        [Given(@"I select the distance")]
        public void GivenISelectTheDistance()
        {
            Thread.Sleep(3000); 
            carPage.SelectDistance();
        }

        [Given(@"I accept cookies")]
        public void GivenIAcceptCookies()
        {
            Thread.Sleep(5000);
            carPage.ClickOnAccept();
        }


        [Given(@"I select the make")]
        public void GivenISelectTheMake()
        {
            Thread.Sleep(1000); 
            carPage.SelectMake();
        }
        
        [Given(@"I select te model")]
        public void GivenISelectTeModel()
        {
            Thread.Sleep(1000);
            carPage.SelectModel();
        }
        
        [Given(@"I select the model variant")]
        public void GivenISelectTheModelVariant()
        {
            Thread.Sleep(1000);
            carPage.SelectVariant();
        }
        
        [Given(@"I select min price")]
        public void GivenISelectMinPrice()
        {
            Thread.Sleep(1000);
            carPage.SelectMini();
        }
        
        [Given(@"I select max price")]
        public void GivenISelectMaxPrice()
        {
            Thread.Sleep(1000);
            carPage.SelectMaxi();
        }
        
        [Given(@"I click on home delivery")]
        public void GivenIClickOnHomeDelivery()
        {
            Thread.Sleep(1000);
            carPage.ClickOnRemote();
        }
        
        [Given(@"I enter keyword ""(.*)""")]
        public void GivenIEnterKeyword(string kword)
        {
            Thread.Sleep(1000);
            carPage.EnterKeyword(kword);
        }
        
        [Given(@"I click on bodytype")]
        public void GivenIClickOnBodytype()
        {
            Thread.Sleep(1000);
            carPage.ClickOnBodytype();
        }
        
        [Given(@"I select mileage")]
        public void GivenISelectMileage()
        {
            Thread.Sleep(1000);
            carPage.SelectMileage();
        }
        
        [Given(@"I select gearbox")]
        public void GivenISelectGearbox()
        {
            Thread.Sleep(1000);
            carPage.SelectGearbox();
        }
        
        [Given(@"i click on fuel type")]
        public void GivenIClickOnFuelType()
        {
            Thread.Sleep(1000);
            carPage.ClickOnFuel();
        }
        
        [When(@"I click on search cars")]
        public void WhenIClickOnSearchCars()
        {
            Thread.Sleep(1000);
            carPage.ClickOnSearch();
        }
        
        [Then(@"I should be able to see all the cars I can choose from")]
        public void ThenIShouldBeAbleToSeeAllTheCarsICanChooseFrom()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
