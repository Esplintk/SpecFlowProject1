Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@mytag
Scenario: MPG easy
	Given Miles driven is 80
	And Gallons used is 10
	When calc_MPG is called
	Then the fuel efficieny should be 8

	Scenario: MPG easy2
	Given Miles driven is 85
	And Gallons used is 10
	When calc_MPG is called
	Then the fuel efficieny should be 8.5

	Scenario: Is a gas hog or not.
	Given Miles driven is 97
	And Gallons used is  12
	When gasHog is called
	Then the car should be true

	Scenario: Drive for rewards
	Given Miles driven is 1000000
	And Gallons used is  500000
	When gas rewards is called
	Then the points given should be 50
