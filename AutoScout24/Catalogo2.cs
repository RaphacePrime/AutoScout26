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
    public partial class Catalogo2 : Form
    {
        System.Data.OleDb.OleDbConnection conn;
        private List<string>carrello = new List<string>();
        Utente U = new Utente();
        float prezzo;
        public Catalogo2()
        {
            InitializeComponent();
        }
        public Catalogo2(Utente U)
        {
            this.U = U;
            InitializeComponent();
        }

        private void Catalogo2_Load(object sender, EventArgs e)
        {
            string connstr;
            connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MazzoLuzzi.accdb;";
            conn = new System.Data.OleDb.OleDbConnection(connstr);
            conn.Open();
            caricaListBox();
        }

        private void caricaListBox()
        {
            System.Data.OleDb.OleDbCommand cmd;
            System.Data.OleDb.OleDbDataReader rs;
            cmd = new System.Data.OleDb.OleDbCommand();
            cmd.Connection = conn;
            string sql;
            sql = "SELECT * FROM Prodotti;";
            cmd.CommandText = sql;
            ListaVeicoli.Items.Clear();
            rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                ListaVeicoli.Items.Add(rs["codiceprodotto"].ToString() + " " + rs["marca"].ToString() + " " + rs["cilindrata"].ToString() + " " + rs["modello"].ToString() + " " + rs["tipologia"].ToString() + " " + rs["n_chilometro"].ToString() + rs["immatricolazione"].ToString() + " " + rs["prezzo"].ToString() + " " + rs["username"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ListaVeicoli.Items.Count!=0)
            {
                string m = ListaVeicoli.SelectedItem.ToString();
                string[] ml = m.Split(' ');
                carrello.Add(ml[0]);
                Console.WriteLine("Stringa completa: " + m);
                foreach (var a in carrello)
                {
                    Console.WriteLine("codice prodotto: " + a);
                }
                caricaComboBox();
            }
           
        }

        private void caricaComboBox()
        {
            
            string sql;
            //foreach(var tap in carrello)
            //{
            //    sql = "SELECT * FROM Prodotti;";
            //    cmd.CommandText = sql;
            //    checkedListBox1.Items.Clear();
            //    rs = cmd.ExecuteReader();
            //
            foreach(var a in carrello)
            {
                System.Data.OleDb.OleDbCommand cmd;
                System.Data.OleDb.OleDbDataReader rs;
                cmd = new System.Data.OleDb.OleDbCommand();
                cmd.Connection = conn;
                sql = "SELECT * FROM Prodotti WHERE (codiceprodotto='"+ a +"');";
                //MessageBox.Show(sql);
                cmd.CommandText = sql;
                checkedListBox1.Items.Clear();
                rs = cmd.ExecuteReader();
                while (rs.Read())
                {
                    checkedListBox1.Items.Add(rs["codiceprodotto"].ToString() + " " + rs["marca"].ToString() + " "
                        + rs["cilindrata"].ToString() + " " + rs["modello"].ToString() + " " + rs["tipologia"].ToString() +
                        " " + rs["n_chilometro"].ToString() + rs["immatricolazione"].ToString()
                        + " " + rs["prezzo"].ToString() + " " + rs["username"].ToString());
                    prezzo = float.Parse(rs["prezzo"].ToString());
                }
            }
            
        }

        private void compra_Click(object sender, EventArgs e)
        {
            float saldo = U.saldo;
            if((saldo-prezzo)<0)
            {
                MessageBox.Show("non hai abbastanza soldi sul conto");
            }
            else
            {
                float nuovosaldo = saldo - prezzo;
                string sql;
                System.Data.OleDb.OleDbCommand cmd;
                System.Data.OleDb.OleDbDataReader rs;
                cmd = new System.Data.OleDb.OleDbCommand();
                cmd.Connection = conn;
                sql = "UPDATE Utenti SET saldo = '"+nuovosaldo+"' WHERE (username = '"+U.username+"');";
                //MessageBox.Show(sql);
                cmd.CommandText = sql;
                rs = cmd.ExecuteReader();

                //////////////////////////////////////////////////////////////////////////////////////////////////////
                cmd = new System.Data.OleDb.OleDbCommand();
                cmd.Connection = conn;
                string m = checkedListBox1.Items[0].ToString();
                string[] ml = m.Split(' ');
                string a = ml[0];
                sql = "DELETE FROM Prodotti WHERE (codiceprodotto='" + a + "');";
                //MessageBox.Show(sql);
                cmd.CommandText = sql;
                rs = cmd.ExecuteReader();


                MessageBox.Show("ACQUISTO RIUSCITO!");
                checkedListBox1.Items.Clear();
                caricaListBox();
            }
        }
    }
    
}
