using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ass
{
    enum WeekDays
    {
       
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //Console.WriteLine("Days of the Week:");
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}

            #endregion
            #region Q2:Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter) as its members.Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Season season;
            //bool f=false;
            //do
            //{
            //    Console.Write("Enter Season:");
            //    f = Enum.TryParse<Season>(Console.ReadLine(), true, out season);
            //} while (!f);
            //if (season == Season.Spring)
            //{
            //    Console.WriteLine("Spring:From March to May");
            //}
            //else if (season == Season.Summer)
            //{
            //    Console.WriteLine("Summer:From June to August");
            //}
            //else if (season == Season.Autumn)
            //{
            //    Console.WriteLine("Autumn:From September to November");
            //}
            //else
            //{
            //    Console.WriteLine("Winter:From December to February");
            //}



            #endregion
        }
    }
}
