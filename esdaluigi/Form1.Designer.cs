
namespace esdaluigi
{
    partial class frmbenvenuto
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkreg = new System.Windows.Forms.LinkLabel();
            this.cmdaccedi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(505, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Benvenuto ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(189, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password utente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(189, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnome.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(668, 145);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(280, 56);
            this.txtnome.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(668, 240);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(280, 56);
            this.txtpass.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(455, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Clicca qui per registrarti.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(426, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(415, 50);
            this.label5.TabIndex = 6;
            this.label5.Text = "Non sei registrato? ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkreg
            // 
            this.linkreg.AutoSize = true;
            this.linkreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkreg.LinkColor = System.Drawing.Color.Blue;
            this.linkreg.Location = new System.Drawing.Point(508, 527);
            this.linkreg.Name = "linkreg";
            this.linkreg.Size = new System.Drawing.Size(228, 33);
            this.linkreg.TabIndex = 7;
            this.linkreg.TabStop = true;
            this.linkreg.Text = "linkregistrazione";
            // 
            // cmdaccedi
            // 
            this.cmdaccedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdaccedi.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdaccedi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cmdaccedi.Location = new System.Drawing.Point(1057, 177);
            this.cmdaccedi.Name = "cmdaccedi";
            this.cmdaccedi.Size = new System.Drawing.Size(256, 83);
            this.cmdaccedi.TabIndex = 8;
            this.cmdaccedi.Text = "&ACCEDI";
            this.cmdaccedi.UseVisualStyleBackColor = false;
            // 
            // frmbenvenuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 683);
            this.Controls.Add(this.cmdaccedi);
            this.Controls.Add(this.linkreg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmbenvenuto";
            this.Text = "Pagina Iniziale Sito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkreg;
        private System.Windows.Forms.Button cmdaccedi;
    }
}

