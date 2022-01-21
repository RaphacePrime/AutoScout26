
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ListaVeicoli
            // 
            this.ListaVeicoli.FormattingEnabled = true;
            this.ListaVeicoli.Location = new System.Drawing.Point(12, 120);
            this.ListaVeicoli.Name = "ListaVeicoli";
            this.ListaVeicoli.Size = new System.Drawing.Size(158, 147);
            this.ListaVeicoli.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::AutoScout24.Properties.Resources.carrello;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(309, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 63);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AutoScout24.Properties.Resources.Aggiungi;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(69, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 63);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "Catalogo";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(242, 120);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(210, 139);
            this.checkedListBox1.TabIndex = 5;
            // 
            // Catalogo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(464, 452);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ListaVeicoli);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Catalogo2";
            this.Text = "Catalogo2";
            this.Load += new System.EventHandler(this.Catalogo2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListaVeicoli;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}