using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car: IVehicle, ICompany
    {
        public string NumOfDoors { get; set; }
        public bool IsAllWheelDrive { get; set; }

        public int NumOfWheels { get; set; }
        public bool IsDrivable { get; set; }
        public int TopSpeed { get; set; }
        public string EngineSize { get; set; }

        public string CompanyName { get; set; }
        public string Logo { get; set; }
    }
}
