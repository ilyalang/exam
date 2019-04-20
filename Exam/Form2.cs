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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void владельцевАвтомобилейToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // driverBindingSource.Visible = true;
            //carBindingSource.Visible = false;
            //violationBindingSource.Visible = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDataSet5.violation". При необходимости она может быть перемещена или удалена.
            this.violationTableAdapter2.Fill(this.examDataSet5.violation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDataSet4.violation". При необходимости она может быть перемещена или удалена.
            this.violationTableAdapter1.Fill(this.examDataSet4.violation);

        }

        private void машиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  driverBindingSource.Visible = false;
          //  carBindingSource.Visible = true;
          //  violationBindingSource.Visible = false;
        }

        private void нарушенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // driverBindingSource.Visible = false;
          //  carBindingSource.Visible = false;
           // violationBindingSource.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем и открываем соединение с MS SQL Server ...

            string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\10150298\source\repos\Exam\Exam\exam.mdf;Integrated Security=True";

            SqlConnection Conn = new SqlConnection(@strConn);

            Conn.Open();

        }

        private void владельцаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Form1 newForm1 = new Form1();
            newForm1.Show();
        }
    }
}
