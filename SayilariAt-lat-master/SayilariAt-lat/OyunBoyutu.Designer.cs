namespace Odev_2
{
    partial class OyunBoyutu
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
            this.btn5x5 = new System.Windows.Forms.Button();
            this.btn6x6 = new System.Windows.Forms.Button();
            this.btn7x7 = new System.Windows.Forms.Button();
            this.btn8x8 = new System.Windows.Forms.Button();
            this.btn9x9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn5x5
            // 
            this.btn5x5.Location = new System.Drawing.Point(12, 6);
            this.btn5x5.Name = "btn5x5";
            this.btn5x5.Size = new System.Drawing.Size(43, 23);
            this.btn5x5.TabIndex = 5;
            this.btn5x5.Text = "5x5";
            this.btn5x5.UseVisualStyleBackColor = true;
            this.btn5x5.Click += new System.EventHandler(this.On_Click);
            // 
            // btn6x6
            // 
            this.btn6x6.Location = new System.Drawing.Point(61, 6);
            this.btn6x6.Name = "btn6x6";
            this.btn6x6.Size = new System.Drawing.Size(43, 23);
            this.btn6x6.TabIndex = 6;
            this.btn6x6.Text = "6x6";
            this.btn6x6.UseVisualStyleBackColor = true;
            this.btn6x6.Click += new System.EventHandler(this.On_Click);
            // 
            // btn7x7
            // 
            this.btn7x7.Location = new System.Drawing.Point(110, 6);
            this.btn7x7.Name = "btn7x7";
            this.btn7x7.Size = new System.Drawing.Size(43, 23);
            this.btn7x7.TabIndex = 7;
            this.btn7x7.Text = "7x7";
            this.btn7x7.UseVisualStyleBackColor = true;
            this.btn7x7.Click += new System.EventHandler(this.On_Click);
            // 
            // btn8x8
            // 
            this.btn8x8.Location = new System.Drawing.Point(159, 6);
            this.btn8x8.Name = "btn8x8";
            this.btn8x8.Size = new System.Drawing.Size(43, 23);
            this.btn8x8.TabIndex = 8;
            this.btn8x8.Text = "8x8";
            this.btn8x8.UseVisualStyleBackColor = true;
            this.btn8x8.Click += new System.EventHandler(this.On_Click);
            // 
            // btn9x9
            // 
            this.btn9x9.Location = new System.Drawing.Point(208, 6);
            this.btn9x9.Name = "btn9x9";
            this.btn9x9.Size = new System.Drawing.Size(43, 23);
            this.btn9x9.TabIndex = 9;
            this.btn9x9.Text = "9x9";
            this.btn9x9.UseVisualStyleBackColor = true;
            this.btn9x9.Click += new System.EventHandler(this.On_Click);
            // 
            // OyunBoyutu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(263, 36);
            this.ControlBox = false;
            this.Controls.Add(this.btn9x9);
            this.Controls.Add(this.btn8x8);
            this.Controls.Add(this.btn7x7);
            this.Controls.Add(this.btn6x6);
            this.Controls.Add(this.btn5x5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OyunBoyutu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oyun Boyutu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn5x5;
        private System.Windows.Forms.Button btn6x6;
        private System.Windows.Forms.Button btn7x7;
        private System.Windows.Forms.Button btn8x8;
        private System.Windows.Forms.Button btn9x9;
    }
}