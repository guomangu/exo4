using System;

namespace Emprunt
{
    public class Credit
    {

        private double tauxInteretAnnuel;
        private int nbrAnneeRbmt;
        private double capitalEmprunte;
        private double tauxInteretmensuel;
        private double mensualite;
        private int mois;
        private double interetsMensuel;
        private double amortissementMois;

        private double partInteret;
        private double partCapital;
        private double restantDu;
        private int i;





        public double TauxInteretAnnuel { get => tauxInteretAnnuel; set => tauxInteretAnnuel = value; }
        public int NbrAnneeRbmt { get => nbrAnneeRbmt; set => nbrAnneeRbmt = value; }
        public double CapitalEmprunte { get => capitalEmprunte; set => capitalEmprunte = value; }
        public double TauxInteretmensuel { get => tauxInteretmensuel; set => tauxInteretmensuel = value; }
        public double Mensualite { get => mensualite; set => mensualite = value; }
        public int Mois { get => mois; set => mois = value; }
        public double InteretsMensuel { get => interetsMensuel; set => interetsMensuel = value; }
        public double AmortissementMois { get => amortissementMois; set => amortissementMois = value; }

        public double PartInteret { get => partInteret; set => partInteret = value; }
        public double PartCapital { get => partCapital; set => partCapital = value; }
        public double RestantDu { get => restantDu; set => restantDu = value; }
        public int I { get => i; set => i = value; }






        public Credit()
        {
            TauxInteretAnnuel = 1.4;
            Mois = 24;
            CapitalEmprunte = 4000;
        }

        public Credit(double _tauxInteretAnnuel, int _nbrAnneeRbmt, double _capitalEmprunte)
        {
            TauxInteretAnnuel = _tauxInteretAnnuel / 100;
            TauxInteretmensuel = TauxInteretAnnuel / 12;
            Mois = _nbrAnneeRbmt * 12;
            NbrAnneeRbmt = _nbrAnneeRbmt;
            CapitalEmprunte = _capitalEmprunte;
        }

        public Credit(int _idMois, double lol1, double lol2, double lol3, double lol4)
        {
            I = _idMois;
            PartInteret = lol2;
            PartCapital = lol1;
            RestantDu = lol3;
            Mensualite = lol4;
        }







        public double CalculMens()
        {
            double Q = (1 - Math.Pow((1 + TauxInteretmensuel), -Mois));

            double a = (CapitalEmprunte * TauxInteretmensuel) / Q;
            return Math.Round(a, 2);
        }






        public double [,] TabAmor()
        {
            // AmortissementMois=CapitalEmprunte / Mois;
            double mensualite = this.CalculMens();
            double restantDu = this.capitalEmprunte;
            double partInteret;
            double partCapital;


            //List<Emprunt> god = new List<Emprunt>();
            double[,] tab2D = new double[Mois, 5];


            for (int i = 0; i < Mois; i++)
            {
                partInteret = restantDu * TauxInteretmensuel;
                partCapital = mensualite - partInteret;
                restantDu = restantDu - partCapital;

                //Console.WriteLine(i+"//"+ Math.Round(partInteret,1) + "//"+ Math.Round(partCapital,1) + "//"+ Math.Round(restantDu,0) + "//"+ Math.Round(mensualite,0));

                //var godmode = new Emprunt(i, Math.Round(partInteret, 1), Math.Round(partCapital, 1), Math.Round(restantDu, 0), Math.Round(mensualite, 0));
                //god.Add(godmode);

                tab2D[i, 0] = i;
                tab2D[i, 1] = Math.Round(partInteret, 1);
                tab2D[i, 2] = Math.Round(partCapital, 1);
                tab2D[i, 3] = Math.Round(restantDu, 0);
                tab2D[i, 4] = Math.Round(mensualite, 0);
            }

            //foreach (var item in god)
            //{
            //    Console.WriteLine(item.I + "||" + item.PartInteret + "||" + item.PartCapital + "||" + item.RestantDu + "||" + item.Mensualite);
            //}

            return tab2D;

            //for (int y = 0; y < Mois; y++)
            //{
            //    Console.WriteLine(tab2D[y, 0] + "||" + tab2D[y, 1] + "||" + tab2D[y, 2] + "||" + tab2D[y, 3] + "||" + tab2D[y, 4]);
            //}
        }
    }
}
