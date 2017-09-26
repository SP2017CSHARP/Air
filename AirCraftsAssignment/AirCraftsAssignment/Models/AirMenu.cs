using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraftsAssignment.Models
{
    public static class AirMenu
    {
        public static void StartProgram()
        {
            AirHanger airHanger = new AirHanger();

            int userAction = 0;
            do
            {
                Console.Clear();
                WriteMenuBoxSetPos();



                Console.WriteLine("1. Buy Airplanes");
                Console.WriteLine("2  Sell Airplanes");
                Console.WriteLine("3. Buy Helicoptors");
                Console.WriteLine("4  Sell Helicoptors");
                Console.WriteLine("5. Show aircrafts");
                Console.WriteLine("6. Quit");
                userAction = int.Parse(Console.ReadLine());

                switch (userAction)
                {
                    //buy airplanes
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter the type of airplane you would like to buy (1-4):" + "\n" +
                            "\n1. Wright Flyer" +
                            "\n2. Learjet 23" +
                            "\n3. Boeing 787" +
                            "\n4. Boeing 747");

                        int chosenPlaneType;
                        do
                        {
                            chosenPlaneType = int.Parse(Console.ReadLine());
                            if (chosenPlaneType < 0 || chosenPlaneType > 4)
                            {
                                Console.WriteLine("Invalid Choice, choose a plane type 1-4");
                            }
                           


                        } while (chosenPlaneType < 0 || chosenPlaneType > 4);

                        AirPlaneType airPlaneType;
                        airPlaneType = (AirPlaneType)chosenPlaneType;

                        Console.Clear();
                        Console.WriteLine("Enter Amount");
                        int amount = int.Parse(Console.ReadLine());

                        airHanger.AddAirplaneToList(amount, airPlaneType);


                        break;
                    //sell airplanes
                    case 2:
                        Console.Clear();
                        airHanger.ShowAirplanes();
                        Console.WriteLine("Write the name of the airplane you would like to sell");
                        string nameOfAirplaneToSell = Console.ReadLine();

                        Console.Clear();
                        airHanger.RemoveAirCraftFromList(nameOfAirplaneToSell);

                        Console.WriteLine("Press Enter To Continue");
                        Console.ReadLine();
                        break;

                        //buy helicopters
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Enter the type of airplane you would like to buy (1-4):" + "\n" +
                            "\n1. Black Hawk" +
                            "\n2. Apache" +
                            "\n3. SikorskyR4" +
                            "\n4. Bell 47");

                            int chosenHType;

                            do
                            {
                                chosenHType = int.Parse(Console.ReadLine());
                                if (chosenHType < 0 || chosenHType > 4)
                                {
                                    Console.WriteLine("Invalid Choice, choose a Helicopter type 1-4");
                                }



                            } while (chosenHType < 0 || chosenHType > 4);

                            HelicopterType hType;
                            hType = (HelicopterType)chosenHType;

                            Console.Clear();

                            Console.WriteLine("Enter Amount");
                            int hAmount = int.Parse(Console.ReadLine());

                            airHanger.AddHelicopterToList(hAmount, hType);


                        }

                        break;
                    case 4:
                        {
                            Console.Clear();
                            airHanger.ShowHelicopters();
                            Console.WriteLine("Write the name of the Helicopter you would like to sell");
                            string nameOfHelicopterToSell = Console.ReadLine();
                            Console.Clear();
                            
                            airHanger.RemoveAirCraftFromList(nameOfHelicopterToSell);

                            Console.WriteLine("Press Enter To Continue");
                            Console.ReadLine();
                        }
                        break;


                    case 5:
                        {
                            Console.Clear();

                            airHanger.ShowAllAirCrafts();

                            Console.WriteLine("Press Enter to Continue...");
                            Console.ReadLine();
                        }
                        break;
                }

            } while (userAction != 6);
        }

        private static void WriteMenuBoxSetPos()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(0, 0);

            
           

            WriteLineKeepPos(@"         __ | __");
            WriteLineKeepPos(@"   ________(*)________");

            WriteLineKeepPos("---------------------------------");
            WriteLineKeepPos("|                               |");
            WriteLineKeepPos("|                               |");
            WriteLineKeepPos("|                               |");
            WriteLineKeepPos("|                               |");
            WriteLineKeepPos("|                               |");
            WriteLineKeepPos("|                               |");
            WriteLineKeepPos("|                               |");
            WriteLineKeepPos("---------------------------------");
            Console.SetCursorPosition(0, 3);
            Console.ForegroundColor = ConsoleColor.White;


        }

        private static void WriteLineKeepPos(string text)
        {
            int top = Console.CursorTop;
            int left = Console.CursorLeft;

            Console.WriteLine(text);
            Console.SetCursorPosition(left, top + 1);

        }
    }
}
