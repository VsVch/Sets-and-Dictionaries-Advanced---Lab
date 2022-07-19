using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> name = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                name.Add(input);

            }
            foreach (var item in name)
            {
                Console.WriteLine(item); 
                
            }
            
        }
    }
}
