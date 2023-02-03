namespace SerialClient
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOperator3 = new System.Windows.Forms.Label();
            this.lblOperator1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOperator2 = new System.Windows.Forms.Label();
            this.pnlOperator = new System.Windows.Forms.Panel();
            this.timUpdate = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlOperator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 116);
            this.label1.TabIndex = 2;
            this.label1.Text = "Final Test\r\nStation 1";
            // 
            // lblOperator3
            // 
            this.lblOperator3.AutoSize = true;
            this.lblOperator3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator3.Location = new System.Drawing.Point(12, 107);
            this.lblOperator3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 4);
            this.lblOperator3.Name = "lblOperator3";
            this.lblOperator3.Size = new System.Drawing.Size(140, 31);
            this.lblOperator3.TabIndex = 2;
            this.lblOperator3.Text = "connected";
            // 
            // lblOperator1
            // 
            this.lblOperator1.AutoSize = true;
            this.lblOperator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator1.Location = new System.Drawing.Point(12, 24);
            this.lblOperator1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 4);
            this.lblOperator1.Name = "lblOperator1";
            this.lblOperator1.Size = new System.Drawing.Size(121, 31);
            this.lblOperator1.TabIndex = 2;
            this.lblOperator1.Text = "Operator";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(44, 40);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(9, 24, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(356, 160);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // lblOperator2
            // 
            this.lblOperator2.AutoSize = true;
            this.lblOperator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator2.Location = new System.Drawing.Point(12, 66);
            this.lblOperator2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 4);
            this.lblOperator2.Name = "lblOperator2";
            this.lblOperator2.Size = new System.Drawing.Size(183, 31);
            this.lblOperator2.TabIndex = 2;
            this.lblOperator2.Text = "Martin Steffan";
            // 
            // pnlOperator
            // 
            this.pnlOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlOperator.Controls.Add(this.lblOperator1);
            this.pnlOperator.Controls.Add(this.lblOperator3);
            this.pnlOperator.Controls.Add(this.lblOperator2);
            this.pnlOperator.Location = new System.Drawing.Point(422, 40);
            this.pnlOperator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlOperator.Name = "pnlOperator";
            this.pnlOperator.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.pnlOperator.Size = new System.Drawing.Size(267, 160);
            this.pnlOperator.TabIndex = 4;
            // 
            // timUpdate
            // 
            this.timUpdate.Interval = 1000;
            this.timUpdate.Tick += new System.EventHandler(this.timUpdate_Tick_1);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(95)))));
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(378, 8);
            this.btnStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(258, 80);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop Test";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.btnStart.CausesValidation = false;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(9, 8);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(347, 80);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Test";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.lblUpdate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Location = new System.Drawing.Point(44, 220);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 280);
            this.panel1.TabIndex = 5;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(71, 188);
            this.lblUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(106, 58);
            this.lblUpdate.TabIndex = 2;
            this.lblUpdate.Text = "Idle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(740, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlOperator);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(758, 589);
            this.Name = "Form1";
            this.Text = "Serial Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pnlOperator.ResumeLayout(false);
            this.pnlOperator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOperator3;
        private System.Windows.Forms.Label lblOperator1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblOperator2;
        private System.Windows.Forms.Panel pnlOperator;
        private System.Windows.Forms.Timer timUpdate;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label label2;
    }
}

