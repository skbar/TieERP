namespace TieERP.Models
{
    public class Review : IEntity
    {
        public string Comment { get; set; }
        public Product Product { get; set; }
    }
}