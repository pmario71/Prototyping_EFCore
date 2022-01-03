# Readme

## Manual Creation of Migrations

```ps1
dotnet ef migrations add <name of migration>
```

## Triggering Migrations

```
dotnet ef database update
```

### Self-contained Bundle

If migration needs to run on a machine with no ef tooling installed:

```
dotnet ef migrations bundle --self-contained
```

Creating a new migration with add and then running the executable does not work and returns following error:

```
No migrations were applied. The database is already up to date.
Done.
```

  
* [Docs - Migration Bundles](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/applying?tabs=dotnet-core-cli#bundles)