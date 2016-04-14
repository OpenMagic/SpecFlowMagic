Feature: UriAttribute

Scenario: Constructor accepts uri with leading /
	Given uri dummy-uri has leading slash
	When I call new UriAttribute(uri)
	Then the UriAttribute object is created
