# MobileDevAssignment

## HW3 Report : 
[![DEMO VIDEO](https://img.youtube.com/vi/2KgSkFTRjdY/0.jpg)](https://www.youtube.com/watch?v=I2BD2XqfJi4)
## HW2 Report : 
### Program Class :
this is the main class where is the menu showen to the user to choose what he wants to do
i have declear a list of "Routes" and i will explain that in a bit

### Router Class :
this class for a single router and its contain an integer for the value, 
and i have declear it as a private variable and create a set&get method

### Route Class :
this class for a single route and its contain a list of route,
and i have declear it as a private variable and create a set&get method

### Inserter Class : 
in this class i created two methods , one for create routes , and anthor one for create the routers 
#### - Create Routes :
this method takes the list of routes and create new object of route and add it to the list
#### - Create Routers : 
this method takes the list of routes and create new object of routers and ask the user to set the value of this router then add it in the route where the user wants

### Searcher Class :
in this class the user can find the shortest path , and i have created four methods in it : SyncSearch , AsyncSearch , finder , Asyncfinder 
#### - SyncSearch : 
this method takes the list of routes and call the finder method to get the cost of the single route and show the result to the user using show method
#### - finder :
this method takes one route and calculate the cost in each router and return it to SyncSearch method 
#### - AsyncSearch :
this method is an asynchronous method takes the list of routes and call the Asyncfinder method to get the cost of the single route but in multithreades and show the result to the user using show method

### Show Routes Class :
i created this class to show the routes and the routers and its contain two methods:
#### - ShowAll : 
takes the list of routes and call show method to show them sepratly 
#### - Show :
takes one route and print the data inside it
