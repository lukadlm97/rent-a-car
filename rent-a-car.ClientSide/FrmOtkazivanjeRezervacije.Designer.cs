namespace rent_a_car.ClientSide
{
    partial class FrmOtkazivanjeRezervacije
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOtkaziRezervaciju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(741, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 15;
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
            this.label1.Location = new System.Drawing.Point(767, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvAutomobili
            // 
            this.dgvRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRezervacije.BackgroundColor = System.Drawing.Color.White;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dgvRezervacije.Location = new System.Drawing.Point(37, 50);
            this.dgvRezervacije.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRezervacije.Name = "dgvAutomobili";
            this.dgvRezervacije.ReadOnly = true;
            this.dgvRezervacije.RowHeadersWidth = 51;
            this.dgvRezervacije.Size = new System.Drawing.Size(583, 178);
            this.dgvRezervacije.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOtkaziRezervaciju);
            this.groupBox1.Controls.Add(this.dgvRezervacije);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(72, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 304);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervacije";
            // 
            // btnPrikaziAuto
            // 
            this.btnOtkaziRezervaciju.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOtkaziRezervaciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.btnOtkaziRezervaciju.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnOtkaziRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOtkaziRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.btnOtkaziRezervaciju.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnOtkaziRezervaciju.Location = new System.Drawing.Point(278, 236);
            this.btnOtkaziRezervaciju.Name = "btnPrikaziAuto";
            this.btnOtkaziRezervaciju.Size = new System.Drawing.Size(120, 52);
            this.btnOtkaziRezervaciju.TabIndex = 16;
            this.btnOtkaziRezervaciju.Text = "Prikaži";
            this.btnOtkaziRezervaciju.UseVisualStyleBackColor = false;
            this.btnOtkaziRezervaciju.Click += new System.EventHandler(this.CloseReservation_Click);
            // 
            // FrmOtkazivanjeRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(11)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOtkazivanjeRezervacija";
            this.Text = "FrmOtkazivanjeRezervacija";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOtkaziRezervaciju;
    }
}