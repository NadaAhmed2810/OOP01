using System;
using Common;
namespace OOP01
{
    internal class Program
    {
        public static void DoSomeCode()
        {
            try {
                int X = int.Parse(Console.ReadLine()); //FormatException
                int Y = int.Parse(Console.ReadLine());
                int Z = X / Y;                         //.DivideByZeroException
                int[] numbers = { 1, 2, 3 };
                numbers[10] = 100;          //.IndexOutOfRangeException
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
           
        }
        public static void DoSomeprotectiveCode()
        {
            try
            {
                int X;
                bool f = false;
                do
                {
                    Console.WriteLine("Enter first Number:");
                    f = int.TryParse(Console.ReadLine(), out X);
                } while (!f);

                int Y;
                do
                {
                    Console.WriteLine("Enter Second Number:");
                    f = int.TryParse(Console.ReadLine(), out Y);
                } while (!f || Y == 0);
                int Z = X / Y;

                int[] numbers = { 1, 2, 3 };
                if (numbers.Length >= 10)
                    numbers[10] = 100;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //close ,free,delete,dealocate unmanaged resourse 
                //open connection Data Base 
                //open file
            }
        
        }
        static void Main(string[] args)
        {
            #region Exception Handling 
            DoSomeprotectiveCode();
            //Exceptions
            // 1. System Exceptions
            //// 1.1 Format Exception
            //// 1.2 Index Out Of Range Exception
            //// 1.3 Null Reference Exception
            //// 1.4 Invalid Operation Exception
            //// 1.5 Arithmetic Exception
            ////  1.5.1 Divided By Zero Exception
            ////  1.5.2 Overflow Exception
            // 2. Application Exception

            #endregion
            #region Access modifier 
            //TypeA typeA=new TypeA();
            // typeA.X = 5; not acess
            //typeA.Y = 5; not access
            //typeA.Z = 10; //can access 
            #endregion
        }
    }
}
