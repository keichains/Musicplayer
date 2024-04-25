using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace musicplayerdesign
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 55, 55));

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool playlistsExpand = false;
        private void playlistsTransition_Tick(object sender, EventArgs e)
        {
            if (playlistsExpand == false)
            {
                playlistsContainer.Height += 10;
                if (playlistsContainer.Height >= 302)
                {
                    playlistsTransition.Stop();
                    playlistsExpand = true;
                }
            }
            else
            {
                playlistsContainer.Height -= 10;
                if (playlistsContainer.Height <= 100)
                {
                    playlistsTransition.Stop();
                    playlistsExpand = false;
                }
            }
        }

        bool slidebarExpand = true;
        private void slidebarTransition_Tick(object sender, EventArgs e)
        {
            if (slidebarExpand)
            {
                slidebar.Width -= 8;
                if (slidebar.Width <= 65)
                {
                    slidebarExpand = false;
                    slidebarTransition.Stop();
                }
            }
            else
            {
                slidebar.Width += 8;
                if (slidebar.Width >= 255)
                {
                    slidebarExpand = true;
                    slidebarTransition.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            slidebarTransition.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            discoverPage1.BringToFront();
        }
        private void Playlists_Click(object sender, EventArgs e)
        {
            playlistsTransition.Start();


            playlist1Page1.BringToFront();

        }
    }
}