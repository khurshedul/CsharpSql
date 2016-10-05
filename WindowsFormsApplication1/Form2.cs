using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        SqlDbConnect conn = new SqlDbConnect();
        public Form2()
        {
            InitializeComponent();
          //  new Form1().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = "insert into subject values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox4.Text + "')";
            conn.SqlQuery(sql);
            conn.NonQueryEx();
            new Form1().Show();
          
            
        }
    }
}
