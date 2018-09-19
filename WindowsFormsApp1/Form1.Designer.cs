namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.bKarvalakki = new System.Windows.Forms.Button();
            this.bMonivalinta = new System.Windows.Forms.Button();
            this.bWinForms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valitse peli";
            // 
            // bKarvalakki
            // 
            this.bKarvalakki.Location = new System.Drawing.Point(12, 36);
            this.bKarvalakki.Name = "bKarvalakki";
            this.bKarvalakki.Size = new System.Drawing.Size(75, 23);
            this.bKarvalakki.TabIndex = 1;
            this.bKarvalakki.Text = "Karvalakki";
            this.bKarvalakki.UseVisualStyleBackColor = true;
            this.bKarvalakki.Click += new System.EventHandler(this.bKarvalakki_Click);
            // 
            // bMonivalinta
            // 
            this.bMonivalinta.Location = new System.Drawing.Point(106, 36);
            this.bMonivalinta.Name = "bMonivalinta";
            this.bMonivalinta.Size = new System.Drawing.Size(75, 23);
            this.bMonivalinta.TabIndex = 2;
            this.bMonivalinta.Text = "Monivalinta";
            this.bMonivalinta.UseVisualStyleBackColor = true;
            this.bMonivalinta.Click += new System.EventHandler(this.bMonivalinta_Click);
            // 
            // bWinForms
            // 
            this.bWinForms.Location = new System.Drawing.Point(203, 36);
            this.bWinForms.Name = "bWinForms";
            this.bWinForms.Size = new System.Drawing.Size(75, 23);
            this.bWinForms.TabIndex = 3;
            this.bWinForms.Text = "WinForms";
            this.bWinForms.UseVisualStyleBackColor = true;
            this.bWinForms.Click += new System.EventHandler(this.bWinForms_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 82);
            this.Controls.Add(this.bWinForms);
            this.Controls.Add(this.bMonivalinta);
            this.Controls.Add(this.bKarvalakki);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bKarvalakki;
        private System.Windows.Forms.Button bMonivalinta;
        private System.Windows.Forms.Button bWinForms;
    }
}

