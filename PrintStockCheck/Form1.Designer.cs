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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stockCheckMain));
            this.btnInFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.lblSearchDirectory = new System.Windows.Forms.Label();
            this.lblSearchDir = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPercentComplete = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInFile
            // 
            this.btnInFile.Location = new System.Drawing.Point(22, 184);
            this.btnInFile.Name = "btnInFile";
            this.btnInFile.Size = new System.Drawing.Size(103, 23);
            this.btnInFile.TabIndex = 0;
            this.btnInFile.Text = "Select Input File";
            this.btnInFile.UseVisualStyleBackColor = true;
            this.btnInFile.Click += new System.EventHandler(this.btnInFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(131, 186);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(317, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(199, 231);
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
            this.grpStatus.Controls.Add(this.lblSearchDirectory);
            this.grpStatus.Controls.Add(this.lblSearchDir);
            this.grpStatus.Controls.Add(this.lblStatus);
            this.grpStatus.Controls.Add(this.lblPercentComplete);
            this.grpStatus.Controls.Add(this.progressBar1);
            this.grpStatus.Location = new System.Drawing.Point(22, 274);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(426, 126);
            this.grpStatus.TabIndex = 4;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Scan Status";
            // 
            // lblSearchDirectory
            // 
            this.lblSearchDirectory.AutoSize = true;
            this.lblSearchDirectory.Location = new System.Drawing.Point(155, 25);
            this.lblSearchDirectory.Name = "lblSearchDirectory";
            this.lblSearchDirectory.Size = new System.Drawing.Size(0, 13);
            this.lblSearchDirectory.TabIndex = 8;
            // 
            // lblSearchDir
            // 
            this.lblSearchDir.AutoSize = true;
            this.lblSearchDir.Location = new System.Drawing.Point(59, 25);
            this.lblSearchDir.Name = "lblSearchDir";
            this.lblSearchDir.Size = new System.Drawing.Size(89, 13);
            this.lblSearchDir.TabIndex = 7;
            this.lblSearchDir.Text = "Search Directory:";
            // 
            // lblStatus
            // 
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(2, 83);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrintStockCheck.Properties.Resources.framed_art_logo;
            this.pictureBox1.Location = new System.Drawing.Point(97, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 106);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.mnuChangeSearch,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fileToolStripMenuItem.Text = "Preferences";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mnuChangeSearch
            // 
            this.mnuChangeSearch.Name = "mnuChangeSearch";
            this.mnuChangeSearch.Size = new System.Drawing.Size(204, 22);
            this.mnuChangeSearch.Text = "Change Search Directory";
            this.mnuChangeSearch.Click += new System.EventHandler(this.mnuChangeSearch_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // stockCheckMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 439);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnInFile);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "stockCheckMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Stock Checker";
            this.Load += new System.EventHandler(this.stockCheckMain_Load);
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeSearch;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label lblSearchDirectory;
        private System.Windows.Forms.Label lblSearchDir;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

