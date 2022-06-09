using Core.Entities;

namespace Entities.Concrete
{
    public class Photo : IEntity
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int MainCategoryId { get; set; }
    }
}
