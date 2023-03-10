using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    public class Girafe : Animal
    {
        public const int AGE_ADULTE = 4;

        public Girafe(int anneeNaissance, string nom, double poids, SexeAnimal sexe, double taille) : base(anneeNaissance, nom, poids, sexe, taille)
        {
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
            return (this.Age >= Elephant.AGE_ADULTE);
        }

        public override string ToString()
        {
            return base.ToString() + "\n Girafe super trop jolie beaucoup";
        }
    }
}
