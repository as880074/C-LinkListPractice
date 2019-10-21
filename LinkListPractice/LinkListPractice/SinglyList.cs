using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListPractice
{
    public class SinglyList<T>
    {
        public Node<T> HeadNode;
        public Node<T> TailNode;
        public Node<T> PtrNode;

        public  SinglyList() 
        {
            HeadNode = null;
            TailNode = null;
            PtrNode = null;
        }
        public void Add(T data) 
        {
            var ptData = new Node<T>(data);
            if (HeadNode is null)
            {
                HeadNode = TailNode=ptData;
            }
            else 
            {
                TailNode.NextNode = ptData;
                TailNode = ptData;
            }
        }
        public IEnumerable<T> ToList()
        {
            if (HeadNode is null)
            {
                yield return default(T);
            }
            else 
            {
                PtrNode = HeadNode;
                while (! (PtrNode is null) ) 
                {
                    var data = PtrNode.Value;
                    PtrNode = PtrNode.NextNode;
                    yield return data;
                }
            }
        }
    }
}
