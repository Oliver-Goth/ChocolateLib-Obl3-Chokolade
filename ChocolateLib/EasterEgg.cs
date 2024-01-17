namespace ChocolateLib
{
    public class EasterEgg
    {
        public int ProductNO { get; set; }
        public string ChocolateType { get; set; }
        public int Price { get; set; }
        public int InStock { get; set; }

        public override string ToString()
        {
            return "Product Number: " + ProductNO + ", Type: " + ChocolateType + ", Price: " + Price + ", In stock: " + InStock;
        }
    }
}