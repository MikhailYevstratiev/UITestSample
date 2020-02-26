Feature: Press Button
	In order to show test project
	As a guide writer
	I want to press some buttons
	
@mytag
Scenario: Press button 2 times
	Given I am on the Buttons Page
	When I press 'Click me!' button 2 times
    And I press 'Go to List page' button
	Then I am navigated to the List page
