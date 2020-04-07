namespace TP3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Ajout = new System.Windows.Forms.Button();
            this.Grp_Ouv = new System.Windows.Forms.GroupBox();
            this.Dat_Ent = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Grp_Cad = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.Grp_Pat = new System.Windows.Forms.GroupBox();
            this.Txt_Pour = new System.Windows.Forms.TextBox();
            this.Txt_CA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dat_Nais = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Pren = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Mat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Opt_O = new System.Windows.Forms.RadioButton();
            this.Opt_C = new System.Windows.Forms.RadioButton();
            this.Opt_P = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Dg_Emp = new System.Windows.Forms.DataGridView();
            this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.Grp_Ouv.SuspendLayout();
            this.Grp_Cad.SuspendLayout();
            this.Grp_Pat.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Emp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Ajout);
            this.groupBox1.Controls.Add(this.Grp_Ouv);
            this.groupBox1.Controls.Add(this.Grp_Cad);
            this.groupBox1.Controls.Add(this.Grp_Pat);
            this.groupBox1.Controls.Add(this.Dat_Nais);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_Pren);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_Nom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Mat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Opt_O);
            this.groupBox1.Controls.Add(this.Opt_C);
            this.groupBox1.Controls.Add(this.Opt_P);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1148, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employé";
            // 
            // Btn_Ajout
            // 
            this.Btn_Ajout.Location = new System.Drawing.Point(817, 246);
            this.Btn_Ajout.Name = "Btn_Ajout";
            this.Btn_Ajout.Size = new System.Drawing.Size(231, 41);
            this.Btn_Ajout.TabIndex = 14;
            this.Btn_Ajout.Text = "Ajout";
            this.Btn_Ajout.UseVisualStyleBackColor = true;
            this.Btn_Ajout.Click += new System.EventHandler(this.Btn_Ajout_Click);
            // 
            // Grp_Ouv
            // 
            this.Grp_Ouv.Controls.Add(this.Dat_Ent);
            this.Grp_Ouv.Controls.Add(this.label8);
            this.Grp_Ouv.Location = new System.Drawing.Point(788, 92);
            this.Grp_Ouv.Name = "Grp_Ouv";
            this.Grp_Ouv.Size = new System.Drawing.Size(314, 127);
            this.Grp_Ouv.TabIndex = 13;
            this.Grp_Ouv.TabStop = false;
            // 
            // Dat_Ent
            // 
            this.Dat_Ent.Location = new System.Drawing.Point(29, 80);
            this.Dat_Ent.Name = "Dat_Ent";
            this.Dat_Ent.Size = new System.Drawing.Size(225, 22);
            this.Dat_Ent.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Date d\'entrer : ";
            // 
            // Grp_Cad
            // 
            this.Grp_Cad.Controls.Add(this.radioButton7);
            this.Grp_Cad.Controls.Add(this.radioButton6);
            this.Grp_Cad.Controls.Add(this.radioButton5);
            this.Grp_Cad.Controls.Add(this.radioButton4);
            this.Grp_Cad.Controls.Add(this.label7);
            this.Grp_Cad.Location = new System.Drawing.Point(598, 90);
            this.Grp_Cad.Name = "Grp_Cad";
            this.Grp_Cad.Size = new System.Drawing.Size(163, 186);
            this.Grp_Cad.TabIndex = 12;
            this.Grp_Cad.TabStop = false;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(83, 136);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(37, 21);
            this.radioButton7.TabIndex = 4;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "4";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(83, 109);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(37, 21);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "3";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(83, 82);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(37, 21);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "2";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(83, 55);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 21);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "1";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Indice :";
            // 
            // Grp_Pat
            // 
            this.Grp_Pat.Controls.Add(this.Txt_Pour);
            this.Grp_Pat.Controls.Add(this.Txt_CA);
            this.Grp_Pat.Controls.Add(this.label6);
            this.Grp_Pat.Controls.Add(this.label5);
            this.Grp_Pat.Location = new System.Drawing.Point(383, 90);
            this.Grp_Pat.Name = "Grp_Pat";
            this.Grp_Pat.Size = new System.Drawing.Size(200, 186);
            this.Grp_Pat.TabIndex = 11;
            this.Grp_Pat.TabStop = false;
            // 
            // Txt_Pour
            // 
            this.Txt_Pour.Location = new System.Drawing.Point(26, 146);
            this.Txt_Pour.Name = "Txt_Pour";
            this.Txt_Pour.Size = new System.Drawing.Size(149, 22);
            this.Txt_Pour.TabIndex = 3;
            // 
            // Txt_CA
            // 
            this.Txt_CA.Location = new System.Drawing.Point(26, 71);
            this.Txt_CA.Name = "Txt_CA";
            this.Txt_CA.Size = new System.Drawing.Size(149, 22);
            this.Txt_CA.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pourcentage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chiffre d\'Affaire";
            // 
            // Dat_Nais
            // 
            this.Dat_Nais.Location = new System.Drawing.Point(118, 214);
            this.Dat_Nais.Name = "Dat_Nais";
            this.Dat_Nais.Size = new System.Drawing.Size(223, 22);
            this.Dat_Nais.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(33, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 44);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date de Naissance :";
            // 
            // Txt_Pren
            // 
            this.Txt_Pren.Location = new System.Drawing.Point(118, 143);
            this.Txt_Pren.Name = "Txt_Pren";
            this.Txt_Pren.Size = new System.Drawing.Size(223, 22);
            this.Txt_Pren.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prénom : ";
            // 
            // Txt_Nom
            // 
            this.Txt_Nom.Location = new System.Drawing.Point(118, 115);
            this.Txt_Nom.Name = "Txt_Nom";
            this.Txt_Nom.Size = new System.Drawing.Size(223, 22);
            this.Txt_Nom.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom :";
            // 
            // Txt_Mat
            // 
            this.Txt_Mat.Location = new System.Drawing.Point(118, 87);
            this.Txt_Mat.Name = "Txt_Mat";
            this.Txt_Mat.Size = new System.Drawing.Size(223, 22);
            this.Txt_Mat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matricule : ";
            // 
            // Opt_O
            // 
            this.Opt_O.AutoSize = true;
            this.Opt_O.Location = new System.Drawing.Point(992, 39);
            this.Opt_O.Name = "Opt_O";
            this.Opt_O.Size = new System.Drawing.Size(76, 21);
            this.Opt_O.TabIndex = 2;
            this.Opt_O.TabStop = true;
            this.Opt_O.Text = "Ouvrier";
            this.Opt_O.UseVisualStyleBackColor = true;
            this.Opt_O.CheckedChanged += new System.EventHandler(this.Opt_O_CheckedChanged);
            // 
            // Opt_C
            // 
            this.Opt_C.AutoSize = true;
            this.Opt_C.Location = new System.Drawing.Point(822, 39);
            this.Opt_C.Name = "Opt_C";
            this.Opt_C.Size = new System.Drawing.Size(67, 21);
            this.Opt_C.TabIndex = 1;
            this.Opt_C.TabStop = true;
            this.Opt_C.Text = "Cadre";
            this.Opt_C.UseVisualStyleBackColor = true;
            this.Opt_C.CheckedChanged += new System.EventHandler(this.Opt_C_CheckedChanged);
            // 
            // Opt_P
            // 
            this.Opt_P.AutoSize = true;
            this.Opt_P.Location = new System.Drawing.Point(647, 39);
            this.Opt_P.Name = "Opt_P";
            this.Opt_P.Size = new System.Drawing.Size(71, 21);
            this.Opt_P.TabIndex = 0;
            this.Opt_P.TabStop = true;
            this.Opt_P.Text = "Patron";
            this.Opt_P.UseVisualStyleBackColor = true;
            this.Opt_P.CheckedChanged += new System.EventHandler(this.Opt_P_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Dg_Emp);
            this.groupBox5.Location = new System.Drawing.Point(12, 320);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1148, 379);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Liste des employés :";
            // 
            // Dg_Emp
            // 
            this.Dg_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricule,
            this.nom,
            this.prenom,
            this.dateNaissance,
            this.salaire});
            this.Dg_Emp.Location = new System.Drawing.Point(21, 34);
            this.Dg_Emp.Name = "Dg_Emp";
            this.Dg_Emp.RowHeadersWidth = 51;
            this.Dg_Emp.RowTemplate.Height = 24;
            this.Dg_Emp.Size = new System.Drawing.Size(1103, 324);
            this.Dg_Emp.TabIndex = 0;
            // 
            // matricule
            // 
            this.matricule.HeaderText = "Matricule";
            this.matricule.MinimumWidth = 6;
            this.matricule.Name = "matricule";
            this.matricule.Width = 125;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.Width = 125;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.MinimumWidth = 6;
            this.prenom.Name = "prenom";
            this.prenom.Width = 125;
            // 
            // dateNaissance
            // 
            this.dateNaissance.HeaderText = "Date de Naissance";
            this.dateNaissance.MinimumWidth = 6;
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Width = 125;
            // 
            // salaire
            // 
            this.salaire.HeaderText = "Salaire";
            this.salaire.MinimumWidth = 6;
            this.salaire.Name = "salaire";
            this.salaire.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 711);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gestion des employés";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Grp_Ouv.ResumeLayout(false);
            this.Grp_Ouv.PerformLayout();
            this.Grp_Cad.ResumeLayout(false);
            this.Grp_Cad.PerformLayout();
            this.Grp_Pat.ResumeLayout(false);
            this.Grp_Pat.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Emp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Ajout;
        private System.Windows.Forms.GroupBox Grp_Ouv;
        private System.Windows.Forms.DateTimePicker Dat_Ent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox Grp_Cad;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox Grp_Pat;
        private System.Windows.Forms.TextBox Txt_Pour;
        private System.Windows.Forms.TextBox Txt_CA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Dat_Nais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Pren;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Mat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Opt_O;
        private System.Windows.Forms.RadioButton Opt_C;
        private System.Windows.Forms.RadioButton Opt_P;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView Dg_Emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaire;
    }
}

