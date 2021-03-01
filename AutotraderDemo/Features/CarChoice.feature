Feature: CarChoice
	In order to search for a car choice
	I must first input all the necessary details

@mytag
Scenario: Valid Search
	Given I navigate to "https://www.autotrader.co.uk/search-form?moreOptions"
	And I enter my postcode "SW1A 2AA"
	And I select the distance
	#And I accept cookies
	And I select the make 
	And I select te model
	And I select the model variant
	And I select min price
	And I select max price 
	And I click on home delivery 
	And I enter keyword "sat nav"
	And I click on bodytype 
	And I select mileage
	And I select gearbox
	And i click on fuel type
	When I click on search cars
	#Then I should be able to see all the cars I can choose from