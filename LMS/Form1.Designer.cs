namespace LMS
{
    partial class LMS
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
            label1 = new Label();
            label2 = new Label();
            UserName = new TextBox();
            ID = new TextBox();
            Login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 59);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 100);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // UserName
            // 
            UserName.Location = new Point(281, 54);
            UserName.Margin = new Padding(3, 2, 3, 2);
            UserName.Name = "UserName";
            UserName.Size = new Size(110, 23);
            UserName.TabIndex = 2;
            // 
            // ID
            // 
            ID.Location = new Point(281, 95);
            ID.Margin = new Padding(3, 2, 3, 2);
            ID.Name = "ID";
            ID.Size = new Size(110, 23);
            ID.TabIndex = 3;
            // 
            // Login
            // 
            Login.Location = new Point(294, 154);
            Login.Margin = new Padding(3, 2, 3, 2);
            Login.Name = "Login";
            Login.Size = new Size(82, 22);
            Login.TabIndex = 4;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // LMS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 340);
            Controls.Add(Login);
            Controls.Add(ID);
            Controls.Add(UserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LMS";
            Text = "Library Management System ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox UserName;
        private TextBox ID;
        private Button Login;
    }
}
