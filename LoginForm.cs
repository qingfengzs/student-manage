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
            //this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputUsername = this.textBox1.Text;
            string inputPassword = this.textBox2.Text;
            //MessageBox.Show(input_password);
            if(inputUsername == username && inputPassword == password)
            {
                this.Close();
            }
        }
    }
}
