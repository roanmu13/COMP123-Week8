using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Week8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Person person1 = new Person("Tom", 25);
            person1.Talks();

            Student student1 = new Student("John", 20, "55874");
            student1.Studies();
            student1.Talks();
        }
    }
}
