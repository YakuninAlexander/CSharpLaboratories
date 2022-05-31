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

        public IEnumerable<Stone> sortStones() => Stones.OrderByDescending(s => s.Price);

        public string getInfo()
        {
            string result = "";
            foreach(var elem in Stones)
            {
                result += $"Имя: {elem.Name}; Прозрачность: {elem.Transparency}; Стоимость: {elem.Price}; Весс: {elem.Weight}!\n";
            }

            return result;
        }
    }
}