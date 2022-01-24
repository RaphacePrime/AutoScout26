
namespace AutoScout24
{
    partial class Catalogo2
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
            this.ListaVeicoli = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.compra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaVeicoli
            // 
            this.ListaVeicoli.FormattingEnabled = true;
            this.ListaVeicoli.ItemHeight = 20;
            this.ListaVeicoli.Location = new System.Drawing.Point(137, 139);
            this.ListaVeicoli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListaVeicoli.Name = "ListaVeicoli";
            this.ListaVeicoli.Size = new System.Drawing.Size(746, 204);
            this.ListaVeicoli.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AutoScout24.Properties.Resources.Aggiungi;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(441, 399);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 75);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 85);
            this.label1.TabIndex = 4;
            this.label1.Text = "Catalogo";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(319, 520);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(313, 50);
            this.checkedListBox1.TabIndex = 5;
            // 
            // compra
            // 
            this.compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compra.Location = new System.Drawing.Point(296, 580);
            this.compra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.compra.Name = "compra";
            this.compra.Size = new System.Drawing.Size(387, 58);
            this.compra.TabIndex = 6;
            this.compra.Text = "Acquista";
            this.compra.UseVisualStyleBackColor = true;
            this.compra.Click += new System.EventHandler(this.compra_Click);
            // 
            // Catalogo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(969, 695);
            this.Controls.Add(this.compra);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaVeicoli);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Catalogo2";
            this.Text = "Catalogo2";
            this.Load += new System.EventHandler(this.Catalogo2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListaVeicoli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button compra;
    }
}