
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodingTest.Models.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public int MobilePhone { get; set; }
        public string Email { get; set; }
        public int EmployeeNum { get; set; }

        public virtual List<Project> Projects { get; set; }
        public List<ProjectEmployeeClient> ProjectEmployee { get; set; }
        


    }
}
