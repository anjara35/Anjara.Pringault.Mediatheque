﻿namespace Mediatheque.Core.Model
{
    public class JeuxDeSociete : ObjetDePret
    {


        public JeuxDeSociete(string titreDeLObjet, int ageMinimum,
            int ageMaximum, string editeur, TypeJeuxDeSociete typeJeux) : base(titreDeLObjet)
        {
            this.AgeMaximum = ageMaximum;
            this.AgeMinimum = ageMinimum;
            this.Editeur = editeur;
            this.TypeJeux = typeJeux;
        }

        public int AgeMinimum { get; set; }
        public int AgeMaximum { get; set; }
        public string Editeur { get; set; }
        public TypeJeuxDeSociete TypeJeux { get; set; }
    }
}
