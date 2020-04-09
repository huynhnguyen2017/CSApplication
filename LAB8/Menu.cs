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
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT course.class_id, course.subject_id, student.firstname, " +
                "student.lastname, student.id FROM class JOIN course ON class.id = course.class_id JOIN student " +
                "ON student.class_id = course.class_id " +
                "WHERE course.teacher_id = '" + textUsername + "' AND course.class_id = 'K44-01';", Con);         
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
                UpdatePoint updatePoint = new UpdatePoint();
                updatePoint.Visible = true;
            }
        }
    }
}
