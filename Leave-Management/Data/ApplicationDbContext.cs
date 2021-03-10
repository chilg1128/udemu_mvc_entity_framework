using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Leave_Management.Models;

namespace Leave_Management.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveAllocation> leaveAllocations { get; set; }
        public DbSet<LeaveHistory> leaveHistories { get; set; }
        public DbSet<LeaveType> leaveTypes { get; set; }
        public DbSet<Leave_Management.Models.DetailsLeaveTypeVM> DetailsLeaveTypeVM { get; set; }
    }
}
