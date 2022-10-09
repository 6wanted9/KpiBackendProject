using KpiBackendProject.Interfaces;
using KpiBackendProject.Models.Entities;
using KpiBackendProject.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ICustomContext, CustomContext>();
builder.Services.AddTransient<IRepository<User>, Repository<User>>();
builder.Services.AddTransient<IRepository<Category>, Repository<Category>>();
builder.Services.AddTransient<IRepository<Record>, Repository<Record>>();
builder.Services.AddTransient<IUserCreator, UserCreator>();
builder.Services.AddTransient<ICategoryCreator, CategoryCreator>();
builder.Services.AddTransient<IRecordCreator, RecordCreator>();
builder.Services.AddTransient<IRecordCreationValidator, RecordCreationValidator>();
builder.Services.AddTransient<IRecordsRetriever, RecordsRetriever>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();