using Edukator.BussinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;

namespace Edukator.BussinessLayer.Concrete
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDAL _courseDAL;

        public CourseManager(ICourseDAL courseDAL)
        {
            _courseDAL = courseDAL;
        }

        public void TDelete(Course entity)
        {
           _courseDAL.Delete(entity);
        }

        public Course TGetByID(int id)
        {
           return _courseDAL.GetByID(id);
        }

        public List<Course> TGetList()
        {
            return _courseDAL.GetList();
        }

        public List<Course> TGetCoursesWithCategory()
        {
            return _courseDAL.GetCoursesWithCategory();
        }

        public void TInsert(Course entity)
        {
           _courseDAL.Insert(entity);
        }

        public void TUpdate(Course entity)
        {
            _courseDAL.Update(entity);
        }

        public List<Course> TGetLastFiveCourse()
        {
            return _courseDAL.GetLastFiveCourse();
        }
    }
}