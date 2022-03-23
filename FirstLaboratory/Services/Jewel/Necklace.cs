using System;
using System.Linq;
using System.Collections.Generic;
using FirstLaboratory.Domain.Rocks;
using FirstLaboratory.Services.Jewel.Interfaces;

namespace FirstLaba.Services.Jewel
{
    public class Necklace : IJewelry
    {
        List<Stone> _stones;
        public Necklace(List<Stone> stones)
        {
            _stones = new List<Stone>(stones);
        }

        public double calculateTotalPrice() => _stones.Sum(s => s.Price);

        public double calculateTotalWeight() => _stones.Sum(s => s.Weight);

        public IEnumerable<Stone> getStonesByTransparency(int min, int max)
            => _stones.Where(s => s.Transparency <= max && s.Transparency >= min);

        public void sortStones() => _stones.OrderBy(s => s.Price);
    }
}