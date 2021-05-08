using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace student_manage
{
    public partial class LoginForm : Form
    {
        private string username = "jinyu";
        private string password = "123";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputUsername = this.textBox1.Text.Trim();
            string inputPassword = this.textBox2.Text.Trim();
            if(inputUsername == username && inputPassword == password)
            {
                this.Close();
            }else{
                MessageBox.Show("用户名或密码错误！");  
            }
        }
    }
}
