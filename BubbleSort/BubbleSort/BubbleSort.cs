using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BubbleSort");
            int[] arr = { 6, 2, 8, 3, 1, 9 };
            foreach(int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n------------------");
            for(int i = 0; i < arr.Length - 1; i++) 
            {
                for(int j=0;j<arr.Length-i-1;j++)
                {
                    
                    if(arr[j]>arr[j+1])
                    {
                        int temp = arr[j + 1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.WriteLine("\nPass : " + i);
                for (int p = 0; p < arr.Length; p++)
                {
                    
                    Console.Write(arr[p] + " ");
                }
            }
            Console.WriteLine("\nsorted array");
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
        }
    }
}
