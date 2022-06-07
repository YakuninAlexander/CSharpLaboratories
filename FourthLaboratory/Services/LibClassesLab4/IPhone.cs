using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClassesLab4
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
