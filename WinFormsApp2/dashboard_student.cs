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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp2
{
    public partial class dashboard_student : Form
    {
        static string connectionString = "server=127.0.0.1;uid=root;pwd=123987;database=lms";
        MySqlConnection conn = new MySqlConnection(connectionString);
        string em, fname;
        public dashboard_student(string em)
        {
            InitializeComponent();
            try
            {
                conn.Open();
                this.em = em;
                string sql_cmd = "SELECT * FROM user WHERE email = @Email";
                MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                cmd.Parameters.AddWithValue("@Email", em);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                fname = dr["Fname"].ToString();
                this.fname = fname;
                name_label.Text = fname;
                dr.Close();

                sql_cmd = "SELECT classroom.classroomName FROM Enroll INNER JOIN classroom ON classroom.classroomId = Enroll.classroomId where Enroll.email = @email";
                cmd = new MySqlCommand(sql_cmd, conn);
                cmd.Parameters.AddWithValue("@Email", em);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string title = dr["classroomName"].ToString();
                    listBox1.Items.Add(title);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dashboard_student_Load(object sender, EventArgs e)
        {

        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            request req = new request(em);
            req.Show();
        }

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
