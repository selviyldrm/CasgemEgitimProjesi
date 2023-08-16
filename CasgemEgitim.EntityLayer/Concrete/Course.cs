﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemEgitim.EntityLayer.Concrete
{
    //kurs
    public class Course
    {
        [Key]
        public int CourseId { get; set; } 
        public string CourseName { get; set; }
        public string CourseImgUrl { get; set; }
        public string CourseDes { get; set; }
        public decimal CoursePrice { get; set; }
        public List<Video> Videos{ get; set; }
        public List<Student> Students{ get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

       
    }
}
