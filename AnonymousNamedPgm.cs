using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace AnonymousNamedProgram
    {
       
        public delegate void NumberDelegate(int n);
        public delegate void GreetingsDelegate(string str);
        public delegate void PetDelegate(string pet);

        class Program
        {

        static int num = 20;
       
        public static void Addnums(int a)
        {
            num += a;
            Console.WriteLine("Named Method Addition:{0}",num);
        }
        public static void Mulnums(int a)
        {
            num *= a;
            Console.WriteLine("Named Method Multiplication:{0}", num);
        }

        public static int Numbers()
        {
            return num;
        }

        static void Main(string[] args)
            {
            string fav = "Dog";
            //Instantiate the delegate

            NumberDelegate obj = delegate (int x)
            {
                Console.WriteLine("Anonymous Method:{0}", x);
            };

            obj(20);

            obj =new NumberDelegate(Addnums);
            obj(10);

            obj = new NumberDelegate(Mulnums);
            obj(7);


            PetDelegate p = delegate (string mypet)
              {
                  Console.WriteLine("My Favorite pet is {0}", mypet);
                  Console.WriteLine("And I Like {0} aslo", fav);
  
              };

            p("Cat");

            GreetingsDelegate obj1 = delegate (string name)
            {
                Console.WriteLine(" Hello Friends " + name + "");
            };
            obj1("Good Noon");

              


                Console.ReadLine();
            }
        }
    }


