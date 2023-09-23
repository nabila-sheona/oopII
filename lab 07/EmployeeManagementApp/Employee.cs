using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace EmployeeManagementApp
{
    public class Employee
    {
        public string Name { get; set; }

        public double BasicSalary { get; set; }
        public double Bonus { get; set; }
        public string Designation { get; set; }
        public DateTime DateOfJoining { get; set; }
        public double HouseAllowance { get; set; }
        public double TransportAllowance { get; private set; }
        public double CostOfLiving { get; private set; }

        public Employee() { }

    

        public Employee(string name, double basicSalary, string designation)
        {
            Name = name;
            BasicSalary = basicSalary;
            HouseAllowance = basicSalary * 0.4;
            TransportAllowance = 5000;
            CostOfLiving = 1000;
            Designation = designation;
            DateOfJoining = DateTime.Now;
        }

        public Employee(string name, double basicSalary, double bonus, string designation, DateTime dateOfJoining)
        {
            Name = name;
            BasicSalary = basicSalary;
            Bonus = bonus;
            Designation = designation;
            DateOfJoining = dateOfJoining;
        }

        public double getSalary()
        {
            return BasicSalary + HouseAllowance + TransportAllowance + CostOfLiving + Bonus;
        }

        public double CalculateSalary()
        {
            double houseAllowance = 0.4 * BasicSalary;
            double transportAllowance = 5000;
            double costOfLiving = 800;
            return BasicSalary + houseAllowance + transportAllowance + costOfLiving + Bonus;
        }

     
        public void GenerateReport()
        {
            EmployeeController employeeController = new EmployeeController();
            Console.WriteLine(employeeController.GetAllEmployees().Count);
            string outputPath = @"D:\sophomore\ooc2\task\EmployeeManagementApp\EmployeeReport.xml";

            Console.WriteLine(outputPath);
            GenerateEmployeeXMLReport(employeeController.GetAllEmployees(), outputPath);
        }

        public void GenerateEmployeeXMLReport(List<Employee> employees, string outputPath)
        {
            try
            {
                var xmlDocument = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("EmployeeData",
                        employees.Select(employee => new XElement("Employee",
                            new XElement("Name", employee.Name),
                            new XElement("BasicSalary", employee.BasicSalary),
                            new XElement("Bonus", employee.Bonus),
                            new XElement("Designation", employee.Designation),
                            new XElement("DateOfJoining", employee.DateOfJoining),
                            new XElement("TotalSalary", employee.getSalary())
                        ))
                    )
                );

                xmlDocument.Save(outputPath);

                Console.WriteLine("Employee XML report generated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating the employee XML report: {ex.Message}");
            }
        }
    }


    public class EmployeeController
    {
        private List<Employee> employees = new List<Employee>();

        public EmployeeController()
        {
            HireEmployee("John Doe", 5000, 1000, "Engineer", new DateTime(2023, 9, 21));
            HireEmployee("Jane Smith", 6000, 1200, "Manager", new DateTime(2021, 8, 22));
            HireEmployee("Bob", 30000, "Worker");
        }

         public void HireEmployee(string name, double basicSalary, double bonus, string designation, DateTime dateOfJoining)
        {
            Employee employee = new Employee(name, basicSalary, bonus, designation, dateOfJoining);
            employees.Add(employee);    
        }

        public void HireEmployee(string name, double basicSalary, string designation)
        {
            Employee employee = new Employee(name, basicSalary, designation);
            employees.Add(employee);
        }
        public List<Employee> GetAllEmployees()
        {
            return employees;
        }


        public void deleteEmployee(string name)
        {
            Employee employeedelete=employees.FirstOrDefault(x => x.Name == name);
            if (employeedelete != null)
            {
                employees.Remove(employeedelete);
                Console.WriteLine($"Employee '{name}' has been deleted.");
            }
            else
            {
                Console.WriteLine($"Employee {name} not found");
            }

        }

        public void findEmployee(string name)
        {

            Employee employeefind = employees.FirstOrDefault(x => x.Name == name);
            if (employeefind != null)
            {
                Console.WriteLine($"Employee '{employeefind.Name}' is found");
              
            }
            else
            {
                Console.WriteLine($"Employee '{name}' not found");
            }
        }

        public void updateEmployee(string name, double newsalary, string newdesignation)
        {
            Employee employeeupdate = employees.FirstOrDefault(x => x.Name == name);

            if (employeeupdate != null)
            {
                employeeupdate.BasicSalary = newsalary;
                employeeupdate.Designation = newdesignation;
                Console.WriteLine($"Employee '{name}' data has been updated.");
            }
            else
            {
                Console.WriteLine($"Employee '{name}' not found.");
            }

        }



    }
}
