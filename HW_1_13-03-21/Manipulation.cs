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
            int[] arr = new int[0];
            if (arrays.Length !=0 )
            {
                if(arrays.Any(x => x > 0 || x < 0))
                {
                    Array.Resize(ref arr, 2);
                    arr[0] = arrays.Where(x => x > 0).Count();
                    arr[1] = arrays.Where(x => x < 0).Sum();
                }
            }
            return arr;
        }
        public int GetUniqNumber(int[] array)
        {
            var a = array.GroupBy(g => g).Where(g => g.Count() < 2).Select(g => g.Key).ToArray();
            return a[0];
        }
            
            
    }
}
