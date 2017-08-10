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

namespace PrintStockCheck
{
    public partial class stockCheckMain : Form
    {
        static string imgDir = "C:\\Users\\Tyler PC\\Dropbox\\Camera Uploads";
        string fileLocation = "";
        int currImg = 0;
        string currSku = "Pareto Chart Information";
        
        
        //string[] images = Directory.GetFiles(imgDir, "*.jpg");

        
     

        //var files = Directory.GetFiles("C:\\path", "*.*", SearchOption.AllDirectories)
        //            .Where(s => s.EndsWith(".mp3") || s.EndsWith(".jpg"));

        public stockCheckMain()
        {
            InitializeComponent();
            openFileDialog.Filter = "CSV Files (*.csv)| *.csv";
            openFileDialog.Filter = "Excel Files (*.xls)| *.xls";
            openFileDialog.Filter = "Excel Files (*.xlsx)| *.xlsx";

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
            
 
        }

        private void checkSkuMatch()
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlApp.Visible = true;


            try
            {
                Workbook wb = xlApp.Workbooks.Open(fileLocation);
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


                    string skuData = row.Cells[1, 1].Value.ToString();


                    //EXTRAPOLATE SKU
                    string[] tempSku = skuData.Split('-');

                    if (tempSku.Length >= 2)
                    {
                        string searchSku = tempSku[1];
                        Console.WriteLine(searchSku);
                        string[] images = Directory.GetFiles(imgDir, "*" + searchSku + "*.*");
                        Console.WriteLine("Img Length: " + images.Length);
                        if (images.Length > 0)
                            checkDirectory(currRow, ws, row, images, searchSku);
                        else
                            Console.WriteLine("NOT IN FILE SYSTEM");

                    }
                    this.progressBar1.Value = currRow;
                    this.progressBar1.Update();




                    percentComplete = (double)currRow / totalRows * 100;

                    lblPercentComplete.Text = Math.Round(percentComplete, 1).ToString() + "%";
                    this.Refresh();
                    currRow++;

                }

                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Scan Complete";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Whoops! The file you're trying to use is either non-existant or invalid. Please try another file. \n Error: " + ex);

            }



        }

        public void checkDirectory(int currRow, Worksheet ws, Range row, string[] images, string skuData)
        {
            string currDirFile;
           // string indata;

            for (int i = 0; i < images.Length; i++)
            {
                currDirFile = Path.GetFileNameWithoutExtension(images[i]);
                //Console.WriteLine(currDirFile);
                
                //Console.WriteLine(indata);
                if (skuData == currDirFile)
                {
                    //TO DO LOGIC IN EXCEL
                    Console.WriteLine("EXACT MATCH");
                    ws.Cells[currRow, 6] = "Scanned";
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



                        // Console.WriteLine(indata);
                    }
                    else
                    {
                        Console.WriteLine("NOT  MATCH");

                    }
                }
            }

            /*
            if (images.Length > 0 && currImg < images.Length)
            {

                
                String currDirFile = Path.GetFileNameWithoutExtension(images[currImg]);
                Console.WriteLine(currDirFile);
                string indata = row.Cells[1, 1].Value.ToString();
                Console.WriteLine(indata);
                if (indata == currDirFile)
                {
                    //TO DO LOGIC IN EXCEL
                    Console.WriteLine("IT WAS A MATCH");
                    Console.WriteLine(indata);
                }
                else
                {
                    //TO DO LOGIC EXTRAPOLATE FROM SKU AND CYCLE THROUGH ALL FILES

                    //Checking that current Excel sku contains the current directory file and that the directory file isn't a small thumbnail image
                    if (currSku.Contains(currDirFile) && !currDirFile.Contains("jpg"))
                    {
                        //THIS MEANS ITS A VALID MATCH, SEND TO FUNCTION TO PROCESS EXCEL
                        Console.WriteLine("match");

                        Console.WriteLine(indata);
                    }
                    else
                    {
                        Console.WriteLine("NOT  MATCH");
                        currImg++;
                        checkDirectory(row);
                    }
                }
            }
            else
                Console.WriteLine("End of directory search");
                */
        }

        public void MarkExcelFile()
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
                return;
            }
            xlApp.Visible = true;

            Workbook wb = xlApp.Workbooks.Open(fileLocation);
           // Workbook wb = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            Range usedRange = ws.UsedRange;

            foreach (Range row in usedRange.Rows)
            {
                    string indata = row.Cells[1,1].Value.ToString();
                   // Console.WriteLine(indata);
            }



            if (ws == null)
            {
                Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
            }

            // Select the Excel cells, in the range c1 to c7 in the worksheet.
            Range aRange = ws.get_Range("C1", "C7");

            if (aRange == null)
            {
                Console.WriteLine("Could not get a range. Check to be sure you have the correct versions of the office DLLs.");
            }

            // Fill the cells in the C1 to C7 range of the worksheet with the number 6.
            Object[] args = new Object[1];
            args[0] = 6;
            aRange.GetType().InvokeMember("Value", BindingFlags.SetProperty, null, aRange, args);

            // Change the cells in the C1 to C7 range of the worksheet to the number 8.
            aRange.Value2 = 8;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                checkSkuMatch();
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show("Whoops! The file you're trying to use is either non-existant or invalid. Please try another file. \n Error: " + ex);

            }
            
           
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

    }
  }
