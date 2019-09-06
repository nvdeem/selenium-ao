Feature: DeLonghiProductPgTests
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Test1
Scenario: Toggle colour option to red
	Given I am on the delonghi product page
	When I click the choose colour lister
	And I click the red option
	Then the red version of the product is displayed

@Test2
Scenario: Share product via email
	Given I am on the delonghi product page
	And I click the share button
	Then the email product wwindow is displayed
	When I enter an email address
	And I click the send product button
	Then the email will be sent
