# Nautical Nest

## Introduction
Nautical Nest is a full-stack web application designed for managing ship berths. It facilitates efficient handling of berth reservations, tracking of ship arrival and departure times, and provides a comprehensive overview of berth availability. Built with .NET for the backend and Angular for the frontend, Nautical Nest aims to streamline the management of maritime docking facilities.

## Features

- **User Authentication**: Secure login and user management.
- **Berth Availability**: View and manage the list of available berths.
- **Search Functionality**: Find berths based on size, location, and availability.
- **Detailed Information**: Access detailed data about docked ships and historical records.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

## Setup Instructions

TODO

### Prerequisites
- [.NET 6 SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)


### Installing Dependencies 

1. **Installation**
   ```shell
   sudo apt install something



### Set up the Backend
2. **Set up the Backend:**
   ```shell
   

## Set up the Frontend

3. **Set up the Frontend**
   ```shell
   

## Scripts

4. **To use scripts install requests library**
   ```shell
   

## Navigate to script folder and run script 

5. **To use script run **
   ```shell

- `a_script_selector_script.py`: Script for selecting other scripts.


6. **Deployment:**

   ```shell
   run

## Available Endpoints
The API is structured into namespaces, which group related endpoints. The following namespaces are available:


- `/berth': Operations related to address entities.
- `/ship': Operations for service entities.
- `/users': User-related operations.

## Accessing Endpoints
You can access the API endpoints using tools like curl or Postman. For example:

   '''shell
   curl -u username:password -X GET http://localhost:5000/berths/ 


This command retrieves all berths if you replace username:password with valid credentials.
Do note that username:password should be some user and password of that user that is in the database,
database should be initialized ,
the address will be different if used in a enviroment like github Codespaces, and it is not static in swagger.yaml .


## Documentation
For Swagger documentation for all endpoints. Visit http://localhost:5000/ to view the interactive documentation and test the API directly from your browser.
For a more detailed guide on how to use each endpoint.
The address will be different if used in a enviroment like github Codespaces, and it is not static in swagger.yaml .

## Authentication
The API uses HTTP Basic Authentication. Ensure you pass the correct username and password headers with each request that requires authentication.
