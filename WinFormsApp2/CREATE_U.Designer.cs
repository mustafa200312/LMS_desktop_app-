namespace WinFormsApp2
{
    partial class CREATE_U
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
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            password = new TextBox();
            email = new TextBox();
            label1 = new Label();
            firstname = new TextBox();
            label4 = new Label();
            lastname = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(373, 388);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 174);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(447, 174);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // password
            // 
            password.Location = new Point(61, 213);
            password.Name = "password";
            password.Size = new Size(307, 27);
            password.TabIndex = 7;
            // 
            // email
            // 
            email.Location = new Point(447, 213);
            email.Name = "email";
            email.Size = new Size(307, 27);
            email.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 44);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 12;
            label1.Text = "Firstname";
            label1.Click += label1_Click;
            // 
            // firstname
            // 
            firstname.Location = new Point(61, 100);
            firstname.Name = "firstname";
            firstname.Size = new Size(307, 27);
            firstname.TabIndex = 11;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 16;
            // 
            // lastname
            // 
            lastname.Location = new Point(447, 100);
            lastname.Name = "lastname";
            lastname.Size = new Size(307, 27);
            lastname.TabIndex = 13;
            lastname.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "educator", "learner" });
            comboBox1.Location = new Point(260, 319);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(298, 28);
            comboBox1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(447, 44);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 17;
            label5.Text = "Lastname";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(260, 279);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 18;
            label6.Text = "Type";
            // 
            // CREATE_U
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(lastname);
            Controls.Add(label1);
            Controls.Add(firstname);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(email);
            Name = "CREATE_U";
            Text = "CREATE_U";
            Load += CREATE_U_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox password;
        private TextBox email;
        private Label label1;
        private TextBox firstname;
        private Label label4;
        private TextBox lastname;
        private Label label5;
        private Label label6;
        public ComboBox comboBox1;
    }
}