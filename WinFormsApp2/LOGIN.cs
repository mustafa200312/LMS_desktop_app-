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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstr = "server=127.0.0.1;uid=root;pwd=123987;database=lms";

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Email or password is missing");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    conn.Open();

                    string sql_cmd = "SELECT count(*) as num,type FROM user WHERE email = @Email AND password = @Password";
                    using (MySqlCommand cmd = new MySqlCommand(sql_cmd, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Read();
                        String v = dr["num"].ToString();
                        int count = Convert.ToInt32(v);
                        if (count == 1)
                        {
                            string x = dr["type"].ToString();
                            if (x == "educator")
                            {

                                dashboard_edu form3 = new dashboard_edu(textBox1.Text);
                                form3.Show();
                                this.Hide();
                            }
                            else
                            {
                                dashboard_student form2 = new dashboard_student(textBox1.Text);
                                form2.Show();
                                this.Hide();
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
