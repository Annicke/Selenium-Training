Feature: Registration
	As a User of Giftrete
	I want to register 
	So that I can use the site

@mytag
Scenario: Valid Registration
	Given I navigate to the site
	And I have entered my first name
	And I have entered my last name
	And I have entered my emailadress
	And I entered my mobile n0
	And I have entered my password
	And I have confirm password
	When I click on Sign Up
	Then I should be registered
