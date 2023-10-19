Feature: OrangeHRMLogin Tests



@Regression
Scenario: Verify Admin TabName From OrangeHRM
	Given User is logged in using credentials "Admin" and "admin123"
	And Clicks on Admin Tab
	Then Verify Admin page is displayed with "Admin" name


@Regression
Scenario Outline: Verify Error Message Upon Login
	Given User is logged in using credentials <username> and <password>
	And User should get <expectedMessage> message
Examples:
	| username | password | expectedMessage     |
	| Admin    | admin12  | Invalid credentials |
	| Admin123 | admin123 | Invalid credentials |


@Regression
Scenario: Verify Admin TabName From OrangeHRM in Datatable format
	Given User is logged in using credentials
		| username | password |
		| Admin    | admin123 |
		| Admin123 | admin    |
	And Clicks on Admin Tab
	Then Verify Admin page is displayed with "Admin" name