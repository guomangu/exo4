using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421
{
    class Partie
    {
        private Lancer manche;
        private int nbMaxLancer=3;
        private int nbPoints;
        private int numLancer;
        private int nbManche;

       // public Lancer UNmanche { get => manche; set => manche = value; }
        public int UNnbMaxLancer { get => nbMaxLancer; set => nbMaxLancer = value; }
        public int UNnbPoints { get => nbPoints; set => nbPoints = value; }
        public int UNnumLancer { get => numLancer; set => numLancer = value; }
        public int UNnbManche { get => nbManche; set => nbManche = value; }

        public void MajPoint(int a,int b)
        {
            if (manche.EstGagnant() == true)
            {
                this.UNnbPoints += a;
            }
            else
            {
                this.UNnbPoints -= b;
            }
        }

        public bool EstPerdue()
        {
            if (UNnbPoints <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void NouveauLancer(int lol)
        {
            this.UNnumLancer++;
          
            manche.ReLancerUnDe(lol);
        }

        public Partie(int _nb)
        {
            Console.WriteLine("Combien de manche voulez vous joué ?");
            string mdr999 = Console.ReadLine();
            int mdr666;
            int.TryParse(mdr999, out mdr666);

            int nbMancheVoulu = mdr666;
            mdr666 = mdr666 * 10;
            int lol666 = mdr666 / 3;


            if (UNnumLancer==0)
            {
                manche = new Lancer();
                UNnbPoints = mdr666;
            }

            this.nbManche = 0;
            bool pop = true;
            do
            {

                UNnumLancer = 0;

                bool pip = true;
                do
                {
                    Console.WriteLine(manche);





                    Console.WriteLine("Combien de de voulez vous lancer ?");
                    string mdr3 = Console.ReadLine();
                    int mdr4;
                    int.TryParse(mdr3, out mdr4);

                    if (mdr4==1)
                    {
                        Console.WriteLine("Quel de voulez vous lancer ?");
                        string mdr5 = Console.ReadLine();
                        int mdr6;
                        int.TryParse(mdr5, out mdr6);

                        this.NouveauLancer(mdr6);

                        UNnumLancer++;
                    }
                    else if (mdr4==2)
                    {
                        Console.WriteLine("Quel de voulez vous lancer ?   1/2");
                        string mdr7 = Console.ReadLine();
                        int mdr8;
                        int.TryParse(mdr7, out mdr8);

                        Console.WriteLine("Quel de voulez vous lancer ?   2/2");
                        string mdr9 = Console.ReadLine();
                        int mdr10;
                        int.TryParse(mdr9, out mdr10);

                        this.NouveauLancer(mdr8);
                        this.NouveauLancer(mdr10);
                        Console.WriteLine(manche);

                        UNnumLancer++;
                    }
                    else
                    {
                        this.NouveauLancer(1);
                        this.NouveauLancer(2);
                        this.NouveauLancer(3);

                        Console.WriteLine(manche);
                        UNnumLancer++;
                    }





                    if ( UNnumLancer<UNnbMaxLancer)
                    {
                      if(manche.EstGagnant() == true)
                        {
                            pip = false;
                            Console.WriteLine("manche gagner c'etait votre derniere chance");
                        }
                        else
                        {
                            pip = false;
                            Console.WriteLine("manche perdu");
                        }
                    }
                    else
                    {
                        if (manche.EstGagnant() == true)
                        {
                            pip = false;
                            Console.WriteLine("manche gagner avec de l'avance bg");
                        }
                        else
                        {
                            //      \^_^/      //
                        }
                    }




                } while (pip==true);

                this.MajPoint(mdr666,lol666);
                Console.WriteLine("Vous avez "+UNnbPoints+" points.");

                this.UNnbManche++;
                if (this.UNnbPoints<=0)
                {
                    pop = false;
                    Console.WriteLine("partie perdu");
                }
                else if (this.UNnbManche > nbMancheVoulu)
                {
                    pop = false;
                    Console.WriteLine("partie gagner");
                }
            } while (pop==true);
        }
    }
}
