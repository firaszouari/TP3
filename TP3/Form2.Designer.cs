namespace TP3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Opt_O = new System.Windows.Forms.RadioButton();
            this.Opt_C = new System.Windows.Forms.RadioButton();
            this.Opt_P = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dg_Ouvrier = new System.Windows.Forms.DataGridView();
            this.mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEntrer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dg_Cadre = new System.Windows.Forms.DataGridView();
            this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dg_Patron = new System.Windows.Forms.DataGridView();
            this.matricul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiffreAffaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pourcentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Ouvrier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Cadre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Patron)).BeginInit();
            this.SuspendLayout();
            // 
            // Opt_O
            // 
            this.Opt_O.AutoSize = true;
            this.Opt_O.Location = new System.Drawing.Point(716, 29);
            this.Opt_O.Name = "Opt_O";
            this.Opt_O.Size = new System.Drawing.Size(76, 21);
            this.Opt_O.TabIndex = 5;
            this.Opt_O.TabStop = true;
            this.Opt_O.Text = "Ouvrier";
            this.Opt_O.UseVisualStyleBackColor = true;
            this.Opt_O.CheckedChanged += new System.EventHandler(this.Opt_O_CheckedChanged);
            // 
            // Opt_C
            // 
            this.Opt_C.AutoSize = true;
            this.Opt_C.Location = new System.Drawing.Point(546, 29);
            this.Opt_C.Name = "Opt_C";
            this.Opt_C.Size = new System.Drawing.Size(67, 21);
            this.Opt_C.TabIndex = 4;
            this.Opt_C.TabStop = true;
            this.Opt_C.Text = "Cadre";
            this.Opt_C.UseVisualStyleBackColor = true;
            this.Opt_C.CheckedChanged += new System.EventHandler(this.Opt_C_CheckedChanged);
            // 
            // Opt_P
            // 
            this.Opt_P.AutoSize = true;
            this.Opt_P.Location = new System.Drawing.Point(371, 29);
            this.Opt_P.Name = "Opt_P";
            this.Opt_P.Size = new System.Drawing.Size(71, 21);
            this.Opt_P.TabIndex = 3;
            this.Opt_P.TabStop = true;
            this.Opt_P.Text = "Patron";
            this.Opt_P.UseVisualStyleBackColor = true;
            this.Opt_P.CheckedChanged += new System.EventHandler(this.Opt_P_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dg_Ouvrier);
            this.groupBox1.Controls.Add(this.Dg_Cadre);
            this.groupBox1.Controls.Add(this.Dg_Patron);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1146, 549);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Dg_Ouvrier
            // 
            this.Dg_Ouvrier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Ouvrier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mat,
            this.fname,
            this.lname,
            this.datNaissance,
            this.dateEntrer,
            this.salary});
            this.Dg_Ouvrier.Location = new System.Drawing.Point(6, 23);
            this.Dg_Ouvrier.Name = "Dg_Ouvrier";
            this.Dg_Ouvrier.RowHeadersWidth = 51;
            this.Dg_Ouvrier.RowTemplate.Height = 24;
            this.Dg_Ouvrier.Size = new System.Drawing.Size(1134, 522);
            this.Dg_Ouvrier.TabIndex = 2;
            // 
            // mat
            // 
            this.mat.HeaderText = "Matricule";
            this.mat.MinimumWidth = 6;
            this.mat.Name = "mat";
            this.mat.Width = 125;
            // 
            // fname
            // 
            this.fname.HeaderText = "Nom";
            this.fname.MinimumWidth = 6;
            this.fname.Name = "fname";
            this.fname.Width = 125;
            // 
            // lname
            // 
            this.lname.HeaderText = "Prenom";
            this.lname.MinimumWidth = 6;
            this.lname.Name = "lname";
            this.lname.Width = 125;
            // 
            // datNaissance
            // 
            this.datNaissance.HeaderText = "Date de naissance";
            this.datNaissance.MinimumWidth = 6;
            this.datNaissance.Name = "datNaissance";
            this.datNaissance.Width = 125;
            // 
            // dateEntrer
            // 
            this.dateEntrer.HeaderText = "Date d\'entrer";
            this.dateEntrer.MinimumWidth = 6;
            this.dateEntrer.Name = "dateEntrer";
            this.dateEntrer.Width = 125;
            // 
            // salary
            // 
            this.salary.HeaderText = "Salaire";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            this.salary.Width = 125;
            // 
            // Dg_Cadre
            // 
            this.Dg_Cadre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Cadre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricule,
            this.name,
            this.prénom,
            this.dateDeNaissance,
            this.index,
            this.salair});
            this.Dg_Cadre.Location = new System.Drawing.Point(6, 22);
            this.Dg_Cadre.Name = "Dg_Cadre";
            this.Dg_Cadre.RowHeadersWidth = 51;
            this.Dg_Cadre.RowTemplate.Height = 24;
            this.Dg_Cadre.Size = new System.Drawing.Size(1134, 522);
            this.Dg_Cadre.TabIndex = 1;
            // 
            // matricule
            // 
            this.matricule.HeaderText = "Matricule";
            this.matricule.MinimumWidth = 6;
            this.matricule.Name = "matricule";
            this.matricule.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Nom";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // prénom
            // 
            this.prénom.HeaderText = "Prenom";
            this.prénom.MinimumWidth = 6;
            this.prénom.Name = "prénom";
            this.prénom.Width = 125;
            // 
            // dateDeNaissance
            // 
            this.dateDeNaissance.HeaderText = "Date de naissance";
            this.dateDeNaissance.MinimumWidth = 6;
            this.dateDeNaissance.Name = "dateDeNaissance";
            this.dateDeNaissance.Width = 125;
            // 
            // index
            // 
            this.index.HeaderText = "index";
            this.index.MinimumWidth = 6;
            this.index.Name = "index";
            this.index.Width = 125;
            // 
            // salair
            // 
            this.salair.HeaderText = "Salaire";
            this.salair.MinimumWidth = 6;
            this.salair.Name = "salair";
            this.salair.Width = 125;
            // 
            // Dg_Patron
            // 
            this.Dg_Patron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Patron.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricul,
            this.nom,
            this.prenom,
            this.dateNaissance,
            this.chiffreAffaire,
            this.pourcentage,
            this.salaire});
            this.Dg_Patron.Location = new System.Drawing.Point(6, 21);
            this.Dg_Patron.Name = "Dg_Patron";
            this.Dg_Patron.RowHeadersWidth = 51;
            this.Dg_Patron.RowTemplate.Height = 24;
            this.Dg_Patron.Size = new System.Drawing.Size(1134, 522);
            this.Dg_Patron.TabIndex = 0;
            // 
            // matricul
            // 
            this.matricul.HeaderText = "Matricule";
            this.matricul.MinimumWidth = 6;
            this.matricul.Name = "matricul";
            this.matricul.Width = 125;
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
            this.prenom.HeaderText = "Prenom";
            this.prenom.MinimumWidth = 6;
            this.prenom.Name = "prenom";
            this.prenom.Width = 125;
            // 
            // dateNaissance
            // 
            this.dateNaissance.HeaderText = "Date de naissance";
            this.dateNaissance.MinimumWidth = 6;
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Width = 125;
            // 
            // chiffreAffaire
            // 
            this.chiffreAffaire.HeaderText = "Chiffre D\'affaire";
            this.chiffreAffaire.MinimumWidth = 6;
            this.chiffreAffaire.Name = "chiffreAffaire";
            this.chiffreAffaire.Width = 125;
            // 
            // pourcentage
            // 
            this.pourcentage.HeaderText = "Pourcentage";
            this.pourcentage.MinimumWidth = 6;
            this.pourcentage.Name = "pourcentage";
            this.pourcentage.Width = 125;
            // 
            // salaire
            // 
            this.salaire.HeaderText = "Salaire";
            this.salaire.MinimumWidth = 6;
            this.salaire.Name = "salaire";
            this.salaire.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 644);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Opt_O);
            this.Controls.Add(this.Opt_C);
            this.Controls.Add(this.Opt_P);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Ouvrier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Cadre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Patron)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Opt_O;
        private System.Windows.Forms.RadioButton Opt_C;
        private System.Windows.Forms.RadioButton Opt_P;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dg_Ouvrier;
        private System.Windows.Forms.DataGridView Dg_Cadre;
        private System.Windows.Forms.DataGridView Dg_Patron;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn salair;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricul;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiffreAffaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn pourcentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn datNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEntrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
    }
}