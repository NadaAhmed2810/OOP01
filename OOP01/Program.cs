
namespace OOP01
{

    enum Gender:int
    {
        Male,Female
    }
    enum Days
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    enum Grades
    {
        A,B,C,D,F

    }
    enum Role
    {
        Admin,viewe,Editor
    }
    enum Branches:byte
    {
        NaseCity,Maadi=251,Dokki,Alex,Enhass,smartVillage
    }
    [Flags]
    enum permissions:byte
    {
        Delete=1,Execute=2,Read=4,Write=8
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender;//Male ,Female
       public permissions permissions;                     

    }

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
            //DoSomeprotectiveCode();
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
            #region Enum
            #region  Ex01
            //String Day = "Saturday";//"Hamada"
            //Days day = Days.Saturday;
            //Grades grade = Grades.A;
            ////if(grade=='A')
            //if(grade == Grades.A)
            //{
            //    Console.WriteLine(":)");
            //}
            //else
            //{
            //    Console.WriteLine(":(");
            //}

            #endregion
            #region Ex02
            //Grades grade = (Grades)2;//explicit Casting[unsafe]
            //Console.WriteLine(grade);
            //Admin,viewer,Editor


            #endregion
            #region Ex03
            // Grades grade =(Grades) Enum.Parse(typeof(Grades),Console.ReadLine());//return object
            // Enum.TryParse(typeof(Grades),Console.ReadLine(), out object result);
            //// Grades grade = Grades(result);
            // Console.WriteLine(result);

            #endregion
            #region Ex04
            //string g = "male";
            //Enum.TryParse(typeof(Gender),g,out object result);
            //Console.WriteLine(result);
            //string g = "male";
            //Enum.TryParse<Gender>(g, true, out Gender result);
            //Console.WriteLine(result);
            #endregion
            #endregion
            #region permissions
            //Employee employee = new Employee();
            //employee.Name = "Nada";
            //employee.Gender = Gender.Female;
            //employee.Age = 20;
            //// employee.permissions = permissions.Delete;
            //employee.permissions = (permissions)3;
            //Console.WriteLine(employee.permissions);
            ////Add permission XOR
            //employee.permissions = employee.permissions ^ (permissions.Read);
            //Console.WriteLine(employee.permissions);
            //employee.permissions = employee.permissions ^ (permissions.Read);
            //Console.WriteLine(employee.permissions);
            //if((employee.permissions & (permissions.Read)) == 0)
            //{
            //    employee.permissions ^=permissions.Read;
            //}
            //Console.WriteLine(employee.permissions);
            ////best way 
            //employee.permissions |= permissions.Read;
            #endregion
            #region struct
            //point p=new point();
            //Console.WriteLine(p.x);//in valid if i delete default constructor
            //p.x = 10;
            //p.y = 5;
            //Console.WriteLine(p.y);
            //p=new point(10,5);
            ////Console.WriteLine(p.y);
            ////Console.WriteLine(p.x);
            //Console.WriteLine(p);//OOP01.point
            //Console.WriteLine(p.ToString());//OOP01.point
            //point p2 = new();
            #endregion
        }
    }

}
