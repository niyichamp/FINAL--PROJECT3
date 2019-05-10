Feature: Login
	As a user of Giftrete site
	I want to Login to Giftrete site
	So I can use Giftrete site

@mytag
Scenario:Login to Giftrete site
	Given I am a registered user of Giftrete site
	And I navigate to Giftrete login page
	And I enter my username
	And I enter my password
	When I click sign in
	Then the giftrete homepage should be opened
