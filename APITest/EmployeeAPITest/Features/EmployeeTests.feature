Feature: EmployeeTests

In work with employee database 
As user if database 
I want work with the database using Api request

Scenario Outline: Check than enpoint returns expected data about employee
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

Scenario: Check if you can create new record in base
	When the user create the employee's information  with 'correct data'
	Then the expected user data and the data from the response are the same ('Post')
		| name    | salary | age |
		| Farabad | 300000 | 30  |

Scenario Outline: Check if you can update existing recond in base
	When the user send api request with employee <id> and new data for update information in database
	Then the expected user data and the data from the response are the same ('Put')
		| name        | salary | age   |
		| UpdatedName | 1222   | 30000 |
Examples:
	| id |
	| 1  |

Scenario Outline: Check if you can delete existing recond from base
	When the user delete the employee's information by the <id> from database
	Then record with employee data has been deleted from database

Examples:
	| id |
	| 1  |

Scenario Outline: Check if id incorrect format returns 400 statuscode with get request
	When the user requests the employee's information by the <id>
	Then in responce return message with exception

Examples:
	| id |
	| 0  |

Scenario: Check if you cant get data from just created record
	Given send api request with employee data for create new record in database with 'correct data'
	When send api request with just created employeee id for get information about him
	Then responce does not contain added information

Scenario Outline: Check if you delete data from base they stay there
	Given send api request with employee <id> for delete record from database
	When the user send api request with id just deleted employee for get information about him
	Then database still contain data information about deleted employee

Examples:
	| id |
	| 1  |

Scenario Outline: Check if you update information about employee in base the data will not change
	Given the user delete the employee's information by the <id>
	When the user send api request with employee <id> and new data for update information in database
	Then information about user with this id has not been updated

Examples:
	| id |
	| 1  |