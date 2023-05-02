using Edukator.EntityLayer.Concrete;

namespace Edukator.DataAccessLayer.Abstract
{
    public interface ICourseDAL : IGenericDAL<Course>
    {
        List<Course> GetCoursesWithCategory();
    }
}
