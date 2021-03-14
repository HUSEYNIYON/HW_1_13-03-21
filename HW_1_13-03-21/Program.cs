using System;
using System.Linq;

namespace HW_1_13_03_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            Manipulation manipulation = new Manipulation();
            int[] newArray = manipulation.DoReverse(numbers);
            foreach (var item in newArray) Console.Write($"{item} ");

            Console.WriteLine();
            string[] devices = { "Telescopes", "Glasses", "Eyes", "Monocles" };
            string[] newArraySort = manipulation.FormatByInc(devices);
            foreach (var item in newArraySort) Console.Write($"{item} ");

            Console.Write("\n[ ");
            int[] digits = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            foreach (var item in manipulation.SumAndCount(digits)) Console.Write(item + " ");
            Console.WriteLine(" ]");

            int[] dig = { 1, 1, 1, 1, 2, 1, 1 };
            int[] nu = manipulation.GetUniqNumber(dig);
            foreach (var item in nu)Console.WriteLine(item);
        }
    }
}
