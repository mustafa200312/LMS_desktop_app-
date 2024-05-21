using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace WinFormsApp2
{
    public partial class CREATE_U : Form
    {
        public CREATE_U()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myConnectionString = "server=127.0.0.1;uid=root;pwd=123987;database=lms";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnectionString))
                {
                    conn.Open();

                    string sql_cmd = "INSERT INTO user (Email, Password, FName, LName, Type) VALUES (@Email, @Password, @FName, @LName, @Type)";
                    using (MySqlCommand cmd = new MySqlCommand(sql_cmd, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email.Text);
                        cmd.Parameters.AddWithValue("@Password", password.Text);
                        cmd.Parameters.AddWithValue("@FName", firstname.Text);
                        cmd.Parameters.AddWithValue("@LName", lastname.Text);
                        cmd.Parameters.AddWithValue("@Type", comboBox1.Text);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                using (MySqlConnection conn = new MySqlConnection(myConnectionString))
                {
                    conn.Open();
                    string sql_cmd = "INSERT INTO " + comboBox1.Text + "(Email, FName, LName) VALUES (@Email,@FName, @LName)";
                    using (MySqlCommand cmd = new MySqlCommand(sql_cmd, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email.Text);
                        cmd.Parameters.AddWithValue("@FName", firstname.Text);
                        cmd.Parameters.AddWithValue("@LName", lastname.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                LOGIN login = new LOGIN();
                login.Show();
                this.Hide();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CREATE_U_Load(object sender, EventArgs e)
        {

        }
    }
}
