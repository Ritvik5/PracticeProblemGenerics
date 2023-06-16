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
    }
}
