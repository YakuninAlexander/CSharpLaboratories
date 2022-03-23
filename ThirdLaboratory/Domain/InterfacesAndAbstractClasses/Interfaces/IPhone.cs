using System;
using Messages.Interfaces;
using ThirdLaboratory.Domain.Data.Classes;
using ThirdLaboratory.Domain.Data.Enums;

namespace ThirdLaboratory.Domain.Data.Interfaces
{

    //Для интерфейса необходимо определить 1 свойство и 2 метода. 

    public interface IPhone
    {
        public string OwnNumber { get; set; }
        public PowerStatus Power { get; set; }
        public IMessage call(Number number);
        public void powerSwitch();
    }
}
