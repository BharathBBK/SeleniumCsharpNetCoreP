Feature: Login
	

@mytag
Scenario: Nxt Admin Login validation
	Given user is on login screen
	And Enter valid username and Password
          | Username       | Password        |
	      |implementations | password123     |	       
	When user click on login button
	Then user should routed to admin application

