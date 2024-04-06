using AkarSoftware.HospitalApp.Managers.Concrete.DependencyResolves.Microsoft;

var builder = WebApplication.CreateBuilder(args);

#region Services

builder.Services.AddControllersWithViews();
builder.Services.AddCostumeDependencies(builder.Environment, builder.Configuration);
#endregion

var app = builder.Build();


#region Middlewares

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
else
{
    app.UseExceptionHandler("/exception");
    app.UseHsts(); // Http yönlendirmeyi zorunlu kılmak için eklenmiştir. 
}
// Costume Status Page
app.UseStatusCodePagesWithReExecute("/Error/{0}"); // Costume Exception Handler


// NToastNotify için eklendi
//app.UseNToastNotify();

/// Https Yönlendirme
app.UseHttpsRedirection(); // Http Yönlendirme için 

/// Static Files Middleware
app.UseStaticFiles();
//app.UseStaticFiles(new StaticFileOptions { RequestPath = "/node_modules", FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory() + "/node_modules")) });

// Routing
app.UseRouting();

// CORS
app.UseCors(x => { x.AllowAnyOrigin(); }); // Ajax için gelen her talep burada cors ayarlaması neticesinde filtrelenecek

// Authentication
app.UseAuthentication();

// Authorization
app.UseAuthorization();

// Costume Middlewares 
//app.AddCostumeMiddlewares();



app.UseEndpoints(e =>
{
    e.MapControllerRoute(name: "defaults", pattern: "{Area=Landing}/{Controller=Home}/{Action=Index}/{id?}");
});

app.Run();

#endregion




app.Run();
