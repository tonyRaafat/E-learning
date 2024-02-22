using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_learing.Models;
using E_learing.Data;
using E_learing.Repository.IRepository;

namespace E_learing.Repository
{
    public class CourseCategoryRepository : Repository<CourseCategory> , ICourseCategoryRepository
    {
        private ApplicationDbContext _db;
        public CourseCategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(CourseCategory obj)
        {
            _db.Update(obj);
        }
    }
}