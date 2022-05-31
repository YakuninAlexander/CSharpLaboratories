using System;
using Messages.Interfaces;
using ThirdLaboratory.Domain.Data.AbstractClasses;
using ThirdLaboratory.Domain.Data.Classes;
using ThirdLaboratory.Domain.Data.Enums;
using Messages;

namespace ThirdLaboratory.Services.Phones
{

    public class Smartphone : MobilePhone
    {
        public double ScreenSize { get; set; }
        public ScreenTypes ScreenType { get; set; }

        public override IMessage sendMessage(string text, Number number)
        {
            IMessage msg = new MessageStream($"Send {text} on number {number.Person.Key}!");
            return msg;
        }

        public IMessage browseChrome()
        {
            IMessage msg = new MessageStream("Chrome is browse!");
            return msg;
        }

        public IMessage checkViruses ()
        {
            IMessage msg = new MessageStream();
            Random rnd = new Random();

            int value = rnd.Next(0,10);
            msg.Value = value % 2 == 0 ? $"Detected {value} viruses" : "Viruses not detected!";
            return msg;
        }

        public Smartphone(ScreenTypes type, double size, string number)
        {
            ScreenSize = size;
            ScreenType = type;
            OwnNumber = number;
        }
    }
}
