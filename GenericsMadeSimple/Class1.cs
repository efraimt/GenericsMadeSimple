using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMadeSimple1
{
    class Class1<T> where T : Person //, new()
    {
    }


    class Person { }
    class Student : Person { }
    class Lecturer : Person {
        public Lecturer(int id)
        {

        }
    }


    class PlayGround
    {
        void SandBox()
        {

            //Class1<int> classInt= new Class1<int>();
            //Class1<string> classString= new Class1<string>();

            Class1<Person> myClass1 = new Class1<Person>();
            Class1<Student> students = new Class1<Student>() { };
            Class1<Lecturer> lecturers=new Class1<Lecturer>() { };  
        }
    }
}
