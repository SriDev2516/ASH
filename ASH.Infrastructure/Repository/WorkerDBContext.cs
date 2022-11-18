using ASP.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASH.Infrastructure.Repository
{
    public class WorkerDBContext: DbContext
    {
        public WorkerDBContext(DbContextOptions<WorkerDBContext> options) : base(options) { }
        public DbSet<Employee> Employees
        {
            get;
            set;
        }
        public DbSet<Supervisor> Supervisors
        {
            get;
            set;
        }
        public DbSet<Manager> Managers
        {
            get;
            set;
        }
       
    }
}
