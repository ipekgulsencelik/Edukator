using Edukator.BussinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;

namespace Edukator.BussinessLayer.Concrete
{
    public class CourseRegisterManager : ICourseRegisterService
    {
        private readonly ICourseRegisterDAL _courseRegisterDAL;
        
        public CourseRegisterManager(ICourseRegisterDAL courseRegisterDAL)
        {
            _courseRegisterDAL = courseRegisterDAL ;
        }

        public List<CourseRegister> TCourseRegisterListWithCoursesAndUsers()
        {
            return _courseRegisterDAL.CourseRegisterListWithCoursesAndUsers();
        }

        public void TDelete(CourseRegister entity)
        {
           _courseRegisterDAL.Delete(entity);
        }

        public CourseRegister TGetByID(int id)
        {
            return _courseRegisterDAL.GetByID(id);
        }

        public List<CourseRegister> TGetList()
        {
            return _courseRegisterDAL.GetList();
        }

        public void TInsert(CourseRegister entity)
        {
            _courseRegisterDAL.Insert(entity);
        }

        public void TUpdate(CourseRegister entity)
        {
            _courseRegisterDAL.Update(entity);
        }
    }
}