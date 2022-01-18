namespace AutoScout24
{
    partial class Vendi
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
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.prezzoTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.urlTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kmTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tipologiaTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.modelloTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cilindrataTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.marcaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codiceTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mazzoLuzziDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource)).BeginInit();
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
            this.tableAdapterManager.UtentiTableAdapter = null;
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Location = new System.Drawing.Point(158, 352);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(75, 44);
            this.buttonAggiungi.TabIndex = 43;
            this.buttonAggiungi.Text = "Aggiungi";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(29, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 25);
            this.label11.TabIndex = 42;
            this.label11.Text = "Vendi un\' auto";
            // 
            // prezzoTxt
            // 
            this.prezzoTxt.Location = new System.Drawing.Point(77, 271);
            this.prezzoTxt.Name = "prezzoTxt";
            this.prezzoTxt.Size = new System.Drawing.Size(141, 20);
            this.prezzoTxt.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Prezzo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 245);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Data Immatricolazione";
            // 
            // urlTxt
            // 
            this.urlTxt.Location = new System.Drawing.Point(57, 219);
            this.urlTxt.Name = "urlTxt";
            this.urlTxt.Size = new System.Drawing.Size(141, 20);
            this.urlTxt.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Url";
            // 
            // kmTxt
            // 
            this.kmTxt.Location = new System.Drawing.Point(123, 193);
            this.kmTxt.Name = "kmTxt";
            this.kmTxt.Size = new System.Drawing.Size(141, 20);
            this.kmTxt.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Numero Kilometri";
            // 
            // tipologiaTxt
            // 
            this.tipologiaTxt.Location = new System.Drawing.Point(87, 167);
            this.tipologiaTxt.Name = "tipologiaTxt";
            this.tipologiaTxt.Size = new System.Drawing.Size(141, 20);
            this.tipologiaTxt.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tipologia";
            // 
            // modelloTxt
            // 
            this.modelloTxt.Location = new System.Drawing.Point(81, 141);
            this.modelloTxt.Name = "modelloTxt";
            this.modelloTxt.Size = new System.Drawing.Size(141, 20);
            this.modelloTxt.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Modello";
            // 
            // cilindrataTxt
            // 
            this.cilindrataTxt.Location = new System.Drawing.Point(87, 115);
            this.cilindrataTxt.Name = "cilindrataTxt";
            this.cilindrataTxt.Size = new System.Drawing.Size(141, 20);
            this.cilindrataTxt.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cilindrata";
            // 
            // marcaTxt
            // 
            this.marcaTxt.Location = new System.Drawing.Point(77, 89);
            this.marcaTxt.Name = "marcaTxt";
            this.marcaTxt.Size = new System.Drawing.Size(141, 20);
            this.marcaTxt.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Marca";
            // 
            // codiceTxt
            // 
            this.codiceTxt.Location = new System.Drawing.Point(77, 63);
            this.codiceTxt.Name = "codiceTxt";
            this.codiceTxt.Size = new System.Drawing.Size(141, 20);
            this.codiceTxt.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Codice";
            // 
            // Vendi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(371, 439);
            this.Controls.Add(this.buttonAggiungi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.prezzoTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.urlTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kmTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tipologiaTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.modelloTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cilindrataTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.marcaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codiceTxt);
            this.Controls.Add(this.label1);
            this.Name = "Vendi";
            this.Text = "Vendi";
            this.Load += new System.EventHandler(this.Vendi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mazzoLuzziDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MazzoLuzziDataSet mazzoLuzziDataSet;
        private System.Windows.Forms.BindingSource prodottiBindingSource;
        private MazzoLuzziDataSetTableAdapters.ProdottiTableAdapter prodottiTableAdapter;
        private MazzoLuzziDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox prezzoTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox urlTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kmTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tipologiaTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox modelloTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cilindrataTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox marcaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codiceTxt;
        private System.Windows.Forms.Label label1;
    }
}
