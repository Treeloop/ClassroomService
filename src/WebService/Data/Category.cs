namespace Treeloop.ClassroomService.WebService
{
    public class Category
    {
        public Category() { }

        public Category(int id, string name, string description)
        {
            CategoryID = id;
            CategoryName = name;
            Description = description;
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}