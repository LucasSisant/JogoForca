namespace JogoDaForca
{
    partial class Form1
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
            this.pnlJogo = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.pnlJogo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlJogo
            // 
            this.pnlJogo.Controls.Add(this.lblText);
            this.pnlJogo.Controls.Add(this.groupBox1);
            this.pnlJogo.Location = new System.Drawing.Point(12, 12);
            this.pnlJogo.Name = "pnlJogo";
            this.pnlJogo.Size = new System.Drawing.Size(621, 381);
            this.pnlJogo.TabIndex = 0;
            this.pnlJogo.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(12, 408);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(621, 65);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.MouseCaptureChanged += new System.EventHandler(this.groupBox1_MouseCaptureChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(266, 118);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(46, 17);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 485);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlJogo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlJogo.ResumeLayout(false);
            this.pnlJogo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlJogo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblText;
    }
}

