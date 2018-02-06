using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus13
{
    class ParkingLevel
    {
        int large = 10;
        int compact = 15;
        int motorcycle = 5;
        int total = 0;
        public ParkingLevel()
        {

        }

        public void listAvailable()
        {
            total = large + compact + motorcycle;
            if (total == 0)
            {
                Console.WriteLine("ALL SPACES ARE FULL. Goodbye.");
                
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("The following spaces are available: ");
            Console.WriteLine("Large: " + large + "\tCompact: " + compact + "\tMotorcycle: " + motorcycle);
            selectVehicle();
        }

        public void SetParking(string vehicle)
        {
           if (vehicle == "bus")
            {
                if (large >= 5)
                {
                    large = large - 5;
                    Console.WriteLine("Bus parked.");
                    listAvailable();
                }
                else
                {
                    Console.WriteLine("There are not enough spaces (5 large)for a bus, sorry.");
                    listAvailable();
                }
            }
           else if (vehicle == "car")
            {
                if (compact >=1)
                {
                    compact = compact - 1;
                }
                else if (compact <=0 && large >=1)
                {
                    large = large - 1;
                }
                else
                {
                    Console.WriteLine("There are no open compact or large spaces left, sorry.");
                    listAvailable();
                }
                Console.WriteLine("Car parked.");
                listAvailable();

            }
            else if (vehicle == "motorcycle")
            {
                if (motorcycle >=1)
                {
                    motorcycle = motorcycle - 1;
                }
                else if (motorcycle <=0 && compact >=1)
                {
                    compact = compact - 1;
                }
                else if (motorcycle <=0 && compact <=0 && large >=1)
                {
                    large = large - 1;
                }
                else
                {
                    Console.WriteLine("Sorry all spaces are full!");
                    listAvailable();
                }
                Console.WriteLine("Motorcycle parked.");
                listAvailable();
            }


        }

        public void selectVehicle()
        {
            Console.WriteLine("What kind of vehicle are you parking?");
            Console.Write("\n1: Motorcycle \n2: Car \n3: Bus \nEnter a corresponding number: " );
            string input = Console.ReadLine();
            int selection = 0;
            try
            {
               selection = int.Parse(input);
            }
            catch
            {
                Console.WriteLine("You must enter a corresponding number.");
                selectVehicle();
            }

            if (selection ==1)
            {
                SetParking("motorcycle");
            }
            else if (selection == 2)
            {
                SetParking("car");
            }
            else if (selection == 3 )
            {
                SetParking("bus");
            }
            else
            {
                Console.WriteLine("Invalid choice. Select 1, 2, or 3." );
                selectVehicle();
            }

        }


    }
}
