using EmployeeCrm.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {    
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<InformationList> InformationLists { get; set; }
        public DbSet<Internship> Internships { get; set; }
        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<RegisterBlank> RegisterBlanks { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Satisfaction> Satisfactions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentPayment> StudentPayments { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
