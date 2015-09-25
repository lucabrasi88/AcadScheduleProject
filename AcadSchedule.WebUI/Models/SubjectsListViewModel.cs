using AcadSchedule.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcadSchedule.WebUI.Models
{
    public class SubjectsListViewModel
    {
        public IEnumerable<Subject> Subjects { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}