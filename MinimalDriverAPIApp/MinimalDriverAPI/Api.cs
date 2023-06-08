using DataAccess.Data;

namespace MinimalDriverAPI;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        app.MapGet("/Drivers", GetDrivers);
        app.MapGet("/Drivers/{id}", GetDriver);
        app.MapPost("/Drivers", InsertDriver);
        app.MapPut("/Drivers", UpdateDriver);
        app.MapDelete("/Driver/{id}", DeleteDriver);

        app.MapGet("/Vehicles", GetVehicles);
        app.MapGet("/Vehicles/{id}", GetVehicle);
        app.MapPost("/Vehicles", InsertVehicle);
        app.MapPut("/Vehicles", UpdateVehicle);
        app.MapDelete("/Vehicles/{id}", DeleteVehicle);

        app.MapGet("/Schedules", GetSchedules);
        app.MapGet("/Schedules/{id}", GetSchedule);
        app.MapPost("/Schedules", InsertSchedule);
        app.MapPut("/Schedules", UpdateSchedule);
        app.MapDelete("/Schedules/{id}", DeleteSchedule);

        app.MapGet("/AllFullSchedule", GetFullSchedule);
        app.MapGet("/All", GetAll);

    }

    private static async Task<IResult> GetDrivers(IDriverData data)
    {
        try
        {
            return Results.Ok(await data.GetDrivers());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetDriver(int id, IDriverData data)
    {
        try
        {
            var results = await data.GetDriver(id);
            if (results is null)
            {
                return Results.NotFound();
            }

            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertDriver(DriverModel driver, IDriverData data)
    {
        try
        {
            await data.InsertDriver(driver);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateDriver(DriverModel driver, IDriverData data)
    {
        try
        {
            await data.UpdateDriver(driver);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteDriver(int id, IDriverData data)
    {
        try
        {
            await data.DeleteDriver(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetVehicles(IVehicleData data)
    {
        try
        {
            return Results.Ok(await data.GetVehicles());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetVehicle(int id, IVehicleData data)
    {
        try
        {
            var results = await data.GetVehicle(id);
            if (results is null)
            {
                return Results.NotFound();
            }

            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertVehicle(VehicleModel vehicle, IVehicleData data)
    {
        try
        {
            await data.InsertVehicle(vehicle);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateVehicle(VehicleModel vehicle, IVehicleData data)
    {
        try
        {
            await data.UpdateVehicle(vehicle);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteVehicle(int id, IVehicleData data)
    {
        try
        {
            await data.DeleteVehicle(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetSchedules(IScheduleData data)
    {
        try
        {
            return Results.Ok(await data.GetSchedules());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetSchedule(int id, IScheduleData data)
    {
        try
        {
            var results = await data.GetSchedule(id);
            if (results is null)
            {
                return Results.NotFound();
            }

            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertSchedule(ScheduleModel schedule, IScheduleData data)
    {
        try
        {
            await data.InsertSchedule(schedule);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateSchedule(ScheduleModel schedule, IScheduleData data)
    {
        try
        {
            await data.UpdateSchedule(schedule);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteSchedule(int id, IScheduleData data)
    {
        try
        {
            await data.DeleteSchedule(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetFullSchedule(IAllData data)
    {
        try
        {
            return Results.Ok(await data.GetFullSchedule());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetAll(IAllData data)
    {
        try
        {
            return Results.Ok(await data.GetAll());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
