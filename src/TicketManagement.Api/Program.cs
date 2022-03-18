using TicketManagement.Application;
using TicketManagement.Persistence;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddApplicationServices();
services.AddPersistenceServices(builder.Configuration);
services.AddControllers();

services.AddCors(options => 
{
    options.AddPolicy("Open",builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

var env = builder.Environment;

var app = builder.Build();

if(env.IsDevelopment()){
    app.UseDeveloperExceptionPage();
}
app.UseRouting();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
