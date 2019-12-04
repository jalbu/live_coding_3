using System;
using System.Collections.Generic;

namespace live_coding_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Example:
            array_one = [1, 5, 2]
            array_two = [3, 6, 4]
            zipped_array = [1, 3, 5, 6, 2, 4]
            */
            List<int> array_one = new List<int>();
            List<int> array_two = new List<int>();
            List<int> zip = new List<int>();

            array_one.Add(1);
            array_one.Add(5);
            array_one.Add(2);

            array_two.Add(3);
            array_two.Add(6);
            array_two.Add(4);

            for (int i = 0; i < array_one.Count; i++)
            {
                zip.Add(array_one[i]);
                zip.Add(array_two[i]);
            }

            Console.WriteLine(String.Join(" ",zip));
            Console.ReadLine();
        }
    }
}
