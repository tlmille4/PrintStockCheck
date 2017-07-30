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
        static string imgDir = "C:\\Test";
        string fileLocation = "";
        int currImg = 0;
        string currSku = "5a8utyre";
        string[] images = Directory.GetFiles(imgDir, "*.jpg");

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
            checkSkuMatch();
 
        }

        private void checkSkuMatch()
        {
            if (images.Length > 0 && currImg < images.Length)
            {

                String currDirFile = Path.GetFileNameWithoutExtension(images[currImg]);
                Console.WriteLine(currDirFile);


                if (currSku == currDirFile)
                {
                    //TO DO LOGIC IN EXCEL
                    Console.WriteLine("IT WAS A MATCH");
                }
                else
                {
                    //TO DO LOGIC EXTRAPOLATE FROM SKU AND CYCLE THROUGH ALL FILES
                    Console.WriteLine("NOT EXACT MATCH");
                    //Checking that current Excel sku contains the current directory file and that the directory file isn't a small thumbnail image
                    if (currSku.Contains(currDirFile) && !currDirFile.Contains("jpg"))
                    {
                        //THIS MEANS ITS A VALID MATCH, SEND TO FUNCTION TO PROCESS EXCEL
                        Console.WriteLine("BITCH BETTA HAVE MY HONEY");
                    }
                    else
                    {
                        currImg++;
                        checkSkuMatch();
                    }
                }
            }
            else
                Console.WriteLine("No .JPG files in directory: " + imgDir);
        }
    }
}
