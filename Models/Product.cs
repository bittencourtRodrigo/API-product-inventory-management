namespace EprApi.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public long BarCode { get; set; }
    }
}
