
namespace esdaluigi
{
    partial class frmcarrello1
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
            this.cmdaggiungi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(307, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "IL TUO CARELLO E\' VUOTO!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdaggiungi
            // 
            this.cmdaggiungi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdaggiungi.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdaggiungi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdaggiungi.Location = new System.Drawing.Point(423, 325);
            this.cmdaggiungi.Name = "cmdaggiungi";
            this.cmdaggiungi.Size = new System.Drawing.Size(284, 115);
            this.cmdaggiungi.TabIndex = 1;
            this.cmdaggiungi.Text = "AG&GIUNGI PRODOTTI";
            this.cmdaggiungi.UseVisualStyleBackColor = false;
            this.cmdaggiungi.Click += new System.EventHandler(this.cmdaggiungi_Click);
            // 
            // frmcarrello1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 651);
            this.Controls.Add(this.cmdaggiungi);
            this.Controls.Add(this.label1);
            this.Name = "frmcarrello1";
            this.Text = "Carrello vuoto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdaggiungi;
    }
}