namespace WinFormsApp2
{
    partial class classroom
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
            components = new System.ComponentModel.Container();
            course_label = new Label();
            listBox1 = new ListBox();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // course_label
            // 
            course_label.AutoSize = true;
            course_label.Font = new Font("Segoe UI", 12F);
            course_label.Location = new Point(42, 41);
            course_label.Name = "course_label";
            course_label.Size = new Size(146, 28);
            course_label.TabIndex = 0;
            course_label.Text = "COURSE NAME";
            course_label.Click += course_label_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 14F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Items.AddRange(new object[] { "Sections", "Quizzes", "Tasks" });
            listBox1.Location = new Point(42, 231);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(706, 128);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(42, 132);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 2;
            label1.Text = "SECTIONS";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(386, 44);
            button3.Name = "button3";
            button3.Size = new Size(178, 29);
            button3.TabIndex = 9;
            button3.Text = "ADD ATTACHMENTS";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(570, 96);
            button2.Name = "button2";
            button2.Size = new Size(178, 29);
            button2.TabIndex = 8;
            button2.Text = "ADD STUDENT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(570, 44);
            button1.Name = "button1";
            button1.Size = new Size(178, 29);
            button1.TabIndex = 7;
            button1.Text = "SHOW STUDENTS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button5
            // 
            button5.Location = new Point(386, 96);
            button5.Name = "button5";
            button5.Size = new Size(178, 29);
            button5.TabIndex = 11;
            button5.Text = "ADD TASK";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(570, 146);
            button6.Name = "button6";
            button6.Size = new Size(178, 29);
            button6.TabIndex = 12;
            button6.Text = "ADD QUIZ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // classroom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(course_label);
            Name = "classroom";
            Text = "classroom";
            Load += classroom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label course_label;
        private ListBox listBox1;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private Button button5;
        private Button button6;
    }
}