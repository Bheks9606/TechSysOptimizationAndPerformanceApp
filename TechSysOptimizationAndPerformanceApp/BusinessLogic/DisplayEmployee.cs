using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSysOptimizationAndPerformanceApp.Models;

namespace TechSysOptimizationAndPerformanceApp.BusinessLogic
{
    public class DisplayEmployee
    {
        public void DisplayEmployees(Employee employee)
        {
            Console.WriteLine($"\tEmployee No: {employee.Id}\n\tFirst Name: {employee.FirstName}\n\tSurname: {employee.LastName}\n\tPhone Number: {employee.PhoneNumber}\n\tEmail Address: {employee.EmailAddress}\n\tJob title: {employee.JobTitle}\n\tSalary: {employee.Salary} ");
            Console.WriteLine("");
        }
    }
}
