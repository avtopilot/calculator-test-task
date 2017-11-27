# Simple calculator web application

## The Task

Write a simple SPA web application which accepts, calculates and displays the value of an expression. The input of your program is a string consisting of digits and ‘operators’ + and *; there are no two consecutive digits. You can assume there will be no integer overflow, but you should output “Error” if the input is invalid.
 
E.g.
“2+3*4+5” => 19
“2*3*4*5” => 120
“2+3*4+” => “Error”
 
The application will contain a “show history” magic button which will display a log of all expressions entered since it started and their results.
Extend your program so that additionally parentheses ‘(‘ and ‘)’ are allowed. You shall output “Sorry, this is too complex” if you find embedded parentheses.
E.g.
“(2+3)*(4+5)” => 45.
“((2+3)*(4+5))” => “Sorry, this is too complex”.

Solution guideline:
• Keep all the data and business logic on the server side of your shiny web application.
• Use Angular 2 or 4 for the front end. Use front end primarily for only displaying results and accepting the expression.
• The result of your work should be preferably a single Visual Studio solution which builds what is needed and starts by pressing F5 (starts the server, opens the browser so that user can start playing with expressions immediately). If there is a need to build the client side outside visual studio or with some manual steps (you wish to use webpack or gulp or Angular CLI or anything else, please provide a step by step manual for how to build and run the application).

## Solution

### Prerequisites

* .Net core
* node
* npm

### Running

```bash
sh ./runWebApi.sh //will run WebApi on the 5000 port
sh ./runClient.sh //will run client on the 3000 port
```
Open browser at http://localhost:3000