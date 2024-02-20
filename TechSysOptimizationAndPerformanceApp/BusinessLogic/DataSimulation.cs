using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSysOptimizationAndPerformanceApp.Models;

namespace TechSysOptimizationAndPerformanceApp.BusinessLogic
{
    public class DataSimulation
    {
        //a list to store employees data
        List<Employee> employees = new List<Employee>();

        //object that will be used to random the employees properties 
        private static Random random = new Random();

        public List<Employee> GenerateEmployeeData()
        {
            for (int i = 1; i <= 1000; i++)
            {
                employees.Add(new Employee 
                {
                    Id = i, 
                    CompanyName =  "Techsys Digital",
                    EmailAddress = $"{GenerateRandomFirstName()}@techsysdigital.com",
                    FirstName = GenerateRandomFirstName(),
                    LastName = GenerateRandomLastName(),
                    Gender = (i % 2 == 0) ? "Male" : "Female",
                    JobTitle = GenerateRandomJobTitle(),
                    PhoneNumber = GenerateRandomPhoneNumber(),
                    Salary = $"R{GenerateRandomSalary(random)}",
                }
                );
            }

            return employees;

        }

        #region MethodsToGenerateRandomData
        private static string GenerateRandomFirstName()
        {
            string[] firstNames = { "Bheki", "Jane", "Sipho", "Bob", "Lwazi", "David", "Mandla", "Frank", "Tshegofatso", "Henry" };
            return GenerateRandomName(firstNames);
        }

        private static string GenerateRandomLastName()
        {
            string[] lastNames = { "Sangweni", "Smith", "Nkosi", "Dlamini", "Rupert", "Jackson", "Jones", "Anderson", "Tau", "Doe" };
            return GenerateRandomName(lastNames);
        }

        private static string GenerateRandomJobTitle()
        {
            string[] jobTitles = { "Software Engineer", "Doctor", "Chemical Engineer", "Lawyer", "Teacher", "Psychologist", "IT Recruiter", "Public Relations", "Sport Manager", "Chief Technology Officer" };
            return GenerateRandomName(jobTitles);
        }

        private static int GenerateRandomSalary(Random random)
        {
            return random.Next(10000, 100000);
        }

        private static string GenerateRandomName(string[] names)
        {
            return names[random.Next(names.Length)];
        }

        private static string GenerateRandomPhoneNumber()
        {
            Random random = new Random();
            return $"+{27} {random.Next(100, 999)} {random.Next(100, 999)} {random.Next(100, 999)}";
        }

        #endregion

    }


}
