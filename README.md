# DeepLabSystem API

This is a complete ASP.NET Core 8.0 Web API solution built following Clean Architecture principles. It serves as a robust foundation for building modern, scalable, and maintainable web applications.

## Features

- **Clean Architecture**: The solution is structured into four distinct projects (`Domain`, `Application`, `Infrastructure`, and `Api`) to ensure a clear separation of concerns.
- **CQRS with MediatR**: Implements the Command Query Responsibility Segregation (CQRS) pattern using the MediatR library for clean and decoupled business logic.
- **Authentication & Authorization**: Features a full authentication module using ASP.NET Core Identity, with support for JWT and refresh tokens.
- **Database**: Uses Entity Framework Core with a code-first approach to manage the database schema. It is configured to work with SQL Server.
- **Generic Repository Pattern**: Implements a generic repository pattern for data access to reduce boilerplate code.
- **API Documentation**: Integrated Swagger/OpenAPI for clear and interactive API documentation.

## Project Structure

- `src/DeepLabSystem.Domain`: Contains the core business entities, enums, and domain events.
- `src/DeepLabSystem.Application`: Contains the application logic, including CQRS commands, queries, handlers, DTOs, and service interfaces.
- `src/DeepLabSystem.Infrastructure`: Contains the implementation details for external concerns, such as the database context, repositories, and other services.
- `src/DeepLabSystem.Api`: The entry point of the application. It contains the API controllers and configuration for the web host.

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker Desktop](https://www.docker.com/products/docker-desktop) (for running SQL Server on macOS/Linux)

### 1. Configure the Database Connection

Open `src/DeepLabSystem.Api/appsettings.json` and update the `DefaultConnection` string with your SQL Server credentials. The default is configured for a local Docker container.

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost,1433;Database=DeepLabSystem;User Id=sa;Password=yourStrong(!)Password;MultipleActiveResultSets=true;TrustServerCertificate=True"
}
```

### 2. Run SQL Server in Docker

If you are not using a local SQL Server instance, you can run one in a Docker container with the following command. **Ensure the password matches the one in your connection string.**

```bash
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=yourStrong(!)Password" -p 1433:1433 --name mssql-deeplab -d mcr.microsoft.com/mssql/server:2022-latest
```

### 3. Apply Database Migrations

Once the database server is running, apply the Entity Framework Core migrations to create the database schema.

```bash
dotnet ef database update --project src/DeepLabSystem.Infrastructure -s src/DeepLabSystem.Api
```

### 4. Run the Application

Finally, run the API project.

```bash
dotnet run --project src/DeepLabSystem.Api
```

The application will be available at `http://localhost:5140`. You can access the Swagger UI at `http://localhost:5140/swagger`.
