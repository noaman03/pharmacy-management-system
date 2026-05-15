# Contributing

Thanks for helping improve the Pharmacy Management app.

## Local workflow

1. Create a branch from `main`.
2. Build the solution in Visual Studio or with MSBuild.
3. Keep UI designer changes focused and review generated `.Designer.cs` diffs before committing.
4. Do not commit `bin/`, `obj/`, `.vs/`, local database files, or personal connection strings.

## Pull request checklist

- The solution builds in `Release`.
- Database changes are reflected in `database/schema.sql`.
- User-facing behavior is documented in `README.md` when it changes.
- New data access code uses SQL parameters.
