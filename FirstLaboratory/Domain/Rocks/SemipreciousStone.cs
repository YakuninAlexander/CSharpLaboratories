using System;
namespace FirstLaboratory.Domain.Rocks
{
    public class SemipreciousStone : Stone
    {
        public SemipreciousStone(string name, int transparency = 20, double price = 50, double weight = 0.1) //70%, 1000 USD, 0.1 K
        {
            Name = name;
            Transparency = transparency;
            Price = price;
            Weight = weight;
        }
    }
}
