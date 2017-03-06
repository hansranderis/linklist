using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linklist
{
    class MyList
    {
        public int count { get; private set; }
        private Node Head;
        public void Insert(object data)
        {
            Node n = new Node();
            n.Data = data;
            n.Next = Head;
            Head = n;
            count++;
        }

        public void Insert(object data,int index)
        {
            if (index > count) index = count;
            if (index <= 0) Insert(data);
            else
            {
                Node position = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    position = position.Next;
                }
                Node n = new Node();
                n.Data = data;
                n.Next = position.Next;
                position.Next = n;
                count++;
            }
        }
        public void Delete()
        {
            if (count > 0)
            {
                Head = Head.Next;
                count--;
            }
        }

        public void Delete(int index)
        {
            if (index > count) index = count;
            if (index <= 0) Delete();
            else
            {
                Node position = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    position = position.Next;
                }
                position.Next = position.Next.Next;
                count--;
            }
        }

        public override string ToString()
        {
            string result = "";
            Node pointernode = Head;
            while(pointernode != null)
            {
                result = result + pointernode.Data.ToString() +"\n";

                pointernode = pointernode.Next;
            }
            return result;
        }
    }
}
