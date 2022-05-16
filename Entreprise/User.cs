using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entreprise
{
    class User
    {
        private string nom;
        private string pass;
        private string profile;

        public string Nom { get => nom; set => nom = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Profile { get => profile; set => profile = value; }
    }
}
