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

        }

        private void radLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}