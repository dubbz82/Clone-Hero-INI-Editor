namespace WindowsFormsApp1
{
    partial class frmBulkEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewValue = new System.Windows.Forms.TextBox();
            this.cboNewValue = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.grpIconInformation = new System.Windows.Forms.GroupBox();
            this.lblIconName = new System.Windows.Forms.Label();
            this.btnUpdateIcon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFullFilePath = new System.Windows.Forms.Label();
            this.grpIconInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Field";
            // 
            // cboField
            // 
            this.cboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(44, 56);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(121, 21);
            this.cboField.TabIndex = 1;
            this.cboField.SelectedIndexChanged += new System.EventHandler(this.cboField_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Value";
            // 
            // txtNewValue
            // 
            this.txtNewValue.Location = new System.Drawing.Point(383, 56);
            this.txtNewValue.Name = "txtNewValue";
            this.txtNewValue.Size = new System.Drawing.Size(202, 20);
            this.txtNewValue.TabIndex = 3;
            this.txtNewValue.TextChanged += new System.EventHandler(this.txtNewValue_TextChanged);
            // 
            // cboNewValue
            // 
            this.cboNewValue.FormattingEnabled = true;
            this.cboNewValue.Location = new System.Drawing.Point(383, 54);
            this.cboNewValue.Name = "cboNewValue";
            this.cboNewValue.Size = new System.Drawing.Size(89, 21);
            this.cboNewValue.TabIndex = 4;
            this.cboNewValue.SelectedIndexChanged += new System.EventHandler(this.cboNewValue_SelectedIndexChanged);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(304, 261);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Update";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // grpIconInformation
            // 
            this.grpIconInformation.Controls.Add(this.lblFullFilePath);
            this.grpIconInformation.Controls.Add(this.label3);
            this.grpIconInformation.Controls.Add(this.btnUpdateIcon);
            this.grpIconInformation.Controls.Add(this.lblIconName);
            this.grpIconInformation.Location = new System.Drawing.Point(201, 102);
            this.grpIconInformation.Name = "grpIconInformation";
            this.grpIconInformation.Size = new System.Drawing.Size(271, 129);
            this.grpIconInformation.TabIndex = 6;
            this.grpIconInformation.TabStop = false;
            this.grpIconInformation.Text = "Icon information";
            this.grpIconInformation.Visible = false;
            // 
            // lblIconName
            // 
            this.lblIconName.AutoSize = true;
            this.lblIconName.Location = new System.Drawing.Point(43, 70);
            this.lblIconName.Name = "lblIconName";
            this.lblIconName.Size = new System.Drawing.Size(43, 13);
            this.lblIconName.TabIndex = 0;
            this.lblIconName.Text = "Not Set";
            // 
            // btnUpdateIcon
            // 
            this.btnUpdateIcon.Location = new System.Drawing.Point(146, 65);
            this.btnUpdateIcon.Name = "btnUpdateIcon";
            this.btnUpdateIcon.Size = new System.Drawing.Size(92, 23);
            this.btnUpdateIcon.TabIndex = 1;
            this.btnUpdateIcon.Text = "Update icon";
            this.btnUpdateIcon.UseVisualStyleBackColor = true;
            this.btnUpdateIcon.Click += new System.EventHandler(this.btnUpdateIcon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Icon Filename";
            // 
            // lblFullFilePath
            // 
            this.lblFullFilePath.AutoSize = true;
            this.lblFullFilePath.Location = new System.Drawing.Point(43, 97);
            this.lblFullFilePath.Name = "lblFullFilePath";
            this.lblFullFilePath.Size = new System.Drawing.Size(0, 13);
            this.lblFullFilePath.TabIndex = 3;
            this.lblFullFilePath.Visible = false;
            // 
            // frmBulkEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 296);
            this.Controls.Add(this.grpIconInformation);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cboNewValue);
            this.Controls.Add(this.txtNewValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboField);
            this.Controls.Add(this.label1);
            this.Name = "frmBulkEdit";
            this.Text = "Bulk Edit";
            this.Load += new System.EventHandler(this.frmBulkEdit_Load);
            this.grpIconInformation.ResumeLayout(false);
            this.grpIconInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewValue;
        private System.Windows.Forms.ComboBox cboNewValue;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.GroupBox grpIconInformation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateIcon;
        private System.Windows.Forms.Label lblIconName;
        private System.Windows.Forms.Label lblFullFilePath;
    }
}