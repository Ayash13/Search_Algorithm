using System;
namespace SearchAlgoritm
{
    class Program
    {
        //array to be searched
        int[] arr = new int[20];
        //number of element in the array 
        int n;
        //get number of elements to store in the array
        int i;
        public void input()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("Array should have minimum 1 and maxomum 20 elements");
            }
            //accept array element
            Console.WriteLine("");
            Console.WriteLine("=====================");
            Console.WriteLine(" Enter array element ");
            Console.WriteLine("=====================");
            for (i = 0; i < n; i++) ;
            {
                Console.Write("");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);

            }
        }
        public void BinarySearch()
        {
            
        }

    }
}