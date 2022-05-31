using System;
namespace MyClasses
{
    public class Class2 : Meeting // Класс 2 – без названия в условии
    {
        public int CountOfGroup { get; set; }


        public double Quality() => base.Q();

        public override double Q() => Quality() + CountOfGroup / Convert.ToDouble(CountOfParticipant);


        public Class2(string name, int countSpeakers, int countParticipant, int countGroup)
            : base(name,countSpeakers,countParticipant)
        {
            CountOfGroup = countGroup;
        }

        public Class2(): base() { }
    }
}
