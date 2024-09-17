using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace wcrud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-M2FCJ8B\\MSSQLSERVER01;Initial Catalog=crud;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string Name = tbName.Text;
            string Age = tbAge.Text;
            string Query = "INSERT INTO tablecrud (NAME, AGE) VALUES ('"+ Name + "','"+ Age + "')";

            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data has been saved");
        }
    }
}
