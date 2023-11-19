using System;
namespace InterfaceExercise
{
	public class Car : IVehicle , ICompany
	{
		public Car()
		{
		}

        public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "4Runner";
        public int SeatCount { get; set; } = 7;
        public string CompanyName{ get; set; } = "Toyota";
        public string Motto { get; set; } = "Let's go places.";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward.");
        }

        public void Reverse()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing...");
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



//make the class (car) conform or inherit to the interface (IVehicle/ICompany)
//this car class conforms to these interfaces
