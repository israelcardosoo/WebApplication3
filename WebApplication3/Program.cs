using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApiFinal.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//

builder.Services.AddCors(etecPoliticas =>
{
    etecPoliticas.AddPolicy("EtecAll",
        builder =>
        {
            builder

            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});


builder.Services.AddRazorPages();
builder.Services.AddDbContext<WebApiFinalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApiFinalContext") ?? throw new InvalidOperationException("Connection string 'WebApiFinalContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors("EtecAll");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
