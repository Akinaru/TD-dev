using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{

    public enum Continent { Asie, Afrique };

    public class Elephant : Animal, IHerbivore
    {
        public const int AGE_ADULTE = 13;
        private Continent origine;

        public Elephant(SexeAnimal sexe, string nom, int anneeNaissance, double poids, double taille, Continent origine) : base(anneeNaissance, nom, poids, sexe, taille)
        {
            this.Origine = origine;
        }

        public Continent Origine
        {
            get
            {
                return origine;
            }

            set
            {
                origine = value;
            }
        }

        public override string Cri()
        {
            string cri = "hummmm";
            if (this.EstAdulte())
                cri = "HUHUMMUHMMUMHMUMMHMUUMHMUMHMUHUHUMMUHMMUMHMUMMHMUUMHMUMHMUHUHUMMUHMMUMHMUMMHMUUMHMUMHMUHUHUMMUHMMUMHMUMMHMUUMHMUMHMUHUHUMMUHMMUMHMUMMHMUUMHMUMHMU";
            return cri;
        }

        public override bool EstAdulte()
        {
            return (this.Age > Elephant.AGE_ADULTE);
        }

        public string HerbePreferee()
        {
            if (this.Age > 5)
            {

            }
            else
                return "Lait maternel";
        }

        public double QteHerbeJour()
        {
            return this.Poids * 0.25;
        }

        public override string ToString()
        {
            string oreilles = "petites", defense = "et défenses";
            if (this.Origine == Continent.Afrique) oreilles = "grandes";
            if ((this.Sexe == SexeAnimal.FEMININ) && (this.Origine == Continent.Asie)) defense = "sans défense";
            return base.ToString() + $"\n Origine: {this.Origine}\n Cri: {this.Cri()}\n Éléphant d'{this.Origine} avec des {oreilles} oreilles {defense}";
        }
    }
}
