using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClassesLab4
{
    public class FlagmanSmartphone : MobilePhone
    {
        public FlagmanSmartphone() : base()
        {
            IsHarmanKardonSpeakers = true;
            isWaterproof = true;
        }
        public override string sendMessage(string text, string number) => $"Send {text} on number {number}!";

        public FlagmanSmartphone(bool waterproof, bool isGoodSpeakers, string number, int price, int pixels) : base(pixels, price, number)
        {
            IsHarmanKardonSpeakers = isGoodSpeakers;
            isWaterproof = waterproof;
        }

        public bool IsHarmanKardonSpeakers { get;private set; }
        public bool isWaterproof { get;private set; }

        public string makeARealisticPhoto() => $"У вас получилось супер-реалистичное фото!{isWaterproof}";
        public string checkWaterproof()
        {
            if(isWaterproof)
            {
                Random rnd = new Random();

                return rnd.Next(0, 10) % 5 == 0 ? "Вы опускаете телефон в воду и он сгорает :(" : "Вы опускаете телефон в воду и с ним ничего не происходит! Магия :)";
            }
            return "Вы опускаете телефон в воду и он сгорает: (";
        }
    }
}
