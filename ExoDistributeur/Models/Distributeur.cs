using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoDistributeur.Models
{
    struct Distributeur
    {
        public Boisson Get()
        {
            Boisson b = new Boisson();
            b.Nom = "Eau";

            return b;
        }
    }
}
