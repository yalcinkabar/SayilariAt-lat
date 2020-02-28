namespace Odev_2
{
    partial class Oyun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oyun));
            this.pnlOyun = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHamle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKutucuk = new System.Windows.Forms.Label();
            this.btnYeniOyun = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOyun
            // 
            this.pnlOyun.Location = new System.Drawing.Point(12, 25);
            this.pnlOyun.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOyun.Name = "pnlOyun";
            this.pnlOyun.Padding = new System.Windows.Forms.Padding(10);
            this.pnlOyun.Size = new System.Drawing.Size(462, 468);
            this.pnlOyun.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(249, -4);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label5.Size = new System.Drawing.Size(22, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "||";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SpringGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(277, -1);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Oynanabilecek Hamle Sayısı";
            // 
            // lblHamle
            // 
            this.lblHamle.AutoSize = true;
            this.lblHamle.BackColor = System.Drawing.SystemColors.Control;
            this.lblHamle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHamle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHamle.Location = new System.Drawing.Point(446, -4);
            this.lblHamle.Name = "lblHamle";
            this.lblHamle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblHamle.Size = new System.Drawing.Size(15, 30);
            this.lblHamle.TabIndex = 4;
            this.lblHamle.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(94, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalan Kutucuk Sayısı";
            // 
            // lblKutucuk
            // 
            this.lblKutucuk.AutoSize = true;
            this.lblKutucuk.BackColor = System.Drawing.Color.Transparent;
            this.lblKutucuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblKutucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKutucuk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKutucuk.Location = new System.Drawing.Point(218, 2);
            this.lblKutucuk.Margin = new System.Windows.Forms.Padding(0);
            this.lblKutucuk.Name = "lblKutucuk";
            this.lblKutucuk.Size = new System.Drawing.Size(15, 20);
            this.lblKutucuk.TabIndex = 2;
            this.lblKutucuk.Text = "-";
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(66, 19);
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeniOyun});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(79, 501);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 501);
            this.Controls.Add(this.lblHamle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKutucuk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlOyun);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Oyun";
            this.Text = "SAYILARI AT-LAT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Oyun_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOyun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKutucuk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHamle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem btnYeniOyun;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

