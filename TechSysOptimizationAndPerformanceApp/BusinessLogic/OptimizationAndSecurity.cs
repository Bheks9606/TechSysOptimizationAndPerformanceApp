using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSysOptimizationAndPerformanceApp.Models;

namespace TechSysOptimizationAndPerformanceApp.BusinessLogic
{
    public class OptimizationAndSecurity
    {
        public List<Employee> OptimizeAndSortDataset(List<Employee> dataset)
        {
            return dataset.OrderBy(x => x.Salary).ToList();
        }
    }
}
