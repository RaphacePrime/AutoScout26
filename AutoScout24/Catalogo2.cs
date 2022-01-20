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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbCommand cmd;
            System.Data.OleDb.OleDbDataReader rs;
            cmd = new System.Data.OleDb.OleDbCommand();
            cmd.Connection = conn;
            string sql;
            sql = "SELECT Classe, Nome FROM Prodotti;";
            cmd.CommandText = sql;
            rs = cmd.ExecuteReader();
            ListaVeicoli.Text = "";
            while (rs.Read())
            {
                //ListaVeicoli.
            }
        }
    }
}
