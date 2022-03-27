
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodingTest.Models.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string NameProject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    
        public ICollection<ProjectEmployeeClient> ProjectEmployee { get; set; }

        

        public int ClientId { get; set; }
        [ForeignKey(nameof(ClientId))]
        public virtual Client Client { get; set; }

        

    }
}
