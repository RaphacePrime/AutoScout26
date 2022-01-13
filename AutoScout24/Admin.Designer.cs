
namespace AutoScout24
{
    partial class Admin
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
            this.prodottiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodottiTableAdapter = new AutoScout24.MazzoLuzziDataSetTableAdapters.ProdottiTableAdapter();
            this.tableAdapterManager = new AutoScout24.MazzoLuzziDataSetTableAdapters.TableAdapterManager();
            this.utentiTableAdapter = new AutoScout24.MazzoLuzziDataSetTableAdapters.UtentiTableAdapter();
            this.utentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxAuto = new System.Windows.Forms.ListBox();
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.buttonModifica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mazzoLuzziDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mazzoLuzziDataSet
            // 
            this.mazzoLuzziDataSet.DataSetName = "MazzoLuzziDataSet";
            this.mazzoLuzziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodottiBindingSource
            // 
            this.prodottiBindingSource.DataMember = "Prodotti";
            this.prodottiBindingSource.DataSource = this.mazzoLuzziDataSet;
            // 
            // prodottiTableAdapter
            // 
            this.prodottiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProdottiTableAdapter = this.prodottiTableAdapter;
            this.tableAdapterManager.UpdateOrder = AutoScout24.MazzoLuzziDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtentiTableAdapter = this.utentiTableAdapter;
            // 
            // utentiTableAdapter
            // 
            this.utentiTableAdapter.ClearBeforeFill = true;
            // 
            // utentiBindingSource
            // 
            this.utentiBindingSource.DataMember = "Utenti";
            this.utentiBindingSource.DataSource = this.mazzoLuzziDataSet;
            // 
            // listBoxAuto
            // 
            this.listBoxAuto.FormattingEnabled = true;
            this.listBoxAuto.Location = new System.Drawing.Point(12, 80);
            this.listBoxAuto.Name = "listBoxAuto";
            this.listBoxAuto.Size = new System.Drawing.Size(1085, 550);
            this.listBoxAuto.TabIndex = 0;
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Location = new System.Drawing.Point(12, 12);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(78, 59);
            this.buttonAggiungi.TabIndex = 3;
            this.buttonAggiungi.Text = "Aggiungi auto";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // buttonElimina
            // 
            this.buttonElimina.Location = new System.Drawing.Point(96, 12);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(78, 59);
            this.buttonElimina.TabIndex = 4;
            this.buttonElimina.Text = "Elimina auto";
            this.buttonElimina.UseVisualStyleBackColor = true;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // buttonModifica
            // 
            this.buttonModifica.Location = new System.Drawing.Point(180, 12);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(78, 59);
            this.buttonModifica.TabIndex = 5;
            this.buttonModifica.Text = "Modifica auto";
            this.buttonModifica.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1109, 642);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.buttonElimina);
            this.Controls.Add(this.buttonAggiungi);
            this.Controls.Add(this.listBoxAuto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mazzoLuzziDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utentiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MazzoLuzziDataSet mazzoLuzziDataSet;
        private System.Windows.Forms.BindingSource prodottiBindingSource;
        private MazzoLuzziDataSetTableAdapters.ProdottiTableAdapter prodottiTableAdapter;
        private MazzoLuzziDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MazzoLuzziDataSetTableAdapters.UtentiTableAdapter utentiTableAdapter;
        private System.Windows.Forms.BindingSource utentiBindingSource;
        private System.Windows.Forms.ListBox listBoxAuto;
        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.Button buttonElimina;
        private System.Windows.Forms.Button buttonModifica;
    }
}