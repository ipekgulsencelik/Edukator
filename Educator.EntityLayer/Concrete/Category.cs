namespace Edukator.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }

        // one to many relation
        public List<Course>? Courses { get; set; }
    }
}
