using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public UserControl1(Image i,string user) 
        {
            InitializeComponent();
            pictureBox1.Image = i;
            label1.Text = user;
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
