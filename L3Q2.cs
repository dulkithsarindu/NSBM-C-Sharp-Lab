using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class Employee
    {
        private int employeeID;
        private string fullName;
        public double salary;

        public Employee(int employeeID, string fullName, double salary)
        {
            this.employeeID = employeeID;
            this.fullName = fullName;
            this.salary = salary;
        }
        public int EmployeeID => employeeID;

        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }
        public void displayemployeeinfo()
        {
            Console.WriteLine($"Employee ID: {employeeID}");
            Console.WriteLine($"Employee name: {fullName}");
            Console.WriteLine($"Employee Salary: {salary}");

        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(101, "john doe", 50000);

            employee.displayemployeeinfo();

            Console.WriteLine("Enter new name for employee");
            employee.FullName = Console.ReadLine();

            Console.WriteLine("Enter new salary for employee");
            employee.salary = int.Parse(Console.ReadLine());

        employee.displayemployeeinfo();
            Console.ReadLine();

        }
    }
}

