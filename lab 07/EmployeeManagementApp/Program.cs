using EmployeeManagementApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.GenerateReport();

            EmployeeController employeeController = new EmployeeController();

            employeeController.findEmployee("Sheona");

            employeeController.deleteEmployee("Jane Smith");
     
            employeeController.updateEmployee("Bob", 32000, "Floor Manager");

            Employee employee1 = new Employee();
            employee1.GenerateReport();

            Console.WriteLine("PRESS ANY KEY TO EXIT...");
            Console.ReadKey();

        }
    }
}



