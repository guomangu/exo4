using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emprunt;

namespace AppEmprunt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMens_Click(object sender, EventArgs e)
        {
            double capital=double.Parse( this.txtcapitalEmprunte.Text);
            double taux = double.Parse(this.txtinteretAnnuel.Text);
            int nbAnnee = int.Parse(this.txtnbAnneeRembourse.Text);

            Credit monCredit = new Credit(taux,nbAnnee,capital);
            double lol = monCredit.CalculMens();
            this.txtmensualite.Text = lol.ToString();
        }
    }
}
