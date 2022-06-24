using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrayCreator
{
    public static class ArrayCreator
    {
       public static T[] Create<T>(int length, T item)
        {
            var array = new T[length];
            for(int i = 0; i < length; i++)
            {
                array[i] = item;
            }
            return array;
        }
    }
}
