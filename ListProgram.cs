using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListIntProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            //syntax of List
            var user = new List<int>();

            //Adding the Records in List
            user.Add(10);
            user.Add(20);
            user.Add(30);
            user.Add(40);

            //Index with value
            user[3]=50;

            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("List Created");
            foreach (var list in user)
            {
                Console.WriteLine("The Element Present in list:" + list);
            }

            user.Remove(10);
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("\nNew List");
            foreach (var list in user)
            {
                Console.WriteLine("The Element Present in list:" + list);
            }

            //Another way to create List
            var user1 = new List<int>() { 100,200,300,400,500,600 };

           

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("\nAnother way to create List");
            foreach (var list1 in user1)
            {
                Console.WriteLine("The Element Present in list:" + list1);
            }
            Console.WriteLine("----------------------------------------------------------");


            //Accessing the List Element by its Index
            Console.WriteLine("\nAccessing the List Element by its Index");

            Console.WriteLine("The First Index of the list is:" + user1[0]);
            Console.WriteLine("The Second Index of the list is:" + user1[1]);
            Console.WriteLine("The Third Index of the list is:" + user1[2]);
            Console.WriteLine("The Fourth Index of the list is:" + user1[3]);
            Console.WriteLine("The Fifth Index of the list is:" + user1[4]);
            Console.WriteLine("The Sixth Index of the list is:" + user1[5]);
            Console.WriteLine("---------------------------------------------------------------");

            ////Index with value
            //user1[6] = 700;




            //Insert(position/index,value) //keep 2 argument to be passed in the method

            user1.Insert(6,700);
            Console.WriteLine("\nNew Element In the List:"+user1[6]);
            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine("\nAll The Elements In List are");
            foreach (var list1 in user1)
            {
                Console.WriteLine("The Element Present in list:" + list1);
            }
            Console.WriteLine("---------------------------------------------------------------");


            //Contains() It disply the record is Present or not

            Console.WriteLine("\nIt Shows the Element Whether the Record is Found or Not:"+user1.Contains(10));

            //Remove()remove the Elements into List
            user1.Remove(700);

            //Display All Records in the List
            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine("\nAll The Elements In List After Removing The Record");
            foreach (var list1 in user1)
            {
                Console.WriteLine("The Element Present in list:" + list1);
            }
            Console.WriteLine("---------------------------------------------------------------");



            Console.ReadLine();

        }
    }
}
