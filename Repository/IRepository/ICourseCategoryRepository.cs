using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_learing.Models;

namespace E_learing.Repository.IRepository
{
    public interface ICourseCategoryRepository :IRepository<CourseCategory>
    {
        void Update(CourseCategory obj);
        void Save();
    }
}