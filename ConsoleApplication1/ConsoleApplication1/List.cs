using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class List<T>
    {
        Element<T> head;

        internal Element<T> Head
        {
            get { return head; }
            set { head = value; }
        }
        public List() { }
        public void addfirst(Element<T> e) { e.Next = head;
        this.head = e;
        }
    }
}
