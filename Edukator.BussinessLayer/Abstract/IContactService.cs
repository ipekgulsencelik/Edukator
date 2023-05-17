using Edukator.EntityLayer.Concrete;

namespace Edukator.BussinessLayer.Abstract
{
    public interface IContactService : IGenericService<Contact>
    {
        public List<Contact> TGetLastFourMessage();
    }
}
