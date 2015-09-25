using AcadSchedule.Domain.Abstract;
using AcadSchedule.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcadSchedule.Domain.Concrete
{
    public class EFSubjectRepository : ISubjectRepository
    {
        private EfDbContext context = new EfDbContext();

        public IQueryable<Subject> Subjects
        {
            get { return context.Subjects; }
        }
    }
}
