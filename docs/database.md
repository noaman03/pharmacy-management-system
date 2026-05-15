# Database Setup

The application uses SQL Server and reads its connection string from `PharmacyManagement/App.config`.

## LocalDB default

The checked-in default targets Visual Studio LocalDB:

```xml
Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True
```

Run `database/schema.sql` in SQL Server Management Studio, Azure Data Studio, or `sqlcmd` before starting the app.

## SQL Server Express

If you use SQL Server Express instead, update the `PharmacyDatabase` connection string to something like:

```xml
Data Source=.\SQLEXPRESS;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True
```

## First login

When the `users` table is empty, the app allows a bootstrap login with:

```text
Username: root
Password: root
```

Create a real administrator account immediately after first login.
