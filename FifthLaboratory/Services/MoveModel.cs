using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    //класс движущихся моделей
    public abstract class MoveModel : Model
    {
        // места ожидания моделей
        public float defaultX, defaultY;

        // движение можелей к какой точке
        public float ToX { get; internal set; }
        public float ToY { get; internal set; }

        public MoveModel(Action<string> msg, float defaultX, float defaultY)
            : base(msg)
        {
            this.defaultX = defaultX;
            this.defaultY = defaultY;

            posX = defaultX;
            posY = defaultY;

            ToX = defaultX;
            ToY = defaultY;
            
            DoSomething = null;
        }

        
        public string Name { get; set; }

        // константа движения
        const float moveConst = 3;

        // делегат
        public Action DoSomething;

        //проверка событий
        protected abstract void Check();

        //проверка прихода
        public bool IsCome()
        {
            return Math.Abs(posX - ToX) < 5 && Math.Abs(posY - ToY) < 5;
        }

        public void Move()
        {
            if (IsCome())
                return;

            //движение
            if (posX - ToX != 0)
            {
                posY += moveConst * (ToY - posY) / Math.Abs(posX - ToX);
                posX += moveConst * Math.Sign(ToX - posX);
            }
            else
            {
                posX += moveConst * (ToX - posX) / Math.Abs(posY - ToY);
                posY += moveConst * Math.Sign(posY - ToY);
            }
        }

        //старт
        public override void Start()
        {
            while (!IsCanceled)
            {
                Check();
                Move();

                DoSomething?.Invoke();

                Task.Delay(30).Wait();
            }
        }
    }
}
