using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB8
{
    public partial class UpdatePoint : Form
    {
        private string MSSV;
        private string Name1;
        private String Name2;
        private string Course;
        public UpdatePoint(string MSSV, string Name1, string Name2, string Course)
        {
            InitializeComponent();
            this.MSSV = MSSV;
            this.Name1 = Name1;
            this.Name2 = Name2;
            this.Course = Course;
            FillTextBox();
        }

        // mấy chỗ fill giống như này là để set value vô.
        public void FillTextBox()
        {
            textBoxMSSV.Text = MSSV;
            textBoxName.Text = Name2 + " " + Name1;
            textBoxCourse.Text = Course;
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {          
            this.Dispose();
        }

        // Chỗ này là event click update và insert điểm
        private void buttonUpdatePoint_Click(object sender, EventArgs e)
        {
            string Str = "Data Source=35.240.239.99;database=lab8;UID=sqlserver;password=dbadminB1607007";
            SqlConnection Con = new SqlConnection(Str);
            SqlCommand check = new SqlCommand("SELECT COUNT (*) FROM point WHERE student_id = '" + MSSV + "';", Con);
            DataTable dataTable = new DataTable();

            string id = textBoxMSSV.Text;
            int courseid = Convert.ToInt32(textBoxCourse.Text);              
            float point = float.Parse(textBoxPoint.Text);

            // Cập nhật nếu điểm đã tồn tại.
            Con.Open();           
            int Exist = (int)check.ExecuteScalar();
            Con.Close();
            if (Exist > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Điểm đã được nhập, bạn có muốn cập nhật?", "Cập Nhật Điểm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string Querry = "UPDATE point SET value = '" + point + "' WHERE student_id = '" + MSSV + "';";
                        SqlCommand cmd = new SqlCommand(Querry, Con);
                        Con.Open();
                        cmd.ExecuteNonQuery();
                        Con.Close();                      
                        MessageBox.Show("Cập nhật điểm thành công");
                    }
                    catch (Exception ex)
                    {                       
                        MessageBox.Show("Cập nhật điểm thất bại, kiểm tra lại dữ liệu nhập vào." + ex.Message);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                    this.Close();
                }
            } else // Thêm nếu điểm chưa tồn tại.
            {
                DialogResult dialogResult = MessageBox.Show("Điểm chưa được nhập, bạn có muốn nhập điểm?", "Cập Nhật Điểm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string Querry = "INSERT INTO point (student_id, course_id, value) VALUES (@student_id, @course_id, @value)";
                        SqlCommand cmd = new SqlCommand(Querry, Con);
                        Con.Open();
                        cmd.Parameters.AddWithValue("@student_id", id);
                        cmd.Parameters.AddWithValue("@course_id", courseid);
                        cmd.Parameters.AddWithValue("@value", point); 

                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("Cập nhật điểm thành công");
                        } else
                        {
                            MessageBox.Show("Cập nhật điểm thất bại, kiểm tra lại dữ liệu nhập vào.");
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cập nhật điểm thất bại, kiểm tra lại dữ liệu nhập vào." + ex.Message);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                    this.Close();
                }
            }          
        }
    }
}
