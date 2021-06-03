using System;

namespace InsertionSort
{
    class Insertion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertion Sort");
            int[] arr = { 5, 1, 8, 2, 9, 3, 6, 0 };
            foreach(int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n--------------------");
            for(int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
                Console.WriteLine("\nPass : " + i);
                foreach(int x in arr)
                {
                    Console.Write(x + " ");
                }
            }
            Console.WriteLine("\nSorted Array");
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
        }
    }
}
