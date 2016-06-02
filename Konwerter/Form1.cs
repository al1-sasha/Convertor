using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using itextsharp;
using iTextSharp;
using GhostscriptSharp;
using Ghostscript.NET;




namespace Konwerter
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        iTextSharp.text.pdf.RandomAccessFileOrArray raf = null;
        iTextSharp.text.pdf.PdfReader reader = null;
        iTextSharp.text.Document doc = null;
        iTextSharp.text.pdf.PdfCopy pdfCpy = null;
        iTextSharp.text.pdf.PdfImportedPage page = null;

        private void bB_OpenDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog1.ShowDialog();
                var filePatch = folderBrowserDialog1.SelectedPath;
                listBox1.Items.Clear();
                var path = System.IO.Path.Combine(filePatch);
                var dir = new System.IO.DirectoryInfo(path);
                foreach (string File in Directory.GetFiles(path, comboBox1.Text, SearchOption.AllDirectories))
                {
                    listBox1.Items.Add(File);
                }
            }
            catch
            {
                //throw ex;
            }
        }

        public void B_jpg2pdf_Click(object sender, EventArgs e)
        {
            try
            {
                if(listBox1.SelectedItems.Count > 0 & comboBox1.Text == "*.jpg") 
                {                                                            
                    foreach (var item in listBox1.SelectedItems)     
                      {
                          Convert.ToString(item);
                          string source = Convert.ToString(item);
                    //for (int i = 0; i <= listBox1.Items.Count - 1; i++)
                    //{
                        //string source = listBox1.Items[i].ToString();
                        string name = Path.GetFileNameWithoutExtension(source);
                        string path = Path.GetFullPath(source);
                        iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(source);
                        //string[] name = Directory.GetFiles(listBox1.Items[i].ToString());
                        using (FileStream fs = new FileStream(source.Replace(".jpg", ".pdf"), FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            using (iTextSharp.text.Document doc = new iTextSharp.text.Document(image))
                            {
                                using (iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs))
                                {
                                    doc.Open();
                                    image.SetAbsolutePosition(0, 0);
                                    writer.DirectContent.AddImage(image);
                                    doc.Close();                                    
                                }
                            
                            }
                        }
                    }
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show("koniec");
                }
                else
                {
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show("Zaznacz pliki jpg na liście");
                    
                }
                
                }
             catch (Exception ex)
            {
                throw ex;
              
            }
        }
        public void splitPdfByPages(String sourcePdf, int numOfPages, string baseNameOutPdf)
        {
 
            int pageCount = 0;
            string path = Path.GetFullPath(sourcePdf);
            string separtator = "_";
            string extension = ".pdf";
            try
            {
                raf = new iTextSharp.text.pdf.RandomAccessFileOrArray(sourcePdf);
                reader = new iTextSharp.text.pdf.PdfReader(raf, null);
                pageCount = reader.NumberOfPages;
                if (pageCount < numOfPages)
                {
                    MessageBox.Show("Nie ma co dzielić");
                }
                else
                {
                    string counter;
                    string ext = System.IO.Path.GetExtension(baseNameOutPdf);
                    string outfile = string.Empty;
                    double m = pageCount / numOfPages;
                    int n = (int)Math.Ceiling(m);
                    int currentPage = 1;
                    string thename = Path.GetFileNameWithoutExtension(sourcePdf);
                    string name = Path.GetFileName(sourcePdf);
                    for (int i = 1; i <= pageCount; i++)
                    {
                        if (i < 10)
                            counter = "00";
                        else                            
                            counter = "0";
                        outfile = path.Replace(name, "") + thename + separtator + counter + i + extension;
                        //outfile = path + slash + thename + separtator + counter + i + extension;
                        //outfile = @"C:\Users\saleksak.OPGKLUBLIN\Desktop\P.0615.2016.169" + slash + thename + separtator + counter + i + extension;
                        doc = new iTextSharp.text.Document(reader.GetPageSizeWithRotation(currentPage));
                        pdfCpy = new iTextSharp.text.pdf.PdfCopy(doc, new System.IO.FileStream(outfile, System.IO.FileMode.Create));
                        doc.Open();
                        if (i < n)

                            for (int j = 1; j <= numOfPages; j++)
                            {
                                page = pdfCpy.GetImportedPage(reader, currentPage);
                                pdfCpy.AddPage(page);
                                currentPage += 1;
                            }
                        else

                            for (int j = currentPage; j <= pageCount; j++)
                            {
                                page = pdfCpy.GetImportedPage(reader, j);
                                pdfCpy.AddPage(page);
                            }
                        doc.Close();
                        Console.Beep();
                    }
                                    }
                reader.Close();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }               
            
         

        

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (listBox1.SelectedItems.Count == 1 | comboBox1.Text == "*.pdf")
                {
                    string sourcePdf = listBox1.SelectedItem.ToString();
                    string file = Path.GetFileName(listBox1.SelectedItem.ToString());
                    //splitPdfByPages(@"C:\Users\saleksak.OPGKLUBLIN\Desktop\P.0615.2016.169\L5.pdf", 1, "L5");
                    splitPdfByPages(sourcePdf, 1, file);
                }
                else
                {
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show("Wybierz plik do dzielenia");
                    
                }
            }
            catch
            {
            }
        }

        private void b_pdf2jpg_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex != -1 & comboBox1.Text == "*.pdf")
                {
                    
                    foreach (var item in listBox1.SelectedItems)     
                      {
                          Convert.ToString(item);
                          string sourcePdf = Convert.ToString(item);
                          string thename = Path.GetFileNameWithoutExtension(sourcePdf);
                            raf = new iTextSharp.text.pdf.RandomAccessFileOrArray(sourcePdf);
                            reader = new iTextSharp.text.pdf.PdfReader(raf, null);
                            var page = reader.GetPageSize(1);
                            int heigt = Convert.ToInt16(page.Height);
                            int width = Convert.ToInt16(page.Width);
                            //uzycie wprapera z Nuget
                            //GhostscriptWrapper.GeneratePageThumb(@sourcePdf, @sourcePdf.Replace("pdf", "jpg"), 1, width, heigt);
                            //GhostscriptWrapper.GeneratePageThumb(sourcePdf, sourcePdf.Replace("pdf", "jpg"), 1, 297, 210);
                            GhostscriptJpegDevice dev = new GhostscriptJpegDevice(GhostscriptJpegDeviceType.Jpeg);
                            dev.GraphicsAlphaBits = GhostscriptImageDeviceAlphaBits.V_4;
                            dev.TextAlphaBits = GhostscriptImageDeviceAlphaBits.V_4;
                            dev.ResolutionXY = new GhostscriptImageDeviceResolution(300, 300);
                            dev.JpegQuality = 100;
                            dev.InputFiles.Add(@sourcePdf);
                            dev.Pdf.FirstPage = 1;
                            dev.Pdf.LastPage = 1;
                            dev.OutputPath = @sourcePdf.Replace("pdf", "jpg");
                            dev.Process();
                        }
                   
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show("koniec");
                    }
                                  
                else
                {
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show("Wskaż pliki pdf na liście");
                   
                }
            }
            catch
            {
            }
        }          
               
        public void MergePdf(string[] pdfFiles, string outputPath)            
        {
            //bool result = false;
            int pdfCount = 0;
            int f = 0;
            string filename = String.Empty;
            iTextSharp.text.pdf.PdfReader reader = null;
            int pageCount = 0;
            iTextSharp.text.Document pdfDoc = null;
            iTextSharp.text.pdf.PdfWriter writer = null;
            iTextSharp.text.pdf.PdfContentByte cb = null;
            iTextSharp.text.pdf.PdfImportedPage page = null;
            int rotation = 0;
            iTextSharp.text.Font bookmarkFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 4, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.RED);

            try
            {
                pdfCount = pdfFiles.Length;
                if (pdfCount > 1)
                {
                    filename = pdfFiles[f];
                    reader = new iTextSharp.text.pdf.PdfReader(filename);
                    pageCount = reader.NumberOfPages;
                    pdfDoc = new iTextSharp.text.Document(reader.GetPageSizeWithRotation(1), 18, 18, 18, 18);
                    writer = iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, new System.IO.FileStream(outputPath, System.IO.FileMode.Create));
                    pdfDoc.AddAuthor("OPGK w Lublinie sp. z o. o. Sławomir Aleksak");
                    pdfDoc.AddCreator("Konwerter");
                    pdfDoc.Open();
                    cb = writer.DirectContent;
                    while (f < pdfCount)
                    {
                        var i = 0;
                        while(i < pageCount)
                        {
                            i += 1;
                            pdfDoc.SetPageSize(reader.GetPageSizeWithRotation(i));
                            pdfDoc.NewPage();
                            if (i == 1)
                            {                                
                                iTextSharp.text.Paragraph para = new iTextSharp.text.Paragraph(System.IO.Path.GetFileName(filename).ToUpper(), bookmarkFont);
                                iTextSharp.text.Chapter chpter = new iTextSharp.text.Chapter(para, f + 1);
                                pdfDoc.Add(chpter);
                            }
                            page = writer.GetImportedPage(reader, i);
                            rotation = reader.GetPageRotation(i);
                            if (rotation == 90)
                            {
                                cb.AddTemplate(page, 0, -1.0F, 1.0F, 0, 0, reader.GetPageSizeWithRotation(i).Height);                                
                            }
                            if (rotation == 270)
                            {
                                cb.AddTemplate(page, 0, 1.0F, -1.0F, 0, reader.GetPageSizeWithRotation(i).Width + 60, -30);
                            }
                            else
                            {
                                cb.AddTemplate(page, 1.0F, 0, 0, 1.0F, 0, 0);
                            }                            
                        }
                        f += 1;
                        if (f < pdfCount)
                        {
                        filename = pdfFiles[f];
                        reader = new iTextSharp.text.pdf.PdfReader(filename);
                        pageCount = reader.NumberOfPages;
                        }
                    }
                    pdfDoc.Close();
                    //result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                var output = textBox1.Text;

                //var input = listBox1.SelectedItems; 
                //string input = Convert.ToString(listBox1.SelectedItems.Count - 1);
                //string[] input = new string[listBox1.SelectedIte.Count];
                //listBox1.SelectedItems.CopyTo(input, 0);

                string[] input = new string[listBox1.SelectedItems.Count];
                listBox1.SelectedItems.CopyTo(input, 0);
                MergePdf(input, output);
                input.DefaultIfEmpty();
                output.DefaultIfEmpty();
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Zaznacz pliki na liście i wprowadź nazwę nowego pliku.");
            }

        }

        private void b_delI_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBox1);
            selectedItems = listBox1.SelectedItems;

            if (listBox1.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    listBox1.Items.Remove(selectedItems[i]);
            }
            else
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Zaznacz pliki na liście");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(listBox1.SelectedItem).Replace(".pdf", "_polaczony.pdf"); 
        }           
      
    }
}
