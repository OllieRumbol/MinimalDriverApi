using MinimalDriverAPI;
using MinimalDriverDataAccess.Data;
using MinimalDriverDataAccess.DbAccess;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IDatabaseConnectionFactory, DatabaseConnectionFactory>();
builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddSingleton<IDriverData, DriverData>();
builder.Services.AddSingleton<IVehicleData, VehicleData>();
builder.Services.AddSingleton<IScheduleData, ScheduleData>();
builder.Services.AddSingleton<IAllData, AllData>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.ConfigureApi();

app.Run();