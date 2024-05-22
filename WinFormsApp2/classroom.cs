using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp2
{
    public partial class classroom : Form
    {
        string connstr = "server=127.0.0.1;uid=root;pwd=123987;database=lms";
        MySqlDataReader dr;
        string classroomId = "";
        string email = "";
        public classroom(string email, string selectedItem)
        {
            InitializeComponent();
            this.email = email;
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connstr;
            conn.Open();
            string sql_cmd = "SELECT classroomId FROM classroom WHERE CreatorEmail = @email and classroomName =  @classroomName";
            using (MySqlCommand cmd = new MySqlCommand(sql_cmd, conn))
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@classroomName", selectedItem);
                dr = cmd.ExecuteReader();
                dr.Read();
                classroomId = dr["classroomId"].ToString();
                conn.Close();
            }
            course_label.Text = selectedItem;
        }

        private void classroom_Load(object sender, EventArgs e)
        {

        }

        private void course_label_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email_s = Interaction.InputBox("Enter student email");
            string sql_cmd = "INSERT INTO request(Email,ClassroomId) values(@email,@ClassroomId)";
            try
            {
                MySqlConnection conn = new MySqlConnection(connstr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                cmd.Parameters.AddWithValue("@email", email_s);
                cmd.Parameters.AddWithValue("@ClassroomId", classroomId);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            quiz_maker qm = new quiz_maker(email, classroomId);
            qm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_Students show_Students = new show_Students(classroomId);
            show_Students.Show();

        }
    }
}
