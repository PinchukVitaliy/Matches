using System;

namespace Matches
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;      // matches    
            int l;

            int a = 1; // side
            Console.WriteLine("Enter the number of squares: ");
            int n = int.Parse(Console.ReadLine());   
            if(1 > n || n > 1000000000)
            {
                Console.WriteLine("The number of squares must be greater than 0 but less than 1,000,000,000");
                return;
            }
            while ((a + 1) * (a + 1) < n)
            {
                a = a + 1;             
            }
            k = 2 * (a * a + a);
            l = n - a * a;
            if (l > 0)
            {
                k = k + 2 * l + 1;
            }
            if (l > a)
            {
                k = k + 1;
            }
            Console.WriteLine("Minimum number of matches required: {0}", k);
            Console.ReadKey();
        }        
    }
}
