using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dashboard
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalendar.Height;
            pnlNav.Top = btnCalendar.Top;
            btnCalendar.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            btnContactUs.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnDashbord_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnCalendar_Leave(object sender, EventArgs e)
        {
            btnCalendar.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}