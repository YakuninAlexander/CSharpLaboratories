using System;
using Messages.Interfaces;
using Messages;
using System.Collections.Generic;
using ThirdLaboratory.Domain.Data.Interfaces;
using ThirdLaboratory.Domain.Data.Classes;
using ThirdLaboratory.Domain.Data.Enums;

namespace ThirdLaboratory.Domain.Data.AbstractClasses
{
    //Абстрактный класс должен содержать 3-5 свойств и 3-5 методов(включая унаследованные свойства интерфейса). 

    public abstract class MobilePhone : IPhone
    {
        public List<Number> PhoneCatalog { get; set; }
        public int Price { get; set; }

        public abstract IMessage sendMessage(string text, Number number);

        #region IPhone implements
        public string OwnNumber { get; set; }
        public PowerStatus Power { get; set; }

        public IMessage call(Number number)
        {
            IMessage msg = new MessageStream("Вызван номер " + number.Person.Key + "!");
            return msg;
        }

        public void powerSwitch()
        {
            Power = Power == PowerStatus.On ? PowerStatus.Off : PowerStatus.On;
        }
        #endregion
    }
}
