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
    public partial class StudentAdd : Form
    {
        public StudentAdd()
        {
            InitializeComponent();
        }

        private void StudentAdd_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            string inputUsername = this.usernameInput.Text.Trim();
            string inputPassword = this.passwordInput.Text.Trim();
            string inputGrade = this.gradeComBox.Text;
            string inputName = this.nameInput.Text.Trim();
            string inputMajor = this.majorInput.Text.Trim();
            string inputPhone = this.phoneInput.Text.Trim();
            string inputMath = this.mathInput.Text.Trim();
            string inputComputer = this.computerInput.Text.Trim();
            string inputEnglish = this.englishInput.Text.Trim();

            if(String.IsNullOrEmpty(inputGrade)|| String.IsNullOrEmpty(inputGrade)|| String.IsNullOrEmpty(inputGrade)|| String.IsNullOrEmpty(inputGrade)|| String.IsNullOrEmpty(inputGrade)|| String.IsNullOrEmpty(inputGrade)|| String.IsNullOrEmpty(inputGrade))
            {
                MessageBox.Show("有输入项为空");
                return;
            }

            if(inputUsername == "")
            {
                MessageBox.Show("用户名不能为空");
                return;
            }
            if(inputPassword.Length < 6 || inputPassword.Length > 30)
            {
                MessageBox.Show("密码长度为6-30");
                return;
            }

            MySqlConnection conn = new MySqlConnection(DatabaseConfig.connectStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句

                string sql = "insert into student(grade,name,major,phone,math_score,computer_score,english_score) values('"+ inputGrade + "','" + inputName + "','" + inputMajor + "'" +
                    ",'" + inputPhone + "','" + inputMath + "','" + inputComputer + "','" + inputEnglish + "')";
                //string sql = "delete from user where userid='9'";
                //string sql = "update user set username='啊哈',password='123' where userid='8'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int result = cmd.ExecuteNonQuery();

                sql = "insert into user(username,password,user_type,status) values('" + inputUsername + "','" + inputPassword + "','s','0')";
                MySqlCommand cmd2 = new MySqlCommand(sql, conn);
                int result2 = cmd2.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("保存失败");
                return;
            }
            finally
            {
                conn.Close();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
