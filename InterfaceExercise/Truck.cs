﻿using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
		public Truck()
		{
		}

        public double EngineSize { get; set; } = 6;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Tacoma";
        public int SeatCount { get; set; } = 6;
        public string CompanyName { get; set; } = "Toyota";
        public string Motto { get; set; } = "Let's go places.";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;

        public void Drive()
        {
            if(HasFourWheelDrive == true)
            {
               Console.WriteLine($"Four wheel drive {GetType().Name} now driving forward.");
            }
            else
            {
                Console.WriteLine($"Four wheel drive {GetType().Name} now driving forward.");
            }
        }
         

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park..");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}

