# customer-service

## Technologies used
To showcase my skills in both of the technologies (**.Net Core** and **NodeJS**) I have developed this project using following technologies.
* **ASP.Net Core MVC** at the front end to develop the UI of the project.
* **NodeJS** along with **ExpressJS** to develop backend service of the project.
* **Auth0** for authenticating and authorizing users.
* **Firebase-Firestore** to save all of the records of the customers.

## Project Structure
Project has two main parts
### UI
UI of this project has been developed using ASP.Net Core MVC using Visual Studio Code along with .NET Core 2.1 SDK.
Project has 3 controllers *Home* to handle base URLs of the app which available publically, *UserAccounts* to handle login and logout routes through **Auth0** and *Customers* to handle private routes with the details of the customers.
There are two main views of the project ***Index** view of **Home** Controller* which is the starting point of the application and publicaly available and other one is ***Index** view of **Customer** Controller* which is a private view and details of the customers is available on this view.
There are two more views in the application **Login** and **Logout**, but these views are the default Auth0 views and handled by **UserAccounts** controller along with **Auth0**.
**Auth0** layer is implemented as a middleware in the **Startup.cs** file of the project.

### Service
Backend service of this project has been written in **NodeJS** along with **ExpressJS**.
**Index.js** file at the root directory is the starting point of the service which containes resources that are available publically, private routes of the customers are also being assembled in this file.
**routes** directory includes private routes of the service (i.e resources related to customers have been written in **routes/customer.js** file) which later on get assembeled in the **index.js** file placed at the root directory.
**middleware** directory includes all of the middleware logic of the private resources ( i.e Authenticating the user through **JWT** and the **Bearer access token** provided in the header of the request with key **authorization** while calling the resource).
**db** directory includes two files, **db-config.js** to set the basic configuration of the database and **customers.js** which includes all of the different methods and business logic to fetch and manipulate the data from the database.
All of the basic configuration of the service and the database is included in the **default.json** file placed under **config** directory.

## Running the project
* In order to run this project please make sure **.NET Core 2.1 SDK** and **NodeJS V10** has been installed on your machine
* Open command prompt
* In command prompt navigate into **service** directory of the project.
* Type `npm install` to install project dependencies.
* Type `node index.js` and hit enter, wait for the text `Customer service is running on 3000` printing on your command prompt, after the mentioned text appears on your the backend service started running.
* Open another command prompt (Please don't close the previouse one, otherwise the backend service will no longer running on your machine)
* In new command prompt that you've open, navigate into **ui** directory of the project.
* Type `dotnet restore` to restore project dependencies.
* Type `dotnet run` and front end application will start running.
* Now open your favourite browser and go to the following link "https://localhost:5001/".

You have successfully started the project on your local machine.
