using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\10150298\source\repos\Exam\Exam\exam.mdf;Integrated Security=True";
            SqlConnection Conn = new SqlConnection(@strConn);
            Conn.Open();

            string sInsSql = "Insert into driver (id_driver, first_name, last_name, pather_name, number_dc) Values ({0},{1},{2},{3},{4})";

            int id_driver = Convert.ToInt32(textBox5.Text);
            string first_name = textBox1.Text;
            string last_name = textBox2.Text;
            string pather_name = textBox3.Text;
            int number_dc = Convert.ToInt32(textBox4.Text);

            string sInsDriver = "Insert into driver (id_driver, first_name, last_name, pather_name, number_dc) Values (" + id_driver + ", '" + first_name + "', '" + last_name + "','" + pather_name + "'," + number_dc + ")";//string.Format(sInsSql,id_driver, first_name, last_name, pather_name, number_dc);

            SqlCommand cmdIns = new SqlCommand(sInsDriver, Conn);

            cmdIns.ExecuteNonQuery();
        }
    }
}
