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
        public Admin()
        {
            InitializeComponent();
        }

        private void prodottiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prodottiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mazzoLuzziDataSet);

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'mazzoLuzziDataSet.Utenti'. È possibile spostarla o rimuoverla se necessario.
            this.utentiTableAdapter.Fill(this.mazzoLuzziDataSet.Utenti);
            // TODO: questa riga di codice carica i dati nella tabella 'mazzoLuzziDataSet.Prodotti'. È possibile spostarla o rimuoverla se necessario.
            this.prodottiTableAdapter.Fill(this.mazzoLuzziDataSet.Prodotti);

        }
    }
}
