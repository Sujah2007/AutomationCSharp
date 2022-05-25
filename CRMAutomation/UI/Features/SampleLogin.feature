Feature: SampleLogin
	Open a home page and test for login

@mytag
Scenario: Test for Login
	Given The browser home page is open
	When Enter the username and password
	Then validate the successful logins
