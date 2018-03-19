Feature: Country
	API methods related to Country are validated here

@mytag
Scenario: Check that response by calling code and by capital city with 372
	Given I warm up the API
	When I make a request with 372 and by Tallinn
	Then the case should success

@mytag
Scenario: Check that response by calling code and by capital city with 371
	Given I warm up the API
	When I make a request with 371 and by Tallinn
	Then the case should failure

@mytag
Scenario: Find Countries in regions for example for Asia
	Given I warm up the API
	When I make a request with Asia : null
	Then the system should return bordering countries more than 3

@mytag
Scenario: Find Countries in regions for example for Europe
	Given I warm up the API
	When I make a request with Europe : null
	Then the system should return bordering countries more than 4

@mytag
Scenario: Check country and expected bordering countries in given region
	Given I warm up the API
	When I make a request with Asia : null 
	Then the case should success

@mytag
Scenario Outline: Check that response by calling code and by capital city
	Given I warm up the API
	When I make a request with 371 and by Tallinn
	Then the response should be the failure
	And the response status code shoulde be 500

Examples: 
	  | Code  | Capital  | Result | Status |
	  | 372   |  Tallinn | Success|  200   |
	  | 371   |  Tallinn | failure|  500   |

@mytag
Scenario Outline: Check that response by country name
	Given I warm up the API
	When I make a request with Asia : India
	Then the response should be the Success
	And the response status code shoulde be 200

Examples: 
	  | name    | Result | Status |
	  | India	| Success|  200   |
	  | USA		| failure|  200   |

@mytag
Scenario Outline: Use currency code and produce one test
	Given I warm up the API
	When I make a request with Euro, 371 and Riga
	Then the response should be the <Result>
	And the response status code shoulde be <Status>

Examples: 
	  | capital | currency			| results	 |
	  | Riga	| Euro				|  Success   |


