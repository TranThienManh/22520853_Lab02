using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520853_Lab2
{
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
            _students = new List<Student>();
            // bat buoc phai truyen danh sach vao bai4 de khi chay biet danh sach dang thuc thi co gia tri gi cua bai nao
        }

        // xủ lý thông tin sinh viên
        // Tạo class Student
        internal class Student
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public string Phone { get; set; }
            public double Course1 { get; set; }
            public double Course2 { get; set; }
            public double Course3 { get; set; }
            public double AverageScore { get; set; }

            public Student() { }

        }

        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(textName_in.Text)
                || string.IsNullOrEmpty(textID_in.Text)
                || string.IsNullOrEmpty(textPhone_in.Text)
                || string.IsNullOrEmpty(textCourse1_in.Text)
                || string.IsNullOrEmpty(textCourse2_in.Text)
                || string.IsNullOrEmpty(textCourse3_in.Text))
            { return true; }
            return false;
        }

        public bool IsPhoneValid(string phone)
        {
            return Regex.IsMatch(phone, @"^0\d{9}$");
            //Dung phuong thuc co san cua thu vien cai nay moi
        }

        public bool IsStudentIDValid(string id)
        {
            if (!Int32.TryParse(id, out var idNum))
                return false;
            return idNum >= 10000000 && idNum <= 99999999;
            /* Thay vi tao ham if kiem tra dieu kien
             ta su dung phuong thuc tryparse cua kieu du lieu int de ep kieu string ve in
             tryparse(string s; out var s) ep kieu dau vao la string, neu string convert to int thanh cong 
             thi tra ve true nguoc lai tr ve false*/
        }

        public bool IsScoreValid(string grade)
        {
            if (!double.TryParse(grade, out var gradeNum))
            {
                return false;
            }
            if (gradeNum >= 0 || gradeNum <= 10)
            {
                return true;
            }
            return false;
        }


        // Khoi tao danh sach sinh vien bang mang vector
        private List<Student> _students;
        private int _index = 0;

        // Xu ly nut add
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                MessageBox.Show("Please enter the missing information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsPhoneValid(textPhone_in.Text))
            {
                MessageBox.Show("Please input valid phone number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsStudentIDValid(textID_in.Text))
            {
                MessageBox.Show("Please input valid student ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsScoreValid(textCourse1_in.Text) || !IsScoreValid(textCourse1_in.Text) || !IsScoreValid(textCourse1_in.Text))
            {
                MessageBox.Show("Please input valid grade!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var student = new Student();
            student.Name = textName_in.Text;
            student.ID = Int32.Parse(textID_in.Text); // Ep kieu string ve int
            student.Phone = textPhone_in.Text;
            student.Course1 = double.Parse(textCourse1_in.Text);
            student.Course2 = double.Parse(textCourse2_in.Text);
            student.Course3 = double.Parse(textCourse3_in.Text);
            student.AverageScore = ((student.Course1 + student.Course2 + student.Course3) / 3);
            _students.Add(student); // add cac doi tuong tiep vao danh sach _student
            ClearTextBoxInput();
            UpdateStatus();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            // dung try - catch de bat du lieu
            try
            {
                OpenFileDialog openFile = new OpenFileDialog()
                {
                    Filter = "Txt File|*.txt"
                    // khong duoc dong code bang ;
                };
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    _students.Clear(); // chu y khong biet code nay de lam gi
                    var path = openFile.FileName; // duong dan vao file open khi mo
                    using (StreamReader fs = new StreamReader(path))
                    {
                        // su dung using de khong phai goi close de dong code sau khi doc xong
                        while (fs.Peek() >= 0)
                        // tim hieu cai while la gi
                        {
                            Student student = new Student();
                            student.Name = fs.ReadLine();
                            student.ID = int.Parse(fs.ReadLine());
                            student.Phone = fs.ReadLine();
                            student.Course1 = double.Parse(fs.ReadLine());
                            student.Course2 = double.Parse(fs.ReadLine());
                            student.Course3 = double.Parse(fs.ReadLine());
                            student.AverageScore = (student.Course1 + student.Course2 + student.Course3) / 3;
                            _students.Add(student); // them tuong tu cho list Students khac
                            _ = fs.ReadLine(); // doc het file de in ra tat ca gia tri co trong file
                        }
                    }
                    UpdateStatus();
                    MessageBox.Show($"Read file from {path} success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog()
                {
                    Filter = "Txt Files | *.txt",
                    FileName = "input4.txt"
                };
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    var path = saveFile.FileName;

                    using (StreamWriter os = new StreamWriter(path, true))
                    {
                        foreach (var student in _students)
                        {
                            // Ghi thông tin của sinh viên vào tệp tin
                            os.WriteLine($"Name: {student.Name}");
                            os.WriteLine($"ID: {student.ID}");
                            os.WriteLine($"Phone: {student.Phone}");
                            os.WriteLine($"Course 1: {student.Course1}");
                            os.WriteLine($"Course 2: {student.Course2}");
                            os.WriteLine($"Course 3: {student.Course3}");
                            os.WriteLine(); // Dòng trống để phân tách thông tin giữa các sinh viên
                        }
                    }

                    MessageBox.Show("File has been saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        // Kiem tra trang thai nhap xuat du lieu
        private void ClearTextBoxInput()
        {
            textName_in.Text = "";
            textID_in.Text = "";
            textPhone_in.Text = "";
            textCourse1_in.Text = "";
            textCourse2_in.Text = "";
            textCourse3_in.Text = "";
        }

        private void UpdateStatus()
        {
            richTextBox1.Text = string.Empty;
            foreach (var student in _students)
            {
                richTextBox1.Text += $"Name: {student.Name} \nID: {student.ID} \nPhone: {student.Phone} \nCourse 1: {student.Course1: 0.00#} \nCourse 2: {student.Course2: 0.00#} \nCourse 3: {student.Course3: 0.00#} \nAvaerage: {student.AverageScore: 0.00#}\n\n";
                // $ dung de nhung vao chuoi cac gia tri mong muon thong qua {Truyen gia tri muon nhung} va :0.00# lam tron de so thap phan thu hai
            }
            _index = 0;
            UpdateOutputTextBox(_index);
        }

        private void UpdateOutputTextBox(int index)
        {
            labelIndex.Text = (_index + 1).ToString();
            //Hiển thị số thứ tự sinh viên
            textName_ou.Text = _students[index].Name;
            textID_ou.Text = _students[index].ID.ToString();
            textPhone_ou.Text = _students[index].Phone;
            textCourse1_ou.Text = Math.Round(_students[index].Course1, 2).ToString();
            textCourse2_ou.Text = $"{_students[index].Course2: 0.00#}";
            textCourse3_ou.Text = $"{_students[index].Course3: 0.00#}";
            textAvg_ou.Text = Math.Round(_students[index].AverageScore, 2).ToString();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (_students.Count == 0)
                return;
            if (_index == 0)
                return;
            _index--;
            UpdateOutputTextBox(_index);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (_students.Count == 0)
                return; // Kiểm tra nếu danh sách không có sinh viên nào thì không làm gì 
            if (_index == _students.Count - 1)
                return; // kiểm tra Vi tri index sinh vien cuôi trong danh sach không thể tăng
            _index++;
            UpdateOutputTextBox(_index);
        }

        private void Luuthongtin_sv_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
