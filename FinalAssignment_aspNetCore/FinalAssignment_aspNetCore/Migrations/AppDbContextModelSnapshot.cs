﻿// <auto-generated />
using FinalAssignment_aspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalAssignment_aspNetCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalAssignment_aspNetCore.EmpLeaveMap", b =>
                {
                    b.Property<int>("mapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("empId")
                        .HasColumnType("int");

                    b.Property<string>("empName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("leaveEndDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("leaveId")
                        .HasColumnType("int");

                    b.Property<string>("leaveName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("leaveStartDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("leaveStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("mapId");

                    b.ToTable("empLeaveMaps");

                    b.HasData(
                        new
                        {
                            mapId = 1,
                            empId = 1,
                            empName = "Mohit Yadav",
                            leaveEndDate = "14/02/2016",
                            leaveId = 1,
                            leaveName = "Casual Leave",
                            leaveStartDate = "10/02/2016",
                            leaveStatus = "Taken"
                        });
                });

            modelBuilder.Entity("FinalAssignment_aspNetCore.Employee", b =>
                {
                    b.Property<int>("emplyeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("employeeDob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeDoj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("emplyeeId");

                    b.ToTable("employees");

                    b.HasData(
                        new
                        {
                            emplyeeId = 1,
                            employeeDob = "13/11/1991",
                            employeeDoj = "10/05/2007",
                            employeeEmail = "Mohityadav6532@gmail.com",
                            employeeName = "Mohit Yadav"
                        });
                });

            modelBuilder.Entity("FinalAssignment_aspNetCore.Leave", b =>
                {
                    b.Property<int>("leaveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("leaveMaxNoOfDays")
                        .HasColumnType("int");

                    b.Property<string>("leaveName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("leaveId");

                    b.ToTable("leaves");

                    b.HasData(
                        new
                        {
                            leaveId = 1,
                            leaveMaxNoOfDays = 20,
                            leaveName = "Casual Leave"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
