namespace IntroToMVC_W2_Lab_A.Models
{
    public class Product
    {
        public int? id { get; set; }
        public required string name { get; set; }
        public string? description { get; set; }
        public required float price { get; set; }
        public required int stock_quantity { get; set; }
        public string? image_path { get; set; }

    }
}
