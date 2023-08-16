﻿using CasgemEgitim.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemEgitim.BusinessLayer.Abstract
{
    public interface IStudentService:IGenericService<Student>
    {
        Task<Student> TGetStudentByUsername(string username);
        Task<Student> AddStudent(Student student);
    }
}
