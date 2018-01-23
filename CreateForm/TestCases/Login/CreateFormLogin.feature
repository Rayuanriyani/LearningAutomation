Feature: CreateFormLogin
	Create Member in jobsdb.com

@mytag
Scenario: CS-001 user can be created login for join member in jobsdb.com
	Given user is at the home page jobsdb
	And Navigate to Sign Up page
	When user created a profile in form sign up
	| First_name | Last_name | Email			     | Password     |
	| cobasekali | coba   | glddS@yahoo.com  | cobalogin123 |
	And Click on the create profile button
	And user Input data about yourself
	| Key                                       | Value                       | Value        | Value     |
	| How long is your total work experience?   | 1 year                      |              |           |
	| What is your latest job?                  | Quality Assurance           |              |           |
	| Who is your latest employer?              | PT.Testing                  |              |           |
	| How long have you been working here?      | Jan                         | 2017         |           |
	| How would you classify your latest job?   | Information Technology (IT) | IT Auditing  |           |
	| In what industry is your latest employer? | Health & Beauty Care	      |              |           |
	| What are your salary expectations?        | Monthly                     | 4000000	     | 5000000   |
	| What is your highest education?           | Diploma                     |              |           |
	| What is your nationality?                 | Indonesia                   |              |           |
	| Where do you live?                        | Indonesia                   | Banten       | Tangerang |
	And Click on the continue button 
	Then the user can be access to login in jobsdb for search job



