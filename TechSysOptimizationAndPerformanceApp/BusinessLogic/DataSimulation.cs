using DataInterface.Utils;
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

        List<Employee> employees = new List<Employee>();  //a list to store employees data

        //object that will be used to random the employees properties 
        private static Random random = new Random();
        private readonly PopulateEmployeeInfo populateEmployeeInfo;

        public DataSimulation(PopulateEmployeeInfo populateEmployeeInfo)
        {
            this.populateEmployeeInfo = populateEmployeeInfo;
        }

        public List<Employee> GenerateEmployeeData()
        {
            int totalEmployees = 1000;
            int batchSize = 100;

            return Enumerable.Range(1, totalEmployees / batchSize)
                             .SelectMany(_ => GenerateEmployeeBatch(batchSize))
                             .ToList();
        }

        private List<Employee> GenerateEmployeeBatch(int batchSize)
        {
            var batch = new List<Employee>();

            for (int i = 0; i < batchSize; i++)
            {
                int employeeId = employees.Count + i + 1;

                batch.Add(new Employee
                {
                    Id = employeeId,
                    CompanyName = "Techsys Digital",
                    EmailAddress = $"{GenerateRandomFirstName(populateEmployeeInfo.FirstNames)}@techsysdigital.com",
                    FirstName = GenerateRandomFirstName(populateEmployeeInfo.FirstNames),
                    LastName = GenerateRandomLastName(populateEmployeeInfo.LastNames),
                    Gender = (employeeId % 2 == 0) ? "Male" : "Female",
                    JobTitle = GenerateRandomJobTitle(populateEmployeeInfo.JobTitles),
                    PhoneNumber = GenerateRandomPhoneNumber(),
                    Salary = $"R{GenerateRandomSalary(random)}",
                });
            }

            return batch;
        }


        #region MethodsToGenerateRandomData
        private static string GenerateRandomFirstName(string[] firstNames)
        {
            return GenerateRandomName(firstNames);
        }

        private static string GenerateRandomLastName(string[] lastNames)
        {
            return GenerateRandomName(lastNames);
        }

        private static string GenerateRandomJobTitle(string[] jobTitles)
        {
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
            return $"+{27} {random.Next(100, 999)} {random.Next(100, 999)} {random.Next(100, 999)}";
        }

        #endregion

    }


}
