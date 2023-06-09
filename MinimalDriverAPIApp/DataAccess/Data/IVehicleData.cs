﻿using MinimalDriverModels;

namespace MinimalDriverDataAccess.Data
{
    public interface IVehicleData
    {
        Task DeleteVehicle(int id);
        Task<VehicleModel?> GetVehicle(int id);
        Task<IEnumerable<VehicleModel>> GetVehicles();
        Task InsertVehicle(VehicleModel vehicle);
        Task UpdateVehicle(VehicleModel vehicle);
    }
}