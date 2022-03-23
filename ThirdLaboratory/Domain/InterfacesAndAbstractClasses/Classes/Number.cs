using System;
using System.Collections.Generic;

namespace ThirdLaboratory.Domain.Data.Classes
{
    public class Number
    {
        public KeyValuePair<string, string> Person { get; set; } //Surname - number

        public Number(string surname, string number)
        {
            Person = new KeyValuePair<string, string>(surname, number);
        }
    }
}
