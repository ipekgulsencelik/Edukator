using Edukator.BussinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;

namespace Edukator.BussinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDAL _socialMediaDAL;

        public SocialMediaManager(ISocialMediaDAL socialMediaDAL)
        {
            _socialMediaDAL = socialMediaDAL;
        }

        public void TDelete(SocialMedia entity)
        {
            _socialMediaDAL.Delete(entity);
        }

        public SocialMedia TGetByID(int id)
        {
            return _socialMediaDAL.GetByID(id);
        }

        public List<SocialMedia> TGetList()
        {
            return _socialMediaDAL.GetList();
        }

        public void TInsert(SocialMedia entity)
        {
            _socialMediaDAL.Insert(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMediaDAL.Update(entity);
        }
    }
}