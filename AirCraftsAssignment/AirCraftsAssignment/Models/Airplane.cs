using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraftsAssignment.Models
{
    enum AirPlaneType
    {
        WrightFlyer = 1,
        Learjet23,
        Boeing787,
        Boeing747
    }
    class Airplane : Aircraft
    {
        private int NumberOfWings { get; set; }
        public override string EngineSound()
        {
            return "Vroooooom";
        }



        //private AirPlaneType _airPlaneType;

        public Airplane(AirPlaneType planeType)
        {
            switch (planeType)
            {
                
                case AirPlaneType.WrightFlyer:
                    {
                        this.Name = "Wright Flyer";
                        this.SpeedInKM = 100;
                        this.YearProduced = 1903;
                        this.NumberOfWings = 4;
                    }
                    break;
                case AirPlaneType.Boeing787:
                    {
                        this.Name = "Boeing 787";
                        this.SpeedInKM = 954;
                        this.YearProduced = 2009;
                        this.NumberOfWings = 2;
                    }
                    break;
                case AirPlaneType.Boeing747:
                    {
                        this.Name = "Boeing 747";
                        this.SpeedInKM = 988;
                        this.YearProduced = 1970;
                        this.NumberOfWings = 2;
                    }
                    break;
                case AirPlaneType.Learjet23:
                    {
                        this.Name = "Lear Jet 23";
                        this.SpeedInKM = 903;
                        this.YearProduced = 1963;
                        this.NumberOfWings = 2;
                    }
                    break;
                
            }            
            
            
            

        }

        public override string ToString()
        {
            return base.ToString() + $"Number Of Wings: {NumberOfWings}\n";
        }
    }
}
