using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScout24
{
    public class Prodotto
    {
        public string codiceprodotto;
        public string marca;
        public int cilindrata;
        public string modello;
        public float prezzo;
        public string tipologia;
        public int n_chilometro;
        public string url;
        public string immatricolazione;
        public string username;
        public Prodotto()
        {
            codiceprodotto = "";
            marca = "";
            cilindrata = 0;
            modello = "";
            prezzo = 0;
            tipologia = "";
            n_chilometro = 0;
            url = "";
            immatricolazione = "";
            username = "";
        }
        public Prodotto(string m, int c, string mod, float p, string t, int nk, string u, string im, string us)
        {
            codiceprodotto = "";
            marca = m;
            cilindrata = c;
            modello = mod;
            prezzo = p;
            tipologia = t;
            n_chilometro = nk;
            url = u;
            immatricolazione = im;
            username = us;
            codiceprodotto += m.Substring(0, 1);
            codiceprodotto += (c.ToString()).Substring(0, 1);
            codiceprodotto += mod.Substring(0, 1);
            codiceprodotto += t.Substring(0, 1);
            codiceprodotto += (nk.ToString()).Substring(0, 1);
            codiceprodotto += u.Substring(0, 1);
            codiceprodotto += im.Substring(0, 2);
            codiceprodotto += im.Substring(3, 2);
            Console.WriteLine("CODICE PRODOTTO: " + codiceprodotto);
        }

        public Prodotto(string cp, string m, int c, string mod, float p, string t, int nk, string u, string im, string us)
        {
            codiceprodotto = cp;
            marca = m;
            cilindrata = c;
            modello = mod;
            prezzo = p;
            tipologia = t;
            n_chilometro = nk;
            url = u;
            immatricolazione = im;
            username = us;
        }
    }
}
