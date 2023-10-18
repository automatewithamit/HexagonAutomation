Feature: OrangeHRMLogin Tests



@Regression
Scenario: Verify Canvas From OrangeHRM
	Given User is logged in using credentials "Admin" and "admin123"
	And Clicks on Admin Tab
	Then Verify Admin page is displayed
	
	
