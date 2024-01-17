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
        private List<EasterEgg> eggs;

        public EasterEggsRepository()
        {
            eggs = new List<EasterEgg>();
            // Tilføj mindst 3 objekter af EasterEgg til listen
            eggs.Add(new EasterEgg(1, "Mørk", 10.99m, 50));
            eggs.Add(new EasterEgg(2, "Mælke", 8.99m, 30));
            eggs.Add(new EasterEgg(3, "Hvid", 12.99m, 20));
        }

        // Get alle påskeæg
        public List<EasterEgg> Get()
        {
            return eggs;
        }

        // Get påskeæg baseret på produkt nummer
        public EasterEgg GetByProductNo(int productNo)
        {
            EasterEgg egg = eggs.FirstOrDefault(e => e.ProductNo == productNo);

            if (egg == null)
            {
                throw new ArgumentException($"Påskeæg med produkt nummer {productNo} blev ikke fundet.");
            }

            return egg;
        }

        // Get påskeæg med lav lagerbeholdning
        public List<EasterEgg> GetLowStock(int stockLevel)
        {
            return eggs.Where(e => e.InStock <= stockLevel).ToList();
        }

        // Opdater påskeæg
        public void Update(EasterEgg egg)
        {
            EasterEgg existingEgg = eggs.FirstOrDefault(e => e.ProductNo == egg.ProductNo);

            if (existingEgg == null)
            {
                throw new ArgumentException($"Påskeæg med produkt nummer {egg.ProductNo} blev ikke fundet.");
            }

            // Opdater properties
            existingEgg.ChocolateType = egg.ChocolateType;
            existingEgg.Price = egg.Price;
            existingEgg.InStock = egg.InStock;
        }
    }
}
