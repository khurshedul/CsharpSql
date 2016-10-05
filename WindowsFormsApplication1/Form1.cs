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
    public partial class Form1 : Form
    {
        SqlDbConnect conn = new SqlDbConnect();
        public Form1()
        {
            InitializeComponent();
            //new Form2().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text=="admin")
            {
                //this.Visible=false;
                
                new Form2().Show();
                
            }
            else if (textBox1.Text == "user" && textBox2.Text == "user")
            {
                
                new Login().Show();
               
            }
            else
            {
                MessageBox.Show("wrong username or password");
            }


        }
    }
}