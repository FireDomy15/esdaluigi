﻿
namespace esdaluigi
{
    partial class frmcarrello2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblprezzo = new System.Windows.Forms.Label();
            this.cmdaggiungi = new System.Windows.Forms.Button();
            this.cmdelimina = new System.Windows.Forms.Button();
            this.cmdtot = new System.Windows.Forms.Button();
            this.lbltot = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.cmdindietro = new System.Windows.Forms.Button();
            this.cmdavanti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(132, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezzo prodotto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(110, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero prodotto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(50, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrizione Prodotto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbldesc
            // 
            this.lbldesc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbldesc.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldesc.Location = new System.Drawing.Point(565, 244);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(273, 239);
            this.lbldesc.TabIndex = 5;
            // 
            // lblprezzo
            // 
            this.lblprezzo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblprezzo.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprezzo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblprezzo.Location = new System.Drawing.Point(565, 159);
            this.lblprezzo.Name = "lblprezzo";
            this.lblprezzo.Size = new System.Drawing.Size(273, 40);
            this.lblprezzo.TabIndex = 6;
            this.lblprezzo.Click += new System.EventHandler(this.lblprezzo_Click);
            // 
            // cmdaggiungi
            // 
            this.cmdaggiungi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdaggiungi.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdaggiungi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdaggiungi.Location = new System.Drawing.Point(329, 508);
            this.cmdaggiungi.Name = "cmdaggiungi";
            this.cmdaggiungi.Size = new System.Drawing.Size(255, 88);
            this.cmdaggiungi.TabIndex = 7;
            this.cmdaggiungi.Text = "AG&GIUNGI PRODOTTI";
            this.cmdaggiungi.UseVisualStyleBackColor = false;
            this.cmdaggiungi.Click += new System.EventHandler(this.cmdaggiungi_Click);
            // 
            // cmdelimina
            // 
            this.cmdelimina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdelimina.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdelimina.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdelimina.Location = new System.Drawing.Point(917, 156);
            this.cmdelimina.Name = "cmdelimina";
            this.cmdelimina.Size = new System.Drawing.Size(350, 53);
            this.cmdelimina.TabIndex = 9;
            this.cmdelimina.Text = "&ELIMINA PRODOTTO";
            this.cmdelimina.UseVisualStyleBackColor = false;
            this.cmdelimina.Click += new System.EventHandler(this.cmdelimina_Click);
            // 
            // cmdtot
            // 
            this.cmdtot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdtot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdtot.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdtot.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdtot.Location = new System.Drawing.Point(1245, 395);
            this.cmdtot.Name = "cmdtot";
            this.cmdtot.Size = new System.Drawing.Size(266, 88);
            this.cmdtot.TabIndex = 10;
            this.cmdtot.Text = "&CALCOLA TOTALE";
            this.cmdtot.UseVisualStyleBackColor = false;
            // 
            // lbltot
            // 
            this.lbltot.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbltot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltot.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltot.Location = new System.Drawing.Point(1270, 508);
            this.lbltot.Name = "lbltot";
            this.lbltot.Size = new System.Drawing.Size(227, 98);
            this.lbltot.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.numericUpDown1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.numericUpDown1.Location = new System.Drawing.Point(571, 84);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(272, 41);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(143, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 40);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome prodotto";
            // 
            // lblnome
            // 
            this.lblnome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblnome.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnome.Location = new System.Drawing.Point(570, 20);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(273, 40);
            this.lblnome.TabIndex = 14;
            // 
            // cmdindietro
            // 
            this.cmdindietro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdindietro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdindietro.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdindietro.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdindietro.Location = new System.Drawing.Point(896, 419);
            this.cmdindietro.Name = "cmdindietro";
            this.cmdindietro.Size = new System.Drawing.Size(140, 66);
            this.cmdindietro.TabIndex = 15;
            this.cmdindietro.Text = "<--";
            this.cmdindietro.UseVisualStyleBackColor = false;
            this.cmdindietro.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdavanti
            // 
            this.cmdavanti.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdavanti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdavanti.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdavanti.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdavanti.Location = new System.Drawing.Point(1042, 419);
            this.cmdavanti.Name = "cmdavanti";
            this.cmdavanti.Size = new System.Drawing.Size(134, 64);
            this.cmdavanti.TabIndex = 16;
            this.cmdavanti.Text = "-->";
            this.cmdavanti.UseVisualStyleBackColor = false;
            // 
            // frmcarrello2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1550, 644);
            this.Controls.Add(this.cmdavanti);
            this.Controls.Add(this.cmdindietro);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbltot);
            this.Controls.Add(this.cmdtot);
            this.Controls.Add(this.cmdelimina);
            this.Controls.Add(this.cmdaggiungi);
            this.Controls.Add(this.lblprezzo);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmcarrello2";
            this.Text = "Carrello pieno";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lblprezzo;
        private System.Windows.Forms.Button cmdaggiungi;
        private System.Windows.Forms.Button cmdelimina;
        private System.Windows.Forms.Button cmdtot;
        private System.Windows.Forms.Label lbltot;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button cmdindietro;
        private System.Windows.Forms.Button cmdavanti;
    }
}