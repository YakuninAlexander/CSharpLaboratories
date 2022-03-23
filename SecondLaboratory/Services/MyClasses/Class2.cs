using System;
namespace MyClasses
{
    public class Class2 : Meeting // Класс 2 – без названия в условии
    {
        int _countOfGroup;


        public double Quality() => CountOfSpeakers / CountOfParticipant;

        public override double Q() => Quality() + _countOfGroup / CountOfParticipant;


        public Class2(string name, int countSpeakers, int countParticipant, int countGroup)
            : base(name,countSpeakers,countParticipant)
        {
            _countOfGroup = countGroup;
        }
    }
}
