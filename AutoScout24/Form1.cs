using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AutoScout24
{
    public partial class Form1 : Form
    {
        Utente U;
        System.Data.OleDb.OleDbConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Definiton of variable "conn" we will use in the form </summary>
        ///
        /// <remarks>   Mazzoleni, 26/01/2022. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string connstr;
            connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MazzoLuzzi.accdb;";

            conn = new System.Data.OleDb.OleDbConnection(connstr);

            conn.Open();



        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   
        ///             Checking if username and password inputted by user
        ///             corresponds to an account registered in the database
        ///             then if the check is true, it opens "Catalogo" Form        
        ///  </summary>
        ///
        /// <remarks>   Mazzoleni, 26/01/2022. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void f1_catalogo_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            string username = f1_username.Text;
            string password = f1_password.Text;


            U = new Utente();
            System.Data.OleDb.OleDbCommand cmd;
            System.Data.OleDb.OleDbDataReader rs;


            cmd = new System.Data.OleDb.OleDbCommand();
            cmd.Connection = conn;

            string sql;
            sql = "SELECT username, password, nomecognome, saldo, codicefiscale FROM Utenti;";
            cmd.CommandText = sql;

            rs = cmd.ExecuteReader();
            //tDati.Text = "";
            while (rs.Read())
            {
                if (password == rs["password"].ToString() && username == rs["username"].ToString())
                {
                    //tDati.AppendText(rs["username"].ToString() + " - " + rs["password"].ToString() + Environment.NewLine);
                    U = new Utente(rs["nomecognome"].ToString(), rs["codicefiscale"].ToString(), rs["password"].ToString(), rs["username"].ToString(), float.Parse(rs["saldo"].ToString()));
                    var a = new Catalogo2(U);
                    a.ShowDialog();
                    break;
                }
                else
                {
                    label3.Text = "ERRORE";
                    label3.Visible = true;
                }

            }
           

           

        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Access for admins to modify "Prodotti" table in the DB</summary>
        ///
        /// <remarks>   Mazzoleni, 26/01/2022. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void f1_admin_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            if (f1_username.Text=="alunno"&&f1_password.Text=="alunno")
            {
                var a = new Admin();
                a.ShowDialog();
            }
            else
            {
                label3.Text = "ERRORE";
                label3.Visible = true;
            }
            
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Access for admins to modify "Utenti" table in the DB </summary>
        ///
        /// <remarks>   Mazzoleni, 26/01/2022. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            if (f1_username.Text == "alunno" && f1_password.Text == "alunno")
            {
                var a = new AdminU();
                a.ShowDialog();
            }
            else
            {
                label3.Text = "ERRORE";
                label3.Visible = true;
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>  
        ///             Checking if username and password inputted by user
        ///             corresponds to an account registered in the database
        ///             then if the check is true, it opens "Vendi" Form
        ///             
        /// </summary>
        ///
        /// <remarks>   Mazzoleni, 26/01/2022. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            string username = f1_username.Text;
            string password = f1_password.Text;
            U = new Utente();
            
            
          

            System.Data.OleDb.OleDbCommand cmd;
            System.Data.OleDb.OleDbDataReader rs;


            cmd = new System.Data.OleDb.OleDbCommand();
            cmd.Connection = conn;

            string sql;
            sql = "SELECT username, password, nomecognome, saldo, codicefiscale FROM Utenti;";
            cmd.CommandText = sql;

            rs = cmd.ExecuteReader();
            //tDati.Text = "";
            while (rs.Read())
            {
                if (password == rs["password"].ToString() && username == rs["username"].ToString())
                {
                 //   tDati.AppendText(rs["username"].ToString() + " - " + rs["password"].ToString() + Environment.NewLine);
                    U = new Utente(rs["nomecognome"].ToString(), rs["codicefiscale"].ToString(), rs["password"].ToString(), rs["username"].ToString(), float.Parse(rs["saldo"].ToString()));
                    var a = new Vendi(U);
                    a.ShowDialog();
                    break;
                }
                else
                {
                    label3.Text = "ERRORE";
                    label3.Visible = true;
                }

            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   
        ///             Saving the progress of our database
        ///             after we modified it.
        /// </summary>
        ///
        /// <remarks>   Mazzoleni, 26/01/2022. </remarks>
        ///-------------------------------------------------------------------------------------------------

        private void CopiaFile()
        {

            const string test1 = "copy";
            const string test2 = "MazzoLuzzi.accdb";
            const string test3 = "..\\..\\MazzoLuzzi.accdb";

            ProcessStartInfo processo = new ProcessStartInfo();
            processo.CreateNoWindow = false;
            processo.UseShellExecute = false;
            processo.FileName = "cmd.exe";
            processo.Arguments = "/c " + test1 + " " + test2 + " " + test3;

            try
            {

                using (Process ProcessoExe = Process.Start(processo))
                {
                    ProcessoExe.WaitForExit();
                }
            }
            catch
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CopiaFile();
        }
    }
}
