namespace WinFormsApp2
{
    partial class dashboard_edu
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
            name_label = new Label();
            listBox1 = new ListBox();
            SUBMIT = new Button();
            SuspendLayout();
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Segoe UI", 12F);
            name_label.Location = new Point(34, 65);
            name_label.Name = "name_label";
            name_label.Size = new Size(68, 28);
            name_label.TabIndex = 0;
            name_label.Text = "NAME";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(34, 173);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(723, 184);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // SUBMIT
            // 
            SUBMIT.Location = new Point(34, 388);
            SUBMIT.Name = "SUBMIT";
            SUBMIT.Size = new Size(723, 29);
            SUBMIT.TabIndex = 2;
            SUBMIT.Text = "CREATE CLASSROOM";
            SUBMIT.UseVisualStyleBackColor = true;
            SUBMIT.Click += button1_Click;
            // 
            // dashboard_edu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SUBMIT);
            Controls.Add(listBox1);
            Controls.Add(name_label);
            Name = "dashboard_edu";
            Text = "dashboard_edu";
            Load += dashboard_edu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_label;
        private ListBox listBox1;
        private Button SUBMIT;
    }
}