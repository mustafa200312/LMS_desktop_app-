namespace WinFormsApp2
{
    partial class classroom_student
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
            classroom_name = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // classroom_name
            // 
            classroom_name.AutoSize = true;
            classroom_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classroom_name.Location = new Point(55, 41);
            classroom_name.Name = "classroom_name";
            classroom_name.Size = new Size(190, 28);
            classroom_name.TabIndex = 0;
            classroom_name.Text = "CLASSROOM NAME";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(55, 121);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(713, 264);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // classroom_student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(classroom_name);
            Name = "classroom_student";
            Text = "classroom_student";
            Load += classroom_student_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label classroom_name;
        private ListBox listBox1;
    }
}