Feature: Search for products for add to busket

In add products to busket
As a user of website 
I want to use search 

@task1 @chrome
Scenario: Check if the search is working correctly
	When User search for 'SUMMER' with search field
	Then In inscription 'SEARCH' displyed 'SUMMER'

@task2 @chrome
Scenario: Check if the search is working correctly with added options
	Given A search has been made for 'SUMMER' with search field
	When User select option 'Price: Highest first' in dropdown list
	Then All element sorted with selected option

@task3 @chrome
Scenario: Check if  adding to basket work correctly
	Given A search has been made for 'SUMMER' with search field
	And User select option 'Price: Highest first' in dropdown
	When User add 'first product' to busket
	Then The following items are saved in the basket
		| Name | Price |

@task4 @chrome
Scenario: Check if adding to basket with specific parameters work correctly
	When User search for 'Blouse' and add to cart first found product with details
		| Quantity | Size | Color |
		| 3        | L    | white |
	Then Message 'Product successfully added to your shopping cart' displayed in modal window

@task5 @chrome
Scenario: Check if in busket correct displayed all added products
	Given A search has been made for 'Blouse' and add to cart first founded product with details
		| Quantity | Size | Color |
		| 3        | L    | White |
	When User search for 'Printed summer dress', add to cart first found product with details and open basket
		| Quantity | Size | Color  |
		| 5        | M    | Orange |
	Then Correct information about added products
		| Name                 | Color  | Size | Unit price | Quantity | Total price |
		| Blouse               | White  | L    | 27.00      | 3        | 81.00       |
		| Printed summer dress | Orange | M    | 28.98      | 5        | 144.90      |
@task6 @chrome
Scenario: Check if delete from busket function work correctly
	Given A search has been made for 'Blouse' and add to cart first founded product with details
		| Quantity | Size | Color |
		| 3        | L    | White |
	And A search has been made for 'Printed summer dress' and add to cart first founded product with details
		| Quantity | Size | Color  |
		| 5        | M    | Orange |
	When User delete 'Printed summer dress' from basket
	Then In busket list only 'Blouse' left
		