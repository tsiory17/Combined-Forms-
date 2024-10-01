namespace Final_Project
{
    partial class IPValidator
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
            this.txtV4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtV6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReadAndDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtV4
            // 
            this.txtV4.Location = new System.Drawing.Point(196, 90);
            this.txtV4.Name = "txtV4";
            this.txtV4.Size = new System.Drawing.Size(359, 26);
            this.txtV4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Today:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtV6
            // 
            this.txtV6.Location = new System.Drawing.Point(196, 143);
            this.txtV6.Name = "txtV6";
            this.txtV6.Size = new System.Drawing.Size(359, 26);
            this.txtV6.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter IP v4 Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter IP v6 Address:";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(27, 241);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(122, 38);
            this.btnValidate.TabIndex = 5;
            this.btnValidate.Text = "Validate IP";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(196, 216);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 38);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(356, 241);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 38);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReadAndDisplay
            // 
            this.btnReadAndDisplay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReadAndDisplay.Location = new System.Drawing.Point(165, 270);
            this.btnReadAndDisplay.Name = "btnReadAndDisplay";
            this.btnReadAndDisplay.Size = new System.Drawing.Size(171, 38);
            this.btnReadAndDisplay.TabIndex = 8;
            this.btnReadAndDisplay.Text = "Read and display";
            this.btnReadAndDisplay.UseVisualStyleBackColor = true;
            this.btnReadAndDisplay.Click += new System.EventHandler(this.btnReadAndDisplay_Click);
            // 
            // IPValidator
            // 
            this.AcceptButton = this.btnValidate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnReadAndDisplay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtV6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtV4);
            this.Name = "IPValidator";
            this.Text = "IPValidator + Rakotoarimanana Tsiory";
            this.Load += new System.EventHandler(this.IPValidator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtV4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtV6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReadAndDisplay;
    }
}