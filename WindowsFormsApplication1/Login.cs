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
    public partial class Login : Form
    {
        SqlDbConnect conn = new SqlDbConnect();
        public Login()
        {
            InitializeComponent();
            //new Form1().Close();
            string sql = "SELECT* from subject";
            conn.SqlQuery(sql);
            int i = 0;
            foreach (DataRow dr in conn.QueryEx().Rows)
            {
                CheckBox box;

                box = new CheckBox();
                box.Tag = i.ToString();
                box.Text = dr[1] + " " + dr[2] + " " + dr[3];
                box.AutoSize = true;
                box.Location = new Point(10, i * 50); //vertical
                //box.Location = new Point(i * 50, 10); //horizontal
                this.Controls.Add(box);
                i++;

            }


        }
        String[]s1 =new String[1000];
        int i = 0;
        string h="";
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            h = "";
            foreach (Control c in Controls.OfType<CheckBox>())
            {
                if (((CheckBox)c).Checked == true)
                {
                    // Console.WriteLine("hi");
                    //MessageBox.Show(((CheckBox)c).Text.ToString());
                    s1[i] = ((CheckBox)c).Text.ToString();
                    h += ((CheckBox)c).Text.ToString()+"\n";
                    i++;

                }
                else
                {
                    //
                }
            }
            MessageBox.Show(h);
         
        }
    }
}
