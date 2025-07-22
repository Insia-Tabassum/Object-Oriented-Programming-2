using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentData_22._7._2025_
{
    internal class Program
    {
        public class Student
        {
            public int id;
            public String name;
            public float cgpa;
            public double creditCount;
            public Student()
            {
                id = 51234;
                name = "Tanha";
                cgpa = 3.51f;
                creditCount = 84;

                

            }
            public Student(int id, string name, float cgpa, double creditCount)
            {
                this.id = id;
                this.name = name;
                this.cgpa = cgpa;
                this.creditCount = creditCount;
            }

            public void ShowInfo()
            {
                Console.WriteLine("Student Name: " + name);
                Console.WriteLine("Student ID: " + id);
                Console.WriteLine("CGPA: " + cgpa);
                Console.WriteLine("Credit Count: " + creditCount);

                
                if (cgpa < 2.5)
                {
                    Console.WriteLine("Status: On Probation");
                }
                else if (cgpa >= 2.5 && cgpa < 3.75)
                {
                    Console.WriteLine("Status: Improving");
                }
                else if (cgpa >= 3.75)
                {
                    Console.WriteLine("Status: Scholarship Holder");
                }

                Console.WriteLine();
            }

           

        }
        static void Main(string[] args)

        {
            Student s = new Student();
            s.ShowInfo();

            Student s1 = new Student(500891, "ANGLE", 3.9f, 120);
            s1.ShowInfo();

            Student s2 = new Student(57002, "Bman", 2.45f, 90); // Example values
            s2.ShowInfo();

            Console.ReadLine();


        }
    }
}
