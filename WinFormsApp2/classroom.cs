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

        public classroom(string email, string selectedItem)
        {
            InitializeComponent();
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
            string email_s = Interaction.InputBox("Enter input name");
            string sql_cmd = "INSERT INTO request(Email,ClassroomId) values(@email,@ClassroomId)";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql_cmd, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email_s);
                    cmd.Parameters.AddWithValue("@ClassroomId", classroomId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
