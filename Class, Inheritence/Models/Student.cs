        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;  
        using System.Threading.Tasks;

namespace Class__Inheritence.Student
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public Boolean isGraduated=true;

        
        public Student(string name, string surname, string group, int point) 
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;

        }
        
        public Student(Boolean isqraduated)  
        {
            isGraduated = isqraduated; 
        }

        public void Getİnfo() 
        {
            Console.WriteLine($"{Group}-{Name} {Surname} {Point} ");
        }
        public void CheckGraduation() 
        {
            if (Point > 65)
            {
                Console.WriteLine("bu telebe mezun olmayib");
            }
            else
            {
                Console.WriteLine("bu telebe mezun olub");
            }
        }
        public void GetDiplomDegree()   
        {
            if(Point < 65)
            {
                Console.WriteLine("yoxdur");
            }
            else if (Point>65 && Point<80)
            {
                Console.WriteLine("adi");
            }
            else if (Point>80 && Point<90)
            {
                Console.WriteLine("şeref");
            }
            else
            {
                Console.WriteLine("yuksek şeref");
            }
        }
    }
}
