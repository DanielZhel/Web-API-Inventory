using Microsoft.Extensions.Configuration;
using Web_API_Inventory;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("InventorySettings.json", false);
//Add services to the container.

builder.Services.Configure<InventorySettings>(builder.Configuration.GetSection("Values"));

//builder.Services.AddSingleton(new InventoryServices("InventorySettings.json"));
builder.Services.AddControllers();
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
