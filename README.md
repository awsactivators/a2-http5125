# ASP.NET Core Web API Week 5 Assignment 2 The Canadian Computing Competition (CCC) is a yearly competition hosted by the University of Waterloo.


## Course: Back-End-Web-Development
## Instructor: Christine Bittle

## Overview

This project implements a series of ASP.NET Core Web API endpoints to perform different tasks based on the provided assignment specifications. This assignment is from The Canadian Computing Competition (CCC) is a yearly competition hosted by the University of Waterloo. The past contests are available through the link below.

https://cemc.uwaterloo.ca/resources/past-contests#ccc?grade=19&academic_year=All&contest
_category=29.

But the questions used for this assignment can found on these links:

https://cemc.uwaterloo.ca/sites/default/files/documents/2023/2023CCCJrProblemSet.html

https://cemc.uwaterloo.ca/sites/default/files/documents/2022/2022CCCJrProblemSet.html

The API has been implemented with C# and is structured to be easy to understand and use. The source code files are located in the `Controllers` folder, with each question's logic implemented in its respective controller.

## Project Structure

The project follows the ASP.NET Core Web API structure. All the endpoints are defined in controllers, which are located in the Controllers folder.

### Controllers

- Q1J1Controller.cs: Deliv-e-droid.

- Q2J1Controller.cs: Cupcake Party.

- Q3J2Controller.cs: Chili Peppers.

- Q4J2Controller.cs: Fergusonball Ratings.

- Q5J3Controller.cs: Special Event.



## How to run the project

### Requirements:

- .NET SDK 6.0 or later

- Visual Studio 2022 or Visual Studio Code (VS Code)

### Steps to Run:

1. Clone the repository or download the project `git@github.com:awsactivators/a2-http5125.git`.

2. Open the project in Visual Studio or VS Code.

3. Restore the dependencies.

```c#
dotnet restore
```

4. Run the project

```c#
dotnet run
```
5. The API will be running at `http://localhost:5000` or `https://localhost:5001` or any port that is given to you (mine is 5026).


## Endpoints

1. **POST** /api/Q1J1/delivedroid 

Description: Calculate final score after packages are delivered with/without collisions.

Example: POST: localhost:5026/api/Q1J1/delivedroid (Content-Type: application/x-www-form-urlencoded)

         Body: delivered=5&collisions=2
        
         Output: 730

2. **GET** /api/Q2J1/calculateleftover

Description: Determine how many cupcakes are left after distributing to students.

Example: GET localhost:5026/api/Q2J1/calculateleftover?regularBoxes=2&smallBoxes=5

Output: 3

3. **POST** /api/Q3J2/calculatespiciness

Description: Calculate the total spiciness of Ron chili.

Example: POST: localhost:5026/api/Q3J2/calculatespiciness/ (Content-Type: application/x-www-form-urlencoded)

         Body: numPeppers=3&peppers=Thai&peppers=Cayenne&peppers=Serrano

         Output: 130500

Response: 64

4. **POST** /api/Q4J1/calculatestars

Description: Determine how many players have a star rating greater than 0 and if the team is a gold team.

Example: POST: localhost:5026/api/Q4J1/calculatestars/ (Content-Type: application/x-www-form-urlencoded)
        
         Body:     numPlayers=3&pointsAndFouls=12&pointsAndFouls=4&pointsAndFouls=10&pointsAndFouls=3&pointsAndFouls=9&pointsAndFouls=1

         Output: 3+

5. **POST** /api/Q5J1/scheduleevent

Description: Determine the best day to schedule an event.

Example: POST: localhost:5026/api/Q5J1/scheduleevent/ (Content-Type: application/x-www-form-urlencoded)

         Body: numPeople=3&availability=YY.Y.&availability=...Y.&availability=.YYY.
         
         Output: 4


## Testing

You can test the API using cURL, swagger UI or any other HTTP client.

For example, to test the SquashFellows order, you can use the following cURL command on your terminal:

```c#
curl -X 'POST' \
  'http://localhost:5026/api/Q5J3/scheduleevent' \
  -H 'Content-Type: application/x-www-form-urlencoded' \
  -d 'numPeople=5&availability=.....&availability=YYYY.&availability=.Y.YY&availability=.YY..&availability=Y....'
```

To test with swagger UI

Go to `http://localhost:<port>/swagger/index.html`

## Additional notes

- The C# files that implement the controllers and logic for the endpoints are located in the Controllers folder.

- Ensure that HTTPS is enabled in the project settings if you're accessing the endpoints via HTTPS.

## Tech Stack

- ASP.NET Core Web API: Framework used to build the API.

- C#: Programming language used for implementing the API.

- .NET Core SDK: Runtime environment for executing the API.

- Visual Studio Code (Vscode): Code editor used for writing, debugging, and managing the project files. 

