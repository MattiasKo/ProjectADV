using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace ClassLibrary.Models
{
    [Serializable]
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public int EmployeeId { get; set; }
       
        public Employee Employee { get; set; }

     
    }
}
