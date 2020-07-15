namespace rent_a_car.ClientSide
{
    partial class FrmGlavnaKorisnik
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajNovogKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajProzivodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiProizvodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaAutomobilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            pretragaAutomobilaToolStripMenuItem.Click += new System.EventHandler(this.pretraga_Click);

            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(139)))), ((int)(((byte)(36)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.proizvodiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(485, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajNovogKorisnikaToolStripMenuItem,
            this.pretragaAutomobilaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.korisniciToolStripMenuItem.Text = "Automobil";
            // 
            // kreirajNovogKorisnikaToolStripMenuItem
            // 
            this.kreirajNovogKorisnikaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(139)))), ((int)(((byte)(36)))));
            this.kreirajNovogKorisnikaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.kreirajNovogKorisnikaToolStripMenuItem.Name = "kreirajNovogKorisnikaToolStripMenuItem";
            this.kreirajNovogKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.kreirajNovogKorisnikaToolStripMenuItem.Text = "Rezervacija automobila";
            // 
            // proizvodiToolStripMenuItem
            // 
            this.proizvodiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajProzivodToolStripMenuItem,
            this.obrisiProizvodToolStripMenuItem});
            this.proizvodiToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
            this.proizvodiToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.proizvodiToolStripMenuItem.Text = "Nalog";
            // 
            // kreirajProzivodToolStripMenuItem
            // 
            this.kreirajProzivodToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(139)))), ((int)(((byte)(36)))));
            this.kreirajProzivodToolStripMenuItem.Name = "kreirajProzivodToolStripMenuItem";
            this.kreirajProzivodToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kreirajProzivodToolStripMenuItem.Text = "Brisanje naloga";
            // 
            // obrisiProizvodToolStripMenuItem
            // 
            this.obrisiProizvodToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(139)))), ((int)(((byte)(36)))));
            this.obrisiProizvodToolStripMenuItem.Name = "obrisiProizvodToolStripMenuItem";
            this.obrisiProizvodToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.obrisiProizvodToolStripMenuItem.Text = "Odjava";
            this.obrisiProizvodToolStripMenuItem.Click += new System.EventHandler(cancel_Click);
            // 
            // pretragaAutomobilaToolStripMenuItem
            // 
            this.pretragaAutomobilaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(139)))), ((int)(((byte)(36)))));
            this.pretragaAutomobilaToolStripMenuItem.Name = "pretragaAutomobilaToolStripMenuItem";
            this.pretragaAutomobilaToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.pretragaAutomobilaToolStripMenuItem.Text = "Pretraga automobila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(426, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Nova", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(452, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmGlavnaKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(11)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(485, 236);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGlavnaKorisnik";
            this.Text = "FrmGlavnaKorisnik";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajNovogKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaAutomobilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajProzivodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiProizvodToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}