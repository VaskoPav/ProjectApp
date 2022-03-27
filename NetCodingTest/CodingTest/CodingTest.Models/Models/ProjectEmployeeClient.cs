using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Models.Models
{
    public class ProjectEmployeeClient
    {
        public int EmployeeId { get; set; }
        public  Employee Employee { get; set; }
        public int ProjectId { get; set; }
        public  Project Project { get; set; }
        



    }
}
