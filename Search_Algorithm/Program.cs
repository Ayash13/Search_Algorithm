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
            char ch;
            do
            {
                //accept the number to be searched
                Console.Write("Enetr element that you want to search : ");
                int item = Int32.Parse(Console.ReadLine());

                //apply binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //obtain the indes of the elements in the array 
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //loop to search for the elements in the array
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;

                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("" + item.ToString() + " Found at position " + (mid + 1).ToString());
                else
                    Console.WriteLine("" + item.ToString() + " Not found in the array ");
                Console.WriteLine(" Number of comparison : " + ctr);

                Console.Write(" Continue Search (y/n): ");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'y'));
        }
        public void LinearResearch()
        {
            char ch;
            //search for number of comaprison
            int ctr;

            do
            {
                //accept the number to the searched
                Console.Write("Enter element you want to search: ");
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("" + item.ToString() + "Found at position" + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("" + item.ToString() + "Not found in the array");
                Console.WriteLine("Number of comparison: " + ctr);
                Console.Write("Continue to search (y/n): ");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'y'));
        }
        static void Main(string[] args)
        {
            
        }
    }
}