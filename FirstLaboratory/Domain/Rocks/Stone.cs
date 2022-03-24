using System;

namespace FirstLaboratory.Domain.Rocks
{
    public abstract class Stone
    {
        public string Name { get; init; }
        public int Transparency { get; init; } //в процентах
        public double Price { get; init; }
        public double Weight { get; init; }
    }

}
