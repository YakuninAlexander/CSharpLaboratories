using System;

namespace LibClassesLab4
{
    public class Smartphone : MobilePhone
    {
        public double ScreenSize { get; set; }
        public string ScreenType { get; set; }

        public override string sendMessage(string text, string number) => $"Send {text} on number {number}!";


        public string browseChrome() => "Хром запускается";

        public string checkViruses()
        {
            Random rnd = new Random();

            int value = rnd.Next(0, 10);
            return value % 2 == 0 ? $"Detected {value} viruses" : "Viruses not detected!";
        }
        public Smartphone() : base()
        {
            ScreenSize = 0;
            ScreenType = "NULL";
        }
        public Smartphone(string type, double size, string number, int price, int pixels) : base(pixels, price, number)
        {
            ScreenSize = size;
            ScreenType = type;
        }
    }
}
