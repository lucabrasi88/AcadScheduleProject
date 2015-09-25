using AcadSchedule.Domain.Abstract;
using AcadSchedule.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcadSchedule.Domain.Entities;

namespace AcadSchedule.WebUI
{
    public class SubjectController : Controller
    {
        private ISubjectRepository subRepository;
        public int PageSize = 10;

        public SubjectController(ISubjectRepository subjectRepository)
        {
            this.subRepository = subjectRepository;
        }

        public ViewResult SubjectList(int page = 1)
        {
            SubjectsListViewModel subjectsViewModel = new SubjectsListViewModel
            {
                Subjects = subRepository.Subjects
                .OrderBy(p => p.Name)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = subRepository.Subjects.Count()
                }
            };

            return View(subjectsViewModel);
        }
    }
}
