Feature: ShortTermLoan

Background:
	Given I navigate into Auden

@Regression smoke
Scenario: Verify the Maximum amount from the slider
When I select the amount form the slider '640' and '152' 
Then I verify the selected amount as '£500'


Scenario: Verify the Minimum Amount from the slider
When I select the amount form the slider '0' and '152' 
Then I verify the selected amount as '£200'

Scenario: Verify the Selected Slider amount as loan amount
When I select the amount form the slider '240' and '152' 
Then I verify the selected amount as '£310'
And I verify the loan amount as '310'

Scenario: Verify the repayment day

Scenario: Select a date for repayment
Given I select repayment date as '3'
Then I verify the selected date '3' is highlighted

