using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCSharp
{
    public class Node
    {
        public Node(object data, Node next = null)
        {
            Next = next;
            Data = data;
        }

        public object Data { get; set; }
        public Node Next { get; set; }

        public override bool Equals(object obj)
        {
            var item = obj as Node;
            if (item == null)
            {
                return false;
            }
            return this.Data.Equals(item.Data);
        }
    }
}
