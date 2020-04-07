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
    public partial class Form1 : Form
    {
        public List<Employe> List_E = new List<Employe>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayGrid();
        }

        private void displayGrid()
        {
            for(int i=0; i < List_E.Count; i++)
            {
                Dg_Emp.Rows.Add(List_E[i].Matricule, List_E[i].Nom, List_E[i].Prenom, List_E[i].Datenaissance, List_E[i].GetSalaire());
            }
        }

        private void Opt_P_CheckedChanged(object sender, EventArgs e)
        {
            if(Opt_P.Checked)
            {
                Opt_C.Checked = false;
                Opt_O.Checked = false;
                Grp_Cad.Enabled = false;
                Grp_Ouv.Enabled = false;
            }
        }

        private void Opt_C_CheckedChanged(object sender, EventArgs e)
        {
            if (Opt_C.Checked)
            {
                Opt_O.Checked = false;
                Opt_P.Checked = false;
                Grp_Pat.Enabled = false;
                Grp_Ouv.Enabled = false;
            }
        }

        private void Opt_O_CheckedChanged(object sender, EventArgs e)
        {
            if (Opt_O.Checked)
            {
                Opt_C.Checked = false;
                Opt_P.Checked = false;
                Grp_Cad.Enabled = false;
                Grp_Pat.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                radioButton4.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                radioButton5.Checked = false;
                radioButton4.Checked = false;
                radioButton7.Checked = false;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton4.Checked = false;
            }
        }

        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            if (Txt_Mat.Text != "" && Txt_Nom.Text != "" && Txt_Pren.Text != "")
            {
                if (Opt_P.Checked && Txt_CA.Text != "" && Txt_Pour.Text != "")
                {
                    var p = new Patron(Convert.ToInt32(Txt_Mat.Text), Txt_Nom.Text, Txt_Pren.Text, Dat_Nais.Value, Convert.ToDouble(Txt_CA.Text), Convert.ToDouble(Txt_Pour.Text));
                    if (!p.Equals(Convert.ToInt32(Txt_Mat.Text)))
                        List_E.Add(p);
                    else
                        MessageBox.Show("Ce Patron existe deja !");
                }
                else if (Opt_C.Checked && (radioButton4.Checked || radioButton5.Checked || radioButton6.Checked || radioButton7.Checked))
                {
                    if (radioButton4.Checked)
                    {
                        var c = new Cadre(Convert.ToInt32(Txt_Mat.Text), Txt_Nom.Text, Txt_Pren.Text, Dat_Nais.Value, 1);
                        if (!c.Equals(Convert.ToInt32(Txt_Mat.Text)))
                            List_E.Add(c);
                        else
                            MessageBox.Show("Cet cadre existe deja !");
                    }
                    else if (radioButton5.Checked)
                    {
                        var c = new Cadre(Convert.ToInt32(Txt_Mat.Text), Txt_Nom.Text, Txt_Pren.Text, Dat_Nais.Value, 2);
                        if (!c.Equals(Convert.ToInt32(Txt_Mat.Text)))
                            List_E.Add(c);
                        else
                            MessageBox.Show("Cet cadre existe deja !");
                    }
                    else if (radioButton6.Checked)
                    {
                        var c = new Cadre(Convert.ToInt32(Txt_Mat.Text), Txt_Nom.Text, Txt_Pren.Text, Dat_Nais.Value, 3);
                        if (!c.Equals(Convert.ToInt32(Txt_Mat.Text)))
                            List_E.Add(c);
                        else
                            MessageBox.Show("Cet cadre existe deja !");
                    }
                    else if (radioButton7.Checked)
                    {
                        var c = new Cadre(Convert.ToInt32(Txt_Mat.Text), Txt_Nom.Text, Txt_Pren.Text, Dat_Nais.Value, 4);
                        if (!c.Equals(Convert.ToInt32(Txt_Mat.Text)))
                            List_E.Add(c);
                        else
                            MessageBox.Show("Cet cadre existe deja !");
                    }
                }
                else if (Opt_O.Checked)
                {
                    var o = new Ouvrier(Convert.ToInt32(Txt_Mat.Text), Txt_Nom.Text, Txt_Pren.Text, Dat_Nais.Value, Dat_Ent.Value);
                    if (!o.Equals(Convert.ToInt32(Txt_Mat.Text)))
                        List_E.Add(o);
                    else
                        MessageBox.Show("Cet Ouvrier existe deja !");
                }
                displayGrid();
            }
        }
    }
}
