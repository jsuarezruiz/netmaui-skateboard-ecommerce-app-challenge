namespace SkateboardApp.Models
{
    public class BasketItem
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public Color ProductColor { get; set; }

        public string ProductImage { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public decimal Total => Quantity * UnitPrice;

        public override string ToString() =>
            $"Product Id: {ProductId}, Quantity: {Quantity}";
    }
}
