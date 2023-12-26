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
- [.NET 6 SDK](https://dotnet.microsoft.com/download)
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
The API is structured into namespaces, which group related endpoints. The following namespaces are available:


- `/berth': Operations related to berths .
- `/ship': Operations for ships.
- '/reservation': Operations for reservations (pairs ship+berth within a reserved timeframe.)
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
