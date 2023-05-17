using Edukator.EntityLayer.Concrete;

namespace Edukator.DataAccessLayer.Abstract
{
    public interface IContactDAL : IGenericDAL<Contact>
    {
        public List<Contact> GetLastFourMessage();
    }
}
