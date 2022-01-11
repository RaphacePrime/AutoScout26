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
    public partial class Catalogo : Form
    {
        List<Prodotto> ListP = new List<Prodotto>();
        List<string> memvolatile = new List<String>();
        Utente U;
        float totale = 0;
        int indice = 0;
        public Catalogo()
        {
            InitializeComponent();
        }
        public Catalogo(Utente U)
        {
            InitializeComponent();
            this.U = U;
            fu_labelutente.Text = U.username;
            fu_saldo.Text = U.saldo.ToString();
            label2.Text = U.saldo.ToString();
            Aggiornamento();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            // TODO: 
            
      
        }
        //TODO : cambia tutto
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            //Aggiornamento();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            //Aggiornamento();
        }
        public void Aggiornamento()
        {
            //string url = this.mazzoLuzziDataSet.Prodotti.urlColumn.ToString();
            //pictureBox1.ImageLocation=urlTextBox.Text;
        }

        private void fu_aggiungicarrello_Click(object sender, EventArgs e)
        {
            //if(fu_aggiungicarrello.Text == "AGGIUNTO AL CARRELLO!") { MessageBox.Show("Veicolo già aggiunto!");  }
            //else
            //{
            //    fu_aggiungicarrello.Text = "AGGIUNTO AL CARRELLO!";
            //    string codiceprodotto = codiceprodottoTextBox.Text;
            //    MazzoLuzziDataSet.ProdottiRow riga = this.mazzoLuzziDataSet.Prodotti.FindBycodiceprodotto(codiceprodotto);
            //    Prodotto P = new Prodotto(riga.codiceprodotto, riga.marca, riga.cilindrata, riga.modello, riga.prezzo, riga.tipologia,
            //        riga.n_chilometro, riga.url, riga.immatricolazione.ToString(), riga.username);
            //    ListP.Add(P);
            //    memvolatile.Add(riga.codiceprodotto);
            //}
            
        }

        private void carrello_Click(object sender, EventArgs e)
        {
        //    groupBoxCatalogo.Hide();
        //    GroupBoxCarrello.Show();
        //    checkedListBox1.Items.Clear();
        //    foreach(var elemento in ListP)
        //    {
        //        string a = elemento.marca;
        //        string b = elemento.modello;
        //        string c = elemento.prezzo.ToString();
        //        aggiornacostototale();
        //        checkedListBox1.Items.Add(a + ";  " +b + ";  "+c + "€");
        //    }
        }

        private void codiceprodottoTextBox_TextChanged(object sender, EventArgs e)
        {
            //aggiornainterfaccia();
        }
        private void aggiornainterfaccia()
        {
            //string username = fu_labelutente.Text;
            //try
            //{
            //    MazzoLuzziDataSet.UtentiRow riga = this.mazzoLuzziDataSet.Utenti.FindByusername(username);
            //    Console.WriteLine("saldo nuovo= " + riga.saldo.ToString());
            //    outputrigautente(riga);
            //    fu_saldo.Text = riga.saldo.ToString();
            //    label2.Text = riga.saldo.ToString();
            //}
            //catch (Exception fe)
            //{
            //}
            //outputlista();
            //if(memvolatile.Count==0)
            //{
            //    fu_aggiungicarrello.Text = "AGGIUNGI AL CARRELLO";
            //}
            //else
            //{
            //    foreach (string tap in memvolatile)
            //    {
            //        if (tap == codiceprodottoTextBox.Text)
            //        {
            //            fu_aggiungicarrello.Text = "AGGIUNTO AL CARRELLO!";
            //            break;
            //        }
            //        else
            //        {
            //            fu_aggiungicarrello.Text = "AGGIUNGI AL CARRELLO";
            //        }
            //    }
            //}
            
        }
        private void outputlista()
        {
            //foreach (string tap in memvolatile)
            //{
            //    Console.WriteLine("MEMVOL:"+tap);
            //}
        }
        private void aggiornacostototale()
        {
        //    totale = 0;
        //    foreach (var elemento in ListP)
        //    {
        //        totale += elemento.prezzo;
        //    }
        //    totalecosto.Text = totale.ToString();
        }

        private void eliminazionedacarrello_Click(object sender, EventArgs e)
        {
            //if (checkedListBox1.Items.Count == 1) { memvolatile.Clear(); }
            //else
            //{
            //    for (int i = 0; i < checkedListBox1.Items.Count; i++)
            //    {

            //        if (checkedListBox1.GetItemChecked(i))
            //        {
            //            checkedListBox1.Items.RemoveAt(i);
            //            memvolatile.RemoveAt(i);
            //            ListP.RemoveAt(i);
            //            i = 0;
            //            //aggiornainterfaccia();
            //            //aggiornacostototale();    
            //        }
            //    }
            //}            
            //aggiornainterfaccia();
            //aggiornacostototale();
        }

        private void acquista_Click(object sender, EventArgs e)
        {
            
            //// switchschermata();
            //int nuovosaldo1 = Int32.Parse(label2.Text);Console.WriteLine(label2);
            //int nuovosaldo2 = Int32.Parse(totalecosto.Text); Console.WriteLine(totalecosto);           
            //int nuovosaldo = nuovosaldo1 - nuovosaldo2;
            ////MessageBox.Show("Il tuo nuovo saldo: " + nuovosaldo);
            //DialogResult dr = MessageBox.Show("CONFERMA DI ACQUISTO", "Sei sicuro di voler acquistare i " +
            //    "prodotti nel carrello?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            //if (dr == DialogResult.Yes)
            //{            
            //    foreach (var tap in memvolatile)
            //    {
            //        Console.WriteLine("SIUUUUUM "+tap);                
            //        MazzoLuzziDataSet.ProdottiRow rigaprodotto = mazzoLuzziDataSet.Prodotti.FindBycodiceprodotto(tap);
            //        outputrigaprodotto(rigaprodotto);                
            //        this.prodottiTableAdapter.Delete(rigaprodotto.codiceprodotto, rigaprodotto.marca, 
            //            rigaprodotto.cilindrata, rigaprodotto.modello, rigaprodotto.tipologia,
            //            rigaprodotto.n_chilometro, rigaprodotto.url, rigaprodotto.immatricolazione, 
            //            rigaprodotto.prezzo, rigaprodotto.username);               
            //        AggiornaProdotti();
            //    }
            //    MazzoLuzziDataSet.UtentiRow rigautente = mazzoLuzziDataSet.Utenti.FindByusername(U.username);
                
                
            //    mazzoLuzziDataSet.Utenti.AcceptChanges();
            //    MessageBox.Show("Il tuo nuovo saldo: " + nuovosaldo);



            //    string a = rigautente.username;
            //    string b = rigautente.nomecognome;
            //    string c = rigautente.codicefiscale;
            //    string d = rigautente.password;
            //    int ef = rigautente.saldo;
            //    this.utentiTableAdapter.Delete(a, b, c, d, ef);
            //    this.utentiTableAdapter.Insert(a, b, c, d, nuovosaldo);
                
            //    AggiornaUtenti();
            //    memvolatile.Clear();
            //    ListP.Clear();
            //    aggiornainterfaccia();
                
            //}
            //else if (dr == DialogResult.Cancel)
            //{
            //    MessageBox.Show("Acquisto annullato!");
            //}
        }
        private void AggiornaProdotti()
        {
        //    this.prodottiTableAdapter.Fill(this.mazzoLuzziDataSet.Prodotti);
        //    prodottiBindingSource.ResetBindings(true);
        //    tableAdapterManager.UpdateAll(mazzoLuzziDataSet);
        //    mazzoLuzziDataSet.Prodotti.AcceptChanges();
        //    mazzoLuzziDataSet.AcceptChanges();
        }

        private void AggiornaUtenti()
        {
            //this.Validate();
            //this.utentiBindingSource.EndEdit();
            //this.utentiTableAdapter.Update(mazzoLuzziDataSet);
            //this.utentiTableAdapter.Fill(this.mazzoLuzziDataSet.Utenti);
            //utentiBindingSource.ResetBindings(true);
           //tableAdapterManager.UpdateAll(mazzoLuzziDataSet);            
            //mazzoLuzziDataSet.Utenti.AcceptChanges();
           // mazzoLuzziDataSet.AcceptChanges();

        }
        public void outputrigautente(MazzoLuzziDataSet.UtentiRow riga)
        {
            //Console.WriteLine("UTENTE: "+riga.nomecognome+ riga.codicefiscale + riga.password + riga.username + riga.saldo);
        }
        public void outputrigaprodotto(MazzoLuzziDataSet.ProdottiRow riga)
        {
            //Console.WriteLine("PRODOTTO: "+riga.codiceprodotto+ riga.marca+riga.cilindrata + riga.modello + riga.prezzo + riga.tipologia +
            //        riga.n_chilometro + riga.url + riga.immatricolazione.ToString() + riga.username);
        }

       /* public void switchschermata()
        {
            if(groupBoxCatalogo.Visible==true)
            {
                groupBoxCatalogo.Visible = false;
                GroupBoxCarrello.Visible = true;
            }
            else
            {
                groupBoxCatalogo.Visible = true;
                GroupBoxCarrello.Visible = false;
            }
        }*/

        private void back_Click(object sender, EventArgs e)
        {
            //groupBoxCatalogo.Show();
            //GroupBoxCarrello.Hide();
            //switchschermata();
        }
    }
}
//DataRow rigautentenuova = mazzoLuzziDataSet.Utenti.NewRow();
//rigautentenuova["username"] = rigautente.username;
//rigautentenuova["nomecognome"] = rigautente.nomecognome;
//rigautentenuova["codicefiscale"] = rigautente.codicefiscale;
//rigautentenuova["password"] = rigautente.password;
//rigautentenuova["saldo"] = rigautente.saldo;
//rigautentenuova.nomecognome=rigautente.nomecognome;rigautentenuova.codicefiscale = rigautente.codicefiscale;rigautentenuova.password = rigautente.password;rigautentenuova.username = fu_labelutente.Text; rigautentenuova.saldo = nuovosaldo;                                
//Console.WriteLine("NUOVO SALDO: " + rigautentenuova.saldo);
//Console.WriteLine("NUOVO USERNAME: " + rigautentenuova.username);
//utentiTableAdapter.Delete(rigautente.username, rigautente.nomecognome, rigautente.codicefiscale, rigautente.password, rigautente.saldo);
//outputrigautente(rigautentenuova);




//mazzoLuzziDataSet.Utenti.Rows.Add(rigautentenuova);
//string a = rigautentenuova.username;
//string b = rigautentenuova.nomecognome;
//string c = rigautentenuova.codicefiscale;
//string d = rigautentenuova.password;
//int ef = rigautentenuova.saldo;
//this.utentiTableAdapter.Insert(a, b, c, d, ef);