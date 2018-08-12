namespace RegistarskeTablice
{
    partial class Form1
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
            this.tablica = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rezultat = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tablica
            // 
            this.tablica.Location = new System.Drawing.Point(23, 76);
            this.tablica.Name = "tablica";
            this.tablica.Size = new System.Drawing.Size(333, 20);
            this.tablica.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Provjera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unesite tablicu:";
            // 
            // rezultat
            // 
            this.rezultat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezultat.Location = new System.Drawing.Point(23, 145);
            this.rezultat.Multiline = true;
            this.rezultat.Name = "rezultat";
            this.rezultat.Size = new System.Drawing.Size(429, 40);
            this.rezultat.TabIndex = 3;
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(36, 224);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(391, 91);
            this.panel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 336);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tablica);
            this.Name = "Form1";
            this.Text = "Ispitivanje tablica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tablica;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rezultat;
        private System.Windows.Forms.Panel panel;
    }
}

