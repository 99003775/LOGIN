using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows
{
    public partial class ORG1 : Form
    {
        public ORG1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Equals= "Helloword agian";
            ORG.Text = "Hello Word";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn2.Text = "cancel the text....";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form1.Text = "sub kuch";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // lblHello.Text = "Hello word";
            //label3.Text = "Tu hi hai sab kuck";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
          ORG.Text = "you are successfully login";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //ORG.Text = "Logout is Succcessful";
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            ORG.Text = "fish market";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ORG.Text = "Hello again....";
        }
    }
}
