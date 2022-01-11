
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
            // AdminU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(890, 642);
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
    }
}