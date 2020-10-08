using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousProgram
{
    public delegate string GreetingsDelegate(string str);//Define the delegate
    public delegate string GreetingDelegate1(string str);
    public delegate int AddDelegate(int a, int b);
    public delegate int MulDelegate(int x, int y);

    class Program
    {
       static void Main(string[] args)
        {
            //Instantiate the delegate
            GreetingsDelegate obj = delegate (string name)
            {
                return " Hello " + name + " Very Good Morning ";

            };

            GreetingsDelegate obj1 = delegate (string name)
              {
                  return " This is " + name +  " Method ";
              };

            AddDelegate obj2 = delegate (int a, int b)
              {
                  return a + b;
              };

            MulDelegate obj3 = delegate (int x, int y)
              {
                  return  x - y;
              };

           //Method is value returning Method
            string str = obj.Invoke("Guys");
            Console.WriteLine(str);

            string str1 = obj1.Invoke("Anonymouus");
            Console.WriteLine(str1);

            int result = obj2.Invoke(10,20);
            Console.WriteLine(result);

            int result1 = obj3.Invoke(40, 20);
            Console.WriteLine(result1);



            Console.ReadLine();
        }
    }
}
