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
    public partial class Admin : Form
    {
        System.Data.OleDb.OleDbConnection conn;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            string connstr;
            connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MazzoLuzzi.accdb;";
            conn = new System.Data.OleDb.OleDbConnection(connstr);
            conn.Open();
            caricaListBox();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Function to update the listbox of the form </summary>
        ///
        /// <remarks>   Mazzoleni, 26/01/2022. </remarks>
        ///-------------------------------------------------------------------------------------------------

        private void caricaListBox()
        {
            System.Data.OleDb.OleDbCommand cmd;
            System.Data.OleDb.OleDbDataReader rs;
            cmd = new System.Data.OleDb.OleDbCommand();
            cmd.Connection = conn;
            string sql;
            sql = "SELECT * FROM Prodotti;";
            cmd.CommandText = sql;
            listBoxAuto.Items.Clear();
            rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                listBoxAuto.Items.Add(rs["codiceprodotto"].ToString() + " " + rs["marca"].ToString() + " " + rs["cilindrata"].ToString() + " " + rs["modello"].ToString() + " " + rs["tipologia"].ToString() + " " + rs["n_chilometro"].ToString() + " " + rs["url"].ToString() + " " + rs["immatricolazione"].ToString() + " " + rs["prezzo"].ToString() + " " + rs["username"].ToString());
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   It opens </summary>
        ///
        /// <remarks>   Mazzoleni, 26/01/2022. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            AggiungiAuto m = new AggiungiAuto();
            m.Show();
            
        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            string m = listBoxAuto.SelectedItem.ToString();
            string[] ml = m.Split(' ');
            System.Data.OleDb.OleDbCommand cmd;
            cmd = new System.Data.OleDb.OleDbCommand();
            cmd.Connection = conn;
            string sql;
            sql = "DELETE from Prodotti where codiceprodotto = '" + ml[0] + "';";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            caricaListBox();
        }
    }
}
