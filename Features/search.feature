Feature: Search

As a user of bbc website
I want to search for information

Scenario: Search Information
	Given I navigate to bbc website
	And I click on the search menu
	And I entered 'weather' in the search bar
	When I clicked the search button
	Then weather information is displayed
