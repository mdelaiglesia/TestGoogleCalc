Feature: Addition
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered into the calculator
	When I enter number '2'
	And I press add
	And I enter number '2'
	And I press equals
	Then the result should be 2 on the screen
