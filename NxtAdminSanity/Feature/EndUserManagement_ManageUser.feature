Feature: EndUserManagement_ManageUser
	
@mytag
Scenario: Nxt Manage User validation
   Given user is on login screen
   And Enter valid username and Password
          | Username       | Password        |
	      |implementations | password123     |	
   When user click on login button
   Given User click on EndUserManagement menu
   And User click on ManageUser submenu
   And enter input to get End user
        | input          |
        | Carpenter      |
    And click on search button
    And click on filtered results
    Then validatate input and results are matching