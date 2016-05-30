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
            this.SuspendLayout();
            // 
            // B_OpenDirectory
            // 
            this.B_OpenDirectory.Location = new System.Drawing.Point(30, 40);
            this.B_OpenDirectory.Name = "B_OpenDirectory";
            this.B_OpenDirectory.Size = new System.Drawing.Size(87, 26);
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
            this.TB_Rosrz.Location = new System.Drawing.Point(30, 238);
            this.TB_Rosrz.Name = "TB_Rosrz";
            this.TB_Rosrz.Size = new System.Drawing.Size(100, 20);
            this.TB_Rosrz.TabIndex = 2;
            this.TB_Rosrz.Text = "*.jpg";
            // 
            // B_jpg2pdf
            // 
            this.B_jpg2pdf.Location = new System.Drawing.Point(30, 84);
            this.B_jpg2pdf.Name = "B_jpg2pdf";
            this.B_jpg2pdf.Size = new System.Drawing.Size(87, 23);
            this.B_jpg2pdf.TabIndex = 3;
            this.B_jpg2pdf.Text = "JPG->PDF";
            this.B_jpg2pdf.UseVisualStyleBackColor = true;
            this.B_jpg2pdf.Click += new System.EventHandler(this.B_jpg2pdf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 621);
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
    }
}

