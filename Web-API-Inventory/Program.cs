using Microsoft.Extensions.Configuration;
using Web_API_Inventory;
using Web_API_Inventory.Model;
using Web_API_Inventory.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//builder.Configuration.AddJsonFile("InventorySettings.json");
//Add services to the container.
builder.Services.AddControllers();
builder.Services.AddTransient<MethodsForProducts>();
builder.Services.AddSingleton(new InventoryService("InventorySettings.json"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
