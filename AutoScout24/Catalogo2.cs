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
        public Catalogo2()
        {
            InitializeComponent();
        }

        private void Catalogo2_Load(object sender, EventArgs e)
        {
            string connstr;
            connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MazzoLuzzi.accdb;";
            conn = new System.Data.OleDb.OleDbConnection(connstr);
            conn.Open();
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
                ListaVeicoli.Items.Add(rs["codiceprodotto"].ToString() + " " + rs["marca"].ToString() + " " + rs["cilindrata"].ToString() + " " + rs["modello"].ToString() + " " + rs["tipologia"].ToString() + " " + rs["n_chilometro"].ToString() + " " + rs["url"].ToString() + " " + rs["immatricolazione"].ToString() + " " + rs["prezzo"].ToString() + " " + rs["username"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string m = ListaVeicoli.SelectedItem.ToString();
            string[] ml = m.Split(' ');
            carrello.Add(ml[0]);
        }
    }
    }
}
