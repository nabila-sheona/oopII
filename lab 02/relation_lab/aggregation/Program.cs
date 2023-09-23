using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Employee
    {
string name; string id;
        void work()
        {
             Console.WriteLine(" Doing my job ");
             }
 }

 class Department
    {
 private List<Employee> employees;

 public Department()
        {
             
            Employee employees = new Employee();
        }

 public void addEmployee(Employee employee)
        {
             employees.Add(employee);
             }
 }
}
