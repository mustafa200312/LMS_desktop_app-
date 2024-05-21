using Microsoft.VisualBasic.Logging;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN form1 = new LOGIN();
            form1.Show();
            this.Hide();
        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
            CREATE_U form1 = new CREATE_U();
            form1.Show();
            this.Hide();
        }
    }
}
