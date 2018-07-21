namespace TempConvert_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bttn_Convert = new System.Windows.Forms.Button();
            this.lbl_degreeTo = new System.Windows.Forms.Label();
            this.CmboBox_TempFrom = new System.Windows.Forms.ComboBox();
            this.CmboBox_TempTo = new System.Windows.Forms.ComboBox();
            this.txtBox_AfterConversion = new System.Windows.Forms.TextBox();
            this.txtBox_UserTemp = new System.Windows.Forms.TextBox();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_UserTempInput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_IsEmptyWarning = new System.Windows.Forms.Label();
            this.lbl_DegreeFrom = new System.Windows.Forms.Label();
            this.lbl_degreeToEmpty = new System.Windows.Forms.Label();
            this.lbl_degreeFromEmpty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bttn_Convert
            // 
            this.Bttn_Convert.Location = new System.Drawing.Point(127, 61);
            this.Bttn_Convert.Name = "Bttn_Convert";
            this.Bttn_Convert.Size = new System.Drawing.Size(56, 25);
            this.Bttn_Convert.TabIndex = 0;
            this.Bttn_Convert.Text = "Convert";
            this.Bttn_Convert.UseVisualStyleBackColor = true;
            this.Bttn_Convert.Click += new System.EventHandler(this.Bttn_Convert_Click);
            // 
            // lbl_degreeTo
            // 
            this.lbl_degreeTo.AutoSize = true;
            this.lbl_degreeTo.Location = new System.Drawing.Point(259, 69);
            this.lbl_degreeTo.Name = "lbl_degreeTo";
            this.lbl_degreeTo.Size = new System.Drawing.Size(35, 13);
            this.lbl_degreeTo.TabIndex = 1;
            this.lbl_degreeTo.Text = "label1";
            // 
            // CmboBox_TempFrom
            // 
            this.CmboBox_TempFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmboBox_TempFrom.FormattingEnabled = true;
            this.CmboBox_TempFrom.Location = new System.Drawing.Point(15, 12);
            this.CmboBox_TempFrom.MaxDropDownItems = 3;
            this.CmboBox_TempFrom.Name = "CmboBox_TempFrom";
            this.CmboBox_TempFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmboBox_TempFrom.Size = new System.Drawing.Size(121, 21);
            this.CmboBox_TempFrom.TabIndex = 3;
            this.CmboBox_TempFrom.SelectedIndexChanged += new System.EventHandler(this.CmboBox_TempFrom_SelectedIndexChanged);
            // 
            // CmboBox_TempTo
            // 
            this.CmboBox_TempTo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmboBox_TempTo.FormattingEnabled = true;
            this.CmboBox_TempTo.Location = new System.Drawing.Point(180, 12);
            this.CmboBox_TempTo.Name = "CmboBox_TempTo";
            this.CmboBox_TempTo.Size = new System.Drawing.Size(121, 21);
            this.CmboBox_TempTo.TabIndex = 4;
            this.CmboBox_TempTo.SelectedIndexChanged += new System.EventHandler(this.CmboBox_TempTo_SelectedIndexChanged);
            // 
            // txtBox_AfterConversion
            // 
            this.txtBox_AfterConversion.Enabled = false;
            this.txtBox_AfterConversion.Location = new System.Drawing.Point(203, 66);
            this.txtBox_AfterConversion.Name = "txtBox_AfterConversion";
            this.txtBox_AfterConversion.Size = new System.Drawing.Size(56, 20);
            this.txtBox_AfterConversion.TabIndex = 5;
            // 
            // txtBox_UserTemp
            // 
            this.txtBox_UserTemp.Location = new System.Drawing.Point(15, 66);
            this.txtBox_UserTemp.Name = "txtBox_UserTemp";
            this.txtBox_UserTemp.Size = new System.Drawing.Size(72, 20);
            this.txtBox_UserTemp.TabIndex = 6;
            this.txtBox_UserTemp.TextChanged += new System.EventHandler(this.TxtBox_UserTemp_TextChanged);
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(147, 15);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(20, 13);
            this.lbl_To.TabIndex = 7;
            this.lbl_To.Text = "To";
            // 
            // lbl_UserTempInput
            // 
            this.lbl_UserTempInput.AutoSize = true;
            this.lbl_UserTempInput.Location = new System.Drawing.Point(12, 51);
            this.lbl_UserTempInput.Name = "lbl_UserTempInput";
            this.lbl_UserTempInput.Size = new System.Drawing.Size(58, 13);
            this.lbl_UserTempInput.TabIndex = 8;
            this.lbl_UserTempInput.Text = "Your temp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Converted Temp:";
            // 
            // lbl_IsEmptyWarning
            // 
            this.lbl_IsEmptyWarning.AutoSize = true;
            this.lbl_IsEmptyWarning.Location = new System.Drawing.Point(12, 89);
            this.lbl_IsEmptyWarning.Name = "lbl_IsEmptyWarning";
            this.lbl_IsEmptyWarning.Size = new System.Drawing.Size(35, 13);
            this.lbl_IsEmptyWarning.TabIndex = 10;
            this.lbl_IsEmptyWarning.Text = "label1";
            this.lbl_IsEmptyWarning.Visible = false;
            // 
            // lbl_DegreeFrom
            // 
            this.lbl_DegreeFrom.AutoSize = true;
            this.lbl_DegreeFrom.Location = new System.Drawing.Point(90, 69);
            this.lbl_DegreeFrom.Name = "lbl_DegreeFrom";
            this.lbl_DegreeFrom.Size = new System.Drawing.Size(35, 13);
            this.lbl_DegreeFrom.TabIndex = 12;
            this.lbl_DegreeFrom.Text = "label1";
            // 
            // lbl_degreeToEmpty
            // 
            this.lbl_degreeToEmpty.AutoSize = true;
            this.lbl_degreeToEmpty.Location = new System.Drawing.Point(177, 36);
            this.lbl_degreeToEmpty.Name = "lbl_degreeToEmpty";
            this.lbl_degreeToEmpty.Size = new System.Drawing.Size(35, 13);
            this.lbl_degreeToEmpty.TabIndex = 13;
            this.lbl_degreeToEmpty.Text = "label1";
            this.lbl_degreeToEmpty.Visible = false;
            // 
            // lbl_degreeFromEmpty
            // 
            this.lbl_degreeFromEmpty.AutoSize = true;
            this.lbl_degreeFromEmpty.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_degreeFromEmpty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_degreeFromEmpty.Location = new System.Drawing.Point(12, 36);
            this.lbl_degreeFromEmpty.Name = "lbl_degreeFromEmpty";
            this.lbl_degreeFromEmpty.Size = new System.Drawing.Size(35, 13);
            this.lbl_degreeFromEmpty.TabIndex = 14;
            this.lbl_degreeFromEmpty.Text = "label1";
            this.lbl_degreeFromEmpty.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 111);
            this.Controls.Add(this.lbl_degreeFromEmpty);
            this.Controls.Add(this.lbl_degreeToEmpty);
            this.Controls.Add(this.lbl_DegreeFrom);
            this.Controls.Add(this.lbl_IsEmptyWarning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_UserTempInput);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.txtBox_UserTemp);
            this.Controls.Add(this.txtBox_AfterConversion);
            this.Controls.Add(this.CmboBox_TempTo);
            this.Controls.Add(this.CmboBox_TempFrom);
            this.Controls.Add(this.lbl_degreeTo);
            this.Controls.Add(this.Bttn_Convert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TempConvert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bttn_Convert;
        private System.Windows.Forms.Label lbl_degreeTo;
        private System.Windows.Forms.ComboBox CmboBox_TempFrom;
        private System.Windows.Forms.ComboBox CmboBox_TempTo;
        private System.Windows.Forms.TextBox txtBox_AfterConversion;
        private System.Windows.Forms.TextBox txtBox_UserTemp;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Label lbl_UserTempInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_IsEmptyWarning;
        private System.Windows.Forms.Label lbl_DegreeFrom;
        private System.Windows.Forms.Label lbl_degreeToEmpty;
        private System.Windows.Forms.Label lbl_degreeFromEmpty;
    }
}

