using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace student_manage
{
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
