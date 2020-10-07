using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPROGRAM1
{


    public class Employee

    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeSal { get; set; }
        public string EmployeeDesignation { get; set; }
        public object Employee1ID { get; set; }
    }

    public class Employee1
    {
        public int Employee1ID { get; set; }
        public string Employee1Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Implement the LINQ on Collection
            IList<Employee> EmployeeList = new List<Employee>()
            {
                //4 students //4Id //4Name //4Age //4Batch
                new Employee(){EmployeeID=101,EmployeeName="Aishu",EmployeeSal=27000,EmployeeDesignation="HR",Employee1ID=101},
                new Employee(){EmployeeID=102,EmployeeName="Anita",EmployeeSal=30000,EmployeeDesignation="Manager",Employee1ID=101},
                new Employee(){EmployeeID=103,EmployeeName="Shivani",EmployeeSal=20000,EmployeeDesignation="Director",Employee1ID=102},
                new Employee(){EmployeeID=104,EmployeeName="Varsha",EmployeeSal=40000,EmployeeDesignation="HR",Employee1ID=103},
                new Employee(){EmployeeID=105,EmployeeName="Manasi",EmployeeSal=45000,EmployeeDesignation="Chief"},

            };

            IList<Employee1> EmployeeList1 = new List<Employee1>()
            {
                new Employee1(){Employee1ID=101,Employee1Name="Asmita"},
                new Employee1(){Employee1ID=102,Employee1Name="Dev"},
                new Employee1(){Employee1ID=103,Employee1Name="Raj"},
                new Employee1(){Employee1ID=104,Employee1Name="Kiran"},
                new Employee1(){Employee1ID=105,Employee1Name="Shubham"},

            };


            //Applying LINQ Logic
            var EmployeeName = EmployeeList.Where(e => e.EmployeeSal > 30000).Select(e => e).Where(et => et.EmployeeID > 102).Select(e => e.EmployeeName);
            var EmployeeName1 = EmployeeList.Where(e => e.EmployeeID<103).Select(e => e.EmployeeName);


            var EmployeeName2 = from e in EmployeeList
                                   where e.EmployeeID > 104 && e.EmployeeID < 101
                                   select new { EmployeeName = e.EmployeeName };
            EmployeeName2.ToList().ForEach(e => Console.WriteLine(e.EmployeeName));

            ////GroupBy Execution
            var EmployeeGroupByBatch = from e in EmployeeList
                                       group e by e.EmployeeID into sb
                                       orderby sb.Key
                                       select new { sb.Key, sb };


            ////Groupby Query
            var EmployeesGroupByBatch1 = from e in EmployeeList 
                                        where e.EmployeeSal > 20000//Query stmt
                                        where e.EmployeeID > 104 //one Query stmt
                                       // where s.studentID > 1//another query stmt
                                        group e by e.EmployeeName into sb
                                        orderby sb.Key
                                        select new { sb.Key, sb };


            //Left Outer Join
            var EmployeeGroup = from et in EmployeeList1
                                join e in EmployeeList
                                on et.Employee1ID equals e.EmployeeID
                                into eg
                                select new
                                {
                                    Employee1Name = et.Employee1Name,
                                    Employee = eg
                                };
            //Sorting

            var sortedEmployee = from e in EmployeeList
                                 orderby e.Employee1ID, e.EmployeeSal
                                 select new
                                 {
                                     EmployeeName = e.EmployeeName,

                                     //Salary = e.EmployeeSal,
                                     Employee1ID = e.Employee1ID
                                 };

            sortedEmployee.ToList().ForEach(e => Console.WriteLine("Employee name:{0},EmployeeID:{1}", e.EmployeeName, e.Employee1ID));


            //Inner Join
            var EmployeeInner = from e in EmployeeList
                                join et in EmployeeList1
                                on e.Employee1ID equals et.Employee1ID
                                select new
                                {
                                    EmployeeName = e.EmployeeName,
                                    EmployeeName1 = et.Employee1Name
                                };
            EmployeeInner.ToList().ForEach(e => Console.WriteLine("{0} is in {1}", e.EmployeeName, e.EmployeeName1));


            foreach (var group in EmployeeGroup)
            {
                Console.WriteLine(group.Employee1Name);
                group.Employee.ToList().ForEach(et => Console.WriteLine(et.EmployeeName));
            }


            foreach (var name in EmployeeName)
            {
                Console.WriteLine(name);
            }

            foreach(var name1 in EmployeeName1)
            {
                Console.WriteLine(name1);
            }

            foreach (var group in EmployeeGroupByBatch)
            {
                Console.WriteLine("EmployeeID{0}:" + group.Key);
            }

            foreach (var group in EmployeesGroupByBatch1)
            {
                Console.WriteLine("EmployeeName{0}:" + group.Key);
            }



            foreach (var name2 in EmployeeName2)
            {
                Console.WriteLine(name2);
            }
            

            Console.ReadLine();

        }
    }
}
