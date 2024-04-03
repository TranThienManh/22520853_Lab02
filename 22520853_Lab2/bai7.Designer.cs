namespace _22520853_Lab2
{
    partial class bai7
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
            components = new System.ComponentModel.Container();
            treeView = new TreeView();
            groupBoxFileContent = new GroupBox();
            richTextBoxFile = new RichTextBox();
            pictureBoxFile = new PictureBox();
            imageList1 = new ImageList(components);
            groupBoxFileContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFile).BeginInit();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Location = new Point(12, 12);
            treeView.Name = "treeView";
            treeView.Size = new Size(371, 587);
            treeView.TabIndex = 0;
            treeView.AfterSelect += treeView_AfterSelect;
            // 
            // groupBoxFileContent
            // 
            groupBoxFileContent.Controls.Add(richTextBoxFile);
            groupBoxFileContent.Controls.Add(pictureBoxFile);
            groupBoxFileContent.Location = new Point(399, 12);
            groupBoxFileContent.Name = "groupBoxFileContent";
            groupBoxFileContent.Size = new Size(766, 587);
            groupBoxFileContent.TabIndex = 1;
            groupBoxFileContent.TabStop = false;
            groupBoxFileContent.Text = "File Content";
            // 
            // richTextBoxFile
            // 
            richTextBoxFile.Location = new Point(28, 38);
            richTextBoxFile.Name = "richTextBoxFile";
            richTextBoxFile.Size = new Size(708, 520);
            richTextBoxFile.TabIndex = 1;
            richTextBoxFile.Text = "";
            // 
            // pictureBoxFile
            // 
            pictureBoxFile.Location = new Point(15, 26);
            pictureBoxFile.Name = "pictureBoxFile";
            pictureBoxFile.Size = new Size(735, 545);
            pictureBoxFile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFile.TabIndex = 0;
            pictureBoxFile.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // bai7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 611);
            Controls.Add(groupBoxFileContent);
            Controls.Add(treeView);
            Name = "bai7";
            Text = "bai7";
            Load += bai7_Load;
            groupBoxFileContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxFile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView;
        private GroupBox groupBoxFileContent;
        private RichTextBox richTextBoxFile;
        private PictureBox pictureBoxFile;
        private ImageList imageList1;
    }
}