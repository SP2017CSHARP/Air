using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraftsAssignment.Models
{
    class AirHanger
    {
        List<Aircraft> aircrafts = new List<Aircraft>();
        public AirHanger()
        {
            aircrafts = new List<Aircraft>();
        }

        public int AmountInStock { get; set; }

        public void AddAirCraftToStock(int amount)
        {
            this.AmountInStock += amount;
        }

        private Aircraft GetAirCraft(string aircraftName)
        {
            foreach (Aircraft a in aircrafts)
            {
                if (a.Name == aircraftName)
                {
                    return a;
                }
                else
                {
                    Console.WriteLine($"Aircraft: {aircraftName} does not exist");
                }
            }
            return null;
        }

        public void RemoveAircraftFromStock(int amount)
        {
            if ((this.AmountInStock - amount) < 0)
            {
                this.AmountInStock = 0;
            }
            else
            {
                this.AmountInStock -= amount;
            }
        }

        public void RemoveAirCraftFromList(string name)
        {

            aircrafts.RemoveAll(x => x.Name == name);

        }

        public void AddAirplaneToList(int amount, AirPlaneType planeType)
        {
            for (int i = 1; i <= amount; i++)
            {
                aircrafts.Add(new Airplane(planeType));
                AddAirCraftToStock(amount);
            }

        }

        public void AddHelicopterToList(int amount, HelicopterType hType)
        {
            for (int i = 1; i <= amount; i++)
            {
                aircrafts.Add(new Helicopter(hType));

                AddAirCraftToStock(amount);
            }

        }

        public void ShowAllAirCrafts()
        {
            string airplaneString = "";
            string helicopterString = "";

            foreach (Aircraft a in aircrafts)
            {
                if (a is Airplane)
                {
                    airplaneString += a.ToString() + Environment.NewLine;
                }
                else if (a is Helicopter)
                {
                    helicopterString += a.ToString() + Environment.NewLine;
                }
                
            }

            Console.WriteLine($"Airplanes: \n {airplaneString}");
            Console.WriteLine($"Helicopters: \n {helicopterString}");

        }

        public void ShowAirplanes()
        {
            Console.WriteLine("Showing Airplanes....");
            Console.WriteLine($"You have: {aircrafts.Count(x => x is Airplane)} Airplanes");

            foreach (Aircraft a in aircrafts)
            {
                if (a is Airplane)
                {
                    Console.WriteLine($"Name: {a.Name}");
                }
            }

        }

        public void ShowHelicopters()
        {
            Console.WriteLine("Showing Helicopters....");
            Console.WriteLine($"You have: {aircrafts.Count(x => x is Helicopter)} Helicopters");

            foreach (Aircraft a in aircrafts)
            {
                if (a is Helicopter)
                {
                    Console.WriteLine($"Name: {a.Name}");
                }
            }
        }






    }
}
