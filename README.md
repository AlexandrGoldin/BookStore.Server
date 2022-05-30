# BookStore.Server
### C# Backend of the Client-Server PC pet-project of the online sopping "BookStore". 
### Data Base deployed on host somee.com
### Developed in Visual Studio 2019
___
### Stack:
* MS SQL Server
* TSQL
* ASP.NET Core 3.1
* Web API
* Entity Framework Core
* N-tier architecture
* CORS
* Swashbuckle
* Data Transfer Object
* AutoMapper
* MemoryCache
* xUnit
___
### VS Solution Arhitecture **BookStore.Server** app uses onion architecture, dependency inversion principle
![VSSolutionStructure](https://user-images.githubusercontent.com/75939181/164613381-fc99307b-abd0-469e-b874-508f09d0efc0.JPG)
___
### Database initialization 
1. Using Entity Framework Core solution with approach Code-First.
This database is being created when the project is first run.
The *DbInitializer.cs* file from the directory BookStore.Server.DAL/Data/ is used to initialize this database.
2. To create a database, you can use the *BookStoreScript.sql* file from the repo [BookStore.SqlScript](https://github.com/GoldinAlexander/BookStore.SqlScript.git)
