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
