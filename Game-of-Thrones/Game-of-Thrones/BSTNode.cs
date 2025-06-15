using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Thrones
{
    internal class BSTNode
    {
        public Esya Data { get; set; }
        public BSTNode Left { get; set; }
        public BSTNode Right { get; set; }

        public BSTNode(Esya data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
