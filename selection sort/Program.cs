using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.Write("enter size of numpers = ");
            x = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[x];
            int z ;
            Console.WriteLine("numpers");
           
            for (int i = 0; i < x; i++)
            {
                z = Convert.ToInt32(Console.ReadLine());
                arr[i] = z;
            }
            Console.WriteLine("your numpers befor sort : ");
            for (int i = 0; i < x; i++)
            {
                Console.Write(arr[i]+",");
            }
            int temp, smallest;

                for (int i = 0 ; i < x -1 ; i++)
            {
                smallest =i;
                for (int j = i + 1; j < x; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                    temp = arr[smallest];
                    arr[smallest] = arr[i];
                    arr[i] = temp;
            }
            Console.WriteLine();
            Console.WriteLine("Sorted array by selection sort is: ");
            for (int i = 0; i < x; i++)
            {
                Console.Write(arr[i] + ", ");
            }

            Console.ReadKey();
        }
    }
}
