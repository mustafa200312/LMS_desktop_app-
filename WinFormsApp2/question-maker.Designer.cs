namespace WinFormsApp2
{
    partial class question_maker
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
            question_title = new TextBox();
            label2 = new Label();
            question_choices = new RichTextBox();
            label3 = new Label();
            button1 = new Button();
            answer = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(50, 50);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 0;
            label1.Text = "Question title:";
            // 
            // question_title
            // 
            question_title.Location = new Point(50, 92);
            question_title.Name = "question_title";
            question_title.Size = new Size(715, 27);
            question_title.TabIndex = 1;
            question_title.TextChanged += question_title_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(50, 122);
            label2.Name = "label2";
            label2.Size = new Size(164, 28);
            label2.TabIndex = 2;
            label2.Text = "Question choices:";
            // 
            // question_choices
            // 
            question_choices.Location = new Point(50, 153);
            question_choices.Name = "question_choices";
            question_choices.Size = new Size(715, 165);
            question_choices.TabIndex = 3;
            question_choices.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(50, 333);
            label3.Name = "label3";
            label3.Size = new Size(160, 28);
            label3.TabIndex = 4;
            label3.Text = "Question answer:";
            // 
            // button1
            // 
            button1.Location = new Point(313, 333);
            button1.Name = "button1";
            button1.Size = new Size(452, 58);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // answer
            // 
            answer.Location = new Point(50, 364);
            answer.Name = "answer";
            answer.Size = new Size(164, 27);
            answer.TabIndex = 7;
            // 
            // question_maker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(answer);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(question_choices);
            Controls.Add(label2);
            Controls.Add(question_title);
            Controls.Add(label1);
            Name = "question_maker";
            Text = "question_maker";
            Load += question_maker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox question_title;
        private Label label2;
        private RichTextBox question_choices;
        private Label label3;
        private Button button1;
        private TextBox answer;
    }
}