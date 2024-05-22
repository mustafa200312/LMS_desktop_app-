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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp2
{
    public partial class request : Form
    {
        string email;
        static string connectionString = "server=127.0.0.1;uid=root;pwd=123987;database=lms";
        MySqlConnection conn = new MySqlConnection(connectionString);
        public request(string em)
        {
            InitializeComponent();
            email = em;
            conn.Open();
            string sql_cmd = "SELECT ClassroomId FROM Request WHERE email = @Email";
            MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
            cmd.Parameters.AddWithValue("@Email", em);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string title = dr["classroomId"].ToString();
                listBox1.Items.Add(title);
            }
            dr.Close();
        }

        private void request_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem.ToString();
            if (selectedItem != null)
            {
                string request_inp = Interaction.InputBox("To accept write (Y) otherwise (N)");
                if (request_inp == "Y")
                {
                    string sql_cmd = "INSERT INTO Enroll(email,classroomId) values(@email,@classroomId)";
                    MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@classroomId", selectedItem);
                    cmd.ExecuteNonQuery();

                    sql_cmd = "DELETE FROM Request WHERE email = @Email AND classroomId = @classroomId";
                    cmd = new MySqlCommand(sql_cmd, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@classroomId", selectedItem);
                    cmd.ExecuteNonQuery();  
                }
                else if (request_inp == "N")
                {
                    string sql_cmd = "DELETE FROM Request WHERE email = @Email AND classroomId = @classroomId";
                    MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@classroomId", selectedItem);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                }
            }
        }
    }
}
