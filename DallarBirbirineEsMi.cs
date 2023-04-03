using System;

namespace DallarBirbirineEsitMi
{

    class Node  //Dallari tanimliyoruz
    {
        public int sayi;
        public Node sol, sag;

        public Node(int sayi)
        {
            sayi = sayi;    //Ilk degelerini sifira esitliyoruz
            sol = sag = null;
        }
    }

    class Program
    {
        static bool Aynilarmi(Node a, Node b)   //Dallar ayni mi diye kontrol eden kisim
        {
            if (a == null && b == null)
            {
                return true;
            }
            else if (a == null || b == null)
            {
                return false;
            }
            else if (a.sayi != b.sayi)
            {
                return false;
            }
            else
            {
                return Aynilarmi(a.sol, b.sol) && Aynilarmi(a.sag, b.sag);
            }
        }

        static void Main(string[] args)
        {
            // İlk ikili ağaç oluşturuluyor
            /* Dallardaki atamayi buradan yapiyoruz. 
            Node() ifadesindeki parantez icine istediginiz sayilari girebilirsiniz */
            Node AgacA = new Node(1);
            AgacA.sol = new Node(2);
            AgacA.sag = new Node(3);
            AgacA.sol.sol = new Node(4);
            AgacA.sol.sag = new Node(5);

            // İkinci ikili ağaç oluşturuluyor
            /* Dallardaki atamayi buradan yapiyoruz. 
           Node() ifadesindeki parantez icine istediginiz sayilari girebilirsiniz */
            Node AgacB = new Node(1);
            AgacB.sol = new Node(2);
            AgacB.sag = new Node(3);
            AgacB.sol.sol = new Node(4);
            AgacB.sol.sag = new Node(5);

            // İki ikili ağacın aynı olup olmadığına gore cikti sagliyor
            if (Aynilarmi(AgacA, AgacB))
            {
                Console.WriteLine("Agaclar aynidir.");
            }
            else
            {
                Console.WriteLine("Agaclar ayni degildir.");
            }

            Console.ReadLine();
        }
    }
}