using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> carParking = new HashSet<string>();
            while (input != "END")
            {
                string[] inputArray = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string command = inputArray[0];
                string number = inputArray[1];
                if (command == "IN")
                {
                    carParking.Add(number);
                }
                if (command == "OUT")
                {
                    carParking.Remove(number);
                }

                input = Console.ReadLine();
            }
            if (carParking.Count == 0)
            {
                Console.WriteLine($"Parking Lot is Empty");
            }
            else
            {
                foreach (var item in carParking)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
