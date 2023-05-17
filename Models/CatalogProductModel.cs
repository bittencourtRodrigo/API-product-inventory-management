namespace EprApi.Models
{
    public class CatalogProductModel
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public long? Barcode { get; set; }
        public double? CurrentInventory { get; set; }
        public string StoreLocation { get; set; }
        public string Name { get; set; }
        public double? CostPrice { get; set; }
        public double? SalePrice { get; set; }
        public string Observation { get; set; }
    }
}