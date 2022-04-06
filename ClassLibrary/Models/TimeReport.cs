using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary.Models
{
    public class TimeReport
    {
        [Key]
        public int Id { get; set; }
        public int Week { get; set; }
        public int HoursWorkedAWeek{ get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
