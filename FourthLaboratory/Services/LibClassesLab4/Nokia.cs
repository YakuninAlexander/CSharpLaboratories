using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClassesLab4
{
    public class Nokia : MobilePhone
    {
        public Nokia(int countOfBricks, int years, string number, int pixels, int price) : base(pixels, price, number)
        {
            OwnNumber = number;
            CountOfDestroyBricks = countOfBricks;
            CountOfYearsCanWork = years;
        }
        public Nokia() :base()
        {
            CountOfDestroyBricks=0;
            CountOfYearsCanWork=0;
        }
        

        public int CountOfDestroyBricks { get; private set; } //количество кирпичей которые может сломать
        public int CountOfYearsCanWork { get; private set; } //количество лет сколько может работать от одного заряда

        public string destroyBricks(int bricks) =>
            CountOfDestroyBricks >= bricks ? "Вы сломали все кирпичи. Удивительно но на нокии ни царапинки!" : "К сожалению нокии не удалось справиться с таким количетсвом кирпичей :(";

        public string knowYearOfCreation() => "Даже динозавры знают про великую Нокию!";

        public override string sendMessage(string text, string number) => $"Send {text} on number {number}!";
    }
}
