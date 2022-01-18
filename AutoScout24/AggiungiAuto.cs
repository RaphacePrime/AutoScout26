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
    public partial class AggiungiAuto : Form
    {
        System.Data.OleDb.OleDbConnection conn;
        public AggiungiAuto()
        {
            InitializeComponent();
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbCommand cmd;
            cmd = new System.Data.OleDb.OleDbCommand();
            cmd.Connection = conn;
            string sql;
            sql = "INSERT into Prodotti (codiceprodotto,marca,cilindrata,modello,tipologia,n_chilometro,url,immatricolazione,prezzo,username) VALUES('"+codiceTxt.Text+"','"+ marcaTxt.Text+"','"+ Int32.Parse(cilindrataTxt.Text) + "','" + modelloTxt.Text + "','" + tipologiaTxt.Text + "','" + Int32.Parse(kmTxt.Text) + "','" + urlTxt.Text + "',"  + dateTimePicker1.Value.ToString("dd/MM/yyyy").ToString() + ",'" + float.Parse(prezzoTxt.Text) + "','" + usernameTxt.Text + "');";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserimento effettuato");
            this.Close();
        }

        private void AggiungiAuto_Load(object sender, EventArgs e)
        {
            string connstr;
            connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MazzoLuzzi.accdb;";
            conn = new System.Data.OleDb.OleDbConnection(connstr);
            conn.Open();
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }
    }
}
