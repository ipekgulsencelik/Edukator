using Edukator.EntityLayer.Concrete;

namespace Edukator.BussinessLayer.Abstract
{
    public interface ICourseRegisterService : IGenericService<CourseRegister>
    {
        List<CourseRegister> TCourseRegisterListWithCoursesAndUsers();
        List<CourseRegister> TCourseRegisterListWithCourseByUser(int id);
    }
}
