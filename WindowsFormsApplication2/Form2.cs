using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
     
        private void Form2_Load(object sender, EventArgs e)
        {

           
            foreach (UserClass h in UserDL.userlist)
            {
                UserControl1 l = new UserControl1(h.Img, h.Username);
                flowLayoutPanel1.Controls.Add(l);

            }
        }

   
     

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        
            Form1 h = new Form1();
            this.Hide();
            h.Show();
        }
    }
}
