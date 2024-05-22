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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class question_maker : Form
    {
        string quiz_id;
        string email;
        string myConnectionString = "server=127.0.0.1;uid=root;pwd=123987;database=lms";
        public question_maker(string quiz_id, string email)
        {
            InitializeComponent();
            this.quiz_id = quiz_id;
            this.email = email;
        }

        private void question_maker_Load(object sender, EventArgs e)
        {

        }

        private void question_title_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(myConnectionString);
            DateTime currentDate = DateTime.Now;
            string dateString = currentDate.ToString("yyyy-MM-dd-HH-mm-ss");
            string question_id = email + "-question-" + dateString;
            conn.Open();
            string sql_cmd = "INSERT INTO Questions (QuestionId, QuestionTitle, rightAnswer, QuizId) VALUES (@QuestionId, @QuestionTitle, @rightAnswer, @QuizId)";

            MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
            cmd.Parameters.AddWithValue("@QuestionId", question_id);
            cmd.Parameters.AddWithValue("@QuestionTitle", question_title.Text);
            cmd.Parameters.AddWithValue("@rightAnswer", answer.Text);
            cmd.Parameters.AddWithValue("QuizId", quiz_id);
            cmd.ExecuteNonQuery();



            string[] answers = question_choices.Text.Split(',');
            int i = 0;
            foreach (string answer in answers)
            {
                DateTime currentDate2 = DateTime.Now;
                string dateString2 = currentDate.ToString("yyyy-MM-dd-HH-mm-ss-" + i.ToString());
                string answerId = email + "-answer-" + dateString2;

                sql_cmd = "INSERT INTO AnswersList (QuestionId,answerId,QuizId) VALUES (@QuestionId,@answerId,@QuizId)";
                cmd = new MySqlCommand(sql_cmd, conn);
                cmd.Parameters.AddWithValue("@QuestionId", question_id);
                cmd.Parameters.AddWithValue("@answerId", answerId);
                cmd.Parameters.AddWithValue("@QuizId", quiz_id);
                cmd.ExecuteNonQuery();
                i++;
            }
            conn.Close();
        }

        private void question_answer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
