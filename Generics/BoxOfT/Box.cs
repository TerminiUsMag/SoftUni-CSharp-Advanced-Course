using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> data;
        public int Count
        {
            get
            {
                return data.Count;
            }
        }
        public Box()
        {
            this.data = new List<T>();
        }

        public void Add(T element)
        {
            data.Add(element);
        }
        public T Remove()
        {
            var removedElement = this.data[this.data.Count - 1];
            this.data.RemoveAt(this.data.Count - 1);
            return removedElement;
        }

    }
}
