using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraftsAssignment.Models
{
    class Aircraft
    {
        public string Name { get; set; }
        public int SpeedInKM { get; set; }
        public int YearProduced { get; set; }

        
        public DateTime DateAdded { get; set; }



      

        public virtual string EngineSound()
        {
            return "";
        }

        public override string ToString()
        {
            return $"Name: {Name}\n Speed: {SpeedInKM}\n Year: {YearProduced}\n".ToString();
        }
    }
}
