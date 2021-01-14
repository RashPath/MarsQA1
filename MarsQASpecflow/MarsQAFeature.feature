Feature: Navigate to the MarsQA portal and testing different features


Scenario: Navigate to the portal
Given I login to the portal
When I add the credentials
Then I verify that I am into the Dashboard of the portal

Scenario: Go to the profile tab and test adding description
Given I login to the portal and add the credentials
When I click the description edit button and add in the description
Then the description is saved and displayed

Scenario: Go to the profile and test adding details under your name
Given I signin to the portal 
When I click on the dropdowns
Then The options are saved and are displayed on the page

Scenario: Go to the Languages tab and test adding in the details
Given I signin to the portal by entering the login details
When I click on the languages tab and add in various options
Then My entries are saved and are displayed on the page



