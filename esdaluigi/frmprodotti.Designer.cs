
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
            this.txtquant = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtprezzo = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtquant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(201, 541);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 79);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descrizione Prodotto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(580, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 79);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantità";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(359, 365);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(514, 79);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezzo prodotto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmdins
            // 
            this.cmdins.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdins.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdins.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdins.Location = new System.Drawing.Point(373, 734);
            this.cmdins.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdins.Name = "cmdins";
            this.cmdins.Size = new System.Drawing.Size(532, 169);
            this.cmdins.TabIndex = 11;
            this.cmdins.Text = "&INSERISCI NEL CARRELLO";
            this.cmdins.UseVisualStyleBackColor = false;
            this.cmdins.Click += new System.EventHandler(this.cmdins_Click);
            // 
            // txtquant
            // 
            this.txtquant.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtquant.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquant.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtquant.Location = new System.Drawing.Point(1172, 210);
            this.txtquant.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtquant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtquant.Name = "txtquant";
            this.txtquant.Size = new System.Drawing.Size(488, 74);
            this.txtquant.TabIndex = 7;
            this.txtquant.Value = new decimal(new int[] {
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
            this.label4.Location = new System.Drawing.Point(380, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(493, 79);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nome prodotto";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1172, 78);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(485, 50);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtprezzo
            // 
            this.txtprezzo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtprezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprezzo.Location = new System.Drawing.Point(1172, 379);
            this.txtprezzo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtprezzo.Name = "txtprezzo";
            this.txtprezzo.Size = new System.Drawing.Size(488, 58);
            this.txtprezzo.TabIndex = 16;
            this.txtprezzo.Text = " ";
            // 
            // txtdesc
            // 
            this.txtdesc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(1140, 569);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(583, 334);
            this.txtdesc.TabIndex = 17;
            this.txtdesc.Text = " ";
            // 
            // frmprodotti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2286, 1246);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtprezzo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtquant);
            this.Controls.Add(this.cmdins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmprodotti";
            this.Text = "Inserimento Prodotti";
            this.Load += new System.EventHandler(this.frmprodotti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtquant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdins;
        private System.Windows.Forms.NumericUpDown txtquant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label txtprezzo;
        private System.Windows.Forms.Label txtdesc;
    }
}