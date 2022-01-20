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
    public partial class AggiungiUtente : Form
    {
        System.Data.OleDb.OleDbConnection conn;
        public AggiungiUtente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbCommand cmd;
            cmd = new System.Data.OleDb.OleDbCommand();
            cmd.Connection = conn;
            string sql;
            sql = "INSERT into Utenti (nomecognome,codicefiscale,[password],username,saldo) " +
                "VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text+ "','" 
                + textBox4.Text + "'," + Int32.Parse(textBox5.Text) + ");";
            Console.WriteLine(sql);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserimento effettuato");
            this.Close();
        }

        private void AggiungiUtente_Load(object sender, EventArgs e)
        {
            string connstr;
            connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MazzoLuzzi.accdb;";
            conn = new System.Data.OleDb.OleDbConnection(connstr);
            conn.Open();            
        }
    }
}
