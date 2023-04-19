using Edukator.DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.Repository;
using Edukator.EntityLayer.Concrete;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EFTestimonialDAL : GenericRepository<Testimonial>, ITestimonialDAL
    {
    }
}
