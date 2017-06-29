using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Week8
{
    public class Student :Person
    {
        //private instance variable

            private string _studentID;

            //public properties
            public string StudentID
        {
            get
            {
                return this._studentID;
            }
            set
            {
                this._studentID=value;
            }
        }

        /// <summary>
        /// constructor for student class, takes 3 arguments. Takes name, age, studentID
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        /// //CONSTRUCTOR------------------------------------------------
        public Student(string name, int age, string studentID) : base(name, age)
        {
            this.StudentID = studentID;
        }

        //PUBLIC METHODS--------------------------------------------------

            /// <summary>
            /// this is the studies method
            /// </summary>

        public void Studies()
        {
            Console.WriteLine(this.Name + " is studying");
        }
    }
}
