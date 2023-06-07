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

        app.MapGet("/Schedule", GetSchedules);

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
