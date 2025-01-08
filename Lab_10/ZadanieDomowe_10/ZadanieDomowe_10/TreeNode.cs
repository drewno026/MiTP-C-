using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10
{
    partial class TreeNode
    {
        public int Val { get; set; } // wartosc przechowywana w wezle
        public TreeNode Left { get; set; } // wezel na lewo od obecnego ("dziecko")
        public TreeNode Right { get; set; } // wezel na prawo od obecnego ("dziecko")
        public TreeNode Up { get; set; } // wezel w gore od obecnego ("rodzic")

        public TreeNode(int v) // konstruktor do tworzenia nowych wezlow
        {
            Val = v;
            Left = Right = Up = null;
        }

        private TreeNode(int v, TreeNode parent) // konstruktor prywatny, uzywany dla wygody
        {
            Val = v;
            Left = Right = null;
            Up = parent;
        }

        public void Add(int v) // rekurencyjna metoda pozwalajaca dodawac nowe wezly
        {
            if (v >= Val) // idziemy w prawo
            {
                if (Right == null) Right = new TreeNode(v, this); // jezeli miejsce po prawej jest wolne - stworz nowy wezel tam
                else Right.Add(v); // jezeli nie - kolejne wywolanie rekurencyjne
            }
            else // idziemy w lewo
            {
                if (Left == null) Left = new TreeNode(v, this); // jezeli miejsce po lewej jest wolne - stworz nowy wezel tam
                else Left.Add(v); // jezeli nie - kolejne wywolanie rekurencyjne
            }
        }

        public bool Search(int v) // rekurencyjna metoda pozwalajaca sprawdzac czy wezel o danej wartosci istnieje
        {
            if (v == Val) return true; 
            else if (v > Val && Right != null) return Right.Search(v); // szukana wartosc jest wieksza - szukaj dalej po prawej
            else if (v < Val && Left != null) return Left.Search(v); // szukana wartosc jest mniejsza - szukaj dalej po lewej
            return false; // nie ma juz gdzie dalej szukac, a wartosci nie znaleziono - zwracamy false
        }
        public int MaxValue()
        {
            if (Right == null)
                return Val;
            return Right.MaxValue();
        }
        public int MinValue()
        {
            if (Left == null)
                return Val;
            return Left.MinValue();
        }
        public int SumValues()
        {
            int sum = Val;
            if (Left != null)
                sum = sum + Left.SumValues();
            if (Right != null)
                sum = sum + Right.SumValues();
            return sum;
        }
        public int CountAllNodes()
        {
            int nodes = 1;
            if (Left != null)
                nodes = nodes + Left.CountAllNodes();
            if (Right != null)
                nodes = nodes + Right.CountAllNodes();
            return nodes;
        }
        public int CountAllLinks()
        {
            int links = CountAllNodes();
            return links - 1;
        }
    }
}
