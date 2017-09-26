using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum HelicopterType
{
    BlackHawk = 1,
    Apache,
    SikorskyR4,
    Bell47
}
namespace AirCraftsAssignment.Models
{
    class Helicopter : Aircraft
    {
        public int Blades { get; set; }
        public bool CanLandOnWater { get; set; }

        public override string EngineSound()
        {
            return "chuka chuka chuka";
        }

       

        public Helicopter( HelicopterType helicopterType)
        {
            

            switch (helicopterType)
            {
                case HelicopterType.Apache:
                    {
                        this.Name = "Apache";
                        this.SpeedInKM = 293;
                        this.YearProduced = 1965;
                        this.CanLandOnWater = false;
                        this.Blades = 4;
                    }
                    break;

                case HelicopterType.Bell47:
                    {
                        this.Name = "Bell 47";
                        this.SpeedInKM = 150;
                        this.YearProduced = 1946;
                        this.Blades = 4;
                        CanLandOnWater = false;
                    }
                    break;

                case HelicopterType.SikorskyR4:
                    {
                        this.Name = "Sikorsky R4";
                        this.SpeedInKM = 200;
                        this.Blades = 4;
                        CanLandOnWater = false;
                        this.YearProduced = 1942;
                    }
                    break;

                case HelicopterType.BlackHawk:
                    {
                        this.Name = "Black Hawk";
                        this.SpeedInKM = 280;
                        this.YearProduced = 1963;
                        this.Blades = 4;
                        this.CanLandOnWater = false;
                    }
                    break;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" Blades: {Blades}\n Lands on Water? : {CanLandOnWater}".ToString();
        }

    }

}

