using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssignment_aspNetCore
{
    public class Employee
    {
        [Key]
        public int emplyeeId { get; set; }
        public string employeeName { get; set; }
        public string employeeDob { get; set; }
        public string employeeDoj { get; set; }
        public string employeeEmail { get; set; }
    }
}
