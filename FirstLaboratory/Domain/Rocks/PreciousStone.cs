using System;
namespace FirstLaboratory.Domain.Rocks
{
    public class PreciousStone : Stone
    {
        public int Frequency { get; init; } // в процентах
        public PreciousStone(int transparency = 70, double price = 1000, double weight = 0.1, int frequency = 1) //70%, 1000 USD, 0.1 K
        {
            Transparency = transparency;
            Price = price;
            Weight = weight;
            Frequency = frequency;
        }
    }

}
