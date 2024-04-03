using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520853_Lab2
{
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog()
                {
                    Filter = "Txt Files|*.txt" // lọc các file có đuôi .txt
                };
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    // lấy nội dung file ra richTextBox
                    StreamReader fs = new StreamReader(openFile.FileName);
                    richTextFile.Text = fs.ReadToEnd();
                    // Lấy tên file ra File name
                    textFile.Text = openFile.SafeFileName.ToString();

                    // Lấy thông tin file
                    FileInfo file_info = new FileInfo(openFile.FileName);

                    // Lấy kích thước file 
                    long size = file_info.Length;
                    textSize.Text = System.Convert.ToString(size) + " bytes";

                    // Lấy Url
                    // cách 1 dùng filename property của openFileDialog để lấy path
                    textUrl.Text = openFile.FileName;
                    // cách 2 dùng .name property của filestream để lấy path

                    // Count Line
                    int cntLine = File.ReadAllLines(openFile.FileName).Length;
                    textLine.Text = cntLine.ToString();

                    // Count Words
                    string[] contents = File.ReadAllLines(openFile.FileName);
                    // dùng readallline của thuộc tính file để lấy ra từng dòng của file bỏ vào string[]
                    int cntWord = 0;
                    foreach (string line in contents)
                    {
                        for (int i = 0; i < line.Length; i++)
                            if (line[i] == ' ' || i == line.Length - 1)
                                cntWord++;
                        // foreach để nhảy vào từng dòng trong file và dùng for để duyệt từng mảng con
                        // trong từng dòng để kiểm tra nếu có " " thì tăng lên 1 đại diện cho 1 từ
                        // và kết thúc dòng cũng tăng lên 1 để đếm từ cuối cùng của dòng đó 
                    }
                    textWord.Text = cntWord.ToString();


                    // Count Characters
                    //string[] contents = File.ReadAllLines(openFile.FileName);
                    int dem = 0;
                    int demktdb = contents.Length -1; // dem ki tu '\n' kí tự xuong dong
                    foreach (string line in contents)
                    {
                        foreach (char c in line)
                        {
                            dem++;
                        }    
                    }
                    textChar.Text = (dem+demktdb+2).ToString();

                    MessageBox.Show("Complete the process !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
