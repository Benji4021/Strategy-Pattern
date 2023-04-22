using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy_Pattern;

namespace Strategy_Pattern
{
    public class Numbers
    {
        Bubblesort MyBubblesort = new Bubblesort();

        public static void Fill(int[] arr)
        {
            Random rnd = new Random();

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
        }

        public static void PrintArr(int[]arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void Algorithm(int[] arr)
        {
            string path = Console.ReadLine();
            bool A = true;

            while (A)
                switch (path)
                {
                    case "A":
                        MyBubblesort.Sort(arr);
                        A = false;

                        break;

                    case "B":
                        A = false;
                        break;

                    case "C":
                        A = false;
                        break;

                    default:
                        Console.WriteLine("That is not an Option.");
                        break;
                }
        }
    }
}
