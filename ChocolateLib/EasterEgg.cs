namespace ChocolateLib
{
    public class EasterEgg
    {
        // Properties
        public int ProductNo { get; set; }
        public string ChocolateType { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }

        // Constructor (optional)
        public EasterEgg(int productNo, string chocolateType, decimal price, int inStock)
        {
            ProductNo = productNo;
            ChocolateType = chocolateType;
            Price = price;
            InStock = inStock;
        }

        // ToString method override
        public override string ToString()
        {
            return $"ProductNo: {ProductNo}, ChocolateType: {ChocolateType}, Price: {Price:C}, InStock: {InStock}";
        }
    }
}