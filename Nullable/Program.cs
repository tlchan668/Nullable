using System;

namespace Nullable {
    class Program {
        static void Main(string[] args) {

         
            var math = new Major { Id = 1, Desc = "Math", MinSat = 900 };
            var Fred = new Student { Id = 1, Name = "Fred", SAT=null, GPA = 3.5 , MajorId = math.Id, Major=math};
            var Bill = new Student { Id = 2, Name = "Bill", SAT = 800, GPA = 2.5, MajorId= null, Major=null };
            var Sue=  new Student { Id = 3, Name = "Sue", SAT = 1500, GPA = 4.0 };

            Console.WriteLine(Fred); Console.WriteLine(Bill); Console.WriteLine(Sue);
        }
    }
}
