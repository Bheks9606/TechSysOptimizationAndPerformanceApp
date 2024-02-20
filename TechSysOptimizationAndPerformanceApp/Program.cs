using TechSysOptimizationAndPerformanceApp.BusinessLogic;

//instance of the classes that will be used for data simulation, optimization and security

DataSimulation dataSimulation = new DataSimulation();
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
