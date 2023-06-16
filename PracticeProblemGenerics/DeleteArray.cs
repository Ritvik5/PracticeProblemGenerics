using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemGenerics
{
    public class DeleteArray
    {
        public void DeleteElement(object[] array, object element)
        {

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    for(int j = i; j < array.Length -1 ; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    // Setting the last value null
                    array[array.Length - 1] = null;
                    break;
                }
            }

            foreach (object obj in array)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

        public void DeleteMethod<T>(ref T[] array1, T elements)
        {
            int count = 0;

            for(int i = 0; i < array1.Length; i++)
            {
                if (array1[i].Equals(elements))
                {
                    count++;
                }
                else if (count > 0)
                {
                    array1[i-count] = array1[i];
                }
            }
            Array.Resize(ref array1,array1.Length - count);

            foreach (T obj1 in array1)
            {
                Console.Write(obj1 + " ");
            }
            Console.WriteLine();
        }
    }
}
