# DotnetWebAPI

# Creating a Web API with C# using dotnet/efcore and SQL Server

This guide will walk you through the steps to create a Web API using C#, Entity Framework Core, and SQL Server.

## Step 1: Install Required Packages

Open a terminal in the root directory of your project and run the following commands to add necessary packages:

```sh
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.AspNetCore.Cors

docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=SimplePassword123!' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
```

##  Step 2: Configure SQL Server

```sh
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=SimplePassword123!' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
```

Next, configure your application to connect to the SQL Server by updating appsettings.json:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost,1433;Database=SimpleDB;User Id=sa;Password=SimplePassword123!;TrustServerCertificate=true"
  },
  "AllowedHosts": "*"
}
```

## Step 3: Generate Database and Tables
```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## Step 4: Run the Web API

Run your Web API using the following command:
```sh
dotnet run
```






