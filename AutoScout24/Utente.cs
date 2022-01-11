using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScout24
{
    public class Utente
    {
        public string nomecognome;
        public string codicefiscale;
        public string password;
        public string username;
        public float saldo;
        public Utente()
        {
            nomecognome = "";
            codicefiscale = "";
            password = "";
            username = "";
            saldo=0;
        }
        public Utente(string a, string b, string c, string d, float e)
        {
            nomecognome = a;
            codicefiscale = b;
            password = c;
            username = d;
            saldo = e;
        }
        
    }
}
