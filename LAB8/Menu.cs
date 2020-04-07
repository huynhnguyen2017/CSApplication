using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;


namespace LAB8
{
    public partial class Menu : Form
    {
        private string textUsername;
         
        public Menu(string textUsername)
        {
            InitializeComponent();
            this.textUsername = textUsername;
            FillCombobox();
        } 

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void secondSubject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void threeSubject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        public void FillCombobox()
        {
            string Str = "Data Source=35.240.239.99;database=lab8;UID=sqlserver;password=dbadminB1607007";
            // Querry lấy tên các môn học, textUsername là get mã cán bộ từ ô username ở class Login.
            string Query = "SELECT * FROM subject INNER JOIN course ON subject.id = course.subject_id WHERE course.teacher_id = '" + textUsername + "';";
            SqlConnection Con = new SqlConnection(Str);
            SqlCommand cmd = new SqlCommand(Query, Con);
            SqlDataReader sqlDataReader;            

            try
            {
                Con.Open();
                sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {               
                    string sName = sqlDataReader["name"].ToString();
                   
                    comboBox1.Items.Add(sName);
                    
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Con.Close();
        }

        // Update DGView
        /*public void update()
        {
            // Add column
            DanhsachSV.ColumnCount = 6;
            DanhsachSV.Columns[0].Name = "STT";
            DanhsachSV.Columns[1].Name = "MSSV";
            DanhsachSV.Columns[2].Name = "Ho va Ten";
            DanhsachSV.Columns[3].Name = "Ma Lop";
            DanhsachSV.Columns[4].Name = "Ten Lop";
            DanhsachSV.Columns[5].Name = "Diem";

            //Add rows
            ArrayList row = new ArrayList();
            row.Add("1");
            row.Add("B18001");
            row.Add("Phạm Thị Bảo Nhiên");
            row.Add("K44-001");
            row.Add("CNPM 01");
            row.Add("8.9");
            DanhsachSV.Rows.Add(row.ToArray());

            // second row
            row = new ArrayList();
            row.Add("2");
            row.Add("B18002");
            row.Add("Nguyễn Văn An");
            row.Add("K44-001");
            row.Add("CNPM 01");
            row.Add("8.0");
            DanhsachSV.Rows.Add(row.ToArray());

            // 3 row
            row = new ArrayList();
            row.Add("3");
            row.Add("B18003");
            row.Add("Lê Hoài Anh");
            row.Add("K44-001");
            row.Add("CNPM 01");
            row.Add("9");
            DanhsachSV.Rows.Add(row.ToArray());

            // 4 row
            row = new ArrayList();
            row.Add("4");
            row.Add("B18004");
            row.Add("Nguyễn Lâm Hoàng Anh");
            row.Add("K44-001");
            row.Add("CNPM 01");
            row.Add("8.5");
            DanhsachSV.Rows.Add(row.ToArray());

            // 5 row
            row = new ArrayList();
            row.Add("5");
            row.Add("B18005");
            row.Add("Lê Minh Bằng");
            row.Add("K44-001");
            row.Add("CNPM 01");
            row.Add("8.1");
            DanhsachSV.Rows.Add(row.ToArray());

            // 6 row
            row = new ArrayList();
            row.Add("6");
            row.Add("B18006");
            row.Add("Vương Thừa Chấn");
            row.Add("K44-002");
            row.Add("CNPM 02");
            row.Add("7.9");
            DanhsachSV.Rows.Add(row.ToArray());

            // 7 row
            row = new ArrayList();
            row.Add("7");
            row.Add("B18007");
            row.Add("Cao Công Danh");
            row.Add("K44-002");
            row.Add("CNPM 02");
            row.Add("9.8");
            DanhsachSV.Rows.Add(row.ToArray());

            // 8 row
            row = new ArrayList();
            row.Add("8");
            row.Add("B18008");
            row.Add("Trịnh Lê Long Đức");
            row.Add("K44-002");
            row.Add("CNPM 02");
            row.Add("6.9");
            DanhsachSV.Rows.Add(row.ToArray());

            // 9 row
            row = new ArrayList();
            row.Add("9");
            row.Add("B18009");
            row.Add("Dương Lê Minh Hậu");
            row.Add("K44-002");
            row.Add("CNPM 02");
            row.Add("8.9");
            DanhsachSV.Rows.Add(row.ToArray());

            // 10 row
            row = new ArrayList();
            row.Add("10");
            row.Add("B18010");
            row.Add("Nguyễn Vũ Hoàng");
            row.Add("K44-002");
            row.Add("CNPM 02");
            row.Add("9.6");
            DanhsachSV.Rows.Add(row.ToArray());

            // 11 row
            row = new ArrayList();
            row.Add("11");
            row.Add("B18011");
            row.Add("Nguyễn Hoàng Thái Học");
            row.Add("K44-003");
            row.Add("CNPM 03");
            row.Add("9.1");
            DanhsachSV.Rows.Add(row.ToArray());

            // 12 row
            row = new ArrayList();
            row.Add("12");
            row.Add("B18012");
            row.Add("Nguyễn Quốc Huy");
            row.Add("K44-003");
            row.Add("CNPM 03");
            row.Add("9.7");
            DanhsachSV.Rows.Add(row.ToArray());

            // 13 row
            row = new ArrayList();
            row.Add("13");
            row.Add("B18013");
            row.Add("Võ Đoàn Gia Huy");
            row.Add("K44-003");
            row.Add("CNPM 03");
            row.Add("9.8");
            DanhsachSV.Rows.Add(row.ToArray());

            // 14 row
            row = new ArrayList();
            row.Add("14");
            row.Add("B18014");
            row.Add("Vũ Thị Bích Huyền");
            row.Add("K44-003");
            row.Add("CNPM 03");
            row.Add("9.2");
            DanhsachSV.Rows.Add(row.ToArray());

            // 14 row
            row = new ArrayList();
            row.Add("15");
            row.Add("B18015");
            row.Add("Hồ Việt Hưng");
            row.Add("K44-003");
            row.Add("CNPM 03");
            row.Add("9.6");
            DanhsachSV.Rows.Add(row.ToArray());

            //Add button colum
            DataGridViewButtonColumn updatebtn = new DataGridViewButtonColumn();
            updatebtn.HeaderText = "Cap nhat diem";
            updatebtn.Name = "updateBtnName";
            updatebtn.Text = "Thuc hien";
            updatebtn.UseColumnTextForButtonValue = true;
            DanhsachSV.Columns.Add(updatebtn);

        }*/

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
        /*
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            update();
        }
        */      

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string Str = "Data Source=35.240.239.99;database=lab8;UID=sqlserver;password=dbadminB1607007";      
            SqlConnection Con = new SqlConnection(Str);
            // Querry lấy danh sách sinh viên với môn tương ứng.
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM student INNER JOIN course ON student.class_id = course.class_id WHERE course.teacher_id = '" + textUsername + "';", Con);         
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);

            DanhsachSV.DataSource = dataTable;
            DataGridViewButtonColumn updatebtn = new DataGridViewButtonColumn();
            updatebtn.HeaderText = "Cap nhat diem";
            updatebtn.Name = "updateBtnName";
            updatebtn.Text = "Thuc hien";
            updatebtn.UseColumnTextForButtonValue = true;
            DanhsachSV.Columns.Add(updatebtn);

        }

        private void DanhsachSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DanhsachSV.Columns[e.ColumnIndex].Name == "updateBtnName")
            {
                DataGridViewRow row = DanhsachSV.Rows[e.RowIndex];
                string rMSSV = row.Cells[0].Value.ToString();
                string rName1 = row.Cells[1].Value.ToString();
                string rName2 = row.Cells[2].Value.ToString();
                string rCourse = row.Cells[3].Value.ToString();

                UpdatePoint updatePoint = new UpdatePoint(rMSSV, rName1, rName2, rCourse);
                updatePoint.Visible = true;
            }
        }
    }
} 
