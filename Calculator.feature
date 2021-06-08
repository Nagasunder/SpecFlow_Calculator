Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowDateCalculator/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Date
	Given Launch Calculator in DateCalculator Mode
	#And Screen Clear
	And Click From
	And Click Previous
	And Select 2
	And Click To
	And ClickPrevious
	And Select 10
	Then The result should be 1 week, 1 day
	And End Calculator
