﻿using CasgemEgitim.BusinessLayer.Abstract;
using CasgemEgitim.DataAccessLayer.Concrete;
using CasgemEgitim.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CasgemEgitim.PresentationLayer.Controllers
{
    public class TeacherController : Controller
    {
        readonly ITeacherService _teacherService;
        readonly ICourseService _courseService;
        private Context dbContext = new Context();

        public TeacherController(ITeacherService teacherService, ICourseService courseService)
        {
            _teacherService = teacherService;
            _courseService = courseService;

        }

        //Kurs
        public IActionResult ListTeacher()
        {
            var values = _teacherService.TGetList();
            return View(values);
        }

        public IActionResult DeleteTeacher(int id)
        {
            var foundId = _teacherService.TGetById(id);
            _teacherService.TDelete(foundId);
            return RedirectToAction("ListTeacher");
        }
        [HttpGet]
        public IActionResult AddTeacher()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {
            teacher.Role = "A";
            _teacherService.TInsert(teacher);
            return RedirectToAction("ListTeacher");
        }

        [HttpGet]
        public IActionResult UpdateTeacher(int id)
        {
            var values = _teacherService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateTeacher(Teacher teacher)
        {
            var values = _teacherService.TGetById(teacher.TeachertId);
            values.TeacherName = teacher.TeacherName;
            values.TeacherSurname = teacher.TeacherSurname;
            values.TeacherUsername = teacher.TeacherUsername;
            values.TeacherImageUrl= teacher.TeacherImageUrl;
            values.TeacherPassword = teacher.TeacherPassword;
            _teacherService.TUpdate(values);
            return RedirectToAction("ListTeacher");
        }
        public IActionResult TeacherCourse(int teacherId)
        {
            var values = dbContext.Courses.Where(c => c.TeacherId== teacherId).ToList();
            return View(values);
        }


    }
}