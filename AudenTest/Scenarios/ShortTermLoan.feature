Feature: ShortTermLoan

Background:
	Given I navigate into Auden

@Regression
Scenario: Verify the Maximum amount from the slider
When I select the amount form the slider '1232' and '33' 
Then I verify the selected amount as '£500'


Scenario: Verify the Minimum Amount from the slider
When I select the amount form the slider '603' and '153' 
Then I verify the selected amount as '£200'

Scenario: Verify the Selected Slider amount as loan amount
When I select the amount form the slider '840' and '152' 
Then I verify the selected amount as '£350'
And I verify the loan amount as '350'

Scenario: Verify the repayment day