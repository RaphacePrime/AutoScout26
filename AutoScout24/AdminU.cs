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
        public AdminU()
        {
            InitializeComponent();
        }

        private void utentiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utentiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mazzoLuzziDataSet);

        }

        private void AdminU_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'mazzoLuzziDataSet.Utenti'. È possibile spostarla o rimuoverla se necessario.
            this.utentiTableAdapter.Fill(this.mazzoLuzziDataSet.Utenti);

        }
    }
}
