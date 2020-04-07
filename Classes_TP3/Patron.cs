using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_TP3
{
    public class Patron:Employe
    {
        public double ca { get; set; }
        public double pourcentage { get; set; }

        public Patron(int m, string n, string p, DateTime dn, double ca, double pourcentage)
            : base(m, n, p, dn)
        {
            this.ca = ca;
            this.pourcentage = pourcentage;
        }

        public override string ToString()
        {
            return "Patron" + base.ToString() + "Pourcentage" + pourcentage + "%";
        }

        public override double GetSalaire()
        {
            return Math.Round((ca * pourcentage / 100) / 12, 2);
        }
    }
}
