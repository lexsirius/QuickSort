using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class Sort
    {
        public static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                var p = Partition(array, left, right);
                QuickSort(array, left, p - 1);
                QuickSort(array, p, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            var pivot = array[left];
            var i = left;
            var j = right;
            var len = array.Length;
            while (i <= j)
            {
                while (array[i] < pivot && i < len - 1)
                    i++;
                while (array[j] > pivot && j > 0)
                    j--;
                if (i <= j)
                {
                    var container = array[i];
                    array[i] = array[j];
                    array[j] = container;
                    i++;
                    j--;
                }
            }
            return i;
        }
    }
}
