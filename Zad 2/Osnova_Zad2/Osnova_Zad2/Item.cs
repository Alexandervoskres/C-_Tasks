using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osnova_Zad2
{
    abstract class Item
    {
        protected long invNumber; // инвентарный номер – целое число
        protected bool taken; // хранит состояние объекта – имеется

        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }
        public Item()
        {
            this.taken = true;
        }
        public bool IsAvailable() // истина, если предмет имеется в библиотеке
        {
            if (taken == true) return true; else return false;
        }
        public long GetInvNumber() // инвентарный номер
        {
            return invNumber;
        }
        public void Take() // операция "взять"
        {
            taken = false;
        }
        abstract public void Return();
        public virtual void Show()
        {
            Console.WriteLine(" Состояние единицы хранения:\n Инвентарный номер:{0}\n Наличие:{1}", invNumber, taken);

        }
        public void TakeItem()
        {
            if (this.IsAvailable()) this.Take();
        }


    }
}
