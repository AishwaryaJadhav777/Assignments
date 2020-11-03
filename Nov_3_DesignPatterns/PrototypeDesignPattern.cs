using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeMethod
{

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Age = 21;
            p1.Birthdate = Convert.ToDateTime("1999-03-21");
            p1.Name = "Aishwarya";
            p1.IdInfo = new IdInfo(666);

            Person p2 = p1.ShallowCopy();
            Person p3 = p1.DeepCopy();

            Console.WriteLine("Original Value of p1,p2,p3:");
            Console.WriteLine("P1 instance values:");
            DisplayValues(p1);
            Console.WriteLine("P2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("P3 instance values:");
            DisplayValues(p3);
            Console.ReadLine();
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine("Name:{0:s},Age:{1:d},Birthdate:{2:MM/dd//yy}", p.Name, p.Age, p.Birthdate);
            Console.WriteLine("ID#:{0:d}", p.IdInfo.IdNumber);
        }
    }

    public class Person
    {
        public string Name;
        public DateTime Birthdate;
        public int Age;
        public IdInfo IdInfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = string.Copy(Name);
            return clone;
        }
       
    }

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }
}
