using System;
using System.Linq;
using System.Collections.Generic;
using FirstLaboratory.Domain.Rocks;
using FirstLaboratory.Services.Jewel.Interfaces;

namespace FirstLaboratory.Services.Jewel
{
    public class Necklace : IJewelry
    {
        public List<Stone> Stones { get; private set; }
        public Necklace(List<Stone> stones)
        {
            Stones = new List<Stone>(stones);
        }

        public double calculateTotalPrice() => Stones.Sum(s => s.Price);

        public double calculateTotalWeight() => Stones.Sum(s => s.Weight);

        public IEnumerable<Stone> getStonesByTransparency(int min, int max)
            => Stones.Where(s => s.Transparency <= max && s.Transparency >= min);

        public void sortStones() => Stones.OrderBy(s => s.Price);
    }
}