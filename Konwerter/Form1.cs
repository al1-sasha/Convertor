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



namespace Konwerter
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void bB_OpenDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog1.ShowDialog();
                var filePatch = folderBrowserDialog1.SelectedPath;
                listBox1.Items.Clear();
                var path = System.IO.Path.Combine(filePatch);
                var dir = new System.IO.DirectoryInfo(path);
                foreach (string File in Directory.GetFiles(path, TB_Rosrz.Text, SearchOption.AllDirectories))
                {
                    listBox1.Items.Add(File);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B_jpg2pdf_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= listBox1.Items.Count - 1; i++)
            {

                string source = listBox1.Items[i].ToString();
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
            MessageBox.Show("koniec");
        }
        public void splitPdfByPages(String sourcePdf, int numOfPages, string baseNameOutPdf)
        {
            iTextSharp.text.pdf.RandomAccessFileOrArray raf = null;
            iTextSharp.text.pdf.PdfReader reader = null;
            iTextSharp.text.Document doc = null;
            iTextSharp.text.pdf.PdfCopy pdfCpy = null;
            iTextSharp.text.pdf.PdfImportedPage page = null;
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
            string sourcePdf = listBox1.SelectedItem.ToString();
            string file = Path.GetFileName(listBox1.SelectedItem.ToString());
            //splitPdfByPages(@"C:\Users\saleksak.OPGKLUBLIN\Desktop\P.0615.2016.169\L5.pdf", 1, "L5");
            splitPdfByPages(sourcePdf, 1, file);
        }
        
        private void b_pdf2jpg_Click(object sender, EventArgs e)
        {

        }

    }
}
