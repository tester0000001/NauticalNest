# Nautical Nest

## Introduction
Nautical Nest is a full-stack web application designed for managing ship berths. It facilitates efficient handling of berth reservations, tracking of ship arrival and departure times, and provides a comprehensive overview of berth availability. Built with .NET for the backend and Angular for the frontend, Nautical Nest aims to streamline the management of maritime docking facilities.

## Features

- **User Authentication**: Secure login and user management.
- **Berth Availability**: View and manage the list of available berths.
- **Search Functionality**: Find berths based on size, location, and availability.
- **Detailed Information**: Access detailed data about docked ships and historical records.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine.

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

## Setup Instructions


### Installing .NET 6 SDK on Ubuntu

1. **Add Microsoft Package Repository:**
- Open the terminal
- Download the Microsoft package repository configuration package:
   ```shell
   wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb

2. **Install the package:**

   ```shell
   sudo dpkg -i packages-microsoft-prod.deb

3. **Remove the package file:**
   ```shell
   sudo dpkg -i packages-microsoft-prod.deb
   rm packages-microsoft-prod.deb

## Setting Up 
1. **EF Core commands:**
   ```shell
      dotnet new tool-manifest
      dotnet tool install dotnet-ef --version 7.0.0
      cd Server
      cd Data
      dotnet dotnet-ef
      dotnet ef migrations add InitialCreate
      dotnet ef database update


The InitialCreate migration will scaffold a migration script with the necessary database commands to create your schema based on the current model 
      

## Setting Up SQL Server with Docker

### Docker Installation Guide
Follow these steps to install Docker on your Ubuntu system:

1. **Update the package list:**

   ```shell
   sudo apt-get update

2. **Install packages to allow apt to use a repository over HTTPS:**

   ```shell
   sudo apt-get install apt-transport-https ca-certificates curl software-properties-common

3. **Add Docker’s official GPG key:**

   ```shell
   curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo apt-key add -


4. **Set up the stable Docker repository:**

   ```shell
   sudo add-apt-repository "deb [arch=amd64] https://download.docker.com/linux/ubuntu $(lsb_release -cs) stable"

5. **Update the package list again:**

   ```shell
   sudo apt-get update

6. **Install Docker CE, Docker-ce-cli and containerd.io :**

   ```shell
   sudo apt-get install docker-ce docker-ce-cli containerd.io

Install containerd.io and Docker CE:

7. **Test your Docker installation by running the hello-world image:**
   ```shell
   sudo docker run hello-world

This will download a test image and run it in a container. If you see a welcome message, Docker has been successfully installed.

### Pull SQL Server Docker Image:

1. **Pull the latest SQL Server image:**

   ```shell
   docker pull mcr.microsoft.com/mssql/server:2019-latest

2. **Start SQL Server:**
Run the SQL Server container using the Docker command. This will start an instance of SQL Server running in a container.
   ```shell
   docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Passw0rd" -p 1433:1433 --name sql1 -d mcr.microsoft.com/mssql/server:2019-latest

Note: replace Passw0rd with a password of your choice.

3. **Connect to SQL Server:**

Connect to your SQL Server instance using a SQL client tool like 
Azure Data Studio, 
or SQL Server Management Studio. 

Use the server address:    localhost, 
               username:   sa, 
               and the password you set.

### Pull SQL Server Docker Image:

1. **Create a .NET Project:**
Initialize a new .NET Web API project in project folder and change into the project directory:
   ```shell
   dotnet new webapi -n NauticalNest
   cd NauticalNest

2. **Add EF Core Packages:**
Add the EF Core library and the SQL Server provider:
   ```shell
   dotnet add package Microsoft.EntityFrameworkCore
   dotnet add package Microsoft.EntityFrameworkCore.SqlServer

### Build and Run :
1. **Compile and run:**

   ```shell
   dotnet build
   dotnet run

 
TODO other setups 
   

## Set up the Frontend

3. **Set up the Frontend**
   ```shell
   

## Available Endpoints

The API is structured into namespaces, grouping related endpoints for ease of use and organization. Below are the available namespaces with their respective operations:

### Berths (`/berths`)
Operations related to berths in the ship berth management system.

- `GET /berths`: Retrieves a list of all berths.
- `GET /berths/{id}`: Retrieves a specific berth by its ID.
- `POST /berths`: Creates a new berth.
- `PUT /berths/{id}`: Updates a specific berth by its ID.
- `DELETE /berths/{id}`: Deletes a specific berth by its ID.

### Ships (`/ships`)
Operations for managing ships.

- `GET /ships`: Retrieves a list of all ships.
- `GET /ships/{id}`: Retrieves a specific ship by its ID.
- `POST /ships`: Creates a new ship.
- `PUT /ships/{id}`: Updates a specific ship by its ID.
- `DELETE /ships/{id}`: Deletes a specific ship by its ID.

### Reservations (`/reservations`)
Operations for managing reservations which associate ships with berths within a reserved timeframe.

- `GET /reservations`: Retrieves all reservations.
- `GET /reservations/{id}`: Retrieves a specific reservation by its ID.
- `POST /reservations`: Creates a new reservation.
- `PUT /reservations/{id}`: Updates a specific reservation by its ID.
- `DELETE /reservations/{id}`: Deletes a specific reservation by its ID.

### Users (`/users`)
User-related operations, including authentication and user management.

- `GET /users`: Retrieves a list of all users.
- `GET /users/{id}`: Retrieves a specific user by their ID.
- `POST /users/register`: Registers a new user.
- `POST /users/login`: Authenticates a user and returns a token.
- `PUT /users/{id}`: Updates a specific user by their ID.
- `DELETE /users/{id}`: Deletes a specific user by their ID.

## Accessing Endpoints

You can access the API endpoints using tools like `curl` or Postman. For example:

1. **curl example**
   ```shell
   curl -u username:password -X GET http://localhost:5000/berths/
   curl -u username:password -X GET http://localhost:5000/berths/{id}
   curl -u username:password -X DELETE http://localhost:5000/ships/{id}
   curl -u username:password -X POST http://localhost:5000/users/register
   curl -u username:password -X PUT http://localhost:5000/reservations/{id}


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
