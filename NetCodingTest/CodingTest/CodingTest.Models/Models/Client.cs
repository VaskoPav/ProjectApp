
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodingTest.Models.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }

        public virtual List<Project> Projects { get; set; }

    }
}
