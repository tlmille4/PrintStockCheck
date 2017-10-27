namespace PrintStockCheck
{
    partial class changeSearchDirectory
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
            this.txtDirectoryName = new System.Windows.Forms.TextBox();
            this.lblDirectoryName = new System.Windows.Forms.Label();
            this.btnChangeDirectory = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDirectoryName
            // 
            this.txtDirectoryName.Location = new System.Drawing.Point(80, 46);
            this.txtDirectoryName.Name = "txtDirectoryName";
            this.txtDirectoryName.Size = new System.Drawing.Size(298, 20);
            this.txtDirectoryName.TabIndex = 0;
            // 
            // lblDirectoryName
            // 
            this.lblDirectoryName.AutoSize = true;
            this.lblDirectoryName.Location = new System.Drawing.Point(22, 49);
            this.lblDirectoryName.Name = "lblDirectoryName";
            this.lblDirectoryName.Size = new System.Drawing.Size(52, 13);
            this.lblDirectoryName.TabIndex = 1;
            this.lblDirectoryName.Text = "Directory:";
            // 
            // btnChangeDirectory
            // 
            this.btnChangeDirectory.Location = new System.Drawing.Point(80, 83);
            this.btnChangeDirectory.Name = "btnChangeDirectory";
            this.btnChangeDirectory.Size = new System.Drawing.Size(163, 23);
            this.btnChangeDirectory.TabIndex = 2;
            this.btnChangeDirectory.Text = "Select New Directory";
            this.btnChangeDirectory.UseVisualStyleBackColor = true;
            this.btnChangeDirectory.Click += new System.EventHandler(this.btnChangeDirectory_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(260, 83);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // changeSearchDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 157);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChangeDirectory);
            this.Controls.Add(this.lblDirectoryName);
            this.Controls.Add(this.txtDirectoryName);
            this.Name = "changeSearchDirectory";
            this.Text = "Change Search Directory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirectoryName;
        private System.Windows.Forms.Label lblDirectoryName;
        private System.Windows.Forms.Button btnChangeDirectory;
        private System.Windows.Forms.Button btnSave;
    }
}