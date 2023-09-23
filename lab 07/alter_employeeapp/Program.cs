using EmployeeManagementApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alter_employeeapp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeRepository employeeRepository = new EmployeeRepository();

            // Create and add employees
            employeeRepository.AddEmployee(new Employee("John Doe", 5000, 1000, "Engineer", new DateTime(2023, 9, 21)));
            employeeRepository.AddEmployee(new Employee("Jane Smith", 6000, 1200, "Manager", new DateTime(2021, 8, 22)));
            employeeRepository.AddEmployee(new Employee("Bob", 30000, 0, "Worker", new DateTime(2022, 7, 15)));

            string outputPath = @"C:\Users\User-CSE\Pictures\Hudai\EmployeeReport.xml";

            IEmployeeReportGenerator reportGenerator = new XMLEmployeeReportGenerator();
            reportGenerator.GenerateReport(employeeRepository.GetAllEmployees(), outputPath);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
