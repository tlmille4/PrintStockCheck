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
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using System.Collections;

namespace PrintStockCheck
{
   
    
    public partial class stockCheckMain : Form
    {
        //Default image director on external drive
        public static string imgDir = @"H:\Images\Scanned";

        
        string fileLocation = "";


        public stockCheckMain()
        {
            //GUI preferences
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
            openFileDialog.Filter = "Excel/CSV Files (*.csv, *.xls,*.xlsx)| *.csv; *.xls; *.xlsx";

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
            
            lblSearchDirectory.Text = imgDir;
           
        }

        private void checkSkuMatch()
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            


            try
            {
                Workbook wb = xlApp.Workbooks.Open(fileLocation);
                xlApp.Visible = false;
                // Workbook wb = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                Worksheet ws = (Worksheet)wb.Worksheets[1];
                Range usedRange = ws.UsedRange;
                int totalRows = ws.UsedRange.Rows.Count;
                Console.WriteLine("Total Rows ----- " + totalRows);

                int currRow = 1;
                double percentComplete;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = totalRows;

                lblStatus.Text = "Scanning Excel Worksheet .. Please Wait .. ";

                
                foreach (Range row in usedRange.Rows)
                {
                    if (ws.Cells[currRow, 6].Value == null)
                    {


                        string skuData = row.Cells[1, 1].Value.ToString();
                        //EXTRAPOLATE SKU
                        try
                        {
                            string[] tempSku = skuData.Split('-');
                            if (tempSku.Length >= 2)
                            {
                                string searchSku = tempSku[1].ToUpper();
                                //Use regular expression to remove whitespace from sku
                                Regex.Replace(searchSku, @"\s+", "");
                                Console.WriteLine(searchSku);
                                string[] images = Directory.GetFiles(imgDir, "*" + searchSku + "*.*");
                                Console.WriteLine("Img Length: " + images.Length);
                                if (images.Length > 0)
                                    checkDirectory(currRow, ws, row, images, searchSku);
                                else
                                    Console.WriteLine("NOT IN FILE SYSTEM");

                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("There was an error extrapolating SKU data from Cell A" + currRow);
                            row.Interior.Color = System.Drawing.Color.Red;

                        }
                    }

                    //Update progress bar data
                    this.progressBar1.Value = currRow;
                    this.progressBar1.Update();

                    percentComplete = (double)currRow / totalRows * 100;

                    lblPercentComplete.Text = Math.Round(percentComplete, 1).ToString() + "%";
                    this.Refresh();
                    currRow++;

                }

                //Tell user scan is complete
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Scan Complete";
                
                MessageBox.Show("Scan Complete! All " + currRow + " row(s) of file '" + fileLocation + "' have been searched.", "Stock Search Complete");

                //Show excel file to user
                
                xlApp.Visible = true;
                this.Close();
            }
            catch (Exception ex)
            {
                //Tell user issue with excel file
                MessageBox.Show("Whoops! The file you're trying to use is either non-existant or invalid. Please try another file. \n Error: " + ex);
            }
        }

        public void checkDirectory(int currRow, Worksheet ws, Range row, string[] images, string skuData)
        {
            string currDirFile;

            for (int i = 0; i < images.Length; i++)
            {
                currDirFile = Path.GetFileNameWithoutExtension(images[i]).ToUpper();
                //Console.WriteLine(currDirFile);
                
                //Console.WriteLine(indata);
                if (skuData == currDirFile)
                {
                    //TO DO LOGIC IN EXCEL
                    Console.WriteLine("EXACT MATCH");
                    ws.Cells[currRow, 6] = "Scanned";
                    break;
                   // Console.WriteLine(indata);
                }
                else
                {
                    //TO DO LOGIC EXTRAPOLATE FROM SKU AND CYCLE THROUGH ALL FILES

                    //Checking that current Excel sku contains the current directory file and that the directory file isn't a small thumbnail image
                    if (currDirFile.Contains(skuData) && !currDirFile.Contains("jpg"))
                    {
                        //THIS MEANS ITS A VALID MATCH, SEND TO FUNCTION TO PROCESS EXCEL
                        Console.WriteLine("match");
                        ws.Cells[currRow, 6] = "Possible Match";

                    }
                    else if (skuData.All(c => Char.IsLetter(c)))
                    {
                        
                        Console.WriteLine("Possible Sku Error");
                        ws.Cells[currRow, 6] = "ERRONIOUS SKU";

                    }
                    else
                        Console.WriteLine("NOT  MATCH"); 
                }
            }

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool validFile = false;
            string file = txtFilePath.Text.ToUpper();
            Console.WriteLine(file);

            if (file.EndsWith(".CSV") || file.EndsWith(".XLSX") || file.EndsWith(".XLS"))
                validFile = true;

            if (file == "" || validFile == false)
                MessageBox.Show("Whoops! No excel file was detected. Please choose a valid CSV or Excel file to continue.");
            else
            {
                try
                {
                    checkSkuMatch();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Whoops! Something not-so-great has occured. Use the following as reference to this error: \n Error: " + ex);

                }
            }
            
           
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void emailWithQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuChangeSearch_Click(object sender, EventArgs e)
        {
            //changeSearchDirectory form = new changeSearchDirectory();
            //form.Show();
            //
            //lblSearchDirectory.Text = imgDir;

            FolderBrowserDialog ofDialog = new FolderBrowserDialog();


            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                //txtDirectoryName.Text = ofDialog.SelectedPath;
                //newDir = ofDialog.SelectedPath;
                imgDir = ofDialog.SelectedPath;
                lblSearchDirectory.Text = imgDir;
                this.Refresh();
                Console.WriteLine(stockCheckMain.imgDir);


            }

        }



        private void lblSearchDirectory_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }
    }
  }
