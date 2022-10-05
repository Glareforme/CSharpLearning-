Feature: EmployeeTests

In work with employee database 
As user if database 
I want work with the database using Api request

Scenario Outline: 1. Check that the endpoint returns expected data about employee
	When the user requests the employee's information by the <id>
	Then the expected user data and the data from the response are the same ('Get')
		| name             | salary | age |
		| Tiger Nixon      | 320800 | 61  |
		| Jenette Caldwell | 345000 | 30  |
		| Quinn Flynn      | 342000 | 22  |

Examples:
	| id |
	| 1  |
	| 21 |
	| 12 |

Scenario: 2. Check if you can create new record in base
	When the user creates the employee's information  with 'correct data'
	Then the expected user data and the data from the response are the same ('Post')
		| name    | salary | age |
		| Farabad | 300000 | 30  |

Scenario: 3. Check if you can update existing recond in base
	When the user sends api request with employee <id> and new data for update information in the database
	Then the expected user data and the data from the response are the same ('Put')
		| name        | salary | age   |
		| UpdatedName | 1222   | 30000 |

Scenario: 4. Check if you can delete existing recond from base
	When the user deletes the employee's information by the <id> from the database
	Then record with employee data has been deleted from database

Scenario: 5. Check if id incorrect format returns 400 statuscode with get request
	When the user requests the employee's information by the <id>
	Then in response return message with the exception


Scenario: 6. Check if you cant get data from just created record
	Given send api request with employee data to create a new record in the database with 'correct data'
	When send api request with just created employee id for getting information about him
	Then response does not contain added information

Scenario: 7. Check if you delete data from base they stay there
	Given send api request with employee <id> to delete record from the database
	When the user send api request with id just deleted the employee for getting information about him
	Then the database still contains data information about deleted employee

Scenario: 8. Check if you update information about employee in base the data will not change
	Given the user delete the employee's information by the <id>
	When the user sends api request with employee <id> and new data for update information in the database
	Then information about the user with this id has not been updated