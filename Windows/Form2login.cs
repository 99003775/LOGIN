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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void login1()
        {
            string id = idbox.Text;
            string pass = passbox.Text;

            if (id == "amit" && pass == "9733")
            {
                this.Hide();
                ORG1 f = new ORG1();
                f.Show();
                // ORG1.Text = "YOU ARE SUCCESSFULLY LOGIN";


            }
            else
            {

                MessageBox.Show("Please Enter correct Id and password");

            }
        }

        private void reset()
        {
            idbox.Text = "";
            passbox.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            login1();


        }

        private void idbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void passbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                login1();

            }
            if(e.KeyChar == (char)Keys.Space)
            {
                reset();
            }
        }
    }
}
