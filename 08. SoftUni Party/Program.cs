using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipPeople = new HashSet<string>();
            HashSet<string> regularPeople = new HashSet<string>();
            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    char first = input[0];
                    if(char.IsDigit(first))
                    {

                        vipPeople.Add(input);
                    }
                    else
                    {
                        regularPeople.Add(input);
                    }
                }
                input = Console.ReadLine();
            }

            while (input != "END")
            {
                string gestName = input;

                if (vipPeople.Contains(gestName))
                {
                    vipPeople.Remove(gestName);
                }
                if (regularPeople.Contains(gestName))
                {
                    regularPeople.Remove(gestName);
                }
                input = Console.ReadLine();
            }
            int guest = vipPeople.Count + regularPeople.Count;
            Console.WriteLine(guest);
            foreach (var vip in vipPeople)
            {
                Console.WriteLine(vip);
            }
            foreach (var regular in regularPeople)
            {
                Console.WriteLine(regular);
            }
        }
    }
}
