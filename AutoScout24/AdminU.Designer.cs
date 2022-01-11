
namespace AutoScout24
{
    partial class AdminU
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mazzoLuzziDataSet = new AutoScout24.MazzoLuzziDataSet();
            this.utentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utentiTableAdapter = new AutoScout24.MazzoLuzziDataSetTableAdapters.UtentiTableAdapter();
            this.tableAdapterManager = new AutoScout24.MazzoLuzziDataSetTableAdapters.TableAdapterManager();
            this.listBoxU = new System.Windows.Forms.ListBox();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.buttonModifica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mazzoLuzziDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mazzoLuzziDataSet
            // 
            this.mazzoLuzziDataSet.DataSetName = "MazzoLuzziDataSet";
            this.mazzoLuzziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utentiBindingSource
            // 
            this.utentiBindingSource.DataMember = "Utenti";
            this.utentiBindingSource.DataSource = this.mazzoLuzziDataSet;
            // 
            // utentiTableAdapter
            // 
            this.utentiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProdottiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AutoScout24.MazzoLuzziDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtentiTableAdapter = this.utentiTableAdapter;
            // 
            // listBoxU
            // 
            this.listBoxU.FormattingEnabled = true;
            this.listBoxU.Location = new System.Drawing.Point(12, 77);
            this.listBoxU.Name = "listBoxU";
            this.listBoxU.Size = new System.Drawing.Size(866, 550);
            this.listBoxU.TabIndex = 0;
            // 
            // buttonElimina
            // 
            this.buttonElimina.Location = new System.Drawing.Point(96, 12);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(78, 59);
            this.buttonElimina.TabIndex = 1;
            this.buttonElimina.Text = "Elimina utente selezionata";
            this.buttonElimina.UseVisualStyleBackColor = true;
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Location = new System.Drawing.Point(12, 12);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(78, 59);
            this.buttonAggiungi.TabIndex = 2;
            this.buttonAggiungi.Text = "Aggiungi utente";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // buttonModifica
            // 
            this.buttonModifica.Location = new System.Drawing.Point(180, 12);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(78, 59);
            this.buttonModifica.TabIndex = 3;
            this.buttonModifica.Text = "Modifica utente selezionata";
            this.buttonModifica.UseVisualStyleBackColor = true;
            // 
            // AdminU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(890, 642);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.buttonAggiungi);
            this.Controls.Add(this.buttonElimina);
            this.Controls.Add(this.listBoxU);
            this.Name = "AdminU";
            this.Text = "AdminU";
            this.Load += new System.EventHandler(this.AdminU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mazzoLuzziDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utentiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MazzoLuzziDataSet mazzoLuzziDataSet;
        private System.Windows.Forms.BindingSource utentiBindingSource;
        private MazzoLuzziDataSetTableAdapters.UtentiTableAdapter utentiTableAdapter;
        private MazzoLuzziDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox listBoxU;
        private System.Windows.Forms.Button buttonElimina;
        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.Button buttonModifica;
    }
}