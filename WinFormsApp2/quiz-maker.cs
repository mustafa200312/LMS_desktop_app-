using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp2
{
    public partial class quiz_maker : Form
    {
        string quiz_id;
        string email;
        string classroom_id;
        public quiz_maker(string email, string classroom_id)
        {
            InitializeComponent();
            DateTime currentDate = DateTime.Now;
            string dateString = currentDate.ToString("yyyy-MM-dd-HH-mm-ss");
            quiz_id = email + "-quiz-" + dateString;
            this.email = email;
            this.classroom_id = classroom_id;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(myConnectionString);
            DateTime currentDate = DateTime.Now;
            string dateString = currentDate.ToString("yyyy-MM-dd-HH-mm-ss");
            string question_id = email + "-question-" + dateString;
            conn.Open();
            string sql_cmd = "INSERT INTO Quiz (QuizId, title, startingTime, duration, ClassroomId, Email)" +
                " VALUES (@QuizId, @title, @startingTime, @duration, @ClassroomId, @Email)";

            MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
            cmd.Parameters.AddWithValue("@QuizId", quiz_id);
            cmd.Parameters.AddWithValue("@title", quiz_title.Text);
            cmd.Parameters.AddWithValue("@startingTime", start_time.Text);
            cmd.Parameters.AddWithValue("@duration", duration.Text);
            cmd.Parameters.AddWithValue("@ClassroomId", classroom_id);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.ExecuteNonQuery();

            question_maker qm = new question_maker(quiz_id, email);
            qm.Show();
            this.Hide();
        }

        private void quiz_maker_Load(object sender, EventArgs e)
        {

        }
        string myConnectionString = "server=127.0.0.1;uid=root;pwd=123987;database=lms";

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
