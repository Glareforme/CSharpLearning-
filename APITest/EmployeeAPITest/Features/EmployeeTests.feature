Feature: EmployeeTests

In work with employee database 
As user if database 
I want work with the database using Api request

Scenario Outline: Check than employee controller return correct data
	When Send api request with employeee <id> for get information about him
	Then The expected user data and the data from the response are the same ('Get')

Examples:
	| id |
	| 1  |
	| 21 |
	| 12 |

Scenario: Check if you can create new record in base
	When Send api request with employee data for create new record in database with 'correct data'
	Then The expected user data and the data from the response are the same ('Post')

Scenario Outline: Check if you can update existing recond in base
	When Send api request with employee <id> and new data for update information in database
	Then The expected user data and the data from the response are the same ('Put')

Examples:
	| id |
	| 1  |

Scenario Outline: Check if you can delete existing recond from base
	When Send api request with employee <id> for delete record from database
	Then Record with employee data has been deleted from database

Examples:
	| id |
	| 1  |

Scenario Outline: Check if id incorrect format return 400 statuscode with get request
	When Send api request with employeee <id> for get information about him
	Then In responce return message with exception

Examples:
	| id |
	| 0  |

Scenario: Check if you cant get data from just created record
	Given Send api request with employee data for create new record in database with 'correct data'
	When Send api request with just created employeee id for get information about him
	Then Responce does not contain added information

Scenario Outline: Check if you delete data from base they stay there
	Given Send api request with employee <id> for delete record from database
	When Send api request with id just deleted employee for get information about him
	Then Database still contain data information about deleted employee

Examples:
	| id |
	| 1  |

Scenario Outline: Check if you update information about employee in base the data will not change
	Given Send api request with employeee <id> for get current information about him
	When Send api request with employee <id> and new data for update information in database
	Then Information about user with this id has not been updated

Examples:
	| id |
	| 1  |