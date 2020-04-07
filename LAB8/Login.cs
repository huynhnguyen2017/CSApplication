using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB8
{
    public partial class Login : Form
    {
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
            // Chỗ này để get lấy MSCB truy vấn ae có làm lại DB thì coi chừng nó
            // Test thì nhập mấy cái mã cán bộ zô trước để test VD 001 bấm login là đc
            Menu menu = new Menu(textUsername.Text);
            menu.Visible = true;
            this.Visible = false;
        }
    }
}
