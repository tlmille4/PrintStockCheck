using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintStockCheck
{
    public partial class stockCheckMain : Form
    {
        String fileLocation = "";

        public stockCheckMain()
        {
            InitializeComponent();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            String filepath;
            filepath = openFileDialog.FileName;

        }

        private void btnInFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
                fileLocation = openFileDialog.FileName;
            }
        }

        private void stockCheckMain_Load(object sender, EventArgs e)
        {

            String currSku = "5a8utyre";
            String[] images = Directory.GetFiles("C:\\Users\\Tyler PC\\Downloads", "*.jpg");
            

            if (images.Length > 0)
            {
                String currDirFile = Path.GetFileNameWithoutExtension(images[0]);
                Console.WriteLine(currDirFile);


                if (currSku == currDirFile)
                {
                    //TO DO LOGIC IN EXCEL
                    Console.WriteLine("IT WAS A MATCH");
                }
                else
                {
                    //TO DO LOGIC EXTRAPOLATE FROM SKU AND CYCLE THROUGH ALL FILES
                    Console.WriteLine("NOT A MATCH");
                }
                

            }
            
        }
    }
}
