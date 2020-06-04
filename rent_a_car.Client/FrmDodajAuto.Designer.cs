namespace rent_a_car.Client
{
    partial class FrmDodajAuto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.cbGPS = new System.Windows.Forms.CheckBox();
            this.cbSedisteZaDecu = new System.Windows.Forms.CheckBox();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdbaci = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(516, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Nova", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(542, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "X";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGodina);
            this.groupBox1.Controls.Add(this.cbSedisteZaDecu);
            this.groupBox1.Controls.Add(this.cbGPS);
            this.groupBox1.Controls.Add(this.lblDatum);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtMarka);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 224);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos novog automobila:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.lblDatum.Location = new System.Drawing.Point(17, 165);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(152, 20);
            this.lblDatum.TabIndex = 7;
            this.lblDatum.Text = "Godina proizvodnje";
            // 
            // txtModel
            // 
            this.txtModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(11)))), ((int)(((byte)(47)))));
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.txtModel.ForeColor = System.Drawing.Color.White;
            this.txtModel.Location = new System.Drawing.Point(21, 109);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(162, 19);
            this.txtModel.TabIndex = 5;
            this.txtModel.Text = "Model";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(21, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 1);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(17, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 1);
            this.panel1.TabIndex = 3;
            // 
            // txtMarka
            // 
            this.txtMarka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(11)))), ((int)(((byte)(47)))));
            this.txtMarka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.txtMarka.ForeColor = System.Drawing.Color.White;
            this.txtMarka.Location = new System.Drawing.Point(21, 51);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(162, 19);
            this.txtMarka.TabIndex = 2;
            this.txtMarka.Text = "Marka";
            // 
            // cbGPS
            // 
            this.cbGPS.AutoSize = true;
            this.cbGPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGPS.ForeColor = System.Drawing.Color.White;
            this.cbGPS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbGPS.Location = new System.Drawing.Point(335, 51);
            this.cbGPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGPS.Name = "cbGPS";
            this.cbGPS.Size = new System.Drawing.Size(66, 24);
            this.cbGPS.TabIndex = 9;
            this.cbGPS.Text = "GPS";
            this.cbGPS.UseVisualStyleBackColor = false;
            // 
            // cbSedisteZaDecu
            // 
            this.cbSedisteZaDecu.AutoSize = true;
            this.cbSedisteZaDecu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSedisteZaDecu.ForeColor = System.Drawing.Color.White;
            this.cbSedisteZaDecu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSedisteZaDecu.Location = new System.Drawing.Point(335, 104);
            this.cbSedisteZaDecu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSedisteZaDecu.Name = "cbSedisteZaDecu";
            this.cbSedisteZaDecu.Size = new System.Drawing.Size(151, 24);
            this.cbSedisteZaDecu.TabIndex = 10;
            this.cbSedisteZaDecu.Text = "Sedište za decu";
            this.cbSedisteZaDecu.UseVisualStyleBackColor = false;
            // 
            // txtGodina
            // 
            this.txtGodina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGodina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(11)))), ((int)(((byte)(47)))));
            this.txtGodina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.txtGodina.ForeColor = System.Drawing.Color.White;
            this.txtGodina.Location = new System.Drawing.Point(199, 165);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(162, 19);
            this.txtGodina.TabIndex = 11;
            this.txtGodina.Text = "godina";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.btnDodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodaj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnDodaj.Location = new System.Drawing.Point(322, 277);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(176, 44);
            this.btnDodaj.TabIndex = 22;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // btnOdbaci
            // 
            this.btnOdbaci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdbaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.btnOdbaci.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnOdbaci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdbaci.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdbaci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnOdbaci.Location = new System.Drawing.Point(95, 277);
            this.btnOdbaci.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdbaci.Name = "btnOdbaci";
            this.btnOdbaci.Size = new System.Drawing.Size(176, 44);
            this.btnOdbaci.TabIndex = 21;
            this.btnOdbaci.Text = "Odbaci";
            this.btnOdbaci.UseVisualStyleBackColor = false;
            // 
            // FrmDodajAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(11)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(584, 345);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdbaci);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDodajAuto";
            this.Text = "FrmDodajAuto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.CheckBox cbSedisteZaDecu;
        private System.Windows.Forms.CheckBox cbGPS;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdbaci;
    }
}