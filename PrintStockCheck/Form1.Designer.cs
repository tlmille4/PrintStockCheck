namespace PrintStockCheck
{
    partial class stockCheckMain
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
            this.btnInFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPercentComplete = new System.Windows.Forms.Label();
            this.grpStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInFile
            // 
            this.btnInFile.Location = new System.Drawing.Point(22, 51);
            this.btnInFile.Name = "btnInFile";
            this.btnInFile.Size = new System.Drawing.Size(103, 23);
            this.btnInFile.TabIndex = 0;
            this.btnInFile.Text = "Select Input File";
            this.btnInFile.UseVisualStyleBackColor = true;
            this.btnInFile.Click += new System.EventHandler(this.btnInFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(131, 53);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(317, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(199, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search File";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(62, 41);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(282, 29);
            this.progressBar1.TabIndex = 3;
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.lblStatus);
            this.grpStatus.Controls.Add(this.lblPercentComplete);
            this.grpStatus.Controls.Add(this.progressBar1);
            this.grpStatus.Location = new System.Drawing.Point(22, 138);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(426, 126);
            this.grpStatus.TabIndex = 4;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Scan Status";
            // 
            // lblStatus
            // 
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(0, 83);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(420, 29);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Scan Not Yet Started";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.AutoSize = true;
            this.lblPercentComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentComplete.Location = new System.Drawing.Point(357, 46);
            this.lblPercentComplete.Name = "lblPercentComplete";
            this.lblPercentComplete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPercentComplete.Size = new System.Drawing.Size(29, 18);
            this.lblPercentComplete.TabIndex = 4;
            this.lblPercentComplete.Text = "0%";
            // 
            // stockCheckMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 294);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnInFile);
            this.Name = "stockCheckMain";
            this.Text = "Print Stock Checker";
            this.Load += new System.EventHandler(this.stockCheckMain_Load);
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPercentComplete;
    }
}

