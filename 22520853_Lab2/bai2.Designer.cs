namespace _22520853_Lab2
{
    partial class bai2
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
            richTextFile = new RichTextBox();
            panel1 = new Panel();
            textChar = new TextBox();
            textWord = new TextBox();
            textLine = new TextBox();
            textUrl = new TextBox();
            textSize = new TextBox();
            textFile = new TextBox();
            label_Filename = new Label();
            label_Charcnt = new Label();
            label_Wordcnt = new Label();
            label_Linecnt = new Label();
            label_Url = new Label();
            label_Size = new Label();
            btn_Exit = new Button();
            btn_Read = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextFile
            // 
            richTextFile.BackColor = SystemColors.ActiveBorder;
            richTextFile.ForeColor = Color.Blue;
            richTextFile.Location = new Point(402, 29);
            richTextFile.Name = "richTextFile";
            richTextFile.Size = new Size(342, 409);
            richTextFile.TabIndex = 0;
            richTextFile.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(textChar);
            panel1.Controls.Add(textWord);
            panel1.Controls.Add(textLine);
            panel1.Controls.Add(textUrl);
            panel1.Controls.Add(textSize);
            panel1.Controls.Add(textFile);
            panel1.Controls.Add(label_Filename);
            panel1.Controls.Add(label_Charcnt);
            panel1.Controls.Add(label_Wordcnt);
            panel1.Controls.Add(label_Linecnt);
            panel1.Controls.Add(label_Url);
            panel1.Controls.Add(label_Size);
            panel1.Controls.Add(btn_Exit);
            panel1.Controls.Add(btn_Read);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(53, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 412);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // textChar
            // 
            textChar.Location = new Point(156, 312);
            textChar.Name = "textChar";
            textChar.Size = new Size(175, 27);
            textChar.TabIndex = 13;
            // 
            // textWord
            // 
            textWord.Location = new Point(156, 259);
            textWord.Name = "textWord";
            textWord.Size = new Size(175, 27);
            textWord.TabIndex = 12;
            // 
            // textLine
            // 
            textLine.Location = new Point(156, 211);
            textLine.Name = "textLine";
            textLine.Size = new Size(175, 27);
            textLine.TabIndex = 11;
            // 
            // textUrl
            // 
            textUrl.Location = new Point(156, 159);
            textUrl.Name = "textUrl";
            textUrl.Size = new Size(175, 27);
            textUrl.TabIndex = 10;
            // 
            // textSize
            // 
            textSize.Location = new Point(156, 112);
            textSize.Name = "textSize";
            textSize.Size = new Size(175, 27);
            textSize.TabIndex = 9;
            // 
            // textFile
            // 
            textFile.Location = new Point(156, 65);
            textFile.Name = "textFile";
            textFile.Size = new Size(175, 27);
            textFile.TabIndex = 8;
            // 
            // label_Filename
            // 
            label_Filename.AutoSize = true;
            label_Filename.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Filename.Location = new Point(17, 68);
            label_Filename.Name = "label_Filename";
            label_Filename.Size = new Size(76, 20);
            label_Filename.TabIndex = 7;
            label_Filename.Text = "File name";
            // 
            // label_Charcnt
            // 
            label_Charcnt.AutoSize = true;
            label_Charcnt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Charcnt.Location = new Point(17, 315);
            label_Charcnt.Name = "label_Charcnt";
            label_Charcnt.Size = new Size(120, 20);
            label_Charcnt.TabIndex = 6;
            label_Charcnt.Text = "Character count";
            // 
            // label_Wordcnt
            // 
            label_Wordcnt.AutoSize = true;
            label_Wordcnt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Wordcnt.Location = new Point(17, 262);
            label_Wordcnt.Name = "label_Wordcnt";
            label_Wordcnt.Size = new Size(92, 20);
            label_Wordcnt.TabIndex = 5;
            label_Wordcnt.Text = "Word count";
            // 
            // label_Linecnt
            // 
            label_Linecnt.AutoSize = true;
            label_Linecnt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Linecnt.Location = new Point(17, 214);
            label_Linecnt.Name = "label_Linecnt";
            label_Linecnt.Size = new Size(82, 20);
            label_Linecnt.TabIndex = 4;
            label_Linecnt.Text = "Line count";
            // 
            // label_Url
            // 
            label_Url.AutoSize = true;
            label_Url.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Url.Location = new Point(17, 159);
            label_Url.Name = "label_Url";
            label_Url.Size = new Size(38, 20);
            label_Url.TabIndex = 3;
            label_Url.Text = "URL";
            // 
            // label_Size
            // 
            label_Size.AutoSize = true;
            label_Size.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Size.Location = new Point(17, 112);
            label_Size.Name = "label_Size";
            label_Size.Size = new Size(36, 20);
            label_Size.TabIndex = 2;
            label_Size.Text = "Size";
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.Red;
            btn_Exit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.ForeColor = Color.White;
            btn_Exit.Location = new Point(0, 360);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(343, 49);
            btn_Exit.TabIndex = 1;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Read
            // 
            btn_Read.BackColor = Color.Red;
            btn_Read.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Read.ForeColor = Color.White;
            btn_Read.Location = new Point(0, 0);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(343, 49);
            btn_Read.TabIndex = 0;
            btn_Read.Text = "Read from file";
            btn_Read.UseVisualStyleBackColor = false;
            btn_Read.Click += btn_Read_Click;
            // 
            // bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 450);
            Controls.Add(panel1);
            Controls.Add(richTextFile);
            ForeColor = Color.Blue;
            Name = "bai2";
            Text = "Bài 02 – Đọc thông tin một file .txt";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextFile;
        private Panel panel1;
        private Button btn_Read;
        private Label label_Size;
        private Button btn_Exit;
        private Label label_Filename;
        private Label label_Charcnt;
        private Label label_Wordcnt;
        private Label label_Linecnt;
        private Label label_Url;
        private TextBox textChar;
        private TextBox textWord;
        private TextBox textLine;
        private TextBox textUrl;
        private TextBox textSize;
        private TextBox textFile;
    }
}