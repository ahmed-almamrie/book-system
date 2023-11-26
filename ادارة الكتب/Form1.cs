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

namespace ادارة_الكتب
{
    public partial class Form1 : Form
    {
        //var for sqlcon
        SqlConnection con=new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            con.ConnectionString = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\a\documents\visual studio 2012\Projects\ادارة الكتب\ادارة الكتب\Db_book.mdf;Integrated Security=True");
            var sql = "SELECT ID,TITLE,AUTHER,PRICE,CAT FROM BOOK";
           da = new SqlDataAdapter(sql, con);
           da.Fill(dt);
           dataGridView1.DataSource = dt;
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
