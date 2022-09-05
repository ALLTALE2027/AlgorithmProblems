using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    internal class Insertionsort
    {
        public static void Insertion( string[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var current = array[i];

                var j = i - 1;
                while (j >= 0 && array[j].ToLower().CompareTo(current.ToLower()) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = current;
            }
            
        }
    }
}
