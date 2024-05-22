using System;
using System.Collections;
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
    public partial class show_Students : Form
    {
        static string connectionString = "server=127.0.0.1;uid=root;pwd=123987;database=lms";
        MySqlConnection conn = new MySqlConnection(connectionString);
        public show_Students(string classroomid)
        {
            InitializeComponent();
            conn.Open();
            string sql_cmd = "SELECT Fname, Lname FROM enroll INNER JOIN learner ON enroll.email = learner.email WHERE enroll.classroomid = '" + classroomid+"'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql_cmd, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void show_Students_Load(object sender, EventArgs e)
        {

        }
    }
}
