Feature: Feature1

A short summary of the feature

Background:
	Given Open website page

@tag1
Scenario: Task 1
	When Enter 'Summer' in search input field
	And Click on confirm search button
	Then In inscription 'SEARCH' dispayed 'Summer'

Scenario: Task 2
	When Enter 'Summer' in search input field
	And Click on confirm search button
	And Select option 'Price: Highest first' in dropdown
	Then All element sorted with selected option

Scenario: Task 3
	When Enter 'Summer' in search input field
	And Click on confirm search button
	And Select option 'Price: Highest first' in dropdown
	And Remember name and price of 'first product'
	And Add 'first product' to busket
	And Open busket
	Then Verify added to busset correspond remembered name and price of 'selected product'

Scenario: Task 4
	When Enter 'Blouse' in search input field
	And Click on confirm search button
	And Click on 'More' button for 'first product' found
	And Select in details for product
		| Quantity | Size | Color |
		| 3        | L    | white |
	And Click Add to cart on 'More' product page
	Then Message 'Product successfully added to your shopping cart' displayed in modal window

Scenario: Task 5
	When Enter 'Blouse' in search input field
	And Click on confirm search button
	And Click on 'More' button for 'first product' found
	And Select in details for product
		| Quantity | Size | Color |
		| 3        | L    | white |
	And Click Add to cart on 'More' product page
	And Click 'Continue shopping' in modal window
	And Enter 'Printed summer dress' in search input field
	And Click on confirm search button
	And Click on 'More' button for 'first product' found
	And Select in details for product
		| Quantity | Size | Color  |
		| 5        | m    | Orange |
	And Click Add to cart on 'More' product page
	And Click 'Proceed to checkout' in modal window
	Then For 2 added products dispyaed correct 'Name','Size','Color', 'Price for one product', 'Quantity of goods', 'Total price'

Scenario: Task 6
	When Enter 'Blouse' in search input field
	And Click on confirm search button