using AcadSchedule.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcadSchedule.Domain.Abstract
{
    public interface ISubjectRepository
    {
        IQueryable<Subject> Subjects { get; }
    }
}
