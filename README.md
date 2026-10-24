# Blog App

A .NET 6 ASP.NET Core MVC learning app with blog posts, sections, team records, Entity Framework Core/SQL Server persistence, and scaffolded Identity accounts.

## Setup

Use the .NET 6 SDK/runtime and a development SQL Server instance. .NET 6 is an old, unsupported target; do not treat this repository as a current production starter.

From the repository root:

```bash
dotnet restore
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "YOUR_LOCAL_SQL_SERVER_CONNECTION_STRING"
```

Replace the placeholder with a local development connection string. Both `ApplicationDbContext` (Identity) and `BlogContext` use `DefaultConnection` in [`Program.cs`](Program.cs).

Review and apply the checked-in migrations for **both contexts** before using the app. With compatible EF Core 6 tooling installed, select each context explicitly; Identity migrations live under `Data/Migrations/`, while blog-data migrations live under `Migrations/`. Use an empty development database and inspect migration operations first.

```bash
dotnet run --environment Development
```

Open the listening URL printed by the app. User secrets load in Development; do not commit database credentials. Identity requires confirmed accounts, so account confirmation must be configured or handled through the development registration flow before sign-in succeeds.

## Source guide

- [`Controllers/BlogsController.cs`](Controllers/BlogsController.cs): authorized blog CRUD actions.
- [`Controllers/`](Controllers/): section/team actions, home pages, and an unfinished admin experiment.
- [`Models/BlogContext.cs`](Models/BlogContext.cs): blog, section, and team entities.
- [`Views/`](Views/): MVC pages.

## Limitations

Authorization is not comprehensively enforced across all controllers; the separate `admin` controller is not an authorization boundary and its `CreateBlog` action does not save changes. This is a learning project, not a reviewed publishing/admin system. Use dummy data locally. Build, migrations, account confirmation, and end-to-end behavior have not been tested for this documentation refresh.
