using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable {
    public class Student {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SAT { get; set; }
        public double GPA { get; set; }
        public Major Major { get; set; }

        public int? MajorId { get; set; }//one way or use the whole class instance Major
      

        public Student() {
           

        }
        public override string ToString() {
            //shows me the customer varialbe
            //helpful enhcancement for debugging
            //can call it from program with Console.WriteLine(cust1);
            return $"Id ={this.Id}, name={this.Name}, SAT={this.SAT},GPA={this.GPA}, Major={this.Major.Desc}";
        }

    }
}
