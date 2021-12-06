namespace Recept1._0
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
            this.btnUnesiRecept = new System.Windows.Forms.Button();
            this.btnPregledRecepata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnesiRecept
            // 
            this.btnUnesiRecept.Location = new System.Drawing.Point(135, 270);
            this.btnUnesiRecept.Name = "btnUnesiRecept";
            this.btnUnesiRecept.Size = new System.Drawing.Size(130, 60);
            this.btnUnesiRecept.TabIndex = 0;
            this.btnUnesiRecept.Text = "Unos recepta";
            this.btnUnesiRecept.Click += new System.EventHandler(this.btnUnesiRecept_Click);
            // 
            // btnPregledRecepata
            // 
            this.btnPregledRecepata.Location = new System.Drawing.Point(535, 270);
            this.btnPregledRecepata.Name = "btnPregledRecepata";
            this.btnPregledRecepata.Size = new System.Drawing.Size(130, 60);
            this.btnPregledRecepata.TabIndex = 1;
            this.btnPregledRecepata.Text = "Pregled recepata";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUnesiRecept);
            this.Controls.Add(this.btnPregledRecepata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUnesiRecept;
        private System.Windows.Forms.Button btnPregledRecepata;
    }
}

