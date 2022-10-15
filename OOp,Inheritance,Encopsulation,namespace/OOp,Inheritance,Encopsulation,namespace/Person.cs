using System;
using System.Collections.Generic;
using System.Text;

namespace OOp_Inheritance_Encopsulation_namespace
{
    class Person 
    {

        internal string name;
        public string surname = "xxxx";
        public string adress;
        private int _age;

        public Person()
        {
            surname = "jafarova";
        }
        public void ShowSurname()
        {
            Console.WriteLine(surname);
        }
        public int Age
        {
            get
            {
                if (_age < 18)
                {
                    Console.WriteLine("can;t see");
                    return -1;
                }
                return _age;
            }
            set
            {

                _age = value;
            }

        }

    }
    }

