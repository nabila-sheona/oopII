using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace EmployeeManagementApp
{
    // Employee interface represents common employee properties and behaviors
    public interface IEmployee
    {
        string Name { get; }
        double CalculateSalary();
    }

    // Employee class represents an employee entity
    public class Employee : IEmployee
    {
        public string Name { get; private set; }
        public double BasicSalary { get; private set; }
        public double Bonus { get; private set; }
        public string Designation { get; private set; }
        public DateTime DateOfJoining { get; private set; }

        public Employee(string name, double basicSalary, double bonus, string designation, DateTime dateOfJoining)
        {
            Name = name;
            BasicSalary = basicSalary;
            Bonus = bonus;
            Designation = designation;
            DateOfJoining = dateOfJoining;
        }

        public double CalculateSalary()
        {
            double houseAllowance = 0.4 * BasicSalary;
            double transportAllowance = 5000;
            double costOfLiving = 800;
            return BasicSalary + houseAllowance + transportAllowance + costOfLiving + Bonus;
        }
    }

    // EmployeeRepository interface defines methods for managing employee data
    public interface IEmployeeRepository
    {
        void AddEmployee(IEmployee employee);
        void RemoveEmployee(IEmployee employee);
        IEmployee FindEmployeeByName(string name);
        List<IEmployee> GetAllEmployees();
    }

    // EmployeeRepository class manages employee data (storage and retrieval)
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<IEmployee> employees = new List<IEmployee>();

        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(IEmployee employee)
        {
            employees.Remove(employee);
        }

        public IEmployee FindEmployeeByName(string name)
        {
            return employees.Find(emp => emp.Name == name);
        }

        public List<IEmployee> GetAllEmployees()
        {
            return employees;
        }
    }

    // EmployeeReportGenerator interface defines methods for generating employee reports
    public interface IEmployeeReportGenerator
    {
        void GenerateReport(List<IEmployee> employees, string outputPath);
    }

    // XMLEmployeeReportGenerator class generates employee reports in XML format
    public class XMLEmployeeReportGenerator : IEmployeeReportGenerator
    {
        public void GenerateReport(List<IEmployee> employees, string outputPath)
        {
            try
            {
                var xmlDocument = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("EmployeeData",
                        employees.ConvertAll(employee =>
                            new XElement("Employee",
                                new XElement("Name", employee.Name),
                                new XElement("BasicSalary", (employee as Employee)?.BasicSalary),
                                new XElement("Bonus", (employee as Employee)?.Bonus),
                                new XElement("Designation", (employee as Employee)?.Designation),
                                new XElement("DateOfJoining", (employee as Employee)?.DateOfJoining),
                                new XElement("TotalSalary", employee.CalculateSalary())
                            )
                        )
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

   
}
