# Katalog Application
## Description
Katalog is a desktop application developed in C# .NET 8 using the Devexpress WinForms framework and the Dapper library for communication with a Microsoft SQL Server database. The application serves to display and manage products along with their details in a user-friendly interface.

## Features
### Main Screen:
* A welcome message greets the user in the application.
* The top menu bar provides access to the main functionalities.

### Catalog:
* Clicking the "Catalog" button opens a module with two grids separated by a splitter:

1. **Upper Grid:** Displays a list of products with names, prices, and other details.
1. **Lower Grid:** Shows details of the selected product.

## Database
The application retrieves data from a Microsoft SQL Server database.
The table structure includes tables for products, authors, and categories, which are interconnected.

## Database Connection
- The Dapper library is used for efficient communication with the database.
- The global configuration configures the database connection using the Connection String.

## Coding
- The code is written in C# using the Devexpress WinForms framework for creating the user interface.
- The source code is structured to be readable, modular, and adheres to clean code principles.

## Object Mapping
- Mapping methods are used for data transformation.
- The Mapper class contains generic methods for mapping objects and their lists.

## How to Run the Application
- Open the project in a C#-supporting IDE (e.g., Visual Studio).
- Please make sure you have the correct Connection String configured in GlobalConfig.cs.
- Run the application.

## Author
Martin Baranek
