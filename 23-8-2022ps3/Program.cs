using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_8_2022ps8
{
    internal class ps8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input first number");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second number");
            int j = Convert.ToInt32(Console.ReadLine());
            Divide(i, j);

            Console.ReadLine();
        }
        static void Divide(int p, int q)
        {
            try
            {
                int r;
                r = p / q;
                Console.WriteLine(r);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.StackTrace);

            }
            finally
            {
                Console.WriteLine("anyway message got");
            }

        }
    }
}

//{ 
//    public struct Employee
//    {
//        public int No;

//        public string Name;

//        public int Sal;

//        public int Deptno;

//        public void SetEmployee(int no, string name, int sal, int deptno)

//        {

//            No = no;

//            Name = name;

//            Sal = sal;

//            Deptno = deptno;

//        }




//        public void DisplayEmployee()

//        {

//            Console.WriteLine("Employee:");

//            Console.WriteLine("\tNo    : " + No);

//            Console.WriteLine("\tName   : " + Name);

//            Console.WriteLine("\tSal   : " + Sal);

//            Console.WriteLine("\tDeptno   : " + Deptno);

//            Console.WriteLine("\n");

//        }
//    }


//    class Program
//    {



//        static void Main(string[] args)
//        {





//            Employee[] emp = { new Employee(),

//                       new Employee(),

//                       new Employee(),

//                       new Employee(),
//        };





//            emp[0].SetEmployee(1, "Apsar", 1999, 28);

//            emp[1].SetEmployee(2, "Moulali", 2000, 29);

//            emp[2].SetEmployee(3, "Nagendra", 2100, 30);

//            emp[3].SetEmployee(4, "Mahesh", 2200, 31);



//            emp[0].DisplayEmployee();

//            emp[1].DisplayEmployee();

//            emp[2].DisplayEmployee();

//            emp[3].DisplayEmployee();
//            Console.ReadKey();
//        }
//    }
//}
//{
//struct Employee
//{
//    public int id;
//    public string name;
//    public int salary;
//    public int deptno;

//    public void getId(int id)
//    {
//        Console.WriteLine("Employee Id: " + id);
//    }
//    public void getname(string name)
//    {
//        Console.WriteLine("Employee name: " + name);
//    }
//    public void getsalary(int salary)
//    {
//        Console.WriteLine("Employee salary: " + salary);
//    }
//    public void getdeptno(int deptno)
//    {
//        Console.WriteLine(" Employee deptno: " + deptno);
//    }

//}

//class Program
//{
//    static void Main(string[] args)
//    {


//        Employee emp;


//        emp.id = 1;
//        string name = null;
//        emp.name = name;
//        emp.salary = 1000;
//        emp.deptno = 21;


//        emp.getId(emp.id);
//        emp.getname(emp.name);
//        emp.getsalary(emp.salary);
//        emp.getdeptno(emp.deptno);


//        Console.ReadLine();
//        }
//    }
//}
//{ 
//   struct employee
//{
//    public int empno;
//    public string empname;
//    public int salary;
//    public int deptno;
//};

//public class program
//{
//    public static void Main(string[] args)
//    {
//        employee emp1;
//        employee emp2;

//        emp1.empno = 01;
//        emp1.empname = "moulali";
//        emp1.salary = 25000;
//        emp1.deptno = 29;

//        emp2.empno = 02;
//        emp2.empname = "apsar";
//        emp2.salary = 28000;
//        emp2.deptno = 30;
//        Console.WriteLine(emp1.empno);
//        Console.WriteLine(emp1.empname);
//        Console.WriteLine(emp1.salary);
//        Console.WriteLine(emp1.deptno);
//        Console.WriteLine("_____");
//        Console.WriteLine(emp2.empno);
//        Console.WriteLine(emp2.empname);
//        Console.WriteLine(emp2.salary);
//        Console.WriteLine(emp2.deptno);



//        Console.ReadKey();



