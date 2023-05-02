using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.Repository;
using Edukator.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EFCourseDAL : GenericRepository<Course>, ICourseDAL
    {
        public List<Course> GetCoursesWithCategory()
        {
            using (var context = new Context())
            {
                return context.Courses.Include(x => x.Category).ToList();
            }
        }
    }
}