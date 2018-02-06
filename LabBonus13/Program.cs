using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingLevel parkingLevel1 = new ParkingLevel();
            ParkingLevel parkingLevel2 = new ParkingLevel();
            ParkingLevel parkingLevel3 = new ParkingLevel();
            ParkingLot.parkingLot.Add(parkingLevel1);
            ParkingLot.parkingLot.Add(parkingLevel2);
            ParkingLot.parkingLot.Add(parkingLevel3);

            parkingLevel1.listAvailable();


            Console.ReadLine();

        }
    }
}
