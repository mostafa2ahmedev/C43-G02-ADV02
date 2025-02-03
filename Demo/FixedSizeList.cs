using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class FixedSizeList<T>
    {

        List<T> list;



        public FixedSizeList(int capacity)
        {
            list = new List<T>(capacity);
        }


        public void Add(T item)
        {
            if (list.Count >= list.Capacity) {
                throw new Exception();
            }
            list.Add(item);

        }
        public T Get(int index) {
            if (index < 0 || index >= list.Count) {
                throw new Exception();
            }
            return list[index];

        }
    }
}
