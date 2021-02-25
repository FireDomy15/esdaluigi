
namespace esdaluigi
{
    partial class frmreg
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcognome = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtconfermapass = new System.Windows.Forms.TextBox();
            this.cmdconferma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(632, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrazione:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(320, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Inserisci username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(380, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inserisci nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(325, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Inserisci cognome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(295, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 40);
            this.label5.TabIndex = 7;
            this.label5.Text = "Conferma Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(319, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 40);
            this.label6.TabIndex = 8;
            this.label6.Text = "Inserisci password:";
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtnome.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(949, 108);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(244, 50);
            this.txtnome.TabIndex = 9;
            // 
            // txtcognome
            // 
            this.txtcognome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtcognome.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcognome.Location = new System.Drawing.Point(949, 192);
            this.txtcognome.Name = "txtcognome";
            this.txtcognome.Size = new System.Drawing.Size(244, 50);
            this.txtcognome.TabIndex = 10;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtusername.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(949, 271);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(244, 50);
            this.txtusername.TabIndex = 11;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtpassword.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(949, 349);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(244, 50);
            this.txtpassword.TabIndex = 12;
            // 
            // txtconfermapass
            // 
            this.txtconfermapass.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtconfermapass.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfermapass.Location = new System.Drawing.Point(949, 442);
            this.txtconfermapass.Name = "txtconfermapass";
            this.txtconfermapass.Size = new System.Drawing.Size(244, 50);
            this.txtconfermapass.TabIndex = 13;
            // 
            // cmdconferma
            // 
            this.cmdconferma.Location = new System.Drawing.Point(678, 533);
            this.cmdconferma.Name = "cmdconferma";
            this.cmdconferma.Size = new System.Drawing.Size(116, 23);
            this.cmdconferma.TabIndex = 14;
            this.cmdconferma.Text = "CONFERMA";
            this.cmdconferma.UseVisualStyleBackColor = true;
            this.cmdconferma.Click += new System.EventHandler(this.cmdconferma_Click);
            // 
            // frmreg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 609);
            this.Controls.Add(this.cmdconferma);
            this.Controls.Add(this.txtconfermapass);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtcognome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmreg";
            this.Text = "Registrazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcognome;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtconfermapass;
        private System.Windows.Forms.Button cmdconferma;
    }
}