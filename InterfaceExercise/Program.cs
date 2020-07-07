using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */
            Car porsche = new Car()
            {
                



            };
            Console.WriteLine($"Introducing the new {porsche.CompanyName}, with its {porsche.EngineSize} engine you can expect great gas mileage. Its {porsche.IsAllWheelDrive} this puppy is all wheel drive" +
                $"And with {porsche.NumOfDoors} doors it can get your whole family from a to b at speeds up to {porsche.TopSpeed}mph. With {porsche.NumOfWheels} pirelli tires this thing is slick! Dont forget about that {porsche.Logo} head on the hood!");

            var denali = new Truck()
            {
                CompanyName = "Gmc",
                EngineSize = "Enormous",

                IsDiesel = true,

                Logo = "GMC",

                HasLongBed = false,

                NumOfWheels = 4,

                IsDrivable = true,

                TopSpeed = 165

            };
            Console.WriteLine($"Introducing the new {denali.CompanyName}, with its {denali.EngineSize} engine you can expect reasonable gas mileage. Its {denali.IsDiesel} this puppy is all deisel" +
                $"And to say this truck has a long bed is {denali.HasLongBed}. Though with all the power you can travel at speeds up to {denali.TopSpeed}mph. With {denali.NumOfWheels} pirelli tires this thing is slick! Dont forget about that {denali.Logo} on the hood!");


            SUV Suburban = new SUV()
            {
                CompanyName = "Gmc",
                EngineSize = "Enormous",

                IsLifted = true,

                Logo = "GMC",

                IsGasHog = false,

                NumOfWheels = 4,

                IsDrivable = true,

                TopSpeed = 165

            };
            Console.WriteLine($"Introducing the new {Suburban.CompanyName}, with its {Suburban.EngineSize} engine you can expect incredible gas mileage. Its {Suburban.IsDrivable} this puppy is all Luxury." +
                $"And to say this SUV sucks down gas is {Suburban.IsGasHog} with our new hybrid engine. Though with all the power you can travel at speeds up to {Suburban.TopSpeed}mph. With {Suburban.NumOfWheels} pirelli tires this thing is slick! Dont forget about that {Suburban.Logo} on the hood!");


            ;            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
