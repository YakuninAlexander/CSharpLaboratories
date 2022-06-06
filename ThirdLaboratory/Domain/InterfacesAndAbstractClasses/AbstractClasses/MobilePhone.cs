using System;
using System.Collections.Generic;
using ThirdLaboratory.Domain.Data.Interfaces;
using ThirdLaboratory.Domain.Data.Enums;

namespace ThirdLaboratory.Domain.Data.AbstractClasses
{
    //Абстрактный класс должен содержать 3-5 свойств и 3-5 методов(включая унаследованные свойства интерфейса). 

    public abstract class MobilePhone : IPhone
    {
        public MobilePhone(int pixels,int price)
        {
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
