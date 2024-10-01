namespace Final_Project
{
    partial class frm649
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm649));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGenerate649 = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnReadAndDisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLeave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(21, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 284);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnGenerate649
            // 
            this.btnGenerate649.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGenerate649.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate649.Location = new System.Drawing.Point(12, 292);
            this.btnGenerate649.Name = "btnGenerate649";
            this.btnGenerate649.Size = new System.Drawing.Size(179, 118);
            this.btnGenerate649.TabIndex = 5;
            this.btnGenerate649.Text = "Generate 6+1 unique\r\nnumbers\r\nout of 50";
            this.btnGenerate649.UseVisualStyleBackColor = false;
            this.btnGenerate649.Click += new System.EventHandler(this.btnGenerate649_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDisplay.Location = new System.Drawing.Point(563, 292);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(49, 286);
            this.txtDisplay.TabIndex = 6;
            // 
            // btnReadAndDisplay
            // 
            this.btnReadAndDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReadAndDisplay.Location = new System.Drawing.Point(21, 523);
            this.btnReadAndDisplay.Name = "btnReadAndDisplay";
            this.btnReadAndDisplay.Size = new System.Drawing.Size(170, 118);
            this.btnReadAndDisplay.TabIndex = 7;
            this.btnReadAndDisplay.Text = "&Read and \r\nDisplay the \r\nText File";
            this.btnReadAndDisplay.UseVisualStyleBackColor = false;
            this.btnReadAndDisplay.Click += new System.EventHandler(this.btnReadAndDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "The winning numbers are :";
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(487, 602);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(125, 39);
            this.btnLeave.TabIndex = 9;
            this.btnLeave.Text = "&Exit";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // frm649
            // 
            this.AcceptButton = this.btnGenerate649;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 666);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReadAndDisplay);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnGenerate649);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm649";
            this.Text = "Lotto649 Rakotoarimanana Tsiory";
            this.Load += new System.EventHandler(this.frm649_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGenerate649;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnReadAndDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLeave;
    }
}