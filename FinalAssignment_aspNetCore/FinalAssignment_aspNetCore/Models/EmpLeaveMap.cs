using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssignment_aspNetCore
{
    public class EmpLeaveMap
    {
        [Key]
        public int mapId { get; set; }
        public int empId { get; set; }
        public int leaveId { get; set; }
        public string empName { get; set; }
        public string leaveName { get; set; }
        public string leaveStartDate { get; set; }
        public string leaveEndDate { get; set; }
        public string leaveStatus { get; set; }
    }
}
