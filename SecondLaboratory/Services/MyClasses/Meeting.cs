using System;

namespace MyClasses
{
    public class Meeting //Класс 1 – Митинг
    {
        public string Name { get; set; }
        public int CountOfSpeakers { get; set; }
        public int CountOfParticipant { get; set; }


        public virtual double Q() => CountOfSpeakers / CountOfParticipant;


        public Meeting(string name, int countSpeakers, int countParticipant) 
        {
            Name = name;
            CountOfSpeakers = countSpeakers;
            CountOfParticipant = countParticipant;
        }
    }
}
