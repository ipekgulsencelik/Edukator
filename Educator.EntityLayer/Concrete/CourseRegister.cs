namespace Edukator.EntityLayer.Concrete
{
    public class CourseRegister
    {
        public int CourseRegisterID { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
    }
}
