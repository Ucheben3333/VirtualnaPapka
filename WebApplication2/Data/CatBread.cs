namespace WebApplication2.Data
{
    public class CatBread
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public DateTime RegisterOn { get; set; }
        ICollection<Cat> Cats { get; set; }
    }
}
