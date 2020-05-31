using System;

namespace rent_a_car.Server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Server form";

            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPokreni
            // 
            this.btnStart.Location = new System.Drawing.Point(30, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 88);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // btnZaustavi
            // 
            this.btnStop.Location = new System.Drawing.Point(226, 9);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(140, 88);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop server";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 215);
            this.panel1.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(82, 130);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 24);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 239);
            this.Controls.Add(this.panel1);
            this.Name = "Server form";
            this.Text = "Server form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            lblStatus.Text = "Server doesn't started";
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            bool success = server.Connect();
            if (success)
            {
                lblStatus.Text = "Server has started";
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
            else
            {
                lblStatus.Text = "Can't start server";
            }
        }

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatus;

        #endregion
    }
}

