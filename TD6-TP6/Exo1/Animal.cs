using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{

    public enum SexeAnimal { FEMININ = 'F', MASCULIN = 'M', HERMAPHROFITE = 'H' };

    public abstract class Animal
    {
        private int age;
        private int anneeNaissance;
        private string nom;
        private double poids;
        private SexeAnimal sexe;
        private double taille;

        public const String UM_TAILLE = "m";
        public const String UM_POIDS = "kg";
        public const String UM_AGE = "an(s)";
        
        protected Animal(int anneeNaissance, string nom, double poids, SexeAnimal sexe, double taille)
        {
            this.AnneeNaissance = anneeNaissance;
            this.Nom = nom;
            this.Poids = poids;
            this.Sexe = sexe;
            this.Taille = taille;
        }

        public override string ToString()
        {
            return $"Nom: {this.Nom}\n Age: {this.Age} {Animal.UM_AGE}\n Année de Naissance: {this.AnneeNaissance}\n Poids: {this.Poids} {Animal.UM_POIDS}\n Taille: {this.Taille} {Animal.UM_TAILLE}\n Sexe: {this.Sexe}";
        }

        public abstract bool EstAdulte(); 
        public abstract string Cri();

        public override bool Equals(object obj)
        {
            return obj is Animal animal &&
                   this.Nom == animal.Nom;
        }

        public int Age
        {
            get
            {
                return DateTime.Today.Year - this.AnneeNaissance;
            }
        }

        public int AnneeNaissance
        {
            get
            {
                return anneeNaissance;
            }

            set
            {
                if(value > DateTime.Today.Year)
                {
                    throw new ArgumentException("L'annee est plus grande qui celle actuelle.");
                }
                anneeNaissance = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Le nom ne peut pas être vide.");
                }
                nom = value.ToUpper();
            }
        }

        public double Poids
        {
            get
            {
                return poids;
            }

            set
            { 
                if (value < 0)
                    throw new ArgumentException("Poids doit etre plus grand que 0");
                poids = value;
            }
        }

        public SexeAnimal Sexe
        {
            get
            {
                return sexe;
            }

            set
            {
                sexe = value;
            }
        }

        public double Taille
        {
            get
            {
                return taille;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Taille doit etre plus grand que 0");
                taille = value;
            }
        }



    }
}
