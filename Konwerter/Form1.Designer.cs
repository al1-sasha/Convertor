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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.B_OpenDirectory = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.B_jpg2pdf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.b_pdf2jpg = new System.Windows.Forms.Button();
            this.b_joinPdf = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.b_delI = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_OpenDirectory
            // 
            this.B_OpenDirectory.Location = new System.Drawing.Point(30, 38);
            this.B_OpenDirectory.Name = "B_OpenDirectory";
            this.B_OpenDirectory.Size = new System.Drawing.Size(87, 33);
            this.B_OpenDirectory.TabIndex = 0;
            this.B_OpenDirectory.Text = "Otwórz katalog";
            this.toolTip1.SetToolTip(this.B_OpenDirectory, "Wybierz katalog , w którym znajdują się pliki do przetwarzania.");
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
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // B_jpg2pdf
            // 
            this.B_jpg2pdf.Location = new System.Drawing.Point(30, 125);
            this.B_jpg2pdf.Name = "B_jpg2pdf";
            this.B_jpg2pdf.Size = new System.Drawing.Size(87, 35);
            this.B_jpg2pdf.TabIndex = 3;
            this.B_jpg2pdf.Text = "JPG/TIF->PDF";
            this.toolTip2.SetToolTip(this.B_jpg2pdf, "Konwertuje wskayane pliki jpg do formatu pdf.");
            this.B_jpg2pdf.UseVisualStyleBackColor = true;
            this.B_jpg2pdf.Click += new System.EventHandler(this.B_jpg2pdf_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Podziel plik pdf";
            this.toolTip4.SetToolTip(this.button1, "Dzieli wybrany plik pdf na pojedyńcze strony.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_pdf2jpg
            // 
            this.b_pdf2jpg.Location = new System.Drawing.Point(30, 175);
            this.b_pdf2jpg.Name = "b_pdf2jpg";
            this.b_pdf2jpg.Size = new System.Drawing.Size(87, 35);
            this.b_pdf2jpg.TabIndex = 5;
            this.b_pdf2jpg.Text = "PDF->JPG";
            this.toolTip3.SetToolTip(this.b_pdf2jpg, "Konwertuje wzbrane pliki pdf do formatu jpg.");
            this.b_pdf2jpg.UseVisualStyleBackColor = true;
            this.b_pdf2jpg.Click += new System.EventHandler(this.b_pdf2jpg_Click);
            // 
            // b_joinPdf
            // 
            this.b_joinPdf.Location = new System.Drawing.Point(30, 280);
            this.b_joinPdf.Name = "b_joinPdf";
            this.b_joinPdf.Size = new System.Drawing.Size(87, 35);
            this.b_joinPdf.TabIndex = 6;
            this.b_joinPdf.Text = "Połącz";
            this.toolTip5.SetToolTip(this.b_joinPdf, "Łączy wskazane pliki pdf i zapisuje do nowego pliku.");
            this.b_joinPdf.UseVisualStyleBackColor = true;
            this.b_joinPdf.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_delI
            // 
            this.b_delI.Location = new System.Drawing.Point(443, 195);
            this.b_delI.Name = "b_delI";
            this.b_delI.Size = new System.Drawing.Size(75, 23);
            this.b_delI.TabIndex = 7;
            this.b_delI.Text = "Usuń z listy";
            this.b_delI.UseVisualStyleBackColor = true;
            this.b_delI.Click += new System.EventHandler(this.b_delI_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(540, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Plik łączony";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "*.tif",
            "*.jpg",
            "*.pdf"});
            this.comboBox1.Location = new System.Drawing.Point(30, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "*.jpg";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 26);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(34, 22);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem});
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 385);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.b_delI);
            this.Controls.Add(this.b_joinPdf);
            this.Controls.Add(this.b_pdf2jpg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.B_jpg2pdf);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.B_OpenDirectory);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Konwerter jpg < --> pdf";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_OpenDirectory;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button B_jpg2pdf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_pdf2jpg;
        private System.Windows.Forms.Button b_joinPdf;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.Button b_delI;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
    }
}

