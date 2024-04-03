namespace _22520853_Lab2
{
    partial class bai3
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
            richTextBox_input = new RichTextBox();
            richTextBox_ouput = new RichTextBox();
            btn_Read = new Button();
            btn_Cal = new Button();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // richTextBox_input
            // 
            richTextBox_input.Location = new Point(43, 52);
            richTextBox_input.Name = "richTextBox_input";
            richTextBox_input.Size = new Size(263, 323);
            richTextBox_input.TabIndex = 0;
            richTextBox_input.Text = "";
            // 
            // richTextBox_ouput
            // 
            richTextBox_ouput.Location = new Point(489, 52);
            richTextBox_ouput.Name = "richTextBox_ouput";
            richTextBox_ouput.Size = new Size(263, 323);
            richTextBox_ouput.TabIndex = 1;
            richTextBox_ouput.Text = "";
            // 
            // btn_Read
            // 
            btn_Read.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Read.Location = new Point(341, 75);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(114, 56);
            btn_Read.TabIndex = 2;
            btn_Read.Text = "Đọc File";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += btn_Read_Click;
            // 
            // btn_Cal
            // 
            btn_Cal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cal.Location = new Point(341, 177);
            btn_Cal.Name = "btn_Cal";
            btn_Cal.Size = new Size(114, 56);
            btn_Cal.TabIndex = 3;
            btn_Cal.Text = "Tính";
            btn_Cal.UseVisualStyleBackColor = true;
            btn_Cal.Click += btn_Cal_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(341, 283);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(114, 56);
            btn_Exit.TabIndex = 4;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Cal);
            Controls.Add(btn_Read);
            Controls.Add(richTextBox_ouput);
            Controls.Add(richTextBox_input);
            Name = "bai3";
            Text = "bai3";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox_input;
        private RichTextBox richTextBox_ouput;
        private Button btn_Read;
        private Button btn_Cal;
        private Button btn_Exit;
    }
}