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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      
        }
   

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Image im = Image.FromStream(openFileDialog1.OpenFile());
            pictureBox1.Image = im;
        }

        private void cmdChooseImage(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void cmdSignUp(object sender, EventArgs e)
        {
        
                UserClass u = new UserClass();
                u.Username = textBox1.Text;
                u.Password = textBox2.Text;
                u.Img = pictureBox1.Image;
                UserDL.userlist.Add(u);

                MessageBox.Show("User has registered successfully");
                textBox1.Text = "";
                textBox2.Text = "";
                pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.th;
            
           }

        private void lnklblShowall(object sender, EventArgs e)
        {
         
            Form2 r = new Form2();
            this.Hide();

            r.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
         
        }

     

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
