using System;

namespace rent_a_car.ClientSide
{
    partial class FrmPretragaAutomobila
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
            this.btnPrikaziAuto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.dgvAutomobili = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(735, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.label1.Location = new System.Drawing.Point(766, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPretrazi);
            this.groupBox1.Controls.Add(this.btnPrikaziAuto);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.dgvAutomobili);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtMarka);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(59, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 370);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraži automobile";
            // 
            // btnPrikaziAuto
            // 
            this.btnPrikaziAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrikaziAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.btnPrikaziAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnPrikaziAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrikaziAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.btnPrikaziAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnPrikaziAuto.Location = new System.Drawing.Point(500, 315);
            this.btnPrikaziAuto.Name = "btnPrikaziAuto";
            this.btnPrikaziAuto.Size = new System.Drawing.Size(120, 40);
            this.btnPrikaziAuto.TabIndex = 15;
            this.btnPrikaziAuto.Text = "Prikaži";
            this.btnPrikaziAuto.UseVisualStyleBackColor = false;
            this.btnPrikaziAuto.Click += new System.EventHandler(this.btnPrikaziAuto_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(37, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 1);
            this.panel2.TabIndex = 7;
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
            this.txtModel.Location = new System.Drawing.Point(37, 93);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(177, 19);
            this.txtModel.TabIndex = 6;
            this.txtModel.Text = "Model automobila";
            // 
            // dgvAutomobili
            // 
            this.dgvAutomobili.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutomobili.BackgroundColor = System.Drawing.Color.White;
            this.dgvAutomobili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomobili.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dgvAutomobili.Location = new System.Drawing.Point(37, 129);
            this.dgvAutomobili.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAutomobili.Name = "dgvAutomobili";
            this.dgvAutomobili.ReadOnly = true;
            this.dgvAutomobili.RowHeadersWidth = 51;
            this.dgvAutomobili.Size = new System.Drawing.Size(583, 178);
            this.dgvAutomobili.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(37, 75);
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
            this.txtMarka.Location = new System.Drawing.Point(37, 50);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(177, 19);
            this.txtMarka.TabIndex = 2;
            this.txtMarka.Text = "Marka automobila";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.btnPretrazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.btnPretrazi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnPretrazi.Location = new System.Drawing.Point(500, 83);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(120, 40);
            this.btnPretrazi.TabIndex = 16;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretragaAutomobila_Click);
            // 
            // FrmPretragaAutomobila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(11)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPretragaAutomobila";
            this.Text = "FrmPretragaAutomobila";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnPrikaziAuto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.DataGridView dgvAutomobili;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMarka;
    }
}