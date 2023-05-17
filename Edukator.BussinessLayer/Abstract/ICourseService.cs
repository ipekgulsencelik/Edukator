using Edukator.EntityLayer.Concrete;

namespace Edukator.BussinessLayer.Abstract
{
    public interface ICourseService : IGenericService<Course>
    {
        List<Course> TGetCoursesWithCategory();
        List<Course> TGetLastFiveCourse();
    }
}
