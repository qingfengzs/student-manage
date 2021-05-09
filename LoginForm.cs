using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace student_manage
{
    public partial class LoginForm : Form
    {
        private string defaultUsername = "jinyu";
        private string defaultPassword = "123";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void studentLoginBtn_Click(object sender, EventArgs e)
        {
            string inputUsername = this.usernameInput.Text.Trim();
            string inputPassword = this.passwordInput.Text.Trim();

            if (inputUsername == "")
            {
                MessageBox.Show("用户名不能为空");
                return;
            }

            if (inputPassword.Length < 6 || inputPassword.Length > 30)
            {
                MessageBox.Show("密码长度为6-30位");
                return;
            }

            MySqlConnection conn = new MySqlConnection(DatabaseConfig.connectStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                //在这里使用代码对数据库进行增删查改
                string sql = "select * from user where username=@para1 and password=@para2 and user_type='s'";//在sql语句中定义parameter，然后再给parameter赋值
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("para1", inputUsername);
                cmd.Parameters.AddWithValue("para2", inputPassword);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())//如果用户名和密码正确则能查询到一条语句，即读取下一行返回true
                {
                    UserType.userType = "student";
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void teacherLoginBtn_Click(object sender, EventArgs e)
        {
            string inputUsername = this.usernameInput.Text.Trim();
            string inputPassword = this.passwordInput.Text.Trim();

            if (inputUsername == "")
            {
                MessageBox.Show("用户名不能为空");
                return;
            }

            if (inputPassword.Length < 6 || inputPassword.Length > 30)
            {
                MessageBox.Show("密码长度为6-30位");
                return;
            }

            MySqlConnection conn = new MySqlConnection(DatabaseConfig.connectStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                //在这里使用代码对数据库进行增删查改
                string sql = "select * from user where username=@para1 and password=@para2 and user_type='t'";//在sql语句中定义parameter，然后再给parameter赋值
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("para1", inputUsername);
                cmd.Parameters.AddWithValue("para2", inputPassword);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())//如果用户名和密码正确则能查询到一条语句，即读取下一行返回true
                {
                    UserType.userType = "teacher";
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
