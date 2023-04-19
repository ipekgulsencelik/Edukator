using Edukator.BussinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;

namespace Edukator.BussinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDAL _subscribeDAL;

        public SubscribeManager(ISubscribeDAL subscribeDAL)
        {
            _subscribeDAL = subscribeDAL;
        }

        public void TDelete(Subscribe entity)
        {
            _subscribeDAL.Delete(entity);
        }

        public Subscribe TGetByID(int id)
        {
            return _subscribeDAL.GetByID(id);
        }

        public List<Subscribe> TGetList()
        {
            return _subscribeDAL.GetList();
        }

        public void TInsert(Subscribe entity)
        {
            _subscribeDAL.Insert(entity);
        }

        public void TUpdate(Subscribe entity)
        {
            _subscribeDAL.Update(entity);
        }
    }
}
