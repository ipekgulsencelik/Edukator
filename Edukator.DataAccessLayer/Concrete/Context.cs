using Edukator.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Edukator.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MSI;database=EducatorDB;integrated security=true;trusted_connection=true;encrypt=false");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactInformation> ContactInformations { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
    }
}