using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssignment_aspNetCore
{
    public class Leave
    {
        [Key]
        public int leaveId { get; set; }
        public string leaveName { get; set; }
        public int leaveMaxNoOfDays { get; set; }
    }
}
