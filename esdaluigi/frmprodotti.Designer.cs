
namespace esdaluigi
{
    partial class frmprodotti
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdins = new System.Windows.Forms.Button();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtprezzo = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(379, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descrizione Prodotto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(456, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codice prodotto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(461, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezzo prodotto";
            // 
            // cmdins
            // 
            this.cmdins.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdins.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdins.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdins.Location = new System.Drawing.Point(664, 456);
            this.cmdins.Name = "cmdins";
            this.cmdins.Size = new System.Drawing.Size(266, 88);
            this.cmdins.TabIndex = 11;
            this.cmdins.Text = "&INSERISCI NEL CARRELLO";
            this.cmdins.UseVisualStyleBackColor = false;
            this.cmdins.Click += new System.EventHandler(this.cmdins_Click);
            // 
            // txtdesc
            // 
            this.txtdesc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtdesc.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(868, 327);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(244, 50);
            this.txtdesc.TabIndex = 8;
            // 
            // txtprezzo
            // 
            this.txtprezzo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtprezzo.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprezzo.Location = new System.Drawing.Point(868, 192);
            this.txtprezzo.Name = "txtprezzo";
            this.txtprezzo.Size = new System.Drawing.Size(244, 50);
            this.txtprezzo.TabIndex = 9;
            // 
            // txtcod
            // 
            this.txtcod.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtcod.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.Location = new System.Drawing.Point(868, 57);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(244, 50);
            this.txtcod.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(-35, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(680, 247);
            this.label4.TabIndex = 12;
            this.label4.Text = "MODIFICARE";
            // 
            // frmprodotti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 648);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdins);
            this.Controls.Add(this.txtprezzo);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmprodotti";
            this.Text = "Inserimento Prodotti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdins;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtprezzo;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label4;
    }
}