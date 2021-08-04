using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banks
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte A = new Compte(123456,"Haddock",15000,-2000);
            Compte B = new Compte(456789, "Tournesol", 2000, -1000);
            Console.WriteLine(A.ToString());
            Console.WriteLine(B.ToString());
            Console.WriteLine("------------------------------------------------------------------");

            A.Transferer(1000, B);
            Console.WriteLine(A.ToString());
            Console.WriteLine(B.ToString());
            Console.WriteLine("------------------------------------------------------------------");

            Banks bks = new Banks(101, "BNKS");
            bks.ajouterCompte(A);
            bks.ajouterCompte(B);
            Console.WriteLine(bks.ToString());


            Console.ReadKey();
        }

        public class Compte
        {
            private int numero;
            private string nomCli;
            private double solde;
            private double decouvertCli;



            public int Numero { get => numero; }
            public string NomCli { get => nomCli; }
            public double Solde { get => solde; set => solde = value; }
            public double DecouvertCli { get => decouvertCli; set => decouvertCli = value; }



            public Compte(int _numero,string _nomCli,double _solde,double _decouvert)
            {
                this.numero = _numero;
                this.nomCli = _nomCli;
                this.Solde = _solde;
                this.DecouvertCli = _decouvert;
            }

            public Compte()
            {
                this.numero = 00001;
                this.nomCli = "_sansNom";
                this.Solde = 0;
                this.DecouvertCli = 0;
            }



            public override string ToString()
            {
                return this.NomCli+" = "+ this.Solde;
               
            }

            public string Transferer(double _val,Compte _benef)
            {
                if(this.Solde-_val> this.DecouvertCli)
                {
                    this.Solde = this.Solde - _val;
                    _benef.Solde = _benef.Solde + _val;
                    return "trans reussi";
                }
                else
                {
                    return "fond manquant";
                }
            }
        }

        public class Banks
        {
            private int numeroBanks;
            private string nomBanks;
            private int nbComptesBanks;
            private Compte[] comptesBanks = new Compte[10];



            public int NumeroBanks { get => numeroBanks; }
            public string NomBanks { get => nomBanks; }
            public int NbComptesBanks { get => nbComptesBanks; set => nbComptesBanks = value; }
            public Compte[] ComptesBanks { get => comptesBanks; set => comptesBanks = value; }



            public Banks(int _numeroBanks, string _nomBanks)
            {
                this.numeroBanks = _numeroBanks;
                this.nomBanks = _nomBanks;
                this.nbComptesBanks = 0;
              
            }

            public void ajouterCompte(Compte _compte)
            {
                this.ComptesBanks[NbComptesBanks] = _compte;
                this.NbComptesBanks++;
            }

            public void ajouterCompte(int _numeroCompte, double _soldeCompte, string _nomTitulaire, double _decouvert)
            {
                Compte lol = new Compte(_numeroCompte, _nomTitulaire, _soldeCompte, _decouvert);
                this.ajouterCompte(lol);
            }

            public Compte RendCompte(int _numeroCompte)
            {
                bool test = false;
                int indice = 0;
                for (int i = 0; i < this.NbComptesBanks; i++)
                {
                    if(ComptesBanks[i].Numero== _numeroCompte)
                    {
                        test = true;
                        indice = i;
                            
                    }
                }
                if (test)
                {
                    return ComptesBanks[indice];
                }
                else
                {
                    return null;
                }
            }

            public override String ToString()
            {
                string str;
                str="banks n°="+this.NomBanks + " a "+this.NbComptesBanks+ " nombre de comptes a son actif." ;
                for (int i=0; i < this.NbComptesBanks; i++)
                {
                    str = ComptesBanks.ToString() + "\n";
                }

                return str;
            }
        }

    }
}
