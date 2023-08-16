﻿using CasgemEgitim.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemEgitim.BusinessLayer.Abstract
{
    public interface ITeacherService: IGenericService<Teacher>
    {
        Task<Teacher> TGetTeacherByUsername(string username);
        Task<Teacher> AddTeacher(Teacher teacher);
    }
}