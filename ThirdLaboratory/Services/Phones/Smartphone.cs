using System;
using ThirdLaboratory.Domain.Data.AbstractClasses;
using ThirdLaboratory.Domain.Data.Enums;

namespace ThirdLaboratory.Services.Phones
{

    public class Smartphone : MobilePhone
    {
        public double ScreenSize { get; set; }
        public ScreenTypes ScreenType { get; set; }

        public override string sendMessage(string text, string number) => $"Send {text} on number {number}!";
        

        public string browseChrome() => "Хром запускается";

        public string checkViruses ()
        {
            Random rnd = new Random();

            int value = rnd.Next(0,10);
            return value % 2 == 0 ? $"Detected {value} viruses" : "Viruses not detected!";;
        }

        public Smartphone(ScreenTypes type, double size, string number, int price, int pixels) : base(pixels, price)
        {
            ScreenSize = size;
            ScreenType = type;
            OwnNumber = number;
        }
    }
}