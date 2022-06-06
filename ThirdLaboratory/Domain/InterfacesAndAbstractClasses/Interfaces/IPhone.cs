using System;
using ThirdLaboratory.Domain.Data.Enums;

namespace ThirdLaboratory.Domain.Data.Interfaces
{

    //Для интерфейса необходимо определить 1 свойство и 2 метода. 

    public interface IPhone
    {
        public string OwnNumber { get; set; }
        public bool Power { get; set; }
        public string call(string number);
        public void powerSwitch();
    }
}
