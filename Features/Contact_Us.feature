Feature: Check Submission On Contact Us Without Clicking On The Captcha

Background: 
	Given I Navigate To Website

Scenario Outline: Security Code is Required On Contact Us Form
	Given I Change Website Language To English
	When I Navigate To Contact Us Button On Home Page
	 And I Enter <Name> In Full Name Field
	 And I Enter <Mobile> In Mobile Number Field
	 And I Enter <Email> In Email Address Field
	 And I Enter <Subject> In Subject Field
	 And I Select <CallYou> Option From Call You DropDown
	 And I Select <Category> From Category DropDown
	 And I Select <Type> Of The Inquiry
	 And I Enter <Message> In Message field
	 And Click On Submit Button
	Then Verify Security Code Is Required Error Message Displayed Correctly
		Examples:
		| Name | Mobile     | Email         | Subject     | CallYou |	Category		|	Type		|	Message		 |
		| Test | 0500000000 | test@mbrhe.ae | TestSubject | No      |	Housing Grant	|	Suggestion	| test test test |
