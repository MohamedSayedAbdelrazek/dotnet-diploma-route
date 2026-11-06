using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_ADVC__Assignment_1
{
    internal static class Utility
    {
        //public static void Swap<T>(ref T first,ref T second){
        //    T temp = first;
        //    first= second;
        //    second = temp;
        //}        //public static void Swap<T>(ref T first,ref T second){
        //    T temp = first;
        //    first= second;
        //    second = temp;
        //}

        public static T FindMax<T>(T[] items) where T : IComparable {
            if (items == null || items.Length == 0)
                throw new ArgumentException("Array cannot be null or empty.");

            T max = items[0];

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].CompareTo(max) > 0)
                    max = items[i];
            }
            return max;
        }


        public static T SafeList<T>() { 
        
        
        }



    }
}
