using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesign
{
    class Program
    {

        public class MySingleton
        {
            private static MySingleton instance = new MySingleton();
            private MySingleton() { }

            public static MySingleton ABC
            {
                get { return instance; }
            }
            public static MySingleton World
            {
                get { return instance; }
            }


            public void DoSomething()
            {
                Console.WriteLine("Singleton class is working");
            }

            public void text()
            {
                Console.WriteLine("Singleton1 class is working");
            }
        }
        static void Main(string[] args)
        {
            MySingleton obj =  MySingleton.ABC;
            MySingleton obj1 = MySingleton.World;
            obj.DoSomething();
            obj1.text();
            Console.ReadLine();
        }
    }
}
