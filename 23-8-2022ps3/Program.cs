using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_8_2022ps3
{
    struct employee
    {
        public int empno;
        public string empname;
        public int salary;
        public int deptno;
    };

    public class program
    {
        public static void Main(string[] args)
        {
            employee emp1;
            employee emp2;

            emp1.empno = 01;
            emp1.empname = "moulali";
            emp1.salary = 25000;
            emp1.deptno = 29;

            emp2.empno = 02;
            emp2.empname = "apsar";
            emp2.salary = 28000;
            emp2.deptno = 30;
            Console.WriteLine(emp1.empno);
            Console.WriteLine(emp1.empname);
            Console.WriteLine(emp1.salary);
            Console.WriteLine(emp1.deptno);
            Console.WriteLine("_____");
            Console.WriteLine(emp2.empno);
            Console.WriteLine(emp2.empname);
            Console.WriteLine(emp2.salary);
            Console.WriteLine(emp2.deptno);



            Console.ReadKey();


        }
    }
}
