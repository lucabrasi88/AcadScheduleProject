using AcadSchedule.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcadSchedule.Domain.Concrete
{
    public class EfDbContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
    }
}
