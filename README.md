README.md 

Requirements/Implementations: 

GitHub Repository and Commits: 

https://github.com/kimhogle/ToDoListRESTAPI







 
README File: 

Include a README file explaining your project: 

This here. :) 

 

Describe your project in a paragraph or more: 

To-Do List Web Application 

  

Project Overview 

This project is a web-based To-Do List application built using ASP.NET Core MVC, with a database integrated via Entity Framework Core. It exposes a CRUD RESTful API to manage To-Do items and demonstrates database interaction and API design patterns. 

  

This application allows users to: 

- Create To-Do items. 

- Read (list or fetch individual items) from the database. 

- Update or modify existing To-Do items. 

- Delete items from the database. 

  

--- 

  

Features: 

  

✅ Implementations: 

The following features have been implemented: 

1. **CRUD API**: Users can Create, Read, Update, and Delete To-Do list items. 

2. **Database Interaction**: Data is saved to and retrieved from SQL Server. 

3. **Asynchronous Operations**: All database operations are implemented using async/await for better performance. 

4. **SOLID Principles Implementation**: Adherence to principles like Single Responsibility and Dependency Inversion in Repository design.  

--- 

  

Technologies Used: 

- **ASP.NET Core MVC** (Web framework) 

- **Entity Framework Core** (Database ORM) 

- **SQLite Server** (Database backend) 

- **Visual Studio 2022** or any compatible IDE 

- **C# Programming Language** 

-**ChatGPT.com** to help explain features implemented 

   

 

Identify 3+ features from the provided list that you've integrated: 

Add comments to your code explaining how you are using at least 2 of the solid principles. 

Make your application a CRUD API. 

Make your application asynchronous. 

Make your application an API.  

Example: Product Page - Expose an endpoint that allows a user to add a product via JSON with Postman/POST request. 

 

Add any special instructions for the reviewer to run your project: 




Setup Instructions: 
.NET Migrations



1. Clone the repository: 

   ```bash 

   git clone https://github.com/kimhogle/ToDoListRESTAPI

Visual Appeal: 

Swagger UI 

 

 

Software Project Requirements 

Web-based application: 

 

✅ Implementations: 

Web-Based Application: It's an ASP.NET Core web-based application using MVC with Controllers. 

API: You have implemented RESTful APIs via ControllerBase and routes like /api/ToDoList. 

Database: You are using Entity Framework Core with SQL Server as the database provider. 

 

API: 

The internal API is implemented in the ToDoListController, which exposes the following routes: 

GET /api/ToDoList: Retrieves all to-do items. 

GET /api/ToDoList/{id}: Retrieves a specific to-do item by its ID. 

POST /api/ToDoList: Creates a new to-do item. 

PUT /api/ToDoList/{id}: Updates a to-do item by its ID. 

DELETE /api/ToDoList/{id}: Deletes a to-do item by its ID. 

These routes serve as the internal API of the application and are directly integrated into the application logic. 

 

Database Interaction: 

✅ This applies because: 

You have defined a class/entity (ToDoItem) which represents data from a database table. 

You are interacting with this class by querying data from the database (ApplicationDbContext) through repository calls like GetItems(). 

You are using database data in the application logic/API responses. 

 

 

Functions/Methods: 

✅ Implementations: 

Three functions/methods are implemented and utilized: 

GetItems() — retrieves all to-do items from the database. 

GetItemById(int id) — retrieves a single to-do item by its ID. 

ItemExists(int id) — validates whether a specific item exists in the database. 

At least one returns a value integral to the application: 

GetItems() returns a list of items from the database. 

GetItemById(int id) returns a single to-do item. 

ItemExists(int id) returns a boolean to determine logic flow. 

These methods interact directly with database queries and are integral to the application's core functionality. 

 
