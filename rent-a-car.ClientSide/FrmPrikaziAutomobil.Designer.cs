namespace rent_a_car.ClientSide
{
    partial class FrmPrikaziAutomobil
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
            this.btnVratiSe = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblGodina = new System.Windows.Forms.Label();
            this.lblSediste = new System.Windows.Forms.Label();
            this.lblGSP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(234, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Nova", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnVratiSe
            // 
            this.btnVratiSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.btnVratiSe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnVratiSe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVratiSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnVratiSe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnVratiSe.Location = new System.Drawing.Point(97, 367);
            this.btnVratiSe.Name = "btnVratiSe";
            this.btnVratiSe.Size = new System.Drawing.Size(112, 36);
            this.btnVratiSe.TabIndex = 40;
            this.btnVratiSe.Text = "OK";
            this.btnVratiSe.UseVisualStyleBackColor = false;
            this.btnVratiSe.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(70, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Godina proizvodnje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Sedište za decu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(70, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 44;
            this.label7.Text = "GPS:";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMarka.ForeColor = System.Drawing.Color.White;
            this.lblMarka.Location = new System.Drawing.Point(155, 116);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(50, 18);
            this.lblMarka.TabIndex = 45;
            this.lblMarka.Text = "marka";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblModel.ForeColor = System.Drawing.Color.White;
            this.lblModel.Location = new System.Drawing.Point(155, 159);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(50, 18);
            this.lblModel.TabIndex = 46;
            this.lblModel.Text = "marka";
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblGodina.ForeColor = System.Drawing.Color.White;
            this.lblGodina.Location = new System.Drawing.Point(189, 201);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(50, 18);
            this.lblGodina.TabIndex = 47;
            this.lblGodina.Text = "marka";
            // 
            // lblSediste
            // 
            this.lblSediste.AutoSize = true;
            this.lblSediste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSediste.ForeColor = System.Drawing.Color.White;
            this.lblSediste.Location = new System.Drawing.Point(189, 246);
            this.lblSediste.Name = "lblSediste";
            this.lblSediste.Size = new System.Drawing.Size(50, 18);
            this.lblSediste.TabIndex = 48;
            this.lblSediste.Text = "marka";
            // 
            // lblGSP
            // 
            this.lblGSP.AutoSize = true;
            this.lblGSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblGSP.ForeColor = System.Drawing.Color.White;
            this.lblGSP.Location = new System.Drawing.Point(142, 294);
            this.lblGSP.Name = "lblGSP";
            this.lblGSP.Size = new System.Drawing.Size(50, 18);
            this.lblGSP.TabIndex = 49;
            this.lblGSP.Text = "marka";
            // 
            // FrmPrikazAutomobila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(11)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.Controls.Add(this.lblGSP);
            this.Controls.Add(this.lblSediste);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVratiSe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrikazAutomobila";
            this.Text = "FrmPrikazAutomobila";
            this.Load += new System.EventHandler(FrmPretragaAutomobila_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
          

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVratiSe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Label lblSediste;
        private System.Windows.Forms.Label lblGSP;
    }
}