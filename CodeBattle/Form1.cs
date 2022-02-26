using System.Runtime.InteropServices;


namespace CodeBattle
{
    public partial class Form1 : Form
    {

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private void move_panel(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.MouseDown += new MouseEventHandler(move_panel);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
        }

        private void radLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void radLabel5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        
        private void radButton7_Click(object sender, EventArgs e)
        {

        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible=true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            pictureBox4.BringToFront();
            pictureBox3.Visible = true;
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox6.Visible = true;
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible=false;
            pictureBox5.Visible = true;
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible=false;
            pictureBox7.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}