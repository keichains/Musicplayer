namespace musicplayerdesign
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            playlistsTransition = new System.Windows.Forms.Timer(components);
            slidebarTransition = new System.Windows.Forms.Timer(components);
            panel5 = new Panel();
            button3 = new Button();
            panel3 = new Panel();
            button1 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            button4 = new Button();
            playlistsContainer = new FlowLayoutPanel();
            panel4 = new Panel();
            Playlists = new Button();
            panel8 = new Panel();
            button6 = new Button();
            panel9 = new Panel();
            button7 = new Button();
            panel7 = new Panel();
            button5 = new Button();
            slidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            discoverPage1 = new discoverPage();
            playlist1Page1 = new playlist1Page();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            playlistsContainer.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            slidebar.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(221, 216, 208);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 863);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // playlistsTransition
            // 
            playlistsTransition.Interval = 10;
            playlistsTransition.Tick += playlistsTransition_Tick;
            // 
            // slidebarTransition
            // 
            slidebarTransition.Interval = 10;
            slidebarTransition.Tick += slidebarTransition_Tick;
            // 
            // panel5
            // 
            panel5.Controls.Add(button3);
            panel5.Location = new Point(3, 189);
            panel5.Name = "panel5";
            panel5.Size = new Size(249, 89);
            panel5.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(229, 224, 216);
            button3.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(107, 77, 56);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-17, -19);
            button3.Name = "button3";
            button3.Padding = new Padding(20, 0, 0, 0);
            button3.Size = new Size(293, 134);
            button3.TabIndex = 3;
            button3.Text = "         Discover";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Location = new Point(3, 284);
            panel3.Name = "panel3";
            panel3.Size = new Size(249, 89);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(229, 224, 216);
            button1.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(107, 77, 56);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-17, -19);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(293, 134);
            button1.TabIndex = 3;
            button1.Text = "         Liked Songs";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(107, 77, 56);
            label2.Location = new Point(55, 80);
            label2.Name = "label2";
            label2.Size = new Size(141, 43);
            label2.TabIndex = 2;
            label2.Text = "Music. ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(button4);
            panel6.Location = new Point(3, 485);
            panel6.Name = "panel6";
            panel6.Size = new Size(249, 89);
            panel6.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(229, 224, 216);
            button4.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(107, 77, 56);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-17, -19);
            button4.Name = "button4";
            button4.Padding = new Padding(20, 0, 0, 0);
            button4.Size = new Size(293, 134);
            button4.TabIndex = 3;
            button4.Text = "         Ranking";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // playlistsContainer
            // 
            playlistsContainer.BackColor = Color.FromArgb(229, 224, 216);
            playlistsContainer.Controls.Add(panel4);
            playlistsContainer.Controls.Add(panel8);
            playlistsContainer.Controls.Add(panel9);
            playlistsContainer.Location = new Point(3, 379);
            playlistsContainer.Name = "playlistsContainer";
            playlistsContainer.Size = new Size(245, 100);
            playlistsContainer.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Controls.Add(Playlists);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(249, 89);
            panel4.TabIndex = 3;
            // 
            // Playlists
            // 
            Playlists.BackColor = Color.FromArgb(229, 224, 216);
            Playlists.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            Playlists.ForeColor = Color.FromArgb(107, 77, 56);
            Playlists.Image = (Image)resources.GetObject("Playlists.Image");
            Playlists.ImageAlign = ContentAlignment.MiddleLeft;
            Playlists.Location = new Point(-17, -20);
            Playlists.Name = "Playlists";
            Playlists.Padding = new Padding(20, 0, 0, 0);
            Playlists.Size = new Size(293, 135);
            Playlists.TabIndex = 3;
            Playlists.Text = "         Playlists";
            Playlists.TextAlign = ContentAlignment.MiddleLeft;
            Playlists.UseVisualStyleBackColor = false;
            Playlists.Click += Playlists_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(button6);
            panel8.Location = new Point(3, 98);
            panel8.Name = "panel8";
            panel8.Size = new Size(249, 89);
            panel8.TabIndex = 7;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(229, 224, 216);
            button6.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(107, 77, 56);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-17, -19);
            button6.Name = "button6";
            button6.Padding = new Padding(20, 0, 0, 0);
            button6.Size = new Size(406, 134);
            button6.TabIndex = 3;
            button6.Text = "       Playlist1";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(button7);
            panel9.Location = new Point(3, 193);
            panel9.Name = "panel9";
            panel9.Size = new Size(249, 89);
            panel9.TabIndex = 8;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(229, 224, 216);
            button7.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.FromArgb(107, 77, 56);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-17, -19);
            button7.Name = "button7";
            button7.Padding = new Padding(20, 0, 0, 0);
            button7.Size = new Size(293, 134);
            button7.TabIndex = 3;
            button7.Text = "       Playlist2";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(button5);
            panel7.Location = new Point(3, 580);
            panel7.Name = "panel7";
            panel7.Size = new Size(249, 97);
            panel7.TabIndex = 6;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(229, 224, 216);
            button5.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(107, 77, 56);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-14, -18);
            button5.Name = "button5";
            button5.Padding = new Padding(20, 0, 0, 0);
            button5.Size = new Size(307, 134);
            button5.TabIndex = 3;
            button5.Text = "         Settings";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // slidebar
            // 
            slidebar.BackColor = Color.FromArgb(229, 224, 216);
            slidebar.Controls.Add(panel2);
            slidebar.Controls.Add(panel5);
            slidebar.Controls.Add(panel3);
            slidebar.Controls.Add(playlistsContainer);
            slidebar.Controls.Add(panel6);
            slidebar.Controls.Add(panel7);
            slidebar.Dock = DockStyle.Left;
            slidebar.Location = new Point(0, 0);
            slidebar.Name = "slidebar";
            slidebar.Size = new Size(256, 863);
            slidebar.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 180);
            panel2.TabIndex = 0;
            // 
            // discoverPage1
            // 
            discoverPage1.BackColor = Color.FromArgb(247, 242, 240);
            discoverPage1.Location = new Point(262, 37);
            discoverPage1.Name = "discoverPage1";
            discoverPage1.Size = new Size(1491, 1079);
            discoverPage1.TabIndex = 11;
            // 
            // playlist1Page1
            // 
            playlist1Page1.BackColor = Color.FromArgb(247, 242, 240);
            playlist1Page1.Location = new Point(254, 37);
            playlist1Page1.Name = "playlist1Page1";
            playlist1Page1.Size = new Size(1498, 1079);
            playlist1Page1.TabIndex = 12;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1339, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 242, 240);
            ClientSize = new Size(1460, 863);
            Controls.Add(nightControlBox1);
            Controls.Add(playlist1Page1);
            Controls.Add(discoverPage1);
            Controls.Add(slidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            playlistsContainer.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel7.ResumeLayout(false);
            slidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private System.Windows.Forms.Timer playlistsTransition;
        private System.Windows.Forms.Timer slidebarTransition;
        private Panel panel5;
        private Button button3;
        private Panel panel3;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel6;
        private Button button4;
        private FlowLayoutPanel playlistsContainer;
        private Panel panel4;
        private Button Playlists;
        private Panel panel8;
        private Button button6;
        private Panel panel9;
        private Button button7;
        private Panel panel7;
        private Button button5;
        private FlowLayoutPanel slidebar;
        private Panel panel2;
        private discoverPage discoverPage1;
        private playlist1Page playlist1Page1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}