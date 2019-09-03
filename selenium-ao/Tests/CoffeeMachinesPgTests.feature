Feature: CoffeeMachinesPgTests
	In order to ensure that the coffee machines page is functional
	As an end user
	I want to be able to utlise the core functionality of the page

@Test1
Scenario: Navigate to Coffee Machines page
	Given I am on the small appliances page
	When I click the View All button on the coffee machines card
	Then the coffee machines page is displayed

@Test2
Scenario: Navigate to the Espresso machines page
	Given I am on the coffee machines page
	When I click the View All button on the Espresso card
	Then the Espresso machines lister page is displayed