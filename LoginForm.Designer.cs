
namespace student_manage
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.studentLoginBtn = new System.Windows.Forms.Button();
            this.teacherLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(290, 71);
            this.label1.MaximumSize = new System.Drawing.Size(200, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码：";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(323, 164);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.PlaceholderText = "请输入用户名";
            this.usernameInput.Size = new System.Drawing.Size(212, 44);
            this.usernameInput.TabIndex = 3;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(323, 237);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.PlaceholderText = "请输入密码";
            this.passwordInput.Size = new System.Drawing.Size(212, 44);
            this.passwordInput.TabIndex = 4;
            // 
            // studentLoginBtn
            // 
            this.studentLoginBtn.Location = new System.Drawing.Point(254, 312);
            this.studentLoginBtn.Name = "studentLoginBtn";
            this.studentLoginBtn.Size = new System.Drawing.Size(148, 43);
            this.studentLoginBtn.TabIndex = 6;
            this.studentLoginBtn.Text = "学生登录";
            this.studentLoginBtn.UseVisualStyleBackColor = true;
            this.studentLoginBtn.Click += new System.EventHandler(this.studentLoginBtn_Click);
            // 
            // teacherLoginBtn
            // 
            this.teacherLoginBtn.Location = new System.Drawing.Point(454, 312);
            this.teacherLoginBtn.Name = "teacherLoginBtn";
            this.teacherLoginBtn.Size = new System.Drawing.Size(157, 43);
            this.teacherLoginBtn.TabIndex = 7;
            this.teacherLoginBtn.Text = "教师登录";
            this.teacherLoginBtn.UseVisualStyleBackColor = true;
            this.teacherLoginBtn.Click += new System.EventHandler(this.teacherLoginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.teacherLoginBtn);
            this.Controls.Add(this.studentLoginBtn);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "LoginForm";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button studentLoginBtn;
        private System.Windows.Forms.Button teacherLoginBtn;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
    }
}