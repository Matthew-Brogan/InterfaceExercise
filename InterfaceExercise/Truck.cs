using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck:IVehicle,ICompany
    {
        public bool HasLongBed { get; set; }
        public bool IsDiesel { get; set; }
        public int NumOfWheels { get; set; }
        public string EngineSize { get; set; }
        public int TopSpeed { get; set; }
        public bool IsDrivable { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }
    }
}
