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
    public partial class AdminU : Form
    {
        System.Data.OleDb.OleDbConnection conn;
        public AdminU()
        {
            InitializeComponent();
        }

        private void AdminU_Load(object sender, EventArgs e)
        {
            //    // TODO: questa riga di codice carica i dati nella tabella 'mazzoLuzziDataSet.Utenti'. È possibile spostarla o rimuoverla se necessario.
            //    this.utentiTableAdapter.Fill(this.mazzoLuzziDataSet.Utenti);
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
            sql = "SELECT * FROM Utenti;";
            cmd.CommandText = sql;
            listBoxU.Items.Clear();
            rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                listBoxU.Items.Add(rs["username"].ToString() + " " + rs["nomecognome"].ToString() + " " + rs["codicefiscale"].ToString() + " " + rs["password"].ToString() + " " + rs["saldo"].ToString());
            }
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {

        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            string m = listBoxU.SelectedItem.ToString();
            string[] ml = m.Split(' ');
            System.Data.OleDb.OleDbCommand cmd;
            cmd = new System.Data.OleDb.OleDbCommand();
            cmd.Connection = conn;
            string sql;
            sql = "DELETE from Utenti where username = '" + ml[0] + "';";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            caricaListBox();
        }
    }
}
