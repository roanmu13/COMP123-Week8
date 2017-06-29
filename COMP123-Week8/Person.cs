using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Week8
{
    /// <summary>
    /// This is summary of person class
    /// 
    /// </summary>
    class Person
    {
        //Private instance variables--------------------------------
        private string _name;
        private int _age;

        //Public Properties------------------
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }

        /// <summary>
        /// This is the constructor for person class. The constructor requires two arguments- name(string) and age(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        //PUBLIC METHODS--------------------------------
        /// <summary>
        /// 
        /// This method enables person to talk
        /// </summary>
        public void Talks()
        {
            Console.WriteLine(this.Name + " is talking");  
        }
        }
    }
