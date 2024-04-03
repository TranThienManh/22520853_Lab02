using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520853_Lab2
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btn_Read_Click(object sender, EventArgs e)
        {
            //Dùng try catch để bắt thông tin
            try
            {
                OpenFileDialog openFile = new OpenFileDialog()
                {
                    Filter = "Text Files| *.txt" // lọc file txt
                };
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    // dùng để xác nhận khi click bật file lên
                    // đọc file
                    var path = openFile.FileName;
                    StreamReader fs = new StreamReader(path);
                    // Xuất input vào richTextBox_input
                    richTextBox_input.Text = await fs.ReadToEndAsync();
                    //MessageBox.Show($"Đọc file thành công {openFile.FileName}");
                    // dùng messagebox để thông báo đọc thành công file có tên là ....
                    // bàng $"...{mở file.FileName}"

                    //Thuc hien cac phep tinh
                    //string[] contents = File.ReadAllLines(path);
                    //foreach (string line in contents)
                    //{
                    //    int x = Int32.Parse(CalculateExpression(line));
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double CalculateExpression(string expression)
        {
            // Xóa khoảng trắng
            expression = expression.Replace(" ", "");

            // Tách biểu thức thành các toán hạng và toán tử
            string[] operators = { "+", "-", "*", "/" };
            string[] tokens = expression.Split(operators, StringSplitOptions.RemoveEmptyEntries);

            // Thực hiện tính toán
            double result = double.Parse(tokens[0]);
            int operatorIndex = tokens[0].Length;
            for (int i = 1; i < tokens.Length; i++)
            {
                double operand = double.Parse(tokens[i]);

                // Lấy toán tử tương ứng
                string currentOperator = expression.Substring(operatorIndex, 1);
                operatorIndex += tokens[i].Length + 1;

                switch (currentOperator)
                {
                    case "+":
                        result += operand;
                        break;
                    case "-":
                        result -= operand;
                        break;
                    case "*":
                        result *= operand;
                        break;
                    case "/":
                        if (operand != 0)
                            result /= operand;
                        else
                            throw new DivideByZeroException("Lỗi: Chia cho không");
                        break;
                    default:
                        throw new InvalidOperationException("Toán tử không hợp lệ");
                }
            }

            return result;
        }

        private async void btn_Cal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox_input.Text))
            {
                MessageBox.Show("Please input file contents", "Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                SaveFileDialog saveFile = new SaveFileDialog()
                {
                    Filter = "Txt Files| *.txt",
                    FileName = "output.txt"
                };

                List<string> calculatedResults = new List<string>();

                // Tính toán và lưu kết quả vào danh sách
                foreach (string line in richTextBox_input.Lines)
                {
                    double result = Math.Round(CalculateExpression(line), 3);
                    calculatedResults.Add($"{line} = {result}");
                }

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string outputPath = saveFile.FileName;
                    // Ghi kết quả xuống file output
                    await File.WriteAllLinesAsync(outputPath, calculatedResults);
                    // Đọc kết quả ouput.txt ra file richTextBox
                    StreamReader os = new StreamReader(outputPath);
                    richTextBox_ouput.Text = await os.ReadToEndAsync();

                    MessageBox.Show($"Success to write file at {outputPath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
