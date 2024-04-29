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
            label1.Location = new Point(178, 79);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 134);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // UserName
            // 
            UserName.Location = new Point(321, 72);
            UserName.Name = "UserName";
            UserName.Size = new Size(125, 27);
            UserName.TabIndex = 2;
            // 
            // ID
            // 
            ID.Location = new Point(321, 127);
            ID.Name = "ID";
            ID.Size = new Size(125, 27);
            ID.TabIndex = 3;
            // 
            // Login
            // 
            Login.Location = new Point(336, 206);
            Login.Name = "Login";
            Login.Size = new Size(94, 29);
            Login.TabIndex = 4;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            // 
            // LMS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 453);
            Controls.Add(Login);
            Controls.Add(ID);
            Controls.Add(UserName);
            Controls.Add(label2);
            Controls.Add(label1);
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
