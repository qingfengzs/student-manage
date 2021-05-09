
namespace student_manage
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentList = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.yearComBox = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.math_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computer_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.english_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentList)).BeginInit();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.studentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.grade,
            this.name,
            this.major,
            this.phone,
            this.math_score,
            this.computer_score,
            this.english_score});
            this.studentList.Location = new System.Drawing.Point(-1, 63);
            this.studentList.Name = "studentList";
            this.studentList.RowTemplate.Height = 25;
            this.studentList.Size = new System.Drawing.Size(996, 481);
            this.studentList.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(364, 9);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(100, 38);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "查询";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameInput.Location = new System.Drawing.Point(186, 9);
            this.nameInput.Name = "nameInput";
            this.nameInput.PlaceholderText = "请输入姓名";
            this.nameInput.Size = new System.Drawing.Size(172, 38);
            this.nameInput.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(470, 9);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 38);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "新增";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(575, 9);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(100, 38);
            this.modifyBtn.TabIndex = 5;
            this.modifyBtn.Text = "修改";
            this.modifyBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(679, 9);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 38);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "删除";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // yearComBox
            // 
            this.yearComBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearComBox.FormattingEnabled = true;
            this.yearComBox.Location = new System.Drawing.Point(12, 8);
            this.yearComBox.Name = "yearComBox";
            this.yearComBox.Size = new System.Drawing.Size(168, 39);
            this.yearComBox.TabIndex = 7;
            this.yearComBox.Text = "请选择年级";
            // 
            // id
            // 
            this.id.HeaderText = "学号";
            this.id.Name = "id";
            this.id.Width = 120;
            // 
            // grade
            // 
            this.grade.HeaderText = "年级";
            this.grade.Name = "grade";
            // 
            // name
            // 
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            this.name.Width = 120;
            // 
            // major
            // 
            this.major.HeaderText = "专业";
            this.major.Name = "major";
            // 
            // phone
            // 
            this.phone.HeaderText = "联系电话";
            this.phone.Name = "phone";
            this.phone.Width = 130;
            // 
            // math_score
            // 
            this.math_score.HeaderText = "高等数学成绩";
            this.math_score.Name = "math_score";
            this.math_score.Width = 130;
            // 
            // computer_score
            // 
            this.computer_score.HeaderText = "计算机应用基础成绩";
            this.computer_score.Name = "computer_score";
            this.computer_score.Width = 120;
            // 
            // english_score
            // 
            this.english_score.HeaderText = "英语成绩";
            this.english_score.Name = "english_score";
            this.english_score.Width = 130;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 543);
            this.Controls.Add(this.yearComBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.studentList);
            this.Name = "MainForm";
            this.Text = "学生管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentList;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox yearComBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn major;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn math_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn computer_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn english_score;
    }
}

