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
        string connstr = "server=127.0.0.1;uid=root;pwd=123987;database=lms";
        MySqlConnection conn = new MySqlConnection();
        string em, fname;
        public dashboard_student(string em)
        {
            InitializeComponent();
            this.em = em;
            string sql_cmd = "SELECT * FROM user WHERE email = @Email";
            MySqlDataReader dr;
            using (MySqlCommand cmd = new MySqlCommand(sql_cmd, conn))
            {
                cmd.Parameters.AddWithValue("@Email", em);
                dr = cmd.ExecuteReader();
                dr.Read();
                fname = dr["Fname"].ToString();
                this.fname = fname; 
                dr.Close();
            }
        }

        private void dashboard_student_Load(object sender, EventArgs e)
        {

        }
    }
}
