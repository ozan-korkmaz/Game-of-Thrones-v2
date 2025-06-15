using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Thrones
{
    internal class BST
    {
        private BSTNode root;

        public void Ekle(Esya item)
        {
            root = EkleRec(root, item);
        }

        private BSTNode EkleRec(BSTNode node, Esya item)
        {
            if (node == null)
                return new BSTNode(item);

            int cmp = string.Compare(item.Ad, node.Data.Ad, StringComparison.OrdinalIgnoreCase);

            if (cmp < 0)
                node.Left = EkleRec(node.Left, item);
            else if (cmp > 0)
                node.Right = EkleRec(node.Right, item);

            return node;
        }

        public bool Ara(string ad)
        {
            return AraRec(root, ad);
        }

        private bool AraRec(BSTNode node, string ad)
        {
            if (node == null)
                return false;

            int cmp = string.Compare(ad, node.Data.Ad, StringComparison.OrdinalIgnoreCase);

            if (cmp == 0)
                return true;
            else if (cmp < 0)
                return AraRec(node.Left, ad);
            else
                return AraRec(node.Right, ad);
        }

        public void Sirala()
        {
            Console.WriteLine("📦 Eşyalar (A-Z sıralı):");
            InOrderRec(root);
        }

        private void InOrderRec(BSTNode node)
        {
            if (node != null)
            {
                InOrderRec(node.Left);
                Console.WriteLine("- " + node.Data.Ad);
                InOrderRec(node.Right);
            }
        }

    }
}
