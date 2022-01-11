using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoScout24
{
    public partial class Vendi : Form
    {
        Utente U = new Utente();
        public Vendi(Utente U)
        {
            
            InitializeComponent();
            this.U = U;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cp = textBox1.Text;
            string mar = textBox2.Text;
            int c = Int32.Parse(textBox3.Text);
            string d1 = textBox4.Text;
            float mod = float.Parse(d1);
            string tip = comboBox1.Text;
            int nk = Int32.Parse(textBox6.Text); 
            string url = textBox7.Text;
            string imm = dataImmatricolazionePicker.ToString();
            string u = U.username;
            Prodotto P= new Prodotto(cp,c,mar,mod,tip,nk,url,imm,u);
            MazzoLuzziDataSet.ProdottiRow nuovoprodotto = mazzoLuzziDataSet.Prodotti.NewProdottiRow();
            nuovoprodotto.codiceprodotto = P.codiceprodotto;
            nuovoprodotto.cilindrata = P.cilindrata;
            nuovoprodotto.modello = P.modello;
            nuovoprodotto.marca = P.marca;
            nuovoprodotto.prezzo = Int32.Parse((P.prezzo).ToString());
            nuovoprodotto.n_chilometro = P.n_chilometro;
            nuovoprodotto.tipologia = P.tipologia;
            nuovoprodotto.url = P.url;
            nuovoprodotto.username = P.username;
            nuovoprodotto.immatricolazione = dataImmatricolazionePicker.Value;
            this.prodottiTableAdapter.Insert(nuovoprodotto.codiceprodotto, nuovoprodotto.marca, nuovoprodotto.cilindrata, nuovoprodotto.modello, nuovoprodotto.tipologia, nuovoprodotto.n_chilometro,
                nuovoprodotto.url, nuovoprodotto.immatricolazione, nuovoprodotto.prezzo, nuovoprodotto.username);   

            //    MazzoLuzziDataSet.UtentiRow rigautentenuova = mazzoLuzziDataSet.Utenti.NewUtentiRow();
            //rigautentenuova.nomecognome = rigautente.nomecognome; rigautentenuova.codicefiscale = rigautente.codicefiscale; rigautentenuova.password = rigautente.password; rigautentenuova.username = rigautente.username; rigautentenuova.saldo = nuovosaldo;
            AggiornaProdotti();
            mazzoLuzziDataSet.AcceptChanges();
            MessageBox.Show("Auto inserita correttamente");
            this.Close();
        }
        private void AggiornaProdotti()
        {
            this.prodottiTableAdapter.Fill(this.mazzoLuzziDataSet.Prodotti);
            prodottiBindingSource.ResetBindings(true);
            tableAdapterManager.UpdateAll(mazzoLuzziDataSet);
        }

        private void prodottiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prodottiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mazzoLuzziDataSet);

        }

        private void Vendi_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'mazzoLuzziDataSet.Prodotti'. È possibile spostarla o rimuoverla se necessario.
            this.prodottiTableAdapter.Fill(this.mazzoLuzziDataSet.Prodotti);

        }
    }
}
