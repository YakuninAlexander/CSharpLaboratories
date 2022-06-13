using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public abstract class Model
    {
        // позиция модели в данный момент
        public float posX { get; internal set; }
        public float posY { get; internal set; }

        // занята ли модель
        public bool IsLocked { get; internal set; }
        
        //проверка нужно ли делать действия в потоке
        public bool IsCanceled { get; set; }

        // метод запуска в потоке
        public abstract void Start();

        // для печати сообщений
        public Action<string> Message;

        public Model(Action<string> msg)
        {
            this.Message = msg;
        }
    }
}
