using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_manage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //this.IsMdiContainer = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            LoginForm loginForm = new LoginForm();
            //loginForm.MdiParent = this;
            loginForm.StartPosition = FormStartPosition.CenterParent;
            loginForm.ShowDialog();
        }
    }
}
