using Edukator.EntityLayer.Concrete;

namespace Edukator.DataAccessLayer.Abstract
{
    public interface ICourseRegisterDAL : IGenericDAL<CourseRegister>
    {
        List<CourseRegister> CourseRegisterListWithCoursesAndUsers();
    }
}
