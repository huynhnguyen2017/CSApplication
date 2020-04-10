using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LAB8
{
    public partial class Login : Form
    {
        private SqlConnection Con = new SqlConnection("Data Source=35.240.239.99;database=lab8;UID=sqlserver;password=dbadminB1607007");
        public Login()
        {
            InitializeComponent();
            textPassword.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM teacher WHERE id = '" + textUsername.Text.Trim() + "' AND password = '" + textPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, this.Con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Menu menu = new Menu(textUsername.Text);
                menu.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
            // Chỗ này để get lấy MSCB truy vấn ae có làm lại DB thì coi chừng nó
            // Test thì nhập mấy cái mã cán bộ zô trước để test VD 001 bấm login là đc
            
        }
    }
}
