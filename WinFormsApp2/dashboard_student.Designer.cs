namespace WinFormsApp2
{
    partial class dashboard_student
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
            SUBMIT = new Button();
            listBox1 = new ListBox();
            name_label = new Label();
            SuspendLayout();
            // 
            // SUBMIT
            // 
            SUBMIT.Location = new Point(39, 374);
            SUBMIT.Name = "SUBMIT";
            SUBMIT.Size = new Size(723, 29);
            SUBMIT.TabIndex = 5;
            SUBMIT.Text = "REQUEST";
            SUBMIT.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(39, 99);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(723, 244);
            listBox1.TabIndex = 4;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Segoe UI", 12F);
            name_label.Location = new Point(39, 47);
            name_label.Name = "name_label";
            name_label.Size = new Size(68, 28);
            name_label.TabIndex = 3;
            name_label.Text = "NAME";
            // 
            // dashboard_student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SUBMIT);
            Controls.Add(listBox1);
            Controls.Add(name_label);
            Name = "dashboard_student";
            Text = "dashboard_student";
            Load += dashboard_student_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SUBMIT;
        private ListBox listBox1;
        private Label name_label;
    }
}