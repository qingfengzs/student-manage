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
            string inputGrade = this.gradeComBox.Text;
            string inputName = this.nameInput.Text.Trim();
            string inputMajor = this.majorInput.Text.Trim();
            string inputPhone = this.phoneInput.Text.Trim();
            string inputMath = this.mathInput.Text.Trim();
            string inputComputer = this.computerInput.Text.Trim();
            string inputEnglish = this.englishInput.Text.Trim();

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
