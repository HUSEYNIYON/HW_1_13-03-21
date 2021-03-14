using System;
using System.Linq;

namespace HW_1_13_03_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            string[] devices = { "Telescopes", "Glasses", "Eyes", "Monocles" };
            int[] digits = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            int[] dig = { 1, 1, 1, 1, 2, 1, 1 };
            
            //Reverse
            Manipulation manipulation = new Manipulation();
            int[] newArray = manipulation.DoReverse(numbers);
            foreach (var item in newArray) Console.Write($"{item} ");

            //Formating by Increasing
            Console.WriteLine();
            string[] newArraySort = manipulation.FormatByInc(devices);
            foreach (var item in newArraySort) Console.Write($"{item} ");

            //Sum and Count numbers in array
            Console.Write("\n[ ");
            foreach (var item in manipulation.SumAndCount(digits)) Console.Write(item + " ");
            Console.WriteLine(" ]");

            //Get unique number in array range
            var num = manipulation.GetUniqNumber(dig);
            Console.WriteLine($"Unique: {num}");
        }
    }
}
