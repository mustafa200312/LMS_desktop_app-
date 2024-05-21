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
    public partial class dashboard_edu : Form
    {
        string fname;
        string email;
        string connstr = "server=localhost;uid=root;pwd=123987;database=lms";
        MySqlConnection conn = new MySqlConnection();
        public dashboard_edu(string em)
        {
            InitializeComponent();
            conn.ConnectionString = connstr;
            conn.Open();
            email = em;
            string sql_cmd = "SELECT * FROM user WHERE email = @Email";
            MySqlDataReader dr;
            using (MySqlCommand cmd = new MySqlCommand(sql_cmd, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                dr = cmd.ExecuteReader();
                dr.Read();
                fname = dr["Fname"].ToString();
                dr.Close();
            }
            sql_cmd = "select classroomName,classroomId from classroom where  CreatorEmail = @CreatorEmail";
            using (MySqlCommand cmd = new MySqlCommand(sql_cmd, conn))
            {
                cmd.Parameters.AddWithValue("@CreatorEmail", email);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string title = dr["classroomName"].ToString();
                    string id = dr["classroomId"].ToString();
                    listBox1.Items.Add(title);
                }
                dr.Close();
                conn.Close();
            }
            name_label.Text = "HI " + fname + " !";
        }

        private void dashboard_edu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime currentDate = DateTime.Now;
            string dateString = currentDate.ToString("yyyy-MM-dd-HH-mm-ss");
            string classroom = Interaction.InputBox("Enter input name");
            if ((classroom == " ") || (classroom == ""))
            {
                MessageBox.Show("INVALID INPUT");
                return;
            }
            conn.ConnectionString = connstr;
            conn.Open();
            string sql_cmd = "INSERT INTO classroom (classroomId, classroomName, CreatorEmail) VALUES (@class_id, @class_Name, @CreatorEmail)";
            using (MySqlCommand cmd = new MySqlCommand(sql_cmd, conn))
            {
                cmd.Parameters.AddWithValue("@class_id", email + dateString);
                cmd.Parameters.AddWithValue("@class_Name", classroom);
                cmd.Parameters.AddWithValue("@CreatorEmail", email);
                cmd.ExecuteNonQuery();
            }
            listBox1.Items.Add(classroom);
            conn.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem.ToString();
            if (selectedItem != null)
            {
                classroom classroom = new classroom(email, selectedItem);
                classroom.Show();
                this.Show();
            }
        }
    }
}
