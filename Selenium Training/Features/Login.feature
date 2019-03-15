Feature: Login
	As a User of Giftrete
	I want to be able to login 
	So that I can use the site.

@mytag
Scenario:Login
	Given I navigate to the site
	And I have entered my emailAddress
	And I have entered my password
	When I click on Secure Sign In
	Then I should be signed In
