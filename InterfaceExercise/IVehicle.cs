using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumOfWheels { get; set; }
        public string EngineSize { get; set; }
        public int TopSpeed { get; set; }
        public bool IsDrivable { get; set; }
    }
}
