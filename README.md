# Pharmacy Management System

A Windows Forms pharmacy management application built with C#, .NET Framework 4.8, SQL Server, and Guna UI2 controls.

## Features

- Administrator and pharmacist dashboards
- User creation, profile editing, and user management
- Medicine inventory creation, update, search, and deletion
- Medicine selling/cart workflow with stock updates
- SQL Server database schema included for local setup

## Tech Stack

- C# / Windows Forms
- .NET Framework 4.8
- SQL Server LocalDB or SQL Server Express
- Guna.UI2.WinForms via NuGet

## Getting Started

### Prerequisites

- Windows
- Visual Studio 2022 with the `.NET desktop development` workload and .NET Framework 4.8 targeting pack
- SQL Server LocalDB or SQL Server Express
- SQL Server Management Studio or Azure Data Studio for running the schema

### Setup

1. Clone the repository.
2. Run `database/schema.sql` against your local SQL Server instance.
3. Confirm the `PharmacyDatabase` connection string in `PharmacyManagement/App.config`.
4. Open `PharmacyManagement.sln` in Visual Studio.
5. Restore NuGet packages and build the solution.
6. Start the app.

When the `users` table is empty, use the bootstrap login `root` / `root`, then create a real administrator account.

## Build

Visual Studio is the easiest path for local development. The repository also includes a GitHub Actions workflow that restores NuGet packages and builds the solution on Windows.

```powershell
msbuild PharmacyManagement.sln /restore /p:Configuration=Release /p:Platform="Any CPU"
```

## Project Structure

```text
PharmacyManagement/          WinForms application source
PharmacyManagement/AdminstratorUC/
PharmacyManagement/PharmacistUC/
database/schema.sql          SQL Server database setup
docs/                        Setup and GitHub notes
images/                      UI image assets
```

## Notes

This is a desktop learning project. Before using it in a real pharmacy environment, add password hashing, stronger authorization checks, audit logging, backups, and production configuration management.

## License

No license has been selected yet. Add a `LICENSE` file before making the repository public if you want others to reuse the code.
