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
}
