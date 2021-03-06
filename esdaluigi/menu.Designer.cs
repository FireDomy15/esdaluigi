
namespace esdaluigi
{
    partial class menu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aggiungiprodotti = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoprodotti = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaCarrelloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiprodotti,
            this.catalogoprodotti,
            this.salvaCarrelloToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.chiudiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aggiungiprodotti
            // 
            this.aggiungiprodotti.Name = "aggiungiprodotti";
            this.aggiungiprodotti.Size = new System.Drawing.Size(114, 20);
            this.aggiungiprodotti.Text = "Aggiungi prodotti";
            this.aggiungiprodotti.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // catalogoprodotti
            // 
            this.catalogoprodotti.Name = "catalogoprodotti";
            this.catalogoprodotti.Size = new System.Drawing.Size(132, 20);
            this.catalogoprodotti.Text = "Catalogo dei prodotti";
            this.catalogoprodotti.Click += new System.EventHandler(this.registrazioneToolStripMenuItem_Click);
            // 
            // salvaCarrelloToolStripMenuItem
            // 
            this.salvaCarrelloToolStripMenuItem.Name = "salvaCarrelloToolStripMenuItem";
            this.salvaCarrelloToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.salvaCarrelloToolStripMenuItem.Text = "Salva Carrello";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "logout ";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.chiudiToolStripMenuItem.Text = "chiudi";
            this.chiudiToolStripMenuItem.Click += new System.EventHandler(this.chiudiToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aggiungiprodotti;
        private System.Windows.Forms.ToolStripMenuItem catalogoprodotti;
        private System.Windows.Forms.ToolStripMenuItem salvaCarrelloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}