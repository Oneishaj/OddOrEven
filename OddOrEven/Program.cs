using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsOdd(5));
        }

        public static bool IsOdd(int num) 
        {
            

            if(num % 2 == 0) 
            {
                Console.WriteLine("This is Even");
                return false;
            }
            else 
            {
                Console.WriteLine("This is odd");
                return true;
            }
        }
         

        


        

             
         


    }
}
