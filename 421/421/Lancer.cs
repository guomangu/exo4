using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421
{

    public class Lancer
    {
        private De[] les3Des = new De[3];

        public Lancer()
        {
            for (int i = 0; i < les3Des.Length; i++)
            {
                les3Des[i] = new De();
                les3Des[i].jeter();
            }

            this.Trier();
        }

        private void Trier()
        {
            bool trier;
            int temp;
            do
            {
                trier = false;
                for (int i = 0; i < les3Des.Length - 1; i++)
                {
                    if (les3Des[i].UNfaceDe < les3Des[i + 1].UNfaceDe)
                    {
                        temp = les3Des[i].UNfaceDe;
                        les3Des[i].UNfaceDe = les3Des[i + 1].UNfaceDe;
                        les3Des[i + 1].UNfaceDe = temp;
                        trier = true;
                    }
                }
            } while (trier == true);
        }
    

        public bool EstGagnant()
        {
            bool resultat = false;

            if (les3Des[0].UNfaceDe == 4 && les3Des[1].UNfaceDe == 2 && les3Des[2].UNfaceDe == 1)
            {
                resultat = true;
            }

            return resultat;
        }

        public void ReLancerUnDe(int _numDe)
        {
            les3Des[_numDe - 1].jeter();
            Trier();
        }

        //public int GetValeurDe(int _numDe)
        //{
        //    return les3Des[_numDe - 1].UNfaceDe;
        //}

        public override string ToString()
        {
            string sworl = "\n" + "\n";
            sworl = "ce lancer est composé de 3 dés :" + "\n" + "\n";

            foreach (var item in this.les3Des)
            {
                sworl += item.ToString() + "\t";
            }
            sworl += "\n" + "\n";

            return sworl;
        }
    }

}
