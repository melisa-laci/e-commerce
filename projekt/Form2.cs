using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace projekt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        static Regex validate_emailaddress = email_validation();
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            textBox2.UseSystemPasswordChar = true;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            textBox2.UseSystemPasswordChar = false;

        }
        //Krijimi i nje funksioni per ndrysimin e madhesise se dritares se Form 2
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0X2;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);

            }
        }
        //Kur klikoket X (picturebox4) ne cepin e dritares, dritarja mbyllet
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Kur textBox per Usrnamin fillon te shkruhet ne te, kontrollon qe usernami te mos mbetet bosh ose vetem me hapsira (space)
        private void textbox1_TxtChanged(object sender, EventArgs e)
        {

            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;

            /*if (validate_emailaddress.IsMatch(textBox1.Text) != true)
            {
                label8.Visible = true;
                label10.Visible = true;
            }
            else
            {
                label8.Visible = false;
                label10.Visible = false;

            }*/

        }
        //Kur klikohet buttoni "Login" behet kontrolli per saktesine e informacionit te vene nga perdoruesi
        private void button1_Click(object sender, EventArgs e)
        {
            //Kontrolohet nese usernamei dhe paswordi jan perkatsisht usn ="ml@gmail" dhe pss="ola123"
            if (textBox1.Text == "ml@gmail" && textBox2.Text == "ola123")
            {
                label7.Visible = false;    //fshihen mesazhet e errorit
                label9.Visible = false;
                label12.Visible = false;

            }
            else if (textBox1.Text.Trim() == string.Empty && textBox2.Text.Trim() == string.Empty)
            {
                label7.Visible = false;
                
                label12.Visible = true;  //new label
                label9.Visible = true; //txt change pass is required
            }
            else if (validate_emailaddress.IsMatch(textBox1.Text) != true)
            {
                label8.Visible = true;
                label10.Visible = true;
            }
            else if (textBox1.Text.Trim() == string.Empty) //nese textBox i Usernamit esht  bosh ose vetem me space show mesazhi i  errorit "Invalid username"
            {
                label12.Visible = true; //newlab
            }
            else if (textBox2.Text.Trim() == string.Empty)
            {
                label7.Visible = false;
                label9.Visible = true;
            }
            
            else
            {
                label7.Visible = true;
                label8.Visible = false;
                label9.Visible = false;
                label12.Visible = false;

            }

            if (label7.Visible == true || label9.Visible == true)
                label11.Visible = true;
            else
                label11.Visible = false;

            if (label8.Visible == true || label12.Visible == true)
                label10.Visible = true;
            else
                label10.Visible = false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.Blue;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.Red;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.ShowDialog();
        }
    }
}

