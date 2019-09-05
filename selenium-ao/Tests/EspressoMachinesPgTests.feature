Feature: EspressoMachinesPgTests
	In order to complete the end to end journey of adding an item to basket
	As an end user
	I want to ensure that I can reach the product page

@Test1
Scenario: Expand DeLonghi item to display product page
	Given I am on the espresso machines lister page
	And I have changed the view to grid view
	When I click the more info button
	Then the delonghi item product page is displayed

@Test2
Scenario: Toggle colour facet to stainless steel
	Given I am on the espresso machines lister page
	When I click the stainless steel facet
	Then only the stainless steel products are displayed

@Test3
Scenario: Toggle dropdown and select price low to high
	Given I am on the espresso machines lister page
	When I toggle the sort by dropdown to price low to high
	Then the items are listed from lowest price to highest

@Test4
Scenario: Toggle Brand filter checkboxes
	Given I am on the espresso machines lister page
	When I check the brand filter check box for sage
	Then only the sage products are displayed