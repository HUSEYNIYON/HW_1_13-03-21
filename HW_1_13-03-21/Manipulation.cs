using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW_1_13_03_21
{
    class Manipulation
    {
        public int[] DoReverse(int[] array) => array.Reverse().ToArray();
        public string[] FormatByInc(string[] array) => array.OrderBy(t => t.Length).ToArray();
        public int[] SumAndCount(int[] arrays)
        {
            int count = arrays.Where(t => t > 0).Count();
            int sum = arrays.Where(t => t < 0).Sum();
            int[] arr = { count, sum };
            return arr;
        }
        public int[] GetUniqNumber(int[] array)
        {
            return (array.GroupBy(i => i).Where(i => i.Count() == 1).Select(i => i.Key)).ToArray();
        }
    }
}
