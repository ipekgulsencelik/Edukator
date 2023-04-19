using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Repository;
using Edukator.EntityLayer.Concrete;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EFSocialMediaDAL : GenericRepository<SocialMedia>, ISocialMediaDAL
    {
    }
}
