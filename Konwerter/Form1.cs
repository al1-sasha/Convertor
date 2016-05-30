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

        private void B_jpg2pdf_Click(object sender, EventArgs e)
         

        {
            for (int i = 0; i <= listBox1.Items.Count -1; i++)
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
      
        
    }
    
}
