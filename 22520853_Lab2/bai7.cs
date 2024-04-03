using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520853_Lab2
{
    public partial class bai7 : Form
    {
        public bai7()
        {
            InitializeComponent();
        }

        private void bai7_Load(object sender, EventArgs e)
        {
            var drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                var driveNode = new TreeNode(drive.Name);
                if (Directory.Exists(drive.Name))
                {
                    LoadFolder(drive.Name, driveNode.Nodes); // Hàm tự thêm
                    LoadFile(drive.Name, driveNode.Nodes);  // Hàm tự thêm 
                }
                treeView.Nodes.Add(driveNode);
            }

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pictureBoxFile.Image = null;
            // dung thuộc tính Image của hàm pictureBox để lấy ra file ảnh
            richTextBoxFile.Visible = false;
            var path = e.Node.Tag?.ToString(); // Không biết để làm gì
            if (string.IsNullOrEmpty(path))
            {
                return;
            }
            if (File.Exists(path))
            {
                if (!IsBinaryFile(path)) // hàm đọc và và xuất file Binary
                {
                    try
                    {
                        using var streamReader = new StreamReader(path);
                        richTextBoxFile.Text = streamReader.ReadToEnd();
                        richTextBoxFile.Visible = true;
                        // Thuộc tính Visible là gì ???
                    }
                    catch
                    {
                        return;
                    }
                }    

                if (IsImageFile(path))
                {
                    Image image;
                    try
                    {
                        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                        //tạo luồng fs FileStream có đường dẫn path, chế độ Open và quyền Read
                        {
                            image = Image.FromStream(fs);
                            // Kiểu dữ liệu ảnh lấy phương thức FromStream từ luồng fs để xuất tình ảnh
                        }
                    }
                    catch
                    {
                        return;
                    }
                    pictureBoxFile.Image = image;
                    return;
                    // Kiểm tra xem hai lệnh trên dùng để làm gì
                }
            }
            LoadFolder(path, e.Node.Nodes);
            LoadFile(path, e.Node.Nodes);
            e.Node.Expand();
            // Giải thích 3 code trên
        }

		private void LoadFolder(string path, TreeNodeCollection treeNodeCollection)
        {
            try
            {
                var directories = Directory.GetDirectories(path);
                foreach (var directory in directories)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(directory);
                    TreeNode node = new TreeNode(dirInfo.Name);
                    node.Tag = dirInfo.FullName;
                    node.ImageIndex = 0;
                    node.SelectedImageIndex = 0;
                    treeNodeCollection.Add(node);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFile(string path, TreeNodeCollection treeNodeCollection)
        {
            try
            {
                var files = Directory.GetFiles(path);
                foreach (var file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    TreeNode node = new TreeNode(fileInfo.Name);
                    node.Tag = fileInfo.FullName;
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                    treeNodeCollection.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // IsImageFile
        public bool IsImageFile(string filePath)
        {
            try
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    var header = new byte[10];
                    stream.Read(header, 0, header.Length);

                    // Check header
                    if (header[0] == 0xFF && header[1] == 0xD8 && header[2] == 0xFF && (header[3] == 0xE0 || header[3] == 0xE1) && header[6] == 'J' && header[7] == 'F' && header[8] == 'I' && header[9] == 'F')
                    {
                        //p JPEG
                        return true;
                    }
                    else if (header[0] == 0x89 && header[1] == 0x50 && header[2] == 0x4E && header[3] == 0x47 && header[4] == 0x0D && header[5] == 0x0A && header[6] == 0x1A && header[7] == 0x0A)
                    {
                        // PNG
                        return true;
                    }
                    else if (header[0] == 0x47 && header[1] == 0x49 && header[2] == 0x46 && header[3] == 0x38 && (header[4] == 0x39 || header[4] == 0x37) && header[5] == 0x61)
                    {
                        // GIF
                        return true;
                    }
                    else if (header[0] == 0x42 && header[1] == 0x4D)
                    {
                        // BMP
                        return true;
                    }
                    else if (header[0] == 0x49 && header[1] == 0x49 && header[2] == 0x2A && header[3] == 0x00)
                    {
                        // TIFF (little-endian)
                        return true;
                    }
                    else if (header[0] == 0x4D && header[1] == 0x4D && header[2] == 0x00 && header[3] == 0x2A)
                    {
                        // TTIFF (big-endian)
                        return true;
                    }
                    else if (header[0] == 0x52 && header[1] == 0x49 && header[2] == 0x46 && header[3] == 0x46)
                    {
                        // WAV
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool IsBinaryFile(string filePath)
        {
            using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                var buffer = new byte[1024];
                int bytesRead;
                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    for (int i = 0; i < bytesRead; i++)
                    {
                        if (buffer[i] == 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

    }
}
