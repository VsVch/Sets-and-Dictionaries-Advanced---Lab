using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> numbersCount = new Dictionary<double, int>();
            double[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!numbersCount.ContainsKey(numbers[i]))
                {
                    numbersCount.Add(numbers[i], 0);
                }
                numbersCount[numbers[i]]++;
            }
            foreach (var item in numbersCount)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
