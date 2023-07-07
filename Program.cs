using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Person
    {
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }


        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }

    public class Teacher
    {
        public void Exlpain() 
        {
            Console.WriteLine("Explaining");
        
        }

    }
    public class Student
    {
        public void Learn() 
        {
            Console.WriteLine("Learning...");
        } 


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Student student = new Student();
            student.Learn();    
            teacher.Exlpain();
        }
    }


}
