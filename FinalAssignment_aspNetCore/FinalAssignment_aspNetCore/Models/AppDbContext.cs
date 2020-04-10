using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssignment_aspNetCore
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Employee> employees { get; set; }
        public DbSet<Leave> leaves { get; set; }
        public DbSet<EmpLeaveMap> empLeaveMaps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    emplyeeId = 1,
                    employeeName = "Mohit Yadav",
                    employeeDob = "13/11/1991",
                    employeeDoj = "10/05/2007",
                    employeeEmail = "Mohityadav6532@gmail.com"
                });


            modelBuilder.Entity<Leave>().HasData(
                new Leave
                {
                    leaveId = 1,
                    leaveName = "Casual Leave",
                    leaveMaxNoOfDays = 20
                });


            modelBuilder.Entity<EmpLeaveMap>().HasData(
                new EmpLeaveMap 
                {
                    mapId = 1,
                    empId = 1,
                    leaveId =1,
                    empName = "Mohit Yadav",
                    leaveName = "Casual Leave",
                    leaveStartDate = "10/02/2016",
                    leaveEndDate = "14/02/2016",
                    leaveStatus = "Taken"
                });

        }
    }
}
