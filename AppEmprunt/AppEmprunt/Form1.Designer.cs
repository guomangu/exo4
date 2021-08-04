namespace AppEmprunt
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltauxinteret = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtinteretAnnuel = new System.Windows.Forms.TextBox();
            this.txtnbAnneeRembourse = new System.Windows.Forms.TextBox();
            this.txtcapitalEmprunte = new System.Windows.Forms.TextBox();
            this.txtmensualite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltauxinteret
            // 
            this.lbltauxinteret.AutoSize = true;
            this.lbltauxinteret.Location = new System.Drawing.Point(298, 167);
            this.lbltauxinteret.Name = "lbltauxinteret";
            this.lbltauxinteret.Size = new System.Drawing.Size(90, 13);
            this.lbltauxinteret.TabIndex = 0;
            this.lbltauxinteret.Text = "tauxInteretAnnuel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nbAnneeRembourse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "capitalEmprunte";
            // 
            // txtinteretAnnuel
            // 
            this.txtinteretAnnuel.Location = new System.Drawing.Point(394, 164);
            this.txtinteretAnnuel.Name = "txtinteretAnnuel";
            this.txtinteretAnnuel.Size = new System.Drawing.Size(100, 20);
            this.txtinteretAnnuel.TabIndex = 3;
            // 
            // txtnbAnneeRembourse
            // 
            this.txtnbAnneeRembourse.Location = new System.Drawing.Point(394, 190);
            this.txtnbAnneeRembourse.Name = "txtnbAnneeRembourse";
            this.txtnbAnneeRembourse.Size = new System.Drawing.Size(100, 20);
            this.txtnbAnneeRembourse.TabIndex = 4;
            // 
            // txtcapitalEmprunte
            // 
            this.txtcapitalEmprunte.Location = new System.Drawing.Point(394, 216);
            this.txtcapitalEmprunte.Name = "txtcapitalEmprunte";
            this.txtcapitalEmprunte.Size = new System.Drawing.Size(100, 20);
            this.txtcapitalEmprunte.TabIndex = 5;
            // 
            // txtmensualite
            // 
            this.txtmensualite.Location = new System.Drawing.Point(394, 293);
            this.txtmensualite.Name = "txtmensualite";
            this.txtmensualite.ReadOnly = true;
            this.txtmensualite.Size = new System.Drawing.Size(100, 20);
            this.txtmensualite.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "mensualité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(391, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "crée objet";
            // 
            // btnMens
            // 
            this.btnMens.Location = new System.Drawing.Point(394, 252);
            this.btnMens.Name = "btnMens";
            this.btnMens.Size = new System.Drawing.Size(147, 23);
            this.btnMens.TabIndex = 10;
            this.btnMens.Text = "Calculer  mensualité";
            this.btnMens.UseVisualStyleBackColor = true;
            this.btnMens.Click += new System.EventHandler(this.btnMens_Click);
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMens);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmensualite);
            this.Controls.Add(this.txtcapitalEmprunte);
            this.Controls.Add(this.txtnbAnneeRembourse);
            this.Controls.Add(this.txtinteretAnnuel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltauxinteret);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.BackColor = System.Drawing.Color.White;

        }

        #endregion

        private System.Windows.Forms.Label lbltauxinteret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtinteretAnnuel;
        private System.Windows.Forms.TextBox txtnbAnneeRembourse;
        private System.Windows.Forms.TextBox txtcapitalEmprunte;
        private System.Windows.Forms.TextBox txtmensualite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMens;
    }
}

