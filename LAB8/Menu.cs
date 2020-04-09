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
        private SqlConnection Con = new SqlConnection("Data Source=35.240.239.99;database=lab8;UID=sqlserver;password=dbadminB1607007");
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
            
            // Querry lấy tên các môn học, textUsername là get mã cán bộ từ ô username ở class Login (coi lại câu querry).
            string Query = "SELECT * FROM subject INNER JOIN course ON subject.id = course.subject_id WHERE course.teacher_id = '" + textUsername + "';";  
            SqlCommand cmd = new SqlCommand(Query, this.Con);
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

<<<<<<< HEAD
        // Update DGView
        //public void update()


=======
>>>>>>> master
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
<<<<<<< HEAD
            string Str = "Data Source=35.240.239.99;database=lab8;UID=sqlserver;password=dbadminB1607007";           
            SqlConnection Con = new SqlConnection(Str);
            // Querry lấy danh sách sinh viên với môn tương ứng.
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT course.class_id, course.subject_id, student.firstname, " +
                "student.lastname, student.id FROM class JOIN course ON class.id = course.class_id JOIN student " +
                "ON student.class_id = course.class_id " +
                "WHERE course.teacher_id = '" + textUsername + "' AND course.class_id = 'K44-01';", Con);         
=======
            // Querry lấy danh sách sinh viên với môn tương ứng (coi lại câu querry cho ngon :D) textUsername là get giá trị từ Textbox textUsername bên Class Login để truy vấn.
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM student INNER JOIN course ON student.class_id = course.class_id WHERE course.teacher_id = '" + textUsername + "';", this.Con);         
>>>>>>> master
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);

            // chỗ này là mấy cái button để gọi nhập điểm
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
<<<<<<< HEAD
            if (DanhsachSV.Columns[e.ColumnIndex].Name == "updateBtnName")
            {
                UpdatePoint updatePoint = new UpdatePoint();
            // chỗ này lấy data mỗi row từng comlumn để set nó vô cái chỗ update điểm
=======
           
            // chỗ này lấy data mỗi row từng comlumn để set nó vô cái chỗ update điểm
            if (DanhsachSV.Columns[e.ColumnIndex].Name == "updateBtnName")
            {
                DataGridViewRow row = DanhsachSV.Rows[e.RowIndex];
                string rMSSV = row.Cells[0].Value.ToString();
                string rName1 = row.Cells[1].Value.ToString();
                string rName2 = row.Cells[2].Value.ToString();
                string rCourse = row.Cells[3].Value.ToString();
                //SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM point INNER JOIN course ON student.class_id = course.class_id WHERE course.teacher_id = '" + textUsername + "';", this.Con);
                //DataTable dataTable = new DataTable();
                //sqlData.Fill(dataTable);
                UpdatePoint updatePoint = new UpdatePoint(rMSSV, rName1, rName2, rCourse);
>>>>>>> master
                updatePoint.Visible = true;
            }
        }
    }
} 
