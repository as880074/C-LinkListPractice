using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListPractice
{
    public class Node<T>
    {
        /// <summary>
        /// 節點的資料
        /// </summary>
        public T Value { get; set; }
        /// <summary>
        /// 下一個節點
        /// </summary>
        public Node<T> NextNode { get; set; }
        public Node(T data) 
        {
            Value = data;
            NextNode = null;
        }
    }
}
