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
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=student_manage;";

            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                Console.WriteLine("已经建立连接");
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

    }
}
