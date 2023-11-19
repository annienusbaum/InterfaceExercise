using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var truck = new Truck();
            var suv = new SUV();

            var vehicles = new List<IVehicle>() { car, truck, suv };

            foreach(var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.ChangeGears(true);
                vehicle.Reverse();
            }
        }
    }
}



//TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

//Create 2 Interfaces called IVehicle & ICompany -  done

//Create 3 classes called Car , Truck , & SUV

//In your IVehicle:

/* Create 4 members that Car, Truck, & SUV all have in common.
 * Example: public int NumberOfWheels { get; set; }
 *///------------------------------------------------------------
   //\SYNTAX:
   //public interface IVehicle
   //{
   // public double EngineSize { get; set; }
   //public string Make { get; set;}
   // public string Model { get; set; }
   //public int SeatCount { get; set; }
   //}
   //\\



//In ICompany: 

// Create 2 members that are specific to each every company
//regardless of vehicle type.
//Example: public string Logo { get; set; }
///>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
///            //\SYNTAX:
//\\\ namespace InterfaceExercise
//{
//public interface ICompany
//{
// public string CompanyName { get; set }
// public string Motto { get; set; }
//