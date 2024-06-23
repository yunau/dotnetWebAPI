# dotnetWebAPI

Step 1:

dotnet add package Microsoft.EntityFrameworkCore.SqlServer 
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.AspNetCore.Cors

Step 2:

Run "SQL Server 2022" Docker container

appsettings.json

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

Step 3:

Generate database and tables on SQL Server

dotnet ef migrations add InitialCreate
dotnet ef database update

Step 4:

dotnet run
SIMPLEWEBAPI.Controllers have the APIs






