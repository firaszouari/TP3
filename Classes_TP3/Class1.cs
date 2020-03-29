using System;

namespace Classes_TP3
{
    public abstract class Employe : IEquatable<Employe>
    {

        public int Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Datenaissance { get; set; }
        public Employe(int Matricule, string Nom, string Prenom, DateTime dn)
        {
            this.Matricule = Matricule;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Datenaissance = dn;
        }

        public string ToString()
        {
            return "Matricule   "+ Matricule+"";
        }
        public bool Equals(Employe other)
        {
            throw new NotImplementedException();
        }
    }
}
