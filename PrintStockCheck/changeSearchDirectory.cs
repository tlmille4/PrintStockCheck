using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintStockCheck
{
    public partial class changeSearchDirectory : Form
    {
        public string newDir = "";
        public changeSearchDirectory()
        {
            InitializeComponent();

        }

        private void btnChangeDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofDialog = new FolderBrowserDialog();
            

            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                txtDirectoryName.Text = ofDialog.SelectedPath;
                newDir = ofDialog.SelectedPath;
                stockCheckMain.imgDir = ofDialog.SelectedPath;
                
                Console.WriteLine(stockCheckMain.imgDir);
                
                
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
