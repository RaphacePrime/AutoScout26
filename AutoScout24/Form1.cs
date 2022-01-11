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
    public partial class Form1 : Form
    {
        Utente U;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cambia qui
            //this.utentiTableAdapter.Fill(this.mazzoLuzziDataSet.Utenti);



        }

        private void f1_catalogo_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            string username = f1_username.Text;
            string password = f1_password.Text;


            U = new Utente();
            var a = new Catalogo(U);
            a.ShowDialog();
            // TODO: cambia qui
            //try
            //{
            //    MazzoLuzziDataSet.UtentiRow riga = this.mazzoLuzziDataSet.Utenti.FindByusername(username);
            //    string password1 = riga.password;// label3.Text = riga.password;
            //    if(password== riga.password)
            //    {
            //        U = new Utente(riga.nomecognome, riga.codicefiscale, riga.password, riga.username, riga.saldo);
            //        var a = new Catalogo(U);
            //        a.ShowDialog();
            //    }
            //    else
            //    {
            //        label3.Text = "Password errata";
            //        MessageBox.Show("Password errata");
            //    }



            //}
            //catch(Exception fe)
            //{
            //    MessageBox.Show("UTENTE NON ESISTENTE");
            //    label3.Text = "Username non esistente";
            //    label3.Visible=true;
            //}

        }

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
        // TODO: cambia qui

        //private void utentiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.utentiBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.mazzoLuzziDataSet);

        //}

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

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            string username = f1_username.Text;
            string password = f1_password.Text;
            U = new Utente();
            var a = new Vendi(U);
            a.ShowDialog();
            // TODO: cambia qui

            //try
            //{
            //    MazzoLuzziDataSet.UtentiRow riga = this.mazzoLuzziDataSet.Utenti.FindByusername(username);
            //    string password1 = riga.password;// label3.Text = riga.password;
            //    if (password == password1)
            //    {
                    
            //    }
            //    else
            //    {
            //        label3.Text = "Password errata";
            //    }



            //}
            //catch (Exception fe)
            //{
            //    label3.Text = "Username non esistente";
            //    label3.Visible = true;
            //}
        }

        
    }
}
