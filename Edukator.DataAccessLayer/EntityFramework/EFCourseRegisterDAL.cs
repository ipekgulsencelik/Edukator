using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.Repository;
using Edukator.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EFCourseRegisterDAL : GenericRepository<CourseRegister>, ICourseRegisterDAL
    {
        public List<CourseRegister> CourseRegisterListWithCoursesAndUsers()
        {
            using var context = new Context();

            var values = context.CourseRegisters.Include(x => x.Course).Include(y => y.AppUser).ToList();

            return values;
        }
    }
}
