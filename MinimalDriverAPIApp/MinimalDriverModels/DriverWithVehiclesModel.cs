using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalDriverModels
{
    public  class DriverWithVehiclesModel : DriverModel
    {
        public List<VehicleModel> Vehicles { get; set; }
    }
}
