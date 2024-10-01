namespace Final_Project
{
    partial class frmTemp
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
            this.radioCtoF = new System.Windows.Forms.RadioButton();
            this.radioFtoC = new System.Windows.Forms.RadioButton();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnLeave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioCtoF
            // 
            this.radioCtoF.AutoSize = true;
            this.radioCtoF.Location = new System.Drawing.Point(242, 32);
            this.radioCtoF.Name = "radioCtoF";
            this.radioCtoF.Size = new System.Drawing.Size(113, 24);
            this.radioCtoF.TabIndex = 0;
            this.radioCtoF.TabStop = true;
            this.radioCtoF.Text = "from C to F";
            this.radioCtoF.UseVisualStyleBackColor = true;
            this.radioCtoF.CheckedChanged += new System.EventHandler(this.radioCtoF_CheckedChanged);
            // 
            // radioFtoC
            // 
            this.radioFtoC.AutoSize = true;
            this.radioFtoC.Location = new System.Drawing.Point(242, 85);
            this.radioFtoC.Name = "radioFtoC";
            this.radioFtoC.Size = new System.Drawing.Size(113, 24);
            this.radioFtoC.TabIndex = 1;
            this.radioFtoC.TabStop = true;
            this.radioFtoC.Text = "from F to C";
            this.radioFtoC.UseVisualStyleBackColor = true;
            this.radioFtoC.CheckedChanged += new System.EventHandler(this.radioFtoC_CheckedChanged);
            // 
            // txtFrom
            // 
            this.txtFrom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFrom.Location = new System.Drawing.Point(99, 149);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(156, 26);
            this.txtFrom.TabIndex = 3;
            this.txtFrom.Text = "0";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(323, 149);
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.Size = new System.Drawing.Size(156, 26);
            this.txtTo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "to";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(173, 182);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(21, 20);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "C";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.Location = new System.Drawing.Point(391, 182);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(20, 20);
            this.lblF.TabIndex = 7;
            this.lblF.Text = "F";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(37, 486);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(106, 38);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(258, 486);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(106, 38);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "&Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Message";
            // 
            // txtDisplay
            // 
            this.txtDisplay.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDisplay.Location = new System.Drawing.Point(54, 238);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(486, 124);
            this.txtDisplay.TabIndex = 12;
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(442, 486);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(113, 38);
            this.btnLeave.TabIndex = 13;
            this.btnLeave.Text = "&Exit";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // frmTemp
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.radioFtoC);
            this.Controls.Add(this.radioCtoF);
            this.Name = "frmTemp";
            this.Text = "Temp App-Tsiory Rakotoarimanana";
            this.Load += new System.EventHandler(this.frmTemp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioCtoF;
        private System.Windows.Forms.RadioButton radioFtoC;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnLeave;
    }
}