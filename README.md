# BI Dashboard for ASP.NET Core - Resolve Entity Framework Core Context from the DI Container

The following example obtains Entity Framework Core context from an ASP.NET Core dependency injection container.

1. Implement the `IEFContextProvider` interface (`CustomEFContextProvider` class in this example) to create a service that allows you to get the EF Core Context.

2. Call the [IEFContextProvider.GetContext(String, Type)](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Entity.IEFContextProvider.GetContext(System.String-System.Type)?v=23.1&p=netframework) method to return a context for the specified data source.

3. Call the [AddDbContext](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.entityframeworkservicecollectionextensions.adddbcontext?view=efcore-7.0) method to register the context in the dependency injection container and specify the required connection string in the `WebApplicationBuilder` class.

4. In the `WebApplicationBuilder` class, register the [DashboardConfigurator](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator?v=23.1&p=netframework) service and configure it using the [SetEFContextProvider(IEFContextProvider)](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator.SetEFContextProvider(DevExpress.Data.Entity.IEFContextProvider)?v=23.1&p=netframework) method.

## Files to Review

- [Program.cs](./WebEFCoreApp/Program.cs)
- [CustomEFContextProvider.cs](./WebEFCoreApp/CustomEFContextProvider.cs)
## Documentation

- [IEFContextProvider](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Entity.IEFContextProvider?v=23.1&p=netframework)
- [DashboardConfigurator.SetEFContextProvider](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator.SetEFContextProvider(DevExpress.Data.Entity.IEFContextProvider)?v=23.1&p=netframework)