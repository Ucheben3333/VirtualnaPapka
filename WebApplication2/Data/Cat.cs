namespace WebApplication2.Data
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public DateTime RegisterOn { get; set; }
        public CatBread CatBreads { get; set; }
        public int CatBreadId { get; set; }
    }
}
