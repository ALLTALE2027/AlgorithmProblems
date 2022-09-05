using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    internal class Bubblesort
    {

        public static void IntegerArraySorting(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            for (var j = 1; j < array.Length-i; j++)
                if (array[j] < array[j - 1])
                {
                    (array[j], array[j - 1]) = (array[j - 1], array[j]);
                }
        }

        public static void StringArraySorting(string[] array)
        {
            for (var i = 0; i < array.Length; i++)
            for (var j = 1; j < array.Length-i; j++)
                if (array[j].ToLower().CompareTo(array[j - 1].ToLower()) < 0)
                    (array[j], array[j - 1]) = (array[j - 1], array[j]);
        }
    }
}
