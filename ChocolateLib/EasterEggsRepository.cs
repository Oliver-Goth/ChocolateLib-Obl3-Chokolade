using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateLib
{
    public class EasterEggsRepository
    {
        private int _productNo = 1;
        private readonly List<EasterEgg> easterEggs = new List<EasterEgg>();

        public EasterEggsRepository()
        {
            easterEggs.Add(new EasterEgg() { ProductNO = _productNo++, ChocolateType = "Hvid", Price = 100, InStock = 1000 });
            easterEggs.Add(new EasterEgg() { ProductNO = _productNo++, ChocolateType = "Lys", Price = 200, InStock = 1000 });
            easterEggs.Add(new EasterEgg() { ProductNO = _productNo++, ChocolateType = "Mørk", Price = 200, InStock = 1000 });
        }

        public EasterEgg GetAll()
        {
            return new List<EasterEgg>(easterEggs);
        }

        public EasterEgg? GetByProductNo(int productNo)
        {
            return easterEggs.FirstOrDefault(e => e.ProductNO == productNo);
        }

        public void Update(EasterEgg easterEgg, int productNo)
        {
            EasterEgg? ee = GetByProductNo(productNo);
            if (ee == null)
            {
                throw new ArgumentOutOfRangeException("Easteregg is not found");
            }
            ee.ProductNO = easterEgg.ProductNO;
            ee.ChocolateType = easterEgg.ChocolateType;
            ee.Price = easterEgg.Price;
            ee.InStock = easterEgg.InStock;
        }
    }
}
