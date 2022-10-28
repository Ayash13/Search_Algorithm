using System;
namespace SearchAlgoritm
{
    class Program
    {
        //arrat to be searched
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
        }

    }
}