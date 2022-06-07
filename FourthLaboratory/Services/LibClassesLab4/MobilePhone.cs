using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClassesLab4
{
    //Абстрактный класс должен содержать 3-5 свойств и 3-5 методов(включая унаследованные свойства интерфейса). 

    public abstract class MobilePhone : IPhone
    {
        public MobilePhone()
        {
            OwnNumber = "0";
            Price = 0;
            CameraPixels = 0;
        }
        public MobilePhone(int pixels, int price, string number)
        {
            OwnNumber = number;
            Price = price;
            CameraPixels = pixels;
        }

        public int CameraPixels { get; set; }
        public int Price { get; set; }

        public abstract string sendMessage(string text, string number);

        #region IPhone implements

        public string OwnNumber { get; set; }
        public bool Power { get; set; }
        public void powerSwitch() => Power = !Power;
        public string call(string number) => $"Вызываем номер {number}";

        #endregion
    }
}
