using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{
    class MyList <T>
    {
        private <T>[] items = new <T>[10];
        private int length;

        public int Size()
        {
            return length;
        }

        public bool IsEmpty()
        {
            return length == 0;
        }

        public <T> Get(int index)
        {
            if(index > length)
            {
                throw new Exception("Выход за длину списка"); 
            }
            else
            {
                return items[index];
            }
        }

        public void Set(int index, <T> value)
        {
            if(index > length)
            {
                throw new Exception("Выход за длину списка"); 
            }
            else
            {
                items[index] = value;
            }
        }
        
        public void Add(<T> value)
        {
            if (length >= items.length)
            {
                IncreaseCapacity();
            }
            items[length] = value;
            ++length;
        }
        private void IncreaseCapacity()
        {
            < T > oldItem = items;
            items = new <T>[oldItem.length * 2];
            //TODO реализовать вставку элементов в массив
        }
    }
}
