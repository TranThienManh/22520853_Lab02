namespace _22520853_Lab2
{
    partial class bai1
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
            btn_Read = new Button();
            btn_Write = new Button();
            richTextBox1 = new RichTextBox();
            btn_Exit = new Button();
            btn_Reset = new Button();
            SuspendLayout();
            // 
            // btn_Read
            // 
            btn_Read.Location = new Point(23, 31);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(169, 72);
            btn_Read.TabIndex = 0;
            btn_Read.Text = "Đọc File";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += btn_Read_Click;
            // 
            // btn_Write
            // 
            btn_Write.Location = new Point(23, 142);
            btn_Write.Name = "btn_Write";
            btn_Write.Size = new Size(169, 72);
            btn_Write.TabIndex = 1;
            btn_Write.Text = "Ghi File";
            btn_Write.UseVisualStyleBackColor = true;
            btn_Write.Click += btn_Write_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(237, 31);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(442, 279);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(119, 263);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(86, 38);
            btn_Exit.TabIndex = 3;
            btn_Exit.Text = "Thoát ";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(12, 263);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(86, 38);
            btn_Reset.TabIndex = 4;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 343);
            Controls.Add(btn_Reset);
            Controls.Add(btn_Exit);
            Controls.Add(richTextBox1);
            Controls.Add(btn_Write);
            Controls.Add(btn_Read);
            Name = "bai1";
            Text = "Bài 01 – Ghi và Đọc file";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Read;
        private Button btn_Write;
        private RichTextBox richTextBox1;
        private Button btn_Exit;
        private Button btn_Reset;
    }
}