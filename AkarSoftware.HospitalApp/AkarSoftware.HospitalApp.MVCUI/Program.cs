using AkarSoftware.HospitalApp.Managers.Concrete.DependencyResolves.Microsoft;

var builder = WebApplication.CreateBuilder(args);

#region Services

builder.Services.AddControllersWithViews();
builder.Services.AddCostumeDependencies(builder.Environment, builder.Configuration);
#endregion

var app = builder.Build();

#region Middlewares 




#endregion

app.Run();
