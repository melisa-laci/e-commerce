using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace projekt
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        static Regex validate_emailaddress = email_validation();

        private void textBox1_Change(object sender, EventArgs e)
        {
            if (validate_emailaddress.IsMatch(textBox1.Text) != true)
            {
                labelErrorrMsg11.Visible = true;
                labelErrorrColor1.Visible = true;
            }
            else
            {
                labelErrorrMsg11.Visible = false;
                labelErrorrColor1.Visible = false;

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox3.Text)
            {
                labelErrorrMsg31.Visible = true;
                labelErrorrColor3.Visible = true;
            }
            else
            {
                labelErrorrMsg31.Visible = false;
                labelErrorrColor3.Visible = false;
            }

            if (textBox3.Text.Trim() == string.Empty)
            {
                labelErrorrMsg32.Visible = true;
                labelErrorrColor3.Visible = true;
            }
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            labelErrorrMsg32.Visible = false;
            labelErrorrColor3.Visible = false;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                labelErrorrMsg12.Visible = true;
                labelErrorrColor1.Visible = true;
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            labelErrorrMsg12.Visible = false;
            labelErrorrColor1.Visible = false;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == string.Empty)
            {
                labelErrorrMsg22.Visible = true;
                labelErrorrColor2.Visible = true;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            labelErrorrMsg22.Visible = false;
            labelErrorrColor2.Visible = false;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text.Trim() == string.Empty)
            {
                labelErrorrMsg42.Visible = true;
                labelErrorrColor4.Visible = true;
            }
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            labelErrorrMsg42.Visible = false;
            labelErrorrColor4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


    }
}
