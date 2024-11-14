var builder = DistributedApplication.CreateBuilder(args);

builder.AddAzureFunctionsProject<Projects.FunctionApp9>("functionapp9");

builder.Build().Run();
