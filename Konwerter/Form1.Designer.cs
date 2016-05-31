namespace Konwerter
{
    partial class Form1
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
            this.B_OpenDirectory = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TB_Rosrz = new System.Windows.Forms.TextBox();
            this.B_jpg2pdf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.b_pdf2jpg = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_OpenDirectory
            // 
            this.B_OpenDirectory.Location = new System.Drawing.Point(30, 31);
            this.B_OpenDirectory.Name = "B_OpenDirectory";
            this.B_OpenDirectory.Size = new System.Drawing.Size(87, 35);
            this.B_OpenDirectory.TabIndex = 0;
            this.B_OpenDirectory.Text = "Otwórz katalog";
            this.B_OpenDirectory.UseVisualStyleBackColor = true;
            this.B_OpenDirectory.Click += new System.EventHandler(this.bB_OpenDirectory_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(221, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(540, 173);
            this.listBox1.TabIndex = 1;
            // 
            // TB_Rosrz
            // 
            this.TB_Rosrz.Location = new System.Drawing.Point(123, 46);
            this.TB_Rosrz.Name = "TB_Rosrz";
            this.TB_Rosrz.Size = new System.Drawing.Size(83, 20);
            this.TB_Rosrz.TabIndex = 2;
            this.TB_Rosrz.Text = "*.jpg";
            // 
            // B_jpg2pdf
            // 
            this.B_jpg2pdf.Location = new System.Drawing.Point(30, 84);
            this.B_jpg2pdf.Name = "B_jpg2pdf";
            this.B_jpg2pdf.Size = new System.Drawing.Size(87, 35);
            this.B_jpg2pdf.TabIndex = 3;
            this.B_jpg2pdf.Text = "JPG->PDF";
            this.B_jpg2pdf.UseVisualStyleBackColor = true;
            this.B_jpg2pdf.Click += new System.EventHandler(this.B_jpg2pdf_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Podziel plik pdf";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_pdf2jpg
            // 
            this.b_pdf2jpg.Location = new System.Drawing.Point(30, 134);
            this.b_pdf2jpg.Name = "b_pdf2jpg";
            this.b_pdf2jpg.Size = new System.Drawing.Size(87, 35);
            this.b_pdf2jpg.TabIndex = 5;
            this.b_pdf2jpg.Text = "PDF->JPG";
            this.b_pdf2jpg.UseVisualStyleBackColor = true;
            this.b_pdf2jpg.Click += new System.EventHandler(this.b_pdf2jpg_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 314);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.b_pdf2jpg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.B_jpg2pdf);
            this.Controls.Add(this.TB_Rosrz);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.B_OpenDirectory);
            this.Name = "Form1";
            this.Text = "Konwerter jpg < --> pdf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_OpenDirectory;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox TB_Rosrz;
        private System.Windows.Forms.Button B_jpg2pdf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_pdf2jpg;
        private System.Windows.Forms.Button button2;
    }
}

