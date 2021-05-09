using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace student_manage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            if (UserType.userType == "teacher")
            {
                teacherInit();
            }
        }

        private void teacherInit()
        {
            this.studentList.Rows.Clear();
            MySqlConnection conn = new MySqlConnection(DatabaseConfig.connectStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                string sql = "select * from student";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();//执行ExecuteReader()返回一个MySqlDataReader对象
                while (reader.Read())
                {
                    int index = this.studentList.Rows.Add();

                    this.studentList.Rows[index].Cells[0].Value = reader.GetInt32("id");
                    this.studentList.Rows[index].Cells[1].Value = reader.GetString("grade");
                    this.studentList.Rows[index].Cells[2].Value = reader.GetString("name");
                    this.studentList.Rows[index].Cells[3].Value = reader.GetString("major");
                    this.studentList.Rows[index].Cells[4].Value = reader.GetString("phone");
                    this.studentList.Rows[index].Cells[5].Value = reader.GetFloat("math_score");
                    this.studentList.Rows[index].Cells[6].Value = reader.GetFloat("computer_score");
                    this.studentList.Rows[index].Cells[7].Value = reader.GetFloat("english_score");
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // 先清空dataview
            this.studentList.Rows.Clear();

            string inputGrade = this.gradeComBox.Text;
            string inputName = this.nameInput.Text.Trim();

            MySqlConnection conn = new MySqlConnection(DatabaseConfig.connectStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                string sql = "select * from student";
                MySqlCommand cmd = new MySqlCommand(sql, conn); ;
                if (inputGrade != "" && inputName == "")
                {
                    sql = "select * from student where grade=@grade";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("grade", inputGrade);
                }
                if (inputName != "" && inputGrade == "")
                {
                    sql = "select * from student where name=@name ";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("name", inputName);
                }
                if (inputGrade != "" && inputName != "")
                {
                    sql = "select * from student where grade=@grade and name=@name ";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("grade", inputGrade);
                    cmd.Parameters.AddWithValue("name", inputName);
                }
                MySqlDataReader reader = cmd.ExecuteReader();//执行ExecuteReader()返回一个MySqlDataReader对象
                int index = 0;
                while (reader.Read())
                {
                    index = this.studentList.Rows.Add();
                    this.studentList.Rows[index].Cells[0].Value = reader.GetInt32("id");
                    this.studentList.Rows[index].Cells[1].Value = reader.GetString("grade");
                    this.studentList.Rows[index].Cells[2].Value = reader.GetString("name");
                    this.studentList.Rows[index].Cells[3].Value = reader.GetString("major");
                    this.studentList.Rows[index].Cells[4].Value = reader.GetString("phone");
                    this.studentList.Rows[index].Cells[5].Value = reader.GetFloat("math_score");
                    this.studentList.Rows[index].Cells[6].Value = reader.GetFloat("computer_score");
                    this.studentList.Rows[index].Cells[7].Value = reader.GetFloat("english_score");
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            StudentAdd studentAdd = new StudentAdd();
            if (studentAdd.ShowDialog() == DialogResult.OK)
            {
                teacherInit();
            }
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in studentList.SelectedRows)
            {
                 modifyStudent(r.Index);
            }
            teacherInit();
            MessageBox.Show("修改成功");
        }

        private void modifyStudent(int index)
        {
            string id = this.studentList.Rows[index].Cells[0].Value.ToString();
            string inputGrade = this.studentList.Rows[index].Cells[1].Value.ToString();
            string inputName = this.studentList.Rows[index].Cells[2].Value.ToString();
            string inputMajor = this.studentList.Rows[index].Cells[3].Value.ToString();
            string inputPhone = this.studentList.Rows[index].Cells[4].Value.ToString();
            string inputMath = this.studentList.Rows[index].Cells[5].Value.ToString();
            string inputComputer = this.studentList.Rows[index].Cells[6].Value.ToString();
            string inputEnglish = this.studentList.Rows[index].Cells[7].Value.ToString();

            MySqlConnection conn = new MySqlConnection(DatabaseConfig.connectStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句

                string sql = "update student set grade='" + inputGrade + "',name='" + inputName + "',major='" + inputMajor + "',phone='" + inputPhone + "',math_score='" + inputMath + "',computer_score='" + inputComputer + "',english_score='" + inputEnglish + "' where id='" + id + "'";
                //string sql = "delete from user where userid='9'";
                //string sql = "update user set username='啊哈',password='123' where userid='8'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int result = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("修改失败");
                return;
            }
            finally
            {
                conn.Close();
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int index = studentList.CurrentRow.Index;
            string id = this.studentList.Rows[index].Cells[0].Value.ToString();
            MySqlConnection conn = new MySqlConnection(DatabaseConfig.connectStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句

                string sql = "delete from student where id='" + id + "'";
                //string sql = "delete from user where userid='9'";
                //string sql = "update user set username='啊哈',password='123' where userid='8'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int result = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("删除失败");
                return;
            }
            finally
            {
                conn.Close();
            }
            teacherInit();
            MessageBox.Show("删除成功");
        }
    }
}
