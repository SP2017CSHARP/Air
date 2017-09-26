using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirCraftsAssignment.Models;
using System.Media;

namespace AirCraftsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = Environment.CurrentDirectory + @"\Chill-house.wav";
            player.PlayLooping();

            AirMenu.StartProgram();
        }
    }
}
