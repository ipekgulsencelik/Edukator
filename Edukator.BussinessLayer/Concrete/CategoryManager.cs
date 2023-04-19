using Edukator.BussinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;

namespace Edukator.BussinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void TDelete(Category entity)
        {
            _categoryDAL.Delete(entity);
        }

        public Category TGetByID(int id)
        {
            return _categoryDAL.GetByID(id);
        }

        public List<Category> TGetList()
        {
            return _categoryDAL.GetList();
        }

        public void TInsert(Category entity)
        {
            _categoryDAL.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
            _categoryDAL.Update(entity);
        }
    }
}