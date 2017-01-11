Feature: General Smoke Test

	Scenario: Tap Add Callendar
		Given I can see "US Test Add Calendar Event" button
		When  I tap "US Test Add Calendar Event" button
	#	Then I can see "US Test Add Calendar Event" button

	Scenario: Tap Go Online Forms 1
		Given I can see "Go Online Forms 1" button
		When I tap "Go Online Forms 1" button
		#Then I can see "Online Form" screen
		Given I open App

	Scenario: Tap Go Online Forms 2
		Given I can see "Go Online Forms 2" button
		When I tap "Go Online Forms 2" button
	#	Then I can see "Online Form" screen

	#Scenario: Show PDF
	#	Given I can see "Show PDF" button
	#	When  I tap "Show PDF" buttoon
	#	Then Popup appears "Do you want to open in external viewer?"

	#	When I tap "Cancel" buttoon
	#	Then I can see "PDFView" screen


	#Scenario: First Example
	#	Given I open App