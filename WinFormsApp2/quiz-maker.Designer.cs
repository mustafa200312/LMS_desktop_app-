namespace WinFormsApp2
{
    partial class quiz_maker
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
            label1 = new Label();
            quiz_title = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            duration = new TextBox();
            start_time = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(50, 90);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 0;
            label1.Text = "Quiz title";
            // 
            // quiz_title
            // 
            quiz_title.Location = new Point(50, 121);
            quiz_title.Name = "quiz_title";
            quiz_title.Size = new Size(699, 27);
            quiz_title.TabIndex = 1;
            quiz_title.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(50, 361);
            button1.Name = "button1";
            button1.Size = new Size(699, 77);
            button1.TabIndex = 2;
            button1.Text = "Add questions";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(50, 160);
            label2.Name = "label2";
            label2.Size = new Size(503, 28);
            label2.TabIndex = 5;
            label2.Text = "Starting time format \"YYYY-MM-DD HH:MM:SS.SSSSSS\"";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(50, 250);
            label3.Name = "label3";
            label3.Size = new Size(184, 28);
            label3.TabIndex = 6;
            label3.Text = "Duration in minutes";
            // 
            // duration
            // 
            duration.Location = new Point(50, 281);
            duration.Name = "duration";
            duration.Size = new Size(338, 27);
            duration.TabIndex = 7;
            duration.TextChanged += textBox1_TextChanged_1;
            // 
            // start_time
            // 
            start_time.Location = new Point(50, 210);
            start_time.Name = "start_time";
            start_time.Size = new Size(503, 27);
            start_time.TabIndex = 8;
            // 
            // quiz_maker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(start_time);
            Controls.Add(duration);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(quiz_title);
            Controls.Add(label1);
            Name = "quiz_maker";
            Text = "quiz_maker";
            Load += quiz_maker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox quiz_title;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox duration;
        private TextBox start_time;
    }
}