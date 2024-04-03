using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.Design;

namespace _22520853_Lab2
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private async void btn_Read_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfile = new OpenFileDialog()
                {
                    Filter = "Txt Files| *.txt" //loc tat ca cac file .txt de mo
                };
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    StreamReader fs = new StreamReader(openfile.FileName);
                    richTextBox1.Text = await fs.ReadToEndAsync();
                    MessageBox.Show($"Read file from {openfile.FileName}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_Write_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Please input file contents", "Error", MessageBoxButtons.OK);
                return;
            };
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog()
                {
                    Filter = "Txt Files| *.txt",
                    FileName = "output.txt"
                };
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string outputPath = saveFile.FileName;
                    // luu ten duong dan file vua ghi
                    await File.WriteAllTextAsync(outputPath, richTextBox1.Text.ToUpper());
                    MessageBox.Show($"Success to write file at {outputPath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
