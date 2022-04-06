using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public ICollection<Project> Projects { get; set; }
        public ICollection<TimeReport> TimeReports { get; set; }
    }
}
