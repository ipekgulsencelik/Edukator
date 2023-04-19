using Edukator.BussinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;

namespace Edukator.BussinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDAL _contactDAL;

        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }

        public void TInsert(Contact entity)
        {
            _contactDAL.Insert(entity);
        }

        public void TDelete(Contact entity)
        {
            _contactDAL.Delete(entity);
        }

        public Contact TGetByID(int id)
        {
            return _contactDAL.GetByID(id);
        }

        public List<Contact> TGetList()
        {
            return _contactDAL.GetList();
        }

        public void TUpdate(Contact entity)
        {
            _contactDAL.Update(entity);
        }
    }
}