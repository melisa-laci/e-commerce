using System.Security.Cryptography.X509Certificates;


namespace projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool entered;
        public bool Entered
        {
            get { return entered; }
            set { entered = value; }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (panel1.Width < 187 )
            { 
                panel1.Width = panel1.Width + 10;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true; 
                button5.Visible = true;
                button6.Visible = true;
                button8.Visible = true;
            }
            else
                timer1.Stop();


        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            if (panel1.Width > 4 && Entered == false)
            {

                panel1.Width = panel1.Width - 20;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button8.Visible = false;
                
            }
            else
            {
                timer3.Stop();
                
                //panel1.BackColor = Color.Transparent;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            timer1.Start();
        }

        private void panel1_Click(object sender, EventArgs e)
        {

            timer1.Start();
        }

        private void panel2_Hover(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            timer3.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Entered = false;
            //panel3.Hide();

        }
        private void buttn1_Click(object sender, EventArgs e)
        {
            //panel3.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.ShowDialog();
        }
        // 78-136 Txt i butonave ndryshim ngjyre
        private void button2_MHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }

        private void button2_mLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }
        private void button3_MEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
        }

        private void button3_MLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
        }

        private void button4_MEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Black;
        }

        private void button4_MLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.White;
        }

        private void button5_MEnter(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Black;
        }

        private void button5_MLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.White;
        }

        private void button8_MEnter(object sender, EventArgs e)
        {
            button8.ForeColor = Color.Black;
        }

        
        private void button8_MLeave(object sender, EventArgs e)
        {
            
            button8.ForeColor = Color.White;
        }

        private void button6_MEnter(object sender, EventArgs e)
        {
            Entered = true;
            button6.ForeColor = Color.Black;
        }

        private void button6_MLeave(object sender, EventArgs e)
        {
            button6.ForeColor = Color.White;
            Entered = false;
        }

        private void panel1_Leave(object sender, EventArgs e)
        {
            timer3.Start();
        }
    }
}
