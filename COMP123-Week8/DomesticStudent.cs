using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_Week8
{
    public class DomesticStudent : Student
    {
        public DomesticStudent(string name, int age, string studentID)
            : base(name, age, studentID)
        {
            this.DomesticAddress="unknown";
        }
        public string DomesticAddress { get; set; }
       
    }
}