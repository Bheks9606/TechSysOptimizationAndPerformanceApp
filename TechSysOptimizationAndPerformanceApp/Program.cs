using DataInterface.Utils;
using TechSysOptimizationAndPerformanceApp.BusinessLogic;

//instance of the classes that will be used for data simulation, optimization and security

PopulateEmployeeInfo populateEmployeeInfo = new PopulateEmployeeInfo();
DataSimulation dataSimulation = new DataSimulation(populateEmployeeInfo);
OptimizationAndSecurity optimization = new OptimizationAndSecurity();
DisplayEmployee display = new DisplayEmployee();

//sort and optimize the empolyees data that was simulated

var employees = optimization.OptimizeAndSortDataset(dataSimulation.GenerateEmployeeData());

//label of the application

Console.WriteLine("-------------DATA SIMULATION, OPTIMIZATION AND SECURITY APP------------");
Console.WriteLine("\n");

foreach (var employee in employees)
{
    //display the employees data to the console 
    display.DisplayEmployees(employee);
}
