namespace Treeloop.ClassroomService.WebService
{
    public class Product
    {
        public Product() { }

        public Product(int id, string name, double unitPrice, string package, bool isDiscontinued)
        {
            Id = id;
            Name = name;
            UnitPrice = unitPrice;
            Package = package;
            IsDiscontinued = isDiscontinued;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string Package { get; set; }
        public bool IsDiscontinued { get; set; }
    }
}