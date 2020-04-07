using Classes_TP3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class Form2 : Form
    {
        Form1 frm = new Form1();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Opt_P.Checked = true;
            Opt_O.Checked = false;
            Opt_C.Checked = false;
            Dg_Cadre.Visible = false;
            Dg_Ouvrier.Visible = false;
            Dg_Patron.Visible = true;
        }

        private void Opt_P_CheckedChanged(object sender, EventArgs e)
        {
            Opt_P.Checked = true;
            Opt_O.Checked = false;
            Opt_C.Checked = false;
            Dg_Cadre.Visible = false;
            Dg_Ouvrier.Visible = false;
            Dg_Patron.Visible = true;

            Patron p;

            for(int i= 0; i< frm.List_E.Count(); i++)
            {
                p = (Patron)frm.List_E[i];
                if(p!=null)
                    Dg_Patron.Rows.Add(p.Matricule, p.Nom, p.Prenom, p.Datenaissance, p.ca, p.pourcentage, p.GetSalaire());
            }
        }

        private void Opt_C_CheckedChanged(object sender, EventArgs e)
        {
            Opt_P.Checked = false;
            Opt_O.Checked = false;
            Opt_C.Checked = true;
            Dg_Cadre.Visible = true;
            Dg_Ouvrier.Visible = false;
            Dg_Patron.Visible = false;

            Cadre c;

            for (int i = 0; i < frm.List_E.Count(); i++)
            {
                c = (Cadre)frm.List_E[i];
                if (c != null)
                    Dg_Patron.Rows.Add(c.Matricule, c.Nom, c.Prenom, c.Datenaissance, c.index, c.GetSalaire());
            }
        }

        private void Opt_O_CheckedChanged(object sender, EventArgs e)
        {
            Opt_P.Checked = false;
            Opt_O.Checked = true;
            Opt_C.Checked = false;
            Dg_Cadre.Visible = false;
            Dg_Ouvrier.Visible = true;
            Dg_Patron.Visible = false;

            Ouvrier o;

            for (int i = 0; i < frm.List_E.Count(); i++)
            {
                o = (Ouvrier)frm.List_E[i];
                if (o != null)
                    Dg_Patron.Rows.Add(o.Matricule, o.Nom, o.Prenom, o.Datenaissance, o.dateEnt, o.GetSalaire());
            }
        }
    }
}
