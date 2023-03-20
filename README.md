#  Dr. Sillystringz's Factory
![alt](Factory/Views/wwwroot/img/ss.png "ss")

#### By Vera Weikel 

#### This is a project to build Basic Web Application using ASP .Net, MVC, and EF Core databases.

## Technologies Used

* .Net 6 SDK
* C#
* EFCore
* ASP.Net MVC
* Razor
* EF Core 

## Goals/Objectives

This project shows how to connect an ASP.NET Core MVC project to a MySQL database using [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/).

## Description

This is an MVC web application to manage their engineers, and the machines they are licensed to fix.


## How To Run This Project

1. Clone this [repo](https://github.com/QuietEvolver/DrSillystringzFactory.Solution.git).
2. Open the terminal and navigate to this project's production directory called "Factory".
3. Within the production directory "Factory", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. For the LearnHowToProgram.com lessons, we always assume the `uid` is `root` and the `pwd` is `epicodus`.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[PROJECT_NAME];uid=[YOUR-USERNAME];pwd=[YOUR-PASSWORD];"
  }
}
```

5. Within the production directory of our To Do List app, run the following terminal command:
```
  $ dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
```
6. Within the production directory "Factory", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
7. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. Please enter this into your search engine: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/lessons/redirecting-to-https-and-issuing-a-security-certificate).

## Database Instructions 

* In your terminal type to create a db migration: $ dotnet ef migrations add Initial
* Updating the Database with the Migration: $ dotnet ef database update

## DB (Optional)

* If you would like to see a current view of the database: Open SQL workbench.
* Navigate to the "Administration" tab in SQL Workbench.
* Click "Schema" 
* Right hand mouse click "Refresh All".
* The _Name the schema "project_name" of the database in this current project will be in view

<!-- ## Database Architecture

![alt](HairSalon/wwwroot/img/vw_database_structure.png "vw_database_structure") -->

## Known Bugs

* None

## License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) 2023 Vera Weikel 

