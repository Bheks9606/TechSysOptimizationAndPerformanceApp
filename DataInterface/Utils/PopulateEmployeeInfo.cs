using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.Utils
{
    public class PopulateEmployeeInfo
    {
        // Properties to store the values
        public string[] FirstNames { get; private set; }
        public string[] LastNames { get; private set; }
        public string[] JobTitles { get; private set; }

        public PopulateEmployeeInfo()
        {
            // Initializing the arrays in the constructor
            FirstNames = new string[] { "Bheki", "Jane", "Sipho", "Bob", "Lwazi", "David", "Mandla", "Frank", "Tshegofatso", "Henry" };
            LastNames = new string[] { "Sangweni", "Smith", "Nkosi", "Dlamini", "Rupert", "Jackson", "Jones", "Anderson", "Tau", "Doe" };
            JobTitles = new string[] { "Software Engineer", "Doctor", "Chemical Engineer", "Lawyer", "Teacher", "Psychologist", "IT Recruiter", "Public Relations", "Sport Manager", "Chief Technology Officer" };
        }
    }
}
