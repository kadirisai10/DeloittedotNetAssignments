using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //lambda with array
            int[] arr = { 0, -1, 4, 5, 7, 9, -2, 3, 2, 10 };
            foreach (var a in arr.Where(n => n > 5))
            {
                Console.WriteLine(a);
            }

            List<string> city = new List<string>();
            city.Add("Pune");
            city.Add("Pudicherry");
            city.Add("New Delhi");
            city.Add("vizag");
            city.Add("Hyderabad");

            foreach (var c in city.Where(i => i.StartsWith("P")))
            {
                Console.WriteLine(c);
            }

            foreach (var a in city.Where(i => i.Contains("e")))
            {
                Console.WriteLine(a);
            }

            var result = city.Where(x => x.Contains("e"));
            foreach (var c in result)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(result.Count());

            //3.5 collection initializer
            //adding to collection
            List<Employee> emp = new List<Employee>
            {
                new Employee
                {Empid=100,Name="martin",Dept="IT",Salary=35000 },//property initialization

                new Employee
                {Empid=200,Name="Blake",Dept="Mech",Salary=10000 },

                 new Employee
                {Empid=300,Name="ram",Dept="cse",Salary=100000 },

                  new Employee
                {Empid=400,Name="akshay",Dept="IT",Salary=50000 }



            };

            //display values

            foreach (var i in emp)
                Console.WriteLine(i.Empid + " " + i.Name + " " + i.Dept + " " + i.Salary);

            var data = emp.Where(i => i.Empid == 100).SingleOrDefault();

            if (data == null)
                Console.WriteLine("Invalid Empid");
            else
                Console.WriteLine(data.Empid + " " + data.Name + " " + data.Dept + " " + data.Salary);

            var data1 = emp.Where(i => i.Dept == "IT");

            if (data1.Count() == 0)

            {
                Console.WriteLine("Invalid Dept Name");
            }

            else
            {
                foreach (var i in data1)
                {
                    Console.WriteLine(i.Empid + " " + i.Name + " " + i.Dept + " " + i.Salary);
                }
            }

            //Select name column and sort in ascending order or descending order of name

            var data2 = emp.OrderBy(x => x.Name).Select(y => y.Name);
            foreach (var d in data2)
                Console.WriteLine(d);

            Console.WriteLine("************");

            var data3 = emp.OrderByDescending(x => x.Name).Select(y => y.Name);
            foreach (var d in data3)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("************");

            //Select -1 property or it will select all property
            //select name,salary-anonymoustypes fromc#3.5

            //new{EmpName=e.name,EmpSlary=e.Salary }

            var data4 = emp.Select(x => new { empname = x.Name, Empsal = x.Salary });
            foreach(var i in data4)
            {
                Console.WriteLine(i.empname + " " + i.Empsal);
            }
            Console.WriteLine("************");

            //summary - count of emp dept wise, sum of salry paid dept wise
            //key-coplumn on which the groupby is given
            var grp = emp.GroupBy(x => x.Dept).Select(x => new { Deptname = x.Key, EmpCount = x.Count(), SumSalary = x.Sum(y => y.Salary) });
            foreach (var g in grp)
            {
                Console.WriteLine(g.Deptname + " " + g.EmpCount+" "+g.SumSalary);
            }
            Console.WriteLine("************");


            Console.WriteLine("max Salary:" + emp.Max(x => x.Salary));
            Console.WriteLine("************");
            Console.WriteLine("max Salary:" + emp.Min(x => x.Salary));

            var maxsal = emp.Where(x => x.Salary == emp.Max(y => y.Salary));
            foreach (var i in maxsal)
            {
                Console.WriteLine(i.Empid + " " + i.Name + " " + i.Dept + " " + i.Salary);
            }
            Console.WriteLine("************");
        }
    }
    }
