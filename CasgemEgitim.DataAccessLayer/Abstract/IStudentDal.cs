﻿using CasgemEgitim.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemEgitim.DataAccessLayer.Abstract
{
    public interface IStudentDal:IGenericDal<Student>
    {
        Task<Student> GetStudentByUsername(string username);
        Task<Student> AddStudent(Student student);

    }
}
