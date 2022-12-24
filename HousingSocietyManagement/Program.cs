

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews(); //Registering a service for building and executing a MVC application 

//builder.Services.AddMvc(); // Registering the service for developing and executing the MVC application 

// Includes services that is not needed for MVC app Devlopment . Like RazorPages -- Performance problem .


//builder.Services.AddMvcCore(); // This service will not include All the necessary services for building MVC app.
// For doing any authentication, Json conversion

builder.Services.AddControllers();// This service will added only the controllers , so not sutiable for MVC app development.- Helpful for building the Web APIs



var app = builder.Build();

// Configure the HTTP request pipeline.

//Steps for handling the incoming request -(Pipeline)
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else if(app.Environment.IsProduction())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();//Middleware used to match the right endpoint as per the incoming request.

app.UseAuthorization();

app.MapControllerRoute( // Middleware will actually execute the endpoint 
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
