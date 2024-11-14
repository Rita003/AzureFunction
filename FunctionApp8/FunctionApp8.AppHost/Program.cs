var builder = DistributedApplication.CreateBuilder(args);

builder.AddAzureFunctionsProject<Projects.FunctionApp8>("functionapp8");

builder.Build().Run();
