using System.Drawing;
using System.Drawing.Drawing2D;

namespace Cliente
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitializeContent();
        }

        private void InitializeContent()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            Panel mainPanel = new Panel();
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.BackColor = Color.FromArgb(2, 2, 2);

            Panel scrollPane = new Panel();
            scrollPane.AutoScroll = true;
            scrollPane.BackColor = Color.FromArgb(4, 4, 4);

            Font gothamFont = new Font("Gotham", 12, FontStyle.Bold);

            //orden: bb, ed, fo, tw, jj, ts, em
            // C1-L1 --------------------------------------------------------------------------
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/badbunny.jpeg"); 
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox1.Size = new Size(180, 190); 
            pictureBox1.Location = new Point(110, 60); 

            PictureBox like1 = new PictureBox();
            like1.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like1.SizeMode = PictureBoxSizeMode.StretchImage;
            like1.Size = new Size(50, 30);
            like1.Location = new Point(110, 310);
            like1.Click += UpVotes_Click;
            Label contLikeC1 = new Label();
            contLikeC1.Font = gothamFont;
            contLikeC1.Text = "100";
            contLikeC1.ForeColor = Color.White;
            contLikeC1.AutoSize = false;
            contLikeC1.Size = new Size(50, 20);
            contLikeC1.Location = new Point(155, 315);

            PictureBox dislike1 = new PictureBox();
            dislike1.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike1.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike1.Size = new Size(50, 30);
            dislike1.Location = new Point(210, 310);
            dislike1.Click += DownVotes_Click;
            Label contDislikeC1 = new Label();
            contDislikeC1.Font = gothamFont;
            contDislikeC1.Text = "0";
            contDislikeC1.ForeColor = Color.White;
            contDislikeC1.AutoSize = false;
            contDislikeC1.Size = new Size(50, 20);
            contDislikeC1.Location = new Point(255, 315);
            
            Label label1 = new Label();            
            label1.Font = gothamFont;
            label1.Text = "La Santa";
            label1.ForeColor = Color.White;
            label1.BackColor = Color.FromArgb(18, 18, 18);
            label1.AutoSize = false;
            label1.Size = new Size(180, 20);
            label1.Location = new Point(110, 260);

            Label label2 = new Label();
            label2.Font = gothamFont;
            label2.Text = "Bad Bunny";
            label2.ForeColor = Color.White;
            label2.BackColor = Color.FromArgb(18, 18, 18);
            label2.AutoSize = false;
            label2.Size = new Size(180, 20);
            label2.Location = new Point(110, 280);

            // C2-L1 --------------------------------------------------------------------------------

            PictureBox pictureBox2 = new PictureBox();
            pictureBox2.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/badbunny.jpeg"); 
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox2.Size = new Size(180, 190); 
            pictureBox2.Location = new Point(350, 60); 

            PictureBox like2 = new PictureBox();
            like2.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like2.SizeMode = PictureBoxSizeMode.StretchImage;
            like2.Size = new Size(50, 30);
            like2.Location = new Point(350, 310);
            like2.Click += UpVotes_Click;
            Label contLikeC2 = new Label();
            contLikeC2.Font = gothamFont;
            contLikeC2.Text = "100";
            contLikeC2.ForeColor = Color.White;
            contLikeC2.AutoSize = false;
            contLikeC2.Size = new Size(50, 20);
            contLikeC2.Location = new Point(398, 315);

            PictureBox dislike2 = new PictureBox();
            dislike2.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike2.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike2.Size = new Size(50, 30);
            dislike2.Location = new Point(450, 310);
            dislike2.Click += DownVotes_Click;
            Label contDislikeC2 = new Label();
            contDislikeC2.Font = gothamFont;
            contDislikeC2.Text = "0";
            contDislikeC2.ForeColor = Color.White;
            contDislikeC2.AutoSize = false;
            contDislikeC2.Size = new Size(50, 20);
            contDislikeC2.Location = new Point(498, 315);
            
            Label label3 = new Label();
            label3.Font = gothamFont;
            label3.Text = "LOS PITS";
            label3.ForeColor = Color.White;
            label3.BackColor = Color.FromArgb(18, 18, 18);
            label3.AutoSize = false;
            label3.Size = new Size(180, 20);
            label3.Location = new Point(350, 260);

            Label label4 = new Label();
            label4.Font = gothamFont;
            label4.Text = "Bad Bunny";
            label4.ForeColor = Color.White;
            label4.BackColor = Color.FromArgb(18, 18, 18);
            label4.AutoSize = false;
            label4.Size = new Size(180, 20);
            label4.Location = new Point(350, 280);

            //C3-L1 --------------------------------------------------------------------------------

            PictureBox pictureBox3 = new PictureBox();
            pictureBox3.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/badbunny.jpeg"); 
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox3.Size = new Size(180, 190); 
            pictureBox3.Location = new Point(590, 60); 

            PictureBox like3 = new PictureBox();
            like3.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like3.SizeMode = PictureBoxSizeMode.StretchImage;
            like3.Size = new Size(50, 30);
            like3.Location = new Point(590, 310);
            like3.Click += UpVotes_Click;
            Label contLikeC3 = new Label();
            contLikeC3.Font = gothamFont;
            contLikeC3.Text = "0";
            contLikeC3.ForeColor = Color.White;
            contLikeC3.AutoSize = false;
            contLikeC3.Size = new Size(50, 20);
            contLikeC3.Location = new Point(638, 315);
            
            PictureBox dislike3 = new PictureBox();
            dislike3.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike3.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike3.Size = new Size(50, 30);
            dislike3.Location = new Point(690, 310);
            dislike3.Click += DownVotes_Click;
            Label contDislikeC3 = new Label();
            contDislikeC3.Font = gothamFont;
            contDislikeC3.Text = "0";
            contDislikeC3.ForeColor = Color.White;
            contDislikeC3.AutoSize = false;
            contDislikeC3.Size = new Size(50, 20);
            contDislikeC3.Location = new Point(738, 315);
            
            Label label5 = new Label();
            label5.Font = gothamFont;
            label5.Text = "MONACO";
            label5.ForeColor = Color.White;
            label5.BackColor = Color.FromArgb(18, 18, 18);
            label5.AutoSize = false;
            label5.Size = new Size(180, 20);
            label5.Location = new Point(590, 260);

            Label label6 = new Label();
            label6.Font = gothamFont;
            label6.Text = "Bad Bunny";
            label6.ForeColor = Color.White;
            label6.BackColor = Color.FromArgb(18, 18, 18);
            label6.AutoSize = false;
            label6.Size = new Size(180, 20);
            label6.Location = new Point(590, 280);

            //C4-L1 --------------------------------------------------------------------------------

            PictureBox pictureBox4 = new PictureBox();
            pictureBox4.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/badbunny.jpeg"); 
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox4.Size = new Size(180, 190); 
            pictureBox4.Location = new Point(830, 60); 

            PictureBox like4 = new PictureBox();
            like4.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like4.SizeMode = PictureBoxSizeMode.StretchImage;
            like4.Size = new Size(50, 30);
            like4.Location = new Point(830, 310);
            like4.Click += UpVotes_Click;
            Label contLikeC4 = new Label();
            contLikeC4.Font = gothamFont;
            contLikeC4.Text = "0";
            contLikeC4.ForeColor = Color.White;
            contLikeC4.AutoSize = false;
            contLikeC4.Size = new Size(50, 20);
            contLikeC4.Location = new Point(878, 315);

            PictureBox dislike4 = new PictureBox();
            dislike4.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike4.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike4.Size = new Size(50, 30);
            dislike4.Location = new Point(930, 310);
            dislike4.Click += DownVotes_Click;
            Label contDislikeC4 = new Label();
            contDislikeC4.Font = gothamFont;
            contDislikeC4.Text = "0";
            contDislikeC4.ForeColor = Color.White;
            contDislikeC4.AutoSize = false;
            contDislikeC4.Size = new Size(50, 20);
            contDislikeC4.Location = new Point(978, 315);
            
            Label label7 = new Label();
            label7.Font = gothamFont;
            label7.Text = "Ojitos Lindos";
            label7.ForeColor = Color.White;
            label7.BackColor = Color.FromArgb(18, 18, 18);
            label7.AutoSize = false;
            label7.Size = new Size(180, 20);
            label7.Location = new Point(830, 260);

            Label label8 = new Label();
            label8.Font = gothamFont;
            label8.Text = "Bad Bunny";
            label8.ForeColor = Color.White;
            label8.BackColor = Color.FromArgb(18, 18, 18);
            label8.AutoSize = false;
            label8.Size = new Size(180, 20);
            label8.Location = new Point(830, 280);

            //C5-L1 --------------------------------------------------------------------------------

            PictureBox pictureBox5 = new PictureBox();
            pictureBox5.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/badbunny.jpeg"); 
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox5.Size = new Size(180, 190); 
            pictureBox5.Location = new Point(1070, 60); 

            PictureBox like5 = new PictureBox();
            like5.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like5.SizeMode = PictureBoxSizeMode.StretchImage;
            like5.Size = new Size(50, 30);
            like5.Location = new Point(1070, 310);
            like5.Click += UpVotes_Click;
            Label contLikeC5 = new Label();
            contLikeC5.Font = gothamFont;
            contLikeC5.Text = "0";
            contLikeC5.ForeColor = Color.White;
            contLikeC5.AutoSize = false;
            contLikeC5.Size = new Size(50, 20);
            contLikeC5.Location = new Point(1118, 315);

            PictureBox dislike5 = new PictureBox();
            dislike5.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike5.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike5.Size = new Size(50, 30);
            dislike5.Location = new Point(1170, 310);
            dislike5.Click += DownVotes_Click;
            Label contDislikeC5 = new Label();
            contDislikeC5.Font = gothamFont;
            contDislikeC5.Text = "0";
            contDislikeC5.ForeColor = Color.White;
            contDislikeC5.AutoSize = false;
            contDislikeC5.Size = new Size(50, 20);
            contDislikeC5.Location = new Point(1218, 315);
            
            Label label9 = new Label();
            label9.Font = gothamFont;
            label9.Text = "P FKN R";
            label9.ForeColor = Color.White;
            label9.BackColor = Color.FromArgb(18, 18, 18);
            label9.AutoSize = false;
            label9.Size = new Size(180, 20);
            label9.Location = new Point(1070, 260);

            Label label10 = new Label();
            label10.Font = gothamFont;
            label10.Text = "Bad Bunny";
            label10.ForeColor = Color.White;
            label10.BackColor = Color.FromArgb(18, 18, 18);
            label10.AutoSize = false;
            label10.Size = new Size(180, 20);
            label10.Location = new Point(1070, 280);

            scrollPane.Controls.Add(like1);
            scrollPane.Controls.Add(dislike1);
            scrollPane.Controls.Add(like2);
            scrollPane.Controls.Add(dislike2);
            scrollPane.Controls.Add(like3);
            scrollPane.Controls.Add(dislike3);
            scrollPane.Controls.Add(like4);
            scrollPane.Controls.Add(dislike4);
            scrollPane.Controls.Add(like5);
            scrollPane.Controls.Add(dislike5);
            scrollPane.Controls.Add(pictureBox1);
            scrollPane.Controls.Add(pictureBox2);
            scrollPane.Controls.Add(pictureBox3);
            scrollPane.Controls.Add(pictureBox4);
            scrollPane.Controls.Add(pictureBox5);
            scrollPane.Controls.Add(contLikeC1);
            scrollPane.Controls.Add(contDislikeC1);
            scrollPane.Controls.Add(contLikeC2);
            scrollPane.Controls.Add(contDislikeC2);
            scrollPane.Controls.Add(contLikeC3);
            scrollPane.Controls.Add(contDislikeC3);
            scrollPane.Controls.Add(contLikeC4);
            scrollPane.Controls.Add(contDislikeC4);
            scrollPane.Controls.Add(contLikeC5);
            scrollPane.Controls.Add(contDislikeC5);
            scrollPane.Controls.Add(label1);
            scrollPane.Controls.Add(label2);
            scrollPane.Controls.Add(label3);
            scrollPane.Controls.Add(label4);
            scrollPane.Controls.Add(label5);
            scrollPane.Controls.Add(label6);
            scrollPane.Controls.Add(label7);
            scrollPane.Controls.Add(label8);
            scrollPane.Controls.Add(label9);
            scrollPane.Controls.Add(label10);

            // C1-L2 --------------------------------------------------------------------------
            PictureBox pictureBox6 = new PictureBox();
            pictureBox6.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/badbunny.jpeg"); 
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox6.Size = new Size(180, 190); 
            pictureBox6.Location = new Point(110, 390); 

            PictureBox like6 = new PictureBox();
            like6.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like6.SizeMode = PictureBoxSizeMode.StretchImage;
            like6.Size = new Size(50, 30);
            like6.Location = new Point(110, 640);
            like6.Click += UpVotes_Click;
            Label contLikeC6 = new Label();
            contLikeC6.Font = gothamFont;
            contLikeC6.Text = "100";
            contLikeC6.ForeColor = Color.White;
            contLikeC6.AutoSize = false;
            contLikeC6.Size = new Size(50, 20);
            contLikeC6.Location = new Point(158, 645);

            PictureBox dislike6 = new PictureBox();
            dislike6.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike6.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike6.Size = new Size(50, 30);
            dislike6.Location = new Point(210, 640);
            dislike6.Click += DownVotes_Click;
            Label contDislikeC6 = new Label();
            contDislikeC6.Font = gothamFont;
            contDislikeC6.Text = "0";
            contDislikeC6.ForeColor = Color.White;
            contDislikeC6.AutoSize = false;
            contDislikeC6.Size = new Size(50, 20);
            contDislikeC6.Location = new Point(258, 645);
            
            Label label11 = new Label();            
            label11.Font = gothamFont;
            label11.Text = "La Santa";
            label11.ForeColor = Color.White;
            label11.BackColor = Color.FromArgb(18, 18, 18);
            label11.AutoSize = false;
            label11.Size = new Size(180, 20);
            label11.Location = new Point(110, 590);

            Label label12 = new Label();
            label12.Font = gothamFont;
            label12.Text = "Bad Bunny";
            label12.ForeColor = Color.White;
            label12.BackColor = Color.FromArgb(18, 18, 18);
            label12.AutoSize = false;
            label12.Size = new Size(180, 20);
            label12.Location = new Point(110, 610);

            // C2-L2 --------------------------------------------------------------------------------

            PictureBox pictureBox7 = new PictureBox();
            pictureBox7.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/badbunny.jpeg"); 
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox7.Size = new Size(180, 190); 
            pictureBox7.Location = new Point(350, 390); 

            PictureBox like7 = new PictureBox();
            like7.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like7.SizeMode = PictureBoxSizeMode.StretchImage;
            like7.Size = new Size(50, 30);
            like7.Location = new Point(350, 640);
            like7.Click += UpVotes_Click;
            Label contLikeC7 = new Label();
            contLikeC7.Font = gothamFont;
            contLikeC7.Text = "100";
            contLikeC7.ForeColor = Color.White;
            contLikeC7.AutoSize = false;
            contLikeC7.Size = new Size(50, 20);
            contLikeC7.Location = new Point(398, 645);

            PictureBox dislike7 = new PictureBox();
            dislike7.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike7.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike7.Size = new Size(50, 30);
            dislike7.Location = new Point(450, 640);
            dislike7.Click += DownVotes_Click;
            Label contDislikeC7 = new Label();
            contDislikeC7.Font = gothamFont;
            contDislikeC7.Text = "0";
            contDislikeC7.ForeColor = Color.White;
            contDislikeC7.AutoSize = false;
            contDislikeC7.Size = new Size(50, 20);
            contDislikeC7.Location = new Point(498, 645);
            
            Label label13 = new Label();
            label13.Font = gothamFont;
            label13.Text = "LOS PITS";
            label13.ForeColor = Color.White;
            label13.BackColor = Color.FromArgb(18, 18, 18);
            label13.AutoSize = false;
            label13.Size = new Size(180, 20);
            label13.Location = new Point(350, 590);

            Label label14 = new Label();
            label14.Font = gothamFont;
            label14.Text = "Bad Bunny";
            label14.ForeColor = Color.White;
            label14.BackColor = Color.FromArgb(18, 18, 18);
            label14.AutoSize = false;
            label14.Size = new Size(180, 20);
            label14.Location = new Point(350, 610);

            //C3-L2 --------------------------------------------------------------------------------

            PictureBox pictureBox8 = new PictureBox();
            pictureBox8.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/ed.jpeg"); 
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox8.Size = new Size(180, 190); 
            pictureBox8.Location = new Point(590, 390); 

            PictureBox like8 = new PictureBox();
            like8.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like8.SizeMode = PictureBoxSizeMode.StretchImage;
            like8.Size = new Size(50, 30);
            like8.Location = new Point(590, 640);
            like8.Click += UpVotes_Click;
            Label contLikeC8 = new Label();
            contLikeC8.Font = gothamFont;
            contLikeC8.Text = "0";
            contLikeC8.ForeColor = Color.White;
            contLikeC8.AutoSize = false;
            contLikeC8.Size = new Size(50, 20);
            contLikeC8.Location = new Point(638, 645);
            
            PictureBox dislike8 = new PictureBox();
            dislike8.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike8.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike8.Size = new Size(50, 30);
            dislike8.Location = new Point(690, 640);
            dislike8.Click += DownVotes_Click;
            Label contDislikeC8 = new Label();
            contDislikeC8.Font = gothamFont;
            contDislikeC8.Text = "0";
            contDislikeC8.ForeColor = Color.White;
            contDislikeC8.AutoSize = false;
            contDislikeC8.Size = new Size(50, 20);
            contDislikeC8.Location = new Point(738, 645);
            
            Label label15 = new Label();
            label15.Font = gothamFont;
            label15.Text = "Bad Habits";
            label15.ForeColor = Color.White;
            label15.BackColor = Color.FromArgb(18, 18, 18);
            label15.AutoSize = false;
            label15.Size = new Size(180, 20);
            label15.Location = new Point(590, 590);

            Label label16 = new Label();
            label16.Font = gothamFont;
            label16.Text = "Ed Sheeran";
            label16.ForeColor = Color.White;
            label16.BackColor = Color.FromArgb(18, 18, 18);
            label16.AutoSize = false;
            label16.Size = new Size(180, 20);
            label16.Location = new Point(590, 610);

            //C4-L2 --------------------------------------------------------------------------------

            PictureBox pictureBox9 = new PictureBox();
            pictureBox9.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/ed.jpeg"); 
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox9.Size = new Size(180, 190); 
            pictureBox9.Location = new Point(830, 390); 

            PictureBox like9 = new PictureBox();
            like9.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like9.SizeMode = PictureBoxSizeMode.StretchImage;
            like9.Size = new Size(50, 30);
            like9.Location = new Point(830, 640);
            like9.Click += UpVotes_Click;
            Label contLikeC9 = new Label();
            contLikeC9.Font = gothamFont;
            contLikeC9.Text = "0";
            contLikeC9.ForeColor = Color.White;
            contLikeC9.AutoSize = false;
            contLikeC9.Size = new Size(50, 20);
            contLikeC9.Location = new Point(878, 645);

            PictureBox dislike9 = new PictureBox();
            dislike9.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike9.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike9.Size = new Size(50, 30);
            dislike9.Location = new Point(930, 640);
            dislike9.Click += DownVotes_Click;
            Label contDislikeC9 = new Label();
            contDislikeC9.Font = gothamFont;
            contDislikeC9.Text = "0";
            contDislikeC9.ForeColor = Color.White;
            contDislikeC9.AutoSize = false;
            contDislikeC9.Size = new Size(50, 20);
            contDislikeC9.Location = new Point(978, 645);
            
            Label label17 = new Label();
            label17.Font = gothamFont;
            label17.Text = "Happier";
            label17.ForeColor = Color.White;
            label17.BackColor = Color.FromArgb(18, 18, 18);
            label17.AutoSize = false;
            label17.Size = new Size(180, 20);
            label17.Location = new Point(830, 590);

            Label label18 = new Label();
            label18.Font = gothamFont;
            label18.Text = "Ed Sheeran";
            label18.ForeColor = Color.White;
            label18.BackColor = Color.FromArgb(18, 18, 18);
            label18.AutoSize = false;
            label18.Size = new Size(180, 20);
            label18.Location = new Point(830, 610);

            //C5-1 --------------------------------------------------------------------------------

            PictureBox pictureBox10 = new PictureBox();
            pictureBox10.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/ed.jpeg"); 
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox10.Size = new Size(180, 190); 
            pictureBox10.Location = new Point(1070, 390); 

            PictureBox like10 = new PictureBox();
            like10.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like10.SizeMode = PictureBoxSizeMode.StretchImage;
            like10.Size = new Size(50, 30);
            like10.Location = new Point(1070, 640);
            like10.Click += UpVotes_Click;
            Label contLikeC10 = new Label();
            contLikeC10.Font = gothamFont;
            contLikeC10.Text = "0";
            contLikeC10.ForeColor = Color.White;
            contLikeC10.AutoSize = false;
            contLikeC10.Size = new Size(50, 20);
            contLikeC10.Location = new Point(1118, 645);

            PictureBox dislike10 = new PictureBox();
            dislike10.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike10.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike10.Size = new Size(50, 30);
            dislike10.Location = new Point(1170, 640);
            dislike10.Click += DownVotes_Click;
            Label contDislikeC10 = new Label();
            contDislikeC10.Font = gothamFont;
            contDislikeC10.Text = "0";
            contDislikeC10.ForeColor = Color.White;
            contDislikeC10.AutoSize = false;
            contDislikeC10.Size = new Size(50, 20);
            contDislikeC10.Location = new Point(1218, 645);
            
            Label label19 = new Label();
            label19.Font = gothamFont;
            label19.Text = "Perfect";
            label19.ForeColor = Color.White;
            label19.BackColor = Color.FromArgb(18, 18, 18);
            label19.AutoSize = false;
            label19.Size = new Size(180, 20);
            label19.Location = new Point(1070, 590);

            Label label20 = new Label();
            label20.Font = gothamFont;
            label20.Text = "Ed Sheeran";
            label20.ForeColor = Color.White;
            label20.BackColor = Color.FromArgb(18, 18, 18);
            label20.AutoSize = false;
            label20.Size = new Size(180, 20);
            label20.Location = new Point(1070, 610);

            scrollPane.Controls.Add(like6);
            scrollPane.Controls.Add(dislike6);
            scrollPane.Controls.Add(like7);
            scrollPane.Controls.Add(dislike7);
            scrollPane.Controls.Add(like8);
            scrollPane.Controls.Add(dislike8);
            scrollPane.Controls.Add(like9);
            scrollPane.Controls.Add(dislike9);
            scrollPane.Controls.Add(like10);
            scrollPane.Controls.Add(dislike10);
            scrollPane.Controls.Add(pictureBox6);
            scrollPane.Controls.Add(pictureBox7);
            scrollPane.Controls.Add(pictureBox8);
            scrollPane.Controls.Add(pictureBox9);
            scrollPane.Controls.Add(pictureBox10);
            scrollPane.Controls.Add(contLikeC6);
            scrollPane.Controls.Add(contDislikeC6);
            scrollPane.Controls.Add(contLikeC7);
            scrollPane.Controls.Add(contDislikeC7);
            scrollPane.Controls.Add(contLikeC8);
            scrollPane.Controls.Add(contDislikeC8);
            scrollPane.Controls.Add(contLikeC9);
            scrollPane.Controls.Add(contDislikeC9);
            scrollPane.Controls.Add(contLikeC10);
            scrollPane.Controls.Add(contDislikeC10);
            scrollPane.Controls.Add(label11);
            scrollPane.Controls.Add(label12);
            scrollPane.Controls.Add(label13);
            scrollPane.Controls.Add(label14);
            scrollPane.Controls.Add(label15);
            scrollPane.Controls.Add(label16);
            scrollPane.Controls.Add(label17);
            scrollPane.Controls.Add(label18);
            scrollPane.Controls.Add(label19);
            scrollPane.Controls.Add(label20);

            // C1-L3 --------------------------------------------------------------------------
            PictureBox pictureBox11 = new PictureBox();
            pictureBox11.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/ed.jpeg"); 
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox11.Size = new Size(180, 190); 
            pictureBox11.Location = new Point(110, 720); 

            PictureBox like11 = new PictureBox();
            like11.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like11.SizeMode = PictureBoxSizeMode.StretchImage;
            like11.Size = new Size(50, 30);
            like11.Location = new Point(110, 970);
            like11.Click += UpVotes_Click;
            Label contLikeC11 = new Label();
            contLikeC11.Font = gothamFont;
            contLikeC11.Text = "100";
            contLikeC11.ForeColor = Color.White;
            contLikeC11.AutoSize = false;
            contLikeC11.Size = new Size(50, 20);
            contLikeC11.Location = new Point(158, 975);

            PictureBox dislike11 = new PictureBox();
            dislike11.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike11.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike11.Size = new Size(50, 30);
            dislike11.Location = new Point(210, 970);
            dislike11.Click += DownVotes_Click;
            Label contDislikeC11 = new Label();
            contDislikeC11.Font = gothamFont;
            contDislikeC11.Text = "0";
            contDislikeC11.ForeColor = Color.White;
            contDislikeC11.AutoSize = false;
            contDislikeC11.Size = new Size(50, 20);
            contDislikeC11.Location = new Point(258, 975);
            
            Label label21 = new Label();            
            label21.Font = gothamFont;
            label21.Text = "Photograph";
            label21.ForeColor = Color.White;
            label21.BackColor = Color.FromArgb(18, 18, 18);
            label21.AutoSize = false;
            label21.Size = new Size(180, 20);
            label21.Location = new Point(110, 920);

            Label label22 = new Label();
            label22.Font = gothamFont;
            label22.Text = "Ed Sheeran";
            label22.ForeColor = Color.White;
            label22.BackColor = Color.FromArgb(18, 18, 18);
            label22.AutoSize = false;
            label22.Size = new Size(180, 20);
            label22.Location = new Point(110, 940);

            // C2-L3 --------------------------------------------------------------------------------

            PictureBox pictureBox12 = new PictureBox();
            pictureBox12.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/ed.jpeg"); 
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox12.Size = new Size(180, 190); 
            pictureBox12.Location = new Point(350, 720); 

            PictureBox like12 = new PictureBox();
            like12.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like12.SizeMode = PictureBoxSizeMode.StretchImage;
            like12.Size = new Size(50, 30);
            like12.Location = new Point(350, 970);
            like12.Click += UpVotes_Click;
            Label contLikeC12 = new Label();
            contLikeC12.Font = gothamFont;
            contLikeC12.Text = "100";
            contLikeC12.ForeColor = Color.White;
            contLikeC12.AutoSize = false;
            contLikeC12.Size = new Size(50, 20);
            contLikeC12.Location = new Point(398, 975);

            PictureBox dislike12 = new PictureBox();
            dislike12.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike12.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike12.Size = new Size(50, 30);
            dislike12.Location = new Point(450, 970);
            dislike12.Click += DownVotes_Click;
            Label contDislikeC12 = new Label();
            contDislikeC12.Font = gothamFont;
            contDislikeC12.Text = "0";
            contDislikeC12.ForeColor = Color.White;
            contDislikeC12.AutoSize = false;
            contDislikeC12.Size = new Size(50, 20);
            contDislikeC12.Location = new Point(498, 975);
            
            Label label23 = new Label();
            label23.Font = gothamFont;
            label23.Text = "Shape of You";
            label23.ForeColor = Color.White;
            label23.BackColor = Color.FromArgb(18, 18, 18);
            label23.AutoSize = false;
            label23.Size = new Size(180, 20);
            label23.Location = new Point(350, 920);

            Label label24 = new Label();
            label24.Font = gothamFont;
            label24.Text = "Ed Sheeran";
            label24.ForeColor = Color.White;
            label24.BackColor = Color.FromArgb(18, 18, 18);
            label24.AutoSize = false;
            label24.Size = new Size(180, 20);
            label24.Location = new Point(350, 940);

            //C3-L3 --------------------------------------------------------------------------------

            PictureBox pictureBox13 = new PictureBox();
            pictureBox13.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/ed.jpeg"); 
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox13.Size = new Size(180, 190); 
            pictureBox13.Location = new Point(590, 720); 

            PictureBox like13 = new PictureBox();
            like13.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like13.SizeMode = PictureBoxSizeMode.StretchImage;
            like13.Size = new Size(50, 30);
            like13.Location = new Point(590, 970);
            like13.Click += UpVotes_Click;
            Label contLikeC13 = new Label();
            contLikeC13.Font = gothamFont;
            contLikeC13.Text = "0";
            contLikeC13.ForeColor = Color.White;
            contLikeC13.AutoSize = false;
            contLikeC13.Size = new Size(50, 20);
            contLikeC13.Location = new Point(638, 975);
            
            PictureBox dislike13 = new PictureBox();
            dislike13.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike13.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike13.Size = new Size(50, 30);
            dislike13.Location = new Point(690, 970);
            dislike13.Click += DownVotes_Click;
            Label contDislikeC13 = new Label();
            contDislikeC13.Font = gothamFont;
            contDislikeC13.Text = "0";
            contDislikeC13.ForeColor = Color.White;
            contDislikeC13.AutoSize = false;
            contDislikeC13.Size = new Size(50, 20);
            contDislikeC13.Location = new Point(738, 975);
            
            Label label25 = new Label();
            label25.Font = gothamFont;
            label25.Text = "Shivers";
            label25.ForeColor = Color.White;
            label25.BackColor = Color.FromArgb(18, 18, 18);
            label25.AutoSize = false;
            label25.Size = new Size(180, 20);
            label25.Location = new Point(590, 920);

            Label label26 = new Label();
            label26.Font = gothamFont;
            label26.Text = "Ed Sheeran";
            label26.ForeColor = Color.White;
            label26.BackColor = Color.FromArgb(18, 18, 18);
            label26.AutoSize = false;
            label26.Size = new Size(180, 20);
            label26.Location = new Point(590, 940);

            //C4-L3 --------------------------------------------------------------------------------

            PictureBox pictureBox14 = new PictureBox();
            pictureBox14.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/ed.jpeg"); 
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox14.Size = new Size(180, 190); 
            pictureBox14.Location = new Point(830, 720); 

            PictureBox like14 = new PictureBox();
            like14.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like14.SizeMode = PictureBoxSizeMode.StretchImage;
            like14.Size = new Size(50, 30);
            like14.Location = new Point(830, 970);
            like14.Click += UpVotes_Click;
            Label contLikeC14 = new Label();
            contLikeC14.Font = gothamFont;
            contLikeC14.Text = "0";
            contLikeC14.ForeColor = Color.White;
            contLikeC14.AutoSize = false;
            contLikeC14.Size = new Size(50, 20);
            contLikeC14.Location = new Point(878, 975);

            PictureBox dislike14 = new PictureBox();
            dislike14.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike14.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike14.Size = new Size(50, 30);
            dislike14.Location = new Point(930, 970);
            dislike14.Click += DownVotes_Click;
            Label contDislikeC14 = new Label();
            contDislikeC14.Font = gothamFont;
            contDislikeC14.Text = "0";
            contDislikeC14.ForeColor = Color.White;
            contDislikeC14.AutoSize = false;
            contDislikeC14.Size = new Size(50, 20);
            contDislikeC14.Location = new Point(978, 975);
            
            Label label27 = new Label();
            label27.Font = gothamFont;
            label27.Text = "Thinking Out Loud";
            label27.ForeColor = Color.White;
            label27.BackColor = Color.FromArgb(18, 18, 18);
            label27.AutoSize = false;
            label27.Size = new Size(180, 20);
            label27.Location = new Point(830, 920);

            Label label28 = new Label();
            label28.Font = gothamFont;
            label28.Text = "Ed Sheeran";
            label28.ForeColor = Color.White;
            label28.BackColor = Color.FromArgb(18, 18, 18);
            label28.AutoSize = false;
            label28.Size = new Size(180, 20);
            label28.Location = new Point(830, 940);

            //C5-L3 --------------------------------------------------------------------------------

            PictureBox pictureBox15 = new PictureBox();
            pictureBox15.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/frank.jpeg"); 
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox15.Size = new Size(180, 190); 
            pictureBox15.Location = new Point(1070, 720); 

            PictureBox like15 = new PictureBox();
            like15.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like15.SizeMode = PictureBoxSizeMode.StretchImage;
            like15.Size = new Size(50, 30);
            like15.Location = new Point(1070, 970);
            like15.Click += UpVotes_Click;
            Label contLikeC15 = new Label();
            contLikeC15.Font = gothamFont;
            contLikeC15.Text = "0";
            contLikeC15.ForeColor = Color.White;
            contLikeC15.AutoSize = false;
            contLikeC15.Size = new Size(50, 20);
            contLikeC15.Location = new Point(1118, 975);

            PictureBox dislike15 = new PictureBox();
            dislike15.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike15.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike15.Size = new Size(50, 30);
            dislike15.Location = new Point(1170, 970);
            dislike15.Click += DownVotes_Click;
            Label contDislikeC15 = new Label();
            contDislikeC15.Font = gothamFont;
            contDislikeC15.Text = "0";
            contDislikeC15.ForeColor = Color.White;
            contDislikeC15.AutoSize = false;
            contDislikeC15.Size = new Size(50, 20);
            contDislikeC15.Location = new Point(1218, 975);
            
            Label label29 = new Label();
            label29.Font = gothamFont;
            label29.Text = "Ivy";
            label29.ForeColor = Color.White;
            label29.BackColor = Color.FromArgb(18, 18, 18);
            label29.AutoSize = false;
            label29.Size = new Size(180, 20);
            label29.Location = new Point(1070, 920);

            Label label30 = new Label();
            label30.Font = gothamFont;
            label30.Text = "Frank Ocean";
            label30.ForeColor = Color.White;
            label30.BackColor = Color.FromArgb(18, 18, 18);
            label30.AutoSize = false;
            label30.Size = new Size(180, 20);
            label30.Location = new Point(1070, 940);

            scrollPane.Controls.Add(like11);
            scrollPane.Controls.Add(dislike11);
            scrollPane.Controls.Add(like12);
            scrollPane.Controls.Add(dislike12);
            scrollPane.Controls.Add(like13);
            scrollPane.Controls.Add(dislike13);
            scrollPane.Controls.Add(like14);
            scrollPane.Controls.Add(dislike14);
            scrollPane.Controls.Add(like15);
            scrollPane.Controls.Add(dislike15);
            scrollPane.Controls.Add(pictureBox11);
            scrollPane.Controls.Add(pictureBox12);
            scrollPane.Controls.Add(pictureBox13);
            scrollPane.Controls.Add(pictureBox14);
            scrollPane.Controls.Add(pictureBox15);
            scrollPane.Controls.Add(contLikeC11);
            scrollPane.Controls.Add(contDislikeC11);
            scrollPane.Controls.Add(contLikeC12);
            scrollPane.Controls.Add(contDislikeC12);
            scrollPane.Controls.Add(contLikeC13);
            scrollPane.Controls.Add(contDislikeC13);
            scrollPane.Controls.Add(contLikeC14);
            scrollPane.Controls.Add(contDislikeC14);
            scrollPane.Controls.Add(contLikeC15);
            scrollPane.Controls.Add(contDislikeC15);
            scrollPane.Controls.Add(label21);
            scrollPane.Controls.Add(label22);
            scrollPane.Controls.Add(label23);
            scrollPane.Controls.Add(label24);
            scrollPane.Controls.Add(label25);
            scrollPane.Controls.Add(label26);
            scrollPane.Controls.Add(label27);
            scrollPane.Controls.Add(label28);
            scrollPane.Controls.Add(label29);
            scrollPane.Controls.Add(label30);

            // C1-L4 --------------------------------------------------------------------------

            PictureBox pictureBox16 = new PictureBox();
            pictureBox16.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/frank.jpeg"); 
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox16.Size = new Size(180, 190); 
            pictureBox16.Location = new Point(110, 1050); 

            PictureBox like16 = new PictureBox();
            like16.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like16.SizeMode = PictureBoxSizeMode.StretchImage;
            like16.Size = new Size(50, 30);
            like16.Location = new Point(110, 1300);
            like16.Click += UpVotes_Click;
            Label contLikeC16 = new Label();
            contLikeC16.Font = gothamFont;
            contLikeC16.Text = "100";
            contLikeC16.ForeColor = Color.White;
            contLikeC16.AutoSize = false;
            contLikeC16.Size = new Size(50, 20);
            contLikeC16.Location = new Point(158, 1305);

            PictureBox dislike16 = new PictureBox();
            dislike16.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike16.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike16.Size = new Size(50, 30);
            dislike16.Location = new Point(210, 1300);
            dislike16.Click += DownVotes_Click;
            Label contDislikeC16 = new Label();
            contDislikeC16.Font = gothamFont;
            contDislikeC16.Text = "0";
            contDislikeC16.ForeColor = Color.White;
            contDislikeC16.AutoSize = false;
            contDislikeC16.Size = new Size(50, 20);
            contDislikeC16.Location = new Point(258, 1305);
            
            Label label31 = new Label();            
            label31.Font = gothamFont;
            label31.Text = "Pink + White";
            label31.ForeColor = Color.White;
            label31.BackColor = Color.FromArgb(18, 18, 18);
            label31.AutoSize = false;
            label31.Size = new Size(180, 20);
            label31.Location = new Point(110, 1250);

            Label label32 = new Label();
            label32.Font = gothamFont;
            label32.Text = "Frank Ocean";
            label32.ForeColor = Color.White;
            label32.BackColor = Color.FromArgb(18, 18, 18);
            label32.AutoSize = false;
            label32.Size = new Size(180, 20);
            label32.Location = new Point(110, 1270);

            // C2-L4 --------------------------------------------------------------------------------

            PictureBox pictureBox17 = new PictureBox();
            pictureBox17.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/frank.jpeg"); 
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox17.Size = new Size(180, 190); 
            pictureBox17.Location = new Point(350, 1050); 

            PictureBox like17 = new PictureBox();
            like17.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like17.SizeMode = PictureBoxSizeMode.StretchImage;
            like17.Size = new Size(50, 30);
            like17.Location = new Point(350, 1300);
            like17.Click += UpVotes_Click;
            Label contLikeC17 = new Label();
            contLikeC17.Font = gothamFont;
            contLikeC17.Text = "100";
            contLikeC17.ForeColor = Color.White;
            contLikeC17.AutoSize = false;
            contLikeC17.Size = new Size(50, 20);
            contLikeC17.Location = new Point(398, 1305);

            PictureBox dislike17 = new PictureBox();
            dislike17.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike17.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike17.Size = new Size(50, 30);
            dislike17.Location = new Point(450, 1300);
            dislike17.Click += DownVotes_Click;
            Label contDislikeC17 = new Label();
            contDislikeC17.Font = gothamFont;
            contDislikeC17.Text = "0";
            contDislikeC17.ForeColor = Color.White;
            contDislikeC17.AutoSize = false;
            contDislikeC17.Size = new Size(50, 20);
            contDislikeC17.Location = new Point(498, 1305);
            
            Label label33 = new Label();
            label33.Font = gothamFont;
            label33.Text = "White Ferrari";
            label33.ForeColor = Color.White;
            label33.BackColor = Color.FromArgb(18, 18, 18);
            label33.AutoSize = false;
            label33.Size = new Size(180, 20);
            label33.Location = new Point(350, 1250);

            Label label34 = new Label();
            label34.Font = gothamFont;
            label34.Text = "Frank Ocean";
            label34.ForeColor = Color.White;
            label34.BackColor = Color.FromArgb(18, 18, 18);
            label34.AutoSize = false;
            label34.Size = new Size(180, 20);
            label34.Location = new Point(350, 1270);

            //C3-L4 --------------------------------------------------------------------------------

            PictureBox pictureBox18 = new PictureBox();
            pictureBox18.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/frank.jpeg"); 
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox18.Size = new Size(180, 190); 
            pictureBox18.Location = new Point(590, 1050); 

            PictureBox like18 = new PictureBox();
            like18.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like18.SizeMode = PictureBoxSizeMode.StretchImage;
            like18.Size = new Size(50, 30);
            like18.Location = new Point(590, 1300);
            like18.Click += UpVotes_Click;
            Label contLikeC18 = new Label();
            contLikeC18.Font = gothamFont;
            contLikeC18.Text = "0";
            contLikeC18.ForeColor = Color.White;
            contLikeC18.AutoSize = false;
            contLikeC18.Size = new Size(50, 20);
            contLikeC18.Location = new Point(638, 1305);
            
            PictureBox dislike18 = new PictureBox();
            dislike18.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike18.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike18.Size = new Size(50, 30);
            dislike18.Location = new Point(690, 1300);
            dislike18.Click += DownVotes_Click;
            Label contDislikeC18 = new Label();
            contDislikeC18.Font = gothamFont;
            contDislikeC18.Text = "0";
            contDislikeC18.ForeColor = Color.White;
            contDislikeC18.AutoSize = false;
            contDislikeC18.Size = new Size(50, 20);
            contDislikeC18.Location = new Point(738, 1305);
            
            Label label35 = new Label();
            label35.Font = gothamFont;
            label35.Text = "Chanel";
            label35.ForeColor = Color.White;
            label35.BackColor = Color.FromArgb(18, 18, 18);
            label35.AutoSize = false;
            label35.Size = new Size(180, 20);
            label35.Location = new Point(590, 1250);

            Label label36 = new Label();
            label36.Font = gothamFont;
            label36.Text = "Frank Ocean";
            label36.ForeColor = Color.White;
            label36.BackColor = Color.FromArgb(18, 18, 18);
            label36.AutoSize = false;
            label36.Size = new Size(180, 20);
            label36.Location = new Point(590, 1270);

            //C4-L4 --------------------------------------------------------------------------------

            PictureBox pictureBox19 = new PictureBox();
            pictureBox19.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/frank.jpeg"); 
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox19.Size = new Size(180, 190); 
            pictureBox19.Location = new Point(830, 1050); 

            PictureBox like19 = new PictureBox();
            like19.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like19.SizeMode = PictureBoxSizeMode.StretchImage;
            like19.Size = new Size(50, 30);
            like19.Location = new Point(830, 1300);
            like19.Click += UpVotes_Click;
            Label contLikeC19 = new Label();
            contLikeC19.Font = gothamFont;
            contLikeC19.Text = "0";
            contLikeC19.ForeColor = Color.White;
            contLikeC19.AutoSize = false;
            contLikeC19.Size = new Size(50, 20);
            contLikeC19.Location = new Point(878, 1305);

            PictureBox dislike19 = new PictureBox();
            dislike19.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike19.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike19.Size = new Size(50, 30);
            dislike19.Location = new Point(930, 1300);
            dislike19.Click += DownVotes_Click;
            Label contDislikeC19 = new Label();
            contDislikeC19.Font = gothamFont;
            contDislikeC19.Text = "0";
            contDislikeC19.ForeColor = Color.White;
            contDislikeC19.AutoSize = false;
            contDislikeC19.Size = new Size(50, 20);
            contDislikeC19.Location = new Point(978, 1305);
            
            Label label37 = new Label();
            label37.Font = gothamFont;
            label37.Text = "Lost";
            label37.ForeColor = Color.White;
            label37.BackColor = Color.FromArgb(18, 18, 18);
            label37.AutoSize = false;
            label37.Size = new Size(180, 20);
            label37.Location = new Point(830, 1250);

            Label label38 = new Label();
            label38.Font = gothamFont;
            label38.Text = "Frank Ocean";
            label38.ForeColor = Color.White;
            label38.BackColor = Color.FromArgb(18, 18, 18);
            label38.AutoSize = false;
            label38.Size = new Size(180, 20);
            label38.Location = new Point(830, 1270);

            //C5-L4 --------------------------------------------------------------------------------

            PictureBox pictureBox20 = new PictureBox();
            pictureBox20.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/frank.jpeg"); 
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox20.Size = new Size(180, 190); 
            pictureBox20.Location = new Point(1070, 1050); 

            PictureBox like20 = new PictureBox();
            like20.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like20.SizeMode = PictureBoxSizeMode.StretchImage;
            like20.Size = new Size(50, 30);
            like20.Location = new Point(1070, 1300);
            like20.Click += UpVotes_Click;
            Label contLikeC20 = new Label();
            contLikeC20.Font = gothamFont;
            contLikeC20.Text = "0";
            contLikeC20.ForeColor = Color.White;
            contLikeC20.AutoSize = false;
            contLikeC20.Size = new Size(50, 20);
            contLikeC20.Location = new Point(1118, 1305);

            PictureBox dislike20 = new PictureBox();
            dislike20.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike20.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike20.Size = new Size(50, 30);
            dislike20.Location = new Point(1170, 1300);
            dislike20.Click += DownVotes_Click;
            Label contDislikeC20 = new Label();
            contDislikeC20.Font = gothamFont;
            contDislikeC20.Text = "0";
            contDislikeC20.ForeColor = Color.White;
            contDislikeC20.AutoSize = false;
            contDislikeC20.Size = new Size(50, 20);
            contDislikeC20.Location = new Point(1218, 1305);
            
            Label label39 = new Label();
            label39.Font = gothamFont;
            label39.Text = "In My Room";
            label39.ForeColor = Color.White;
            label39.BackColor = Color.FromArgb(18, 18, 18);
            label39.AutoSize = false;
            label39.Size = new Size(180, 20);
            label39.Location = new Point(1070, 1250);

            Label label40 = new Label();
            label40.Font = gothamFont;
            label40.Text = "Frank Ocean";
            label40.ForeColor = Color.White;
            label40.BackColor = Color.FromArgb(18, 18, 18);
            label40.AutoSize = false;
            label40.Size = new Size(180, 20);
            label40.Location = new Point(1070, 1270);

            scrollPane.Controls.Add(like16);
            scrollPane.Controls.Add(dislike16);
            scrollPane.Controls.Add(like17);
            scrollPane.Controls.Add(dislike17);
            scrollPane.Controls.Add(like18);
            scrollPane.Controls.Add(dislike18);
            scrollPane.Controls.Add(like19);
            scrollPane.Controls.Add(dislike19);
            scrollPane.Controls.Add(like20);
            scrollPane.Controls.Add(dislike20);
            scrollPane.Controls.Add(pictureBox16);
            scrollPane.Controls.Add(pictureBox17);
            scrollPane.Controls.Add(pictureBox18);
            scrollPane.Controls.Add(pictureBox19);
            scrollPane.Controls.Add(pictureBox20);
            scrollPane.Controls.Add(contLikeC16);
            scrollPane.Controls.Add(contDislikeC16);
            scrollPane.Controls.Add(contLikeC17);
            scrollPane.Controls.Add(contDislikeC17);
            scrollPane.Controls.Add(contLikeC18);
            scrollPane.Controls.Add(contDislikeC18);
            scrollPane.Controls.Add(contLikeC19);
            scrollPane.Controls.Add(contDislikeC19);
            scrollPane.Controls.Add(contLikeC20);
            scrollPane.Controls.Add(contDislikeC20);
            scrollPane.Controls.Add(label31);
            scrollPane.Controls.Add(label32);
            scrollPane.Controls.Add(label33);
            scrollPane.Controls.Add(label34);
            scrollPane.Controls.Add(label35);
            scrollPane.Controls.Add(label36);
            scrollPane.Controls.Add(label37);
            scrollPane.Controls.Add(label38);
            scrollPane.Controls.Add(label39);
            scrollPane.Controls.Add(label40);

            // C1-L5 --------------------------------------------------------------------------

            PictureBox pictureBox21 = new PictureBox();
            pictureBox21.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/frank.jpeg"); 
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox21.Size = new Size(180, 190); 
            pictureBox21.Location = new Point(110, 1380); 

            PictureBox like21 = new PictureBox();
            like21.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like21.SizeMode = PictureBoxSizeMode.StretchImage;
            like21.Size = new Size(50, 30);
            like21.Location = new Point(110, 1630);
            like21.Click += UpVotes_Click;
            Label contLikeC21 = new Label();
            contLikeC21.Font = gothamFont;
            contLikeC21.Text = "100";
            contLikeC21.ForeColor = Color.White;
            contLikeC21.AutoSize = false;
            contLikeC21.Size = new Size(50, 20);
            contLikeC21.Location = new Point(158, 1635);

            PictureBox dislike21 = new PictureBox();
            dislike21.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike21.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike21.Size = new Size(50, 30);
            dislike21.Location = new Point(210, 1630);
            dislike21.Click += DownVotes_Click;
            Label contDislikeC21 = new Label();
            contDislikeC21.Font = gothamFont;
            contDislikeC21.Text = "0";
            contDislikeC21.ForeColor = Color.White;
            contDislikeC21.AutoSize = false;
            contDislikeC21.Size = new Size(50, 20);
            contDislikeC21.Location = new Point(258, 1635);
            
            Label label41 = new Label();            
            label41.Font = gothamFont;
            label41.Text = "Navacane";
            label41.ForeColor = Color.White;
            label41.BackColor = Color.FromArgb(18, 18, 18);
            label41.AutoSize = false;
            label41.Size = new Size(180, 20);
            label41.Location = new Point(110, 1580);

            Label label42 = new Label();
            label42.Font = gothamFont;
            label42.Text = "Frank Ocean";
            label42.ForeColor = Color.White;
            label42.BackColor = Color.FromArgb(18, 18, 18);
            label42.AutoSize = false;
            label42.Size = new Size(180, 20);
            label42.Location = new Point(110, 1600);

            // C2-L5 --------------------------------------------------------------------------------

            PictureBox pictureBox22 = new PictureBox();
            pictureBox22.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/abel.jpeg"); 
            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox22.Size = new Size(180, 190); 
            pictureBox22.Location = new Point(350, 1380); 

            PictureBox like22 = new PictureBox();
            like22.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like22.SizeMode = PictureBoxSizeMode.StretchImage;
            like22.Size = new Size(50, 30);
            like22.Location = new Point(350, 1630);
            like22.Click += UpVotes_Click;
            Label contLikeC22 = new Label();
            contLikeC22.Font = gothamFont;
            contLikeC22.Text = "100";
            contLikeC22.ForeColor = Color.White;
            contLikeC22.AutoSize = false;
            contLikeC22.Size = new Size(50, 20);
            contLikeC22.Location = new Point(398, 1635);

            PictureBox dislike22 = new PictureBox();
            dislike22.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike22.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike22.Size = new Size(50, 30);
            dislike22.Location = new Point(450, 1630);
            dislike22.Click += DownVotes_Click;
            Label contDislikeC22 = new Label();
            contDislikeC22.Font = gothamFont;
            contDislikeC22.Text = "0";
            contDislikeC22.ForeColor = Color.White;
            contDislikeC22.AutoSize = false;
            contDislikeC22.Size = new Size(50, 20);
            contDislikeC22.Location = new Point(498, 1635);
            
            Label label43 = new Label();
            label43.Font = gothamFont;
            label43.Text = "Blinding Lights";
            label43.ForeColor = Color.White;
            label43.BackColor = Color.FromArgb(18, 18, 18);
            label43.AutoSize = false;
            label43.Size = new Size(180, 20);
            label43.Location = new Point(350, 1580);

            Label label44 = new Label();
            label44.Font = gothamFont;
            label44.Text = "The Weekend";
            label44.ForeColor = Color.White;
            label44.BackColor = Color.FromArgb(18, 18, 18);
            label44.AutoSize = false;
            label44.Size = new Size(180, 20);
            label44.Location = new Point(350, 1600);

            //C3-L5 --------------------------------------------------------------------------------

            PictureBox pictureBox23 = new PictureBox();
            pictureBox23.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/abel.jpeg"); 
            pictureBox23.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox23.Size = new Size(180, 190); 
            pictureBox23.Location = new Point(590, 1380); 

            PictureBox like23 = new PictureBox();
            like23.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like23.SizeMode = PictureBoxSizeMode.StretchImage;
            like23.Size = new Size(50, 30);
            like23.Location = new Point(590, 1630);
            like23.Click += UpVotes_Click;
            Label contLikeC23 = new Label();
            contLikeC23.Font = gothamFont;
            contLikeC23.Text = "0";
            contLikeC23.ForeColor = Color.White;
            contLikeC23.AutoSize = false;
            contLikeC23.Size = new Size(50, 20);
            contLikeC23.Location = new Point(638, 1635);
            
            PictureBox dislike23 = new PictureBox();
            dislike23.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike23.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike23.Size = new Size(50, 30);
            dislike23.Location = new Point(690, 1630);
            dislike23.Click += DownVotes_Click;
            Label contDislikeC23 = new Label();
            contDislikeC23.Font = gothamFont;
            contDislikeC23.Text = "0";
            contDislikeC23.ForeColor = Color.White;
            contDislikeC23.AutoSize = false;
            contDislikeC23.Size = new Size(50, 20);
            contDislikeC23.Location = new Point(738, 1635);
            
            Label label45 = new Label();
            label45.Font = gothamFont;
            label45.Text = "Call Out My Name";
            label45.ForeColor = Color.White;
            label45.BackColor = Color.FromArgb(18, 18, 18);
            label45.AutoSize = false;
            label45.Size = new Size(180, 20);
            label45.Location = new Point(590, 1580);

            Label label46 = new Label();
            label46.Font = gothamFont;
            label46.Text = "The Weekend";
            label46.ForeColor = Color.White;
            label46.BackColor = Color.FromArgb(18, 18, 18);
            label46.AutoSize = false;
            label46.Size = new Size(180, 20);
            label46.Location = new Point(590, 1600);

            //C4-L5 --------------------------------------------------------------------------------

            PictureBox pictureBox24 = new PictureBox();
            pictureBox24.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/abel.jpeg"); 
            pictureBox24.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox24.Size = new Size(180, 190); 
            pictureBox24.Location = new Point(830, 1380); 

            PictureBox like24 = new PictureBox();
            like24.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like24.SizeMode = PictureBoxSizeMode.StretchImage;
            like24.Size = new Size(50, 30);
            like24.Location = new Point(830, 1630);
            like24.Click += UpVotes_Click;
            Label contLikeC24 = new Label();
            contLikeC24.Font = gothamFont;
            contLikeC24.Text = "0";
            contLikeC24.ForeColor = Color.White;
            contLikeC24.AutoSize = false;
            contLikeC24.Size = new Size(50, 20);
            contLikeC24.Location = new Point(878, 1635);

            PictureBox dislike24 = new PictureBox();
            dislike24.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike24.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike24.Size = new Size(50, 30);
            dislike24.Location = new Point(930, 1630);
            dislike24.Click += DownVotes_Click;
            Label contDislikeC24 = new Label();
            contDislikeC24.Font = gothamFont;
            contDislikeC24.Text = "0";
            contDislikeC24.ForeColor = Color.White;
            contDislikeC24.AutoSize = false;
            contDislikeC24.Size = new Size(50, 20);
            contDislikeC24.Location = new Point(978, 1635);
            
            Label label47 = new Label();
            label47.Font = gothamFont;
            label47.Text = "Die For You";
            label47.ForeColor = Color.White;
            label47.BackColor = Color.FromArgb(18, 18, 18);
            label47.AutoSize = false;
            label47.Size = new Size(180, 20);
            label47.Location = new Point(830, 1580);

            Label label48 = new Label();
            label48.Font = gothamFont;
            label48.Text = "The Weekend";
            label48.ForeColor = Color.White;
            label48.BackColor = Color.FromArgb(18, 18, 18);
            label48.AutoSize = false;
            label48.Size = new Size(180, 20);
            label48.Location = new Point(830, 1600);

            //C5-L5 --------------------------------------------------------------------------------

            PictureBox pictureBox25 = new PictureBox();
            pictureBox25.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/abel.jpeg"); 
            pictureBox25.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox25.Size = new Size(180, 190); 
            pictureBox25.Location = new Point(1070, 1380); 

            PictureBox like25 = new PictureBox();
            like25.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like25.SizeMode = PictureBoxSizeMode.StretchImage;
            like25.Size = new Size(50, 30);
            like25.Location = new Point(1070, 1630);
            like25.Click += UpVotes_Click;
            Label contLikeC25 = new Label();
            contLikeC25.Font = gothamFont;
            contLikeC25.Text = "0";
            contLikeC25.ForeColor = Color.White;
            contLikeC25.AutoSize = false;
            contLikeC25.Size = new Size(50, 20);
            contLikeC25.Location = new Point(1118, 1635);

            PictureBox dislike25 = new PictureBox();
            dislike25.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike25.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike25.Size = new Size(50, 30);
            dislike25.Location = new Point(1170, 1630);
            dislike25.Click += DownVotes_Click;
            Label contDislikeC25 = new Label();
            contDislikeC25.Font = gothamFont;
            contDislikeC25.Text = "0";
            contDislikeC25.ForeColor = Color.White;
            contDislikeC25.AutoSize = false;
            contDislikeC25.Size = new Size(50, 20);
            contDislikeC25.Location = new Point(1218, 1635);
            
            Label label49 = new Label();
            label49.Font = gothamFont;
            label49.Text = "True Colors";
            label49.ForeColor = Color.White;
            label49.BackColor = Color.FromArgb(18, 18, 18);
            label49.AutoSize = false;
            label49.Size = new Size(180, 20);
            label49.Location = new Point(1070, 1580);

            Label label50 = new Label();
            label50.Font = gothamFont;
            label50.Text = "The Weekend";
            label50.ForeColor = Color.White;
            label50.BackColor = Color.FromArgb(18, 18, 18);
            label50.AutoSize = false;
            label50.Size = new Size(180, 20);
            label50.Location = new Point(1070, 1600);

            scrollPane.Controls.Add(like21);
            scrollPane.Controls.Add(dislike21);
            scrollPane.Controls.Add(like22);
            scrollPane.Controls.Add(dislike22);
            scrollPane.Controls.Add(like23);
            scrollPane.Controls.Add(dislike23);
            scrollPane.Controls.Add(like24);
            scrollPane.Controls.Add(dislike24);
            scrollPane.Controls.Add(like25);
            scrollPane.Controls.Add(dislike25);
            scrollPane.Controls.Add(pictureBox21);
            scrollPane.Controls.Add(pictureBox22);
            scrollPane.Controls.Add(pictureBox23);
            scrollPane.Controls.Add(pictureBox24);
            scrollPane.Controls.Add(pictureBox25);
            scrollPane.Controls.Add(contLikeC21);
            scrollPane.Controls.Add(contDislikeC21);
            scrollPane.Controls.Add(contLikeC22);
            scrollPane.Controls.Add(contDislikeC22);
            scrollPane.Controls.Add(contLikeC23);
            scrollPane.Controls.Add(contDislikeC23);
            scrollPane.Controls.Add(contLikeC24);
            scrollPane.Controls.Add(contDislikeC24);
            scrollPane.Controls.Add(contLikeC25);
            scrollPane.Controls.Add(contDislikeC25);
            scrollPane.Controls.Add(label41);
            scrollPane.Controls.Add(label42);
            scrollPane.Controls.Add(label43);
            scrollPane.Controls.Add(label44);
            scrollPane.Controls.Add(label45);
            scrollPane.Controls.Add(label46);
            scrollPane.Controls.Add(label47);
            scrollPane.Controls.Add(label48);
            scrollPane.Controls.Add(label49);
            scrollPane.Controls.Add(label50);

            // C1-L6 --------------------------------------------------------------------------

            PictureBox pictureBox26 = new PictureBox();
            pictureBox26.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/abel.jpeg"); 
            pictureBox26.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox26.Size = new Size(180, 190); 
            pictureBox26.Location = new Point(110, 1710); 

            PictureBox like26 = new PictureBox();
            like26.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like26.SizeMode = PictureBoxSizeMode.StretchImage;
            like26.Size = new Size(50, 30);
            like26.Location = new Point(110, 1960);
            like26.Click += UpVotes_Click;
            Label contLikeC26 = new Label();
            contLikeC26.Font = gothamFont;
            contLikeC26.Text = "100";
            contLikeC26.ForeColor = Color.White;
            contLikeC26.AutoSize = false;
            contLikeC26.Size = new Size(50, 20);
            contLikeC26.Location = new Point(158, 1965);

            PictureBox dislike26 = new PictureBox();
            dislike26.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike26.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike26.Size = new Size(50, 30);
            dislike26.Location = new Point(210, 1960);
            dislike26.Click += DownVotes_Click;
            Label contDislikeC26 = new Label();
            contDislikeC26.Font = gothamFont;
            contDislikeC26.Text = "0";
            contDislikeC26.ForeColor = Color.White;
            contDislikeC26.AutoSize = false;
            contDislikeC26.Size = new Size(50, 20);
            contDislikeC26.Location = new Point(258, 1965);
            
            Label label51 = new Label();            
            label51.Font = gothamFont;
            label51.Text = "I Feel It Coming";
            label51.ForeColor = Color.White;
            label51.BackColor = Color.FromArgb(18, 18, 18);
            label51.AutoSize = false;
            label51.Size = new Size(180, 20);
            label51.Location = new Point(110, 1910);

            Label label52 = new Label();
            label52.Font = gothamFont;
            label52.Text = "The Weekend";
            label52.ForeColor = Color.White;
            label52.BackColor = Color.FromArgb(18, 18, 18);
            label52.AutoSize = false;
            label52.Size = new Size(180, 20);
            label52.Location = new Point(110, 1930);

            // C2-L6 --------------------------------------------------------------------------------

            PictureBox pictureBox27 = new PictureBox();
            pictureBox27.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/abel.jpeg"); 
            pictureBox27.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox27.Size = new Size(180, 190); 
            pictureBox27.Location = new Point(350, 1710); 

            PictureBox like27 = new PictureBox();
            like27.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like27.SizeMode = PictureBoxSizeMode.StretchImage;
            like27.Size = new Size(50, 30);
            like27.Location = new Point(350, 1960);
            like27.Click += UpVotes_Click;
            Label contLikeC27 = new Label();
            contLikeC27.Font = gothamFont;
            contLikeC27.Text = "100";
            contLikeC27.ForeColor = Color.White;
            contLikeC27.AutoSize = false;
            contLikeC27.Size = new Size(50, 20);
            contLikeC27.Location = new Point(398, 1965);

            PictureBox dislike27 = new PictureBox();
            dislike27.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike27.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike27.Size = new Size(50, 30);
            dislike27.Location = new Point(450, 1960);
            dislike27.Click += DownVotes_Click;
            Label contDislikeC27 = new Label();
            contDislikeC27.Font = gothamFont;
            contDislikeC27.Text = "0";
            contDislikeC27.ForeColor = Color.White;
            contDislikeC27.AutoSize = false;
            contDislikeC27.Size = new Size(50, 20);
            contDislikeC27.Location = new Point(498, 1965);
            
            Label label53 = new Label();
            label53.Font = gothamFont;
            label53.Text = "Starboy";
            label53.ForeColor = Color.White;
            label53.BackColor = Color.FromArgb(18, 18, 18);
            label53.AutoSize = false;
            label53.Size = new Size(180, 20);
            label53.Location = new Point(350, 1910);

            Label label54 = new Label();
            label54.Font = gothamFont;
            label54.Text = "The Weekend";
            label54.ForeColor = Color.White;
            label54.BackColor = Color.FromArgb(18, 18, 18);
            label54.AutoSize = false;
            label54.Size = new Size(180, 20);
            label54.Location = new Point(350, 1930);

            //C3-L6 --------------------------------------------------------------------------------

            PictureBox pictureBox28 = new PictureBox();
            pictureBox28.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/abel.jpeg"); 
            pictureBox28.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox28.Size = new Size(180, 190); 
            pictureBox28.Location = new Point(590, 1710); 

            PictureBox like28 = new PictureBox();
            like28.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like28.SizeMode = PictureBoxSizeMode.StretchImage;
            like28.Size = new Size(50, 30);
            like28.Location = new Point(590, 1960);
            like28.Click += UpVotes_Click;
            Label contLikeC28 = new Label();
            contLikeC28.Font = gothamFont;
            contLikeC28.Text = "0";
            contLikeC28.ForeColor = Color.White;
            contLikeC28.AutoSize = false;
            contLikeC28.Size = new Size(50, 20);
            contLikeC28.Location = new Point(638, 1965);
            
            PictureBox dislike28 = new PictureBox();
            dislike28.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike28.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike28.Size = new Size(50, 30);
            dislike28.Location = new Point(690, 1960);
            dislike28.Click += DownVotes_Click;
            Label contDislikeC28 = new Label();
            contDislikeC28.Font = gothamFont;
            contDislikeC28.Text = "0";
            contDislikeC28.ForeColor = Color.White;
            contDislikeC28.AutoSize = false;
            contDislikeC28.Size = new Size(50, 20);
            contDislikeC28.Location = new Point(738, 1965);
            
            Label label55 = new Label();
            label55.Font = gothamFont;
            label55.Text = "Popular";
            label55.ForeColor = Color.White;
            label55.BackColor = Color.FromArgb(18, 18, 18);
            label55.AutoSize = false;
            label55.Size = new Size(180, 20);
            label55.Location = new Point(590, 1910);

            Label label56 = new Label();
            label56.Font = gothamFont;
            label56.Text = "The Weekend";
            label56.ForeColor = Color.White;
            label56.BackColor = Color.FromArgb(18, 18, 18);
            label56.AutoSize = false;
            label56.Size = new Size(180, 20);
            label56.Location = new Point(590, 1930);

            //C4-L6 --------------------------------------------------------------------------------

            PictureBox pictureBox29 = new PictureBox();
            pictureBox29.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/joji.jpeg"); 
            pictureBox29.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox29.Size = new Size(180, 190); 
            pictureBox29.Location = new Point(830, 1710); 

            PictureBox like29 = new PictureBox();
            like29.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like29.SizeMode = PictureBoxSizeMode.StretchImage;
            like29.Size = new Size(50, 30);
            like29.Location = new Point(830, 1960);
            like29.Click += UpVotes_Click;
            Label contLikeC29 = new Label();
            contLikeC29.Font = gothamFont;
            contLikeC29.Text = "0";
            contLikeC29.ForeColor = Color.White;
            contLikeC29.AutoSize = false;
            contLikeC29.Size = new Size(50, 20);
            contLikeC29.Location = new Point(878, 1965);

            PictureBox dislike29 = new PictureBox();
            dislike29.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike29.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike29.Size = new Size(50, 30);
            dislike29.Location = new Point(930, 1960);
            dislike29.Click += DownVotes_Click;
            Label contDislikeC29 = new Label();
            contDislikeC29.Font = gothamFont;
            contDislikeC29.Text = "0";
            contDislikeC29.ForeColor = Color.White;
            contDislikeC29.AutoSize = false;
            contDislikeC29.Size = new Size(50, 20);
            contDislikeC29.Location = new Point(978, 1965);
            
            Label label57 = new Label();
            label57.Font = new Font("Gotham", 7, FontStyle.Bold);
            label57.Text = "SLOW DANCING IN THE DARK";
            label57.ForeColor = Color.White;
            label57.BackColor = Color.FromArgb(18, 18, 18);
            label57.AutoSize = false;
            label57.Size = new Size(180, 20);
            label57.Location = new Point(830, 1910);

            Label label58 = new Label();
            label58.Font = gothamFont;
            label58.Text = "Joji";
            label58.ForeColor = Color.White;
            label58.BackColor = Color.FromArgb(18, 18, 18);
            label58.AutoSize = false;
            label58.Size = new Size(180, 20);
            label58.Location = new Point(830, 1930);

            //C5-L6 --------------------------------------------------------------------------------

            PictureBox pictureBox30 = new PictureBox();
            pictureBox30.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/joji.jpeg"); 
            pictureBox30.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox30.Size = new Size(180, 190); 
            pictureBox30.Location = new Point(1070, 1710); 

            PictureBox like30 = new PictureBox();
            like30.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like30.SizeMode = PictureBoxSizeMode.StretchImage;
            like30.Size = new Size(50, 30);
            like30.Location = new Point(1070, 1960);
            like30.Click += UpVotes_Click;
            Label contLikeC30 = new Label();
            contLikeC30.Font = gothamFont;
            contLikeC30.Text = "0";
            contLikeC30.ForeColor = Color.White;
            contLikeC30.AutoSize = false;
            contLikeC30.Size = new Size(50, 20);
            contLikeC30.Location = new Point(1118, 1965);

            PictureBox dislike30 = new PictureBox();
            dislike30.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike30.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike30.Size = new Size(50, 30);
            dislike30.Location = new Point(1170, 1960);
            dislike30.Click += DownVotes_Click;
            Label contDislikeC30 = new Label();
            contDislikeC30.Font = gothamFont;
            contDislikeC30.Text = "0";
            contDislikeC30.ForeColor = Color.White;
            contDislikeC30.AutoSize = false;
            contDislikeC30.Size = new Size(50, 20);
            contDislikeC30.Location = new Point(1218, 1965);
            
            Label label59 = new Label();
            label59.Font = gothamFont;
            label59.Text = "TEST DRIVE";
            label59.ForeColor = Color.White;
            label59.BackColor = Color.FromArgb(18, 18, 18);
            label59.AutoSize = false;
            label59.Size = new Size(180, 20);
            label59.Location = new Point(1070, 1910);

            Label label60 = new Label();
            label60.Font = gothamFont;
            label60.Text = "Joji";
            label60.ForeColor = Color.White;
            label60.BackColor = Color.FromArgb(18, 18, 18);
            label60.AutoSize = false;
            label60.Size = new Size(180, 20);
            label60.Location = new Point(1070, 1930);
            
            scrollPane.Controls.Add(like26);
            scrollPane.Controls.Add(dislike26);
            scrollPane.Controls.Add(like27);
            scrollPane.Controls.Add(dislike27);
            scrollPane.Controls.Add(like28);
            scrollPane.Controls.Add(dislike28);
            scrollPane.Controls.Add(like29);
            scrollPane.Controls.Add(dislike29);
            scrollPane.Controls.Add(like30);
            scrollPane.Controls.Add(dislike30);
            scrollPane.Controls.Add(pictureBox26);
            scrollPane.Controls.Add(pictureBox27);
            scrollPane.Controls.Add(pictureBox28);
            scrollPane.Controls.Add(pictureBox29);
            scrollPane.Controls.Add(pictureBox30);
            scrollPane.Controls.Add(contLikeC26);
            scrollPane.Controls.Add(contDislikeC26);
            scrollPane.Controls.Add(contLikeC27);
            scrollPane.Controls.Add(contDislikeC27);
            scrollPane.Controls.Add(contLikeC28);
            scrollPane.Controls.Add(contDislikeC28);
            scrollPane.Controls.Add(contLikeC29);
            scrollPane.Controls.Add(contDislikeC29);
            scrollPane.Controls.Add(contLikeC30);
            scrollPane.Controls.Add(contDislikeC30);
            scrollPane.Controls.Add(label51);
            scrollPane.Controls.Add(label52);
            scrollPane.Controls.Add(label53);
            scrollPane.Controls.Add(label54);
            scrollPane.Controls.Add(label55);
            scrollPane.Controls.Add(label56);
            scrollPane.Controls.Add(label57);
            scrollPane.Controls.Add(label58);
            scrollPane.Controls.Add(label59);
            scrollPane.Controls.Add(label60);

            // C1-L7 --------------------------------------------------------------------------

            PictureBox pictureBox31 = new PictureBox();
            pictureBox31.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/joji.jpeg"); 
            pictureBox31.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox31.Size = new Size(180, 190); 
            pictureBox31.Location = new Point(110, 2040); 

            PictureBox like31 = new PictureBox();
            like31.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like31.SizeMode = PictureBoxSizeMode.StretchImage;
            like31.Size = new Size(50, 30);
            like31.Location = new Point(110, 2290);
            like31.Click += UpVotes_Click;
            Label contLikeC31 = new Label();
            contLikeC31.Font = gothamFont;
            contLikeC31.Text = "100";
            contLikeC31.ForeColor = Color.White;
            contLikeC31.AutoSize = false;
            contLikeC31.Size = new Size(50, 20);
            contLikeC31.Location = new Point(158, 2295);

            PictureBox dislike31 = new PictureBox();
            dislike31.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike31.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike31.Size = new Size(50, 30);
            dislike31.Location = new Point(210, 2290);
            dislike31.Click += DownVotes_Click;
            Label contDislikeC31 = new Label();
            contDislikeC31.Font = gothamFont;
            contDislikeC31.Text = "0";
            contDislikeC31.ForeColor = Color.White;
            contDislikeC31.AutoSize = false;
            contDislikeC31.Size = new Size(50, 20);
            contDislikeC31.Location = new Point(258, 2295);
            
            Label label61 = new Label();            
            label61.Font = gothamFont;
            label61.Text = "YEAH RIGHT";
            label61.ForeColor = Color.White;
            label61.BackColor = Color.FromArgb(18, 18, 18);
            label61.AutoSize = false;
            label61.Size = new Size(180, 20);
            label61.Location = new Point(110, 2240);

            Label label62 = new Label();
            label62.Font = gothamFont;
            label62.Text = "Joji";
            label62.ForeColor = Color.White;
            label62.BackColor = Color.FromArgb(18, 18, 18);
            label62.AutoSize = false;
            label62.Size = new Size(180, 20);
            label62.Location = new Point(110, 2260);

            // C2-L7 --------------------------------------------------------------------------------

            PictureBox pictureBox32 = new PictureBox();
            pictureBox32.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/joji.jpeg"); 
            pictureBox32.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox32.Size = new Size(180, 190); 
            pictureBox32.Location = new Point(350, 2040); 

            PictureBox like32 = new PictureBox();
            like32.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like32.SizeMode = PictureBoxSizeMode.StretchImage;
            like32.Size = new Size(50, 30);
            like32.Location = new Point(350, 2290);
            like32.Click += UpVotes_Click;
            Label contLikeC32 = new Label();
            contLikeC32.Font = gothamFont;
            contLikeC32.Text = "100";
            contLikeC32.ForeColor = Color.White;
            contLikeC32.AutoSize = false;
            contLikeC32.Size = new Size(50, 20);
            contLikeC32.Location = new Point(398, 2295);

            PictureBox dislike32 = new PictureBox();
            dislike32.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike32.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike32.Size = new Size(50, 30);
            dislike32.Location = new Point(450, 2290);
            dislike32.Click += DownVotes_Click;
            Label contDislikeC32 = new Label();
            contDislikeC32.Font = gothamFont;
            contDislikeC32.Text = "0";
            contDislikeC32.ForeColor = Color.White;
            contDislikeC32.AutoSize = false;
            contDislikeC32.Size = new Size(50, 20);
            contDislikeC32.Location = new Point(498, 2295);
            
            Label label63 = new Label();
            label63.Font = gothamFont;
            label63.Text = "worldstar money";
            label63.ForeColor = Color.White;
            label63.BackColor = Color.FromArgb(18, 18, 18);
            label63.AutoSize = false;
            label63.Size = new Size(180, 20);
            label63.Location = new Point(350, 2240);

            Label label64 = new Label();
            label64.Font = gothamFont;
            label64.Text = "Joji";
            label64.ForeColor = Color.White;
            label64.BackColor = Color.FromArgb(18, 18, 18);
            label64.AutoSize = false;
            label64.Size = new Size(180, 20);
            label64.Location = new Point(350, 2260);

            //C3-L7 --------------------------------------------------------------------------------

            PictureBox pictureBox33 = new PictureBox();
            pictureBox33.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/joji.jpeg"); 
            pictureBox33.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox33.Size = new Size(180, 190); 
            pictureBox33.Location = new Point(590, 2040); 

            PictureBox like33 = new PictureBox();
            like33.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like33.SizeMode = PictureBoxSizeMode.StretchImage;
            like33.Size = new Size(50, 30);
            like33.Location = new Point(590, 2290);
            like33.Click += UpVotes_Click;
            Label contLikeC33 = new Label();
            contLikeC33.Font = gothamFont;
            contLikeC33.Text = "0";
            contLikeC33.ForeColor = Color.White;
            contLikeC33.AutoSize = false;
            contLikeC33.Size = new Size(50, 20);
            contLikeC33.Location = new Point(638, 2295);
            
            PictureBox dislike33 = new PictureBox();
            dislike33.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike33.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike33.Size = new Size(50, 30);
            dislike33.Location = new Point(690, 2290);
            dislike33.Click += DownVotes_Click;
            Label contDislikeC33 = new Label();
            contDislikeC33.Font = gothamFont;
            contDislikeC33.Text = "0";
            contDislikeC33.ForeColor = Color.White;
            contDislikeC33.AutoSize = false;
            contDislikeC33.Size = new Size(50, 20);
            contDislikeC33.Location = new Point(738, 2295);
            
            Label label65 = new Label();
            label65.Font = gothamFont;
            label65.Text = "Sanctuary";
            label65.ForeColor = Color.White;
            label65.BackColor = Color.FromArgb(18, 18, 18);
            label65.AutoSize = false;
            label65.Size = new Size(180, 20);
            label65.Location = new Point(590, 2240);

            Label label66 = new Label();
            label66.Font = gothamFont;
            label66.Text = "joji";
            label66.ForeColor = Color.White;
            label66.BackColor = Color.FromArgb(18, 18, 18);
            label66.AutoSize = false;
            label66.Size = new Size(180, 20);
            label66.Location = new Point(590, 2260);

            //C4-L7 --------------------------------------------------------------------------------

            PictureBox pictureBox34 = new PictureBox();
            pictureBox34.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/joji.jpeg"); 
            pictureBox34.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox34.Size = new Size(180, 190); 
            pictureBox34.Location = new Point(830, 2040); 

            PictureBox like34 = new PictureBox();
            like34.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like34.SizeMode = PictureBoxSizeMode.StretchImage;
            like34.Size = new Size(50, 30);
            like34.Location = new Point(830, 2290);
            like34.Click += UpVotes_Click;
            Label contLikeC34 = new Label();
            contLikeC34.Font = gothamFont;
            contLikeC34.Text = "0";
            contLikeC34.ForeColor = Color.White;
            contLikeC34.AutoSize = false;
            contLikeC34.Size = new Size(50, 20);
            contLikeC34.Location = new Point(878, 2295);

            PictureBox dislike34 = new PictureBox();
            dislike34.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike34.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike34.Size = new Size(50, 30);
            dislike34.Location = new Point(930, 2290);
            dislike34.Click += DownVotes_Click;
            Label contDislikeC34 = new Label();
            contDislikeC34.Font = gothamFont;
            contDislikeC34.Text = "0";
            contDislikeC34.ForeColor = Color.White;
            contDislikeC34.AutoSize = false;
            contDislikeC34.Size = new Size(50, 20);
            contDislikeC34.Location = new Point(978, 2295);
            
            Label label67 = new Label();
            label67.Font = gothamFont;
            label67.Text = "Feeling Like The End";
            label67.ForeColor = Color.White;
            label67.BackColor = Color.FromArgb(18, 18, 18);
            label67.AutoSize = false;
            label67.Size = new Size(180, 20);
            label67.Location = new Point(830, 2240);

            Label label68 = new Label();
            label68.Font = gothamFont;
            label68.Text = "Joji";
            label68.ForeColor = Color.White;
            label68.BackColor = Color.FromArgb(18, 18, 18);
            label68.AutoSize = false;
            label68.Size = new Size(180, 20);
            label68.Location = new Point(830, 2260);

            //C5-L7 --------------------------------------------------------------------------------

            PictureBox pictureBox35 = new PictureBox();
            pictureBox35.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/joji.jpeg"); 
            pictureBox35.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox35.Size = new Size(180, 190); 
            pictureBox35.Location = new Point(1070, 2040); 

            PictureBox like35 = new PictureBox();
            like35.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like35.SizeMode = PictureBoxSizeMode.StretchImage;
            like35.Size = new Size(50, 30);
            like35.Location = new Point(1070, 2290);
            like35.Click += UpVotes_Click;
            Label contLikeC35 = new Label();
            contLikeC35.Font = gothamFont;
            contLikeC35.Text = "0";
            contLikeC35.ForeColor = Color.White;
            contLikeC35.AutoSize = false;
            contLikeC35.Size = new Size(50, 20);
            contLikeC35.Location = new Point(1118, 2295);

            PictureBox dislike35 = new PictureBox();
            dislike35.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike35.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike35.Size = new Size(50, 30);
            dislike35.Location = new Point(1170, 2290);
            dislike35.Click += DownVotes_Click;
            Label contDislikeC35 = new Label();
            contDislikeC35.Font = gothamFont;
            contDislikeC35.Text = "0";
            contDislikeC35.ForeColor = Color.White;
            contDislikeC35.AutoSize = false;
            contDislikeC35.Size = new Size(50, 20);
            contDislikeC35.Location = new Point(1218, 2295);
            
            Label label69 = new Label();
            label69.Font = gothamFont;
            label69.Text = "Glimpse of Us";
            label69.ForeColor = Color.White;
            label69.BackColor = Color.FromArgb(18, 18, 18);
            label69.AutoSize = false;
            label69.Size = new Size(180, 20);
            label69.Location = new Point(1070, 2240);

            Label label70 = new Label();
            label70.Font = gothamFont;
            label70.Text = "Joji";
            label70.ForeColor = Color.White;
            label70.BackColor = Color.FromArgb(18, 18, 18);
            label70.AutoSize = false;
            label70.Size = new Size(180, 20);
            label70.Location = new Point(1070, 2260);

            scrollPane.Controls.Add(like31);
            scrollPane.Controls.Add(dislike31);
            scrollPane.Controls.Add(like32);
            scrollPane.Controls.Add(dislike32);
            scrollPane.Controls.Add(like33);
            scrollPane.Controls.Add(dislike33);
            scrollPane.Controls.Add(like34);
            scrollPane.Controls.Add(dislike34);
            scrollPane.Controls.Add(like35);
            scrollPane.Controls.Add(dislike35);
            scrollPane.Controls.Add(pictureBox31);
            scrollPane.Controls.Add(pictureBox32);
            scrollPane.Controls.Add(pictureBox33);
            scrollPane.Controls.Add(pictureBox34);
            scrollPane.Controls.Add(pictureBox35);
            scrollPane.Controls.Add(contLikeC31);
            scrollPane.Controls.Add(contDislikeC31);
            scrollPane.Controls.Add(contLikeC32);
            scrollPane.Controls.Add(contDislikeC32);
            scrollPane.Controls.Add(contLikeC33);
            scrollPane.Controls.Add(contDislikeC33);
            scrollPane.Controls.Add(contLikeC34);
            scrollPane.Controls.Add(contDislikeC34);
            scrollPane.Controls.Add(contLikeC35);
            scrollPane.Controls.Add(contDislikeC35);
            scrollPane.Controls.Add(label61);
            scrollPane.Controls.Add(label62);
            scrollPane.Controls.Add(label63);
            scrollPane.Controls.Add(label64);
            scrollPane.Controls.Add(label65);
            scrollPane.Controls.Add(label66);
            scrollPane.Controls.Add(label67);
            scrollPane.Controls.Add(label68);
            scrollPane.Controls.Add(label69);
            scrollPane.Controls.Add(label70);

            // C1-L8 --------------------------------------------------------------------------

            PictureBox pictureBox36 = new PictureBox();
            pictureBox36.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/traviesoscott.jpeg"); 
            pictureBox36.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox36.Size = new Size(180, 190); 
            pictureBox36.Location = new Point(110, 2370); 

            PictureBox like36 = new PictureBox();
            like36.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like36.SizeMode = PictureBoxSizeMode.StretchImage;
            like36.Size = new Size(50, 30);
            like36.Location = new Point(110, 2620);
            like36.Click += UpVotes_Click;
            Label contLikeC36 = new Label();
            contLikeC36.Font = gothamFont;
            contLikeC36.Text = "100";
            contLikeC36.ForeColor = Color.White;
            contLikeC36.AutoSize = false;
            contLikeC36.Size = new Size(50, 20);
            contLikeC36.Location = new Point(158, 2625);

            PictureBox dislike36 = new PictureBox();
            dislike36.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike36.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike36.Size = new Size(50, 30);
            dislike36.Location = new Point(210, 2620);
            dislike36.Click += DownVotes_Click;
            Label contDislikeC36 = new Label();
            contDislikeC36.Font = gothamFont;
            contDislikeC36.Text = "0";
            contDislikeC36.ForeColor = Color.White;
            contDislikeC36.AutoSize = false;
            contDislikeC36.Size = new Size(50, 20);
            contDislikeC36.Location = new Point(258, 2625);
            
            Label label71 = new Label();            
            label71.Font = gothamFont;
            label71.Text = "CAROUSEL";
            label71.ForeColor = Color.White;
            label71.BackColor = Color.FromArgb(18, 18, 18);
            label71.AutoSize = false;
            label71.Size = new Size(180, 20);
            label71.Location = new Point(110, 2570);

            Label label72 = new Label();
            label72.Font = gothamFont;
            label72.Text = "Travis Scott";
            label72.ForeColor = Color.White;
            label72.BackColor = Color.FromArgb(18, 18, 18);
            label72.AutoSize = false;
            label72.Size = new Size(180, 20);
            label72.Location = new Point(110, 2590);

            // C2-L8 --------------------------------------------------------------------------------

            PictureBox pictureBox37 = new PictureBox();
            pictureBox37.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/traviesoscott.jpeg"); 
            pictureBox37.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox37.Size = new Size(180, 190); 
            pictureBox37.Location = new Point(350, 2370); 

            PictureBox like37 = new PictureBox();
            like37.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like37.SizeMode = PictureBoxSizeMode.StretchImage;
            like37.Size = new Size(50, 30);
            like37.Location = new Point(350, 2620);
            like37.Click += UpVotes_Click;
            Label contLikeC37 = new Label();
            contLikeC37.Font = gothamFont;
            contLikeC37.Text = "100";
            contLikeC37.ForeColor = Color.White;
            contLikeC37.AutoSize = false;
            contLikeC37.Size = new Size(50, 20);
            contLikeC37.Location = new Point(398, 2625);

            PictureBox dislike37 = new PictureBox();
            dislike37.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike37.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike37.Size = new Size(50, 30);
            dislike37.Location = new Point(450, 2620);
            dislike37.Click += DownVotes_Click;
            Label contDislikeC37 = new Label();
            contDislikeC37.Font = gothamFont;
            contDislikeC37.Text = "0";
            contDislikeC37.ForeColor = Color.White;
            contDislikeC37.AutoSize = false;
            contDislikeC37.Size = new Size(50, 20);
            contDislikeC37.Location = new Point(498, 2625);
            
            Label label73 = new Label();
            label73.Font = gothamFont;
            label73.Text = "STARGAZING";
            label73.ForeColor = Color.White;
            label73.BackColor = Color.FromArgb(18, 18, 18);
            label73.AutoSize = false;
            label73.Size = new Size(180, 20);
            label73.Location = new Point(350, 2570);

            Label label74 = new Label();
            label74.Font = gothamFont;
            label74.Text = "Travis Scott";
            label74.ForeColor = Color.White;
            label74.BackColor = Color.FromArgb(18, 18, 18);
            label74.AutoSize = false;
            label74.Size = new Size(180, 20);
            label74.Location = new Point(350, 2590);

            //C3-L8 --------------------------------------------------------------------------------

            PictureBox pictureBox38 = new PictureBox();
            pictureBox38.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/traviesoscott.jpeg"); 
            pictureBox38.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox38.Size = new Size(180, 190); 
            pictureBox38.Location = new Point(590, 2370); 

            PictureBox like38 = new PictureBox();
            like38.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like38.SizeMode = PictureBoxSizeMode.StretchImage;
            like38.Size = new Size(50, 30);
            like38.Location = new Point(590, 2620);
            like38.Click += UpVotes_Click;
            Label contLikeC38 = new Label();
            contLikeC38.Font = gothamFont;
            contLikeC38.Text = "0";
            contLikeC38.ForeColor = Color.White;
            contLikeC38.AutoSize = false;
            contLikeC38.Size = new Size(50, 20);
            contLikeC38.Location = new Point(638, 2625);
            
            PictureBox dislike38 = new PictureBox();
            dislike38.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike38.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike38.Size = new Size(50, 30);
            dislike38.Location = new Point(690, 2620);
            dislike38.Click += DownVotes_Click;
            Label contDislikeC38 = new Label();
            contDislikeC38.Font = gothamFont;
            contDislikeC38.Text = "0";
            contDislikeC38.ForeColor = Color.White;
            contDislikeC38.AutoSize = false;
            contDislikeC38.Size = new Size(50, 20);
            contDislikeC38.Location = new Point(738, 2625);
            
            Label label75 = new Label();
            label75.Font = gothamFont;
            label75.Text = "goosebumps";
            label75.ForeColor = Color.White;
            label75.BackColor = Color.FromArgb(18, 18, 18);
            label75.AutoSize = false;
            label75.Size = new Size(180, 20);
            label75.Location = new Point(590, 2570);

            Label label76 = new Label();
            label76.Font = gothamFont;
            label76.Text = "Travis Scott";
            label76.ForeColor = Color.White;
            label76.BackColor = Color.FromArgb(18, 18, 18);
            label76.AutoSize = false;
            label76.Size = new Size(180, 20);
            label76.Location = new Point(590, 2590);

            //C4-L8 --------------------------------------------------------------------------------

            PictureBox pictureBox39 = new PictureBox();
            pictureBox39.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/traviesoscott.jpeg"); 
            pictureBox39.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox39.Size = new Size(180, 190); 
            pictureBox39.Location = new Point(830, 2370); 

            PictureBox like39 = new PictureBox();
            like39.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like39.SizeMode = PictureBoxSizeMode.StretchImage;
            like39.Size = new Size(50, 30);
            like39.Location = new Point(830, 2620);
            like39.Click += UpVotes_Click;
            Label contLikeC39 = new Label();
            contLikeC39.Font = gothamFont;
            contLikeC39.Text = "0";
            contLikeC39.ForeColor = Color.White;
            contLikeC39.AutoSize = false;
            contLikeC39.Size = new Size(50, 20);
            contLikeC39.Location = new Point(878, 2625);

            PictureBox dislike39 = new PictureBox();
            dislike39.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike39.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike39.Size = new Size(50, 30);
            dislike39.Location = new Point(930, 2620);
            dislike39.Click += DownVotes_Click;
            Label contDislikeC39 = new Label();
            contDislikeC39.Font = gothamFont;
            contDislikeC39.Text = "0";
            contDislikeC39.ForeColor = Color.White;
            contDislikeC39.AutoSize = false;
            contDislikeC39.Size = new Size(50, 20);
            contDislikeC39.Location = new Point(978, 2625);
            
            Label label77 = new Label();
            label77.Font = gothamFont;
            label77.Text = "sdp interlude";
            label77.ForeColor = Color.White;
            label77.BackColor = Color.FromArgb(18, 18, 18);
            label77.AutoSize = false;
            label77.Size = new Size(180, 20);
            label77.Location = new Point(830, 2570);

            Label label78 = new Label();
            label78.Font = gothamFont;
            label78.Text = "Travis Scott";
            label78.ForeColor = Color.White;
            label78.BackColor = Color.FromArgb(18, 18, 18);
            label78.AutoSize = false;
            label78.Size = new Size(180, 20);
            label78.Location = new Point(830, 2590);

            //C5-L8 --------------------------------------------------------------------------------

            PictureBox pictureBox40 = new PictureBox();
            pictureBox40.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/traviesoscott.jpeg"); 
            pictureBox40.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox40.Size = new Size(180, 190); 
            pictureBox40.Location = new Point(1070, 2370); 

            PictureBox like40 = new PictureBox();
            like40.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like40.SizeMode = PictureBoxSizeMode.StretchImage;
            like40.Size = new Size(50, 30);
            like40.Location = new Point(1070, 2620);
            like40.Click += UpVotes_Click;
            Label contLikeC40 = new Label();
            contLikeC40.Font = gothamFont;
            contLikeC40.Text = "0";
            contLikeC40.ForeColor = Color.White;
            contLikeC40.AutoSize = false;
            contLikeC40.Size = new Size(50, 20);
            contLikeC40.Location = new Point(1118, 2625);

            PictureBox dislike40 = new PictureBox();
            dislike40.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike40.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike40.Size = new Size(50, 30);
            dislike40.Location = new Point(1170, 2620);
            dislike40.Click += DownVotes_Click;
            Label contDislikeC40 = new Label();
            contDislikeC40.Font = gothamFont;
            contDislikeC40.Text = "0";
            contDislikeC40.ForeColor = Color.White;
            contDislikeC40.AutoSize = false;
            contDislikeC40.Size = new Size(50, 20);
            contDislikeC40.Location = new Point(1218, 2625);
            
            Label label79 = new Label();
            label79.Font = gothamFont;
            label79.Text = "MY EYES";
            label79.ForeColor = Color.White;
            label79.BackColor = Color.FromArgb(18, 18, 18);
            label79.AutoSize = false;
            label79.Size = new Size(180, 20);
            label79.Location = new Point(1070, 2570);

            Label label80 = new Label();
            label80.Font = gothamFont;
            label80.Text = "Travis Scott";
            label80.ForeColor = Color.White;
            label80.BackColor = Color.FromArgb(18, 18, 18);
            label80.AutoSize = false;
            label80.Size = new Size(180, 20);
            label80.Location = new Point(1070, 2590);

            scrollPane.Controls.Add(like36);
            scrollPane.Controls.Add(dislike36);
            scrollPane.Controls.Add(like37);
            scrollPane.Controls.Add(dislike37);
            scrollPane.Controls.Add(like38);
            scrollPane.Controls.Add(dislike38);
            scrollPane.Controls.Add(like39);
            scrollPane.Controls.Add(dislike39);
            scrollPane.Controls.Add(like40);
            scrollPane.Controls.Add(dislike40);
            scrollPane.Controls.Add(pictureBox36);
            scrollPane.Controls.Add(pictureBox37);
            scrollPane.Controls.Add(pictureBox38);
            scrollPane.Controls.Add(pictureBox39);
            scrollPane.Controls.Add(pictureBox40);
            scrollPane.Controls.Add(contLikeC36);
            scrollPane.Controls.Add(contDislikeC36);
            scrollPane.Controls.Add(contLikeC37);
            scrollPane.Controls.Add(contDislikeC37);
            scrollPane.Controls.Add(contLikeC38);
            scrollPane.Controls.Add(contDislikeC38);
            scrollPane.Controls.Add(contLikeC39);
            scrollPane.Controls.Add(contDislikeC39);
            scrollPane.Controls.Add(contLikeC40);
            scrollPane.Controls.Add(contDislikeC40);
            scrollPane.Controls.Add(label71);
            scrollPane.Controls.Add(label72);
            scrollPane.Controls.Add(label73);
            scrollPane.Controls.Add(label74);
            scrollPane.Controls.Add(label75);
            scrollPane.Controls.Add(label76);
            scrollPane.Controls.Add(label77);
            scrollPane.Controls.Add(label78);
            scrollPane.Controls.Add(label79);
            scrollPane.Controls.Add(label80);

            // C1-L9 --------------------------------------------------------------------------

            PictureBox pictureBox41 = new PictureBox();
            pictureBox41.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/traviesoscott.jpeg"); 
            pictureBox41.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox41.Size = new Size(180, 190); 
            pictureBox41.Location = new Point(110, 2700); 

            PictureBox like41 = new PictureBox();
            like41.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like41.SizeMode = PictureBoxSizeMode.StretchImage;
            like41.Size = new Size(50, 30);
            like41.Location = new Point(110, 2950);
            like41.Click += UpVotes_Click;
            Label contLikeC41 = new Label();
            contLikeC41.Font = gothamFont;
            contLikeC41.Text = "100";
            contLikeC41.ForeColor = Color.White;
            contLikeC41.AutoSize = false;
            contLikeC41.Size = new Size(50, 20);
            contLikeC41.Location = new Point(158, 2955);

            PictureBox dislike41 = new PictureBox();
            dislike41.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike41.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike41.Size = new Size(50, 30);
            dislike41.Location = new Point(210, 2950);
            dislike41.Click += DownVotes_Click;
            Label contDislikeC41 = new Label();
            contDislikeC41.Font = gothamFont;
            contDislikeC41.Text = "0";
            contDislikeC41.ForeColor = Color.White;
            contDislikeC41.AutoSize = false;
            contDislikeC41.Size = new Size(50, 20);
            contDislikeC41.Location = new Point(258, 2955);
            
            Label label81 = new Label();            
            label81.Font = gothamFont;
            label81.Text = "MELTDOWN";
            label81.ForeColor = Color.White;
            label81.BackColor = Color.FromArgb(18, 18, 18);
            label81.AutoSize = false;
            label81.Size = new Size(180, 20);
            label81.Location = new Point(110, 2900);

            Label label82 = new Label();
            label82.Font = gothamFont;
            label82.Text = "Travis Scott";
            label82.ForeColor = Color.White;
            label82.BackColor = Color.FromArgb(18, 18, 18);
            label82.AutoSize = false;
            label82.Size = new Size(180, 20);
            label82.Location = new Point(110, 2920);

            // C2-L9 --------------------------------------------------------------------------------

            PictureBox pictureBox42 = new PictureBox();
            pictureBox42.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/traviesoscott.jpeg"); 
            pictureBox42.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox42.Size = new Size(180, 190); 
            pictureBox42.Location = new Point(350, 2700); 

            PictureBox like42 = new PictureBox();
            like42.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like42.SizeMode = PictureBoxSizeMode.StretchImage;
            like42.Size = new Size(50, 30);
            like42.Location = new Point(350, 2950);
            like42.Click += UpVotes_Click;
            Label contLikeC42 = new Label();
            contLikeC42.Font = gothamFont;
            contLikeC42.Text = "100";
            contLikeC42.ForeColor = Color.White;
            contLikeC42.AutoSize = false;
            contLikeC42.Size = new Size(50, 20);
            contLikeC42.Location = new Point(398, 2955);

            PictureBox dislike42 = new PictureBox();
            dislike42.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike42.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike42.Size = new Size(50, 30);
            dislike42.Location = new Point(450, 2950);
            dislike42.Click += DownVotes_Click;
            Label contDislikeC42 = new Label();
            contDislikeC42.Font = gothamFont;
            contDislikeC42.Text = "0";
            contDislikeC42.ForeColor = Color.White;
            contDislikeC42.AutoSize = false;
            contDislikeC42.Size = new Size(50, 20);
            contDislikeC42.Location = new Point(498, 2955);
            
            Label label83 = new Label();
            label83.Font = gothamFont;
            label83.Text = "pick up the phone";
            label83.ForeColor = Color.White;
            label83.BackColor = Color.FromArgb(18, 18, 18);
            label83.AutoSize = false;
            label83.Size = new Size(180, 20);
            label83.Location = new Point(350, 2900);

            Label label84 = new Label();
            label84.Font = gothamFont;
            label84.Text = "Travis Scott";
            label84.ForeColor = Color.White;
            label84.BackColor = Color.FromArgb(18, 18, 18);
            label84.AutoSize = false;
            label84.Size = new Size(180, 20);
            label84.Location = new Point(350, 2920);

            //C3-L9 --------------------------------------------------------------------------------

            PictureBox pictureBox43 = new PictureBox();
            pictureBox43.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/eminem.jpeg"); 
            pictureBox43.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox43.Size = new Size(180, 190); 
            pictureBox43.Location = new Point(590, 2700); 

            PictureBox like43 = new PictureBox();
            like43.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like43.SizeMode = PictureBoxSizeMode.StretchImage;
            like43.Size = new Size(50, 30);
            like43.Location = new Point(590, 2950);
            like43.Click += UpVotes_Click;
            Label contLikeC43 = new Label();
            contLikeC43.Font = gothamFont;
            contLikeC43.Text = "0";
            contLikeC43.ForeColor = Color.White;
            contLikeC43.AutoSize = false;
            contLikeC43.Size = new Size(50, 20);
            contLikeC43.Location = new Point(638, 2955);
            
            PictureBox dislike43 = new PictureBox();
            dislike43.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike43.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike43.Size = new Size(50, 30);
            dislike43.Location = new Point(690, 2950);
            dislike43.Click += DownVotes_Click;
            Label contDislikeC43 = new Label();
            contDislikeC43.Font = gothamFont;
            contDislikeC43.Text = "0";
            contDislikeC43.ForeColor = Color.White;
            contDislikeC43.AutoSize = false;
            contDislikeC43.Size = new Size(50, 20);
            contDislikeC43.Location = new Point(738, 2955);
            
            Label label85 = new Label();
            label85.Font = gothamFont;
            label85.Text = "Mockingbird";
            label85.ForeColor = Color.White;
            label85.BackColor = Color.FromArgb(18, 18, 18);
            label85.AutoSize = false;
            label85.Size = new Size(180, 20);
            label85.Location = new Point(590, 2900);

            Label label86 = new Label();
            label86.Font = gothamFont;
            label86.Text = "Eminem";
            label86.ForeColor = Color.White;
            label86.BackColor = Color.FromArgb(18, 18, 18);
            label86.AutoSize = false;
            label86.Size = new Size(180, 20);
            label86.Location = new Point(590, 2920);

            //C4-L9 --------------------------------------------------------------------------------

            PictureBox pictureBox44 = new PictureBox();
            pictureBox44.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/eminem.jpeg"); 
            pictureBox44.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox44.Size = new Size(180, 190); 
            pictureBox44.Location = new Point(830, 2700); 

            PictureBox like44 = new PictureBox();
            like44.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like44.SizeMode = PictureBoxSizeMode.StretchImage;
            like44.Size = new Size(50, 30);
            like44.Location = new Point(830, 2950);
            like44.Click += UpVotes_Click;
            Label contLikeC44 = new Label();
            contLikeC44.Font = gothamFont;
            contLikeC44.Text = "0";
            contLikeC44.ForeColor = Color.White;
            contLikeC44.AutoSize = false;
            contLikeC44.Size = new Size(50, 20);
            contLikeC44.Location = new Point(878, 2955);

            PictureBox dislike44 = new PictureBox();
            dislike44.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike44.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike44.Size = new Size(50, 30);
            dislike44.Location = new Point(930, 2950);
            dislike44.Click += DownVotes_Click;
            Label contDislikeC44 = new Label();
            contDislikeC44.Font = gothamFont;
            contDislikeC44.Text = "0";
            contDislikeC44.ForeColor = Color.White;
            contDislikeC44.AutoSize = false;
            contDislikeC44.Size = new Size(50, 20);
            contDislikeC44.Location = new Point(978, 2955);
            
            Label label87 = new Label();
            label87.Font = gothamFont;
            label87.Text = "Lose Yourself";
            label87.ForeColor = Color.White;
            label87.BackColor = Color.FromArgb(18, 18, 18);
            label87.AutoSize = false;
            label87.Size = new Size(180, 20);
            label87.Location = new Point(830, 2900);

            Label label88 = new Label();
            label88.Font = gothamFont;
            label88.Text = "Eminem";
            label88.ForeColor = Color.White;
            label88.BackColor = Color.FromArgb(18, 18, 18);
            label88.AutoSize = false;
            label88.Size = new Size(180, 20);
            label88.Location = new Point(830, 2920);

            //C5-L9 --------------------------------------------------------------------------------

            PictureBox pictureBox45 = new PictureBox();
            pictureBox45.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/eminem.jpeg"); 
            pictureBox45.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox45.Size = new Size(180, 190); 
            pictureBox45.Location = new Point(1070, 2700); 

            PictureBox like45 = new PictureBox();
            like45.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like45.SizeMode = PictureBoxSizeMode.StretchImage;
            like45.Size = new Size(50, 30);
            like45.Location = new Point(1070, 2950);
            like45.Click += UpVotes_Click;
            Label contLikeC45 = new Label();
            contLikeC45.Font = gothamFont;
            contLikeC45.Text = "0";
            contLikeC45.ForeColor = Color.White;
            contLikeC45.AutoSize = false;
            contLikeC45.Size = new Size(50, 20);
            contLikeC45.Location = new Point(1118, 2955);

            PictureBox dislike45 = new PictureBox();
            dislike45.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike45.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike45.Size = new Size(50, 30);
            dislike45.Location = new Point(1170, 2950);
            dislike45.Click += DownVotes_Click;
            Label contDislikeC45 = new Label();
            contDislikeC45.Font = gothamFont;
            contDislikeC45.Text = "0";
            contDislikeC45.ForeColor = Color.White;
            contDislikeC45.AutoSize = false;
            contDislikeC45.Size = new Size(50, 20);
            contDislikeC45.Location = new Point(1218, 2955);
            
            Label label89 = new Label();
            label89.Font = gothamFont;
            label89.Text = "Without Me";
            label89.ForeColor = Color.White;
            label89.BackColor = Color.FromArgb(18, 18, 18);
            label89.AutoSize = false;
            label89.Size = new Size(180, 20);
            label89.Location = new Point(1070, 2900);

            Label label90 = new Label();
            label90.Font = gothamFont;
            label90.Text = "Eminem";
            label90.ForeColor = Color.White;
            label90.BackColor = Color.FromArgb(18, 18, 18);
            label90.AutoSize = false;
            label90.Size = new Size(180, 20);
            label90.Location = new Point(1070, 2920);

            scrollPane.Controls.Add(like41);
            scrollPane.Controls.Add(dislike41);
            scrollPane.Controls.Add(like42);
            scrollPane.Controls.Add(dislike42);
            scrollPane.Controls.Add(like43);
            scrollPane.Controls.Add(dislike43);
            scrollPane.Controls.Add(like44);
            scrollPane.Controls.Add(dislike44);
            scrollPane.Controls.Add(like45);
            scrollPane.Controls.Add(dislike45);
            scrollPane.Controls.Add(pictureBox41);
            scrollPane.Controls.Add(pictureBox42);
            scrollPane.Controls.Add(pictureBox43);
            scrollPane.Controls.Add(pictureBox44);
            scrollPane.Controls.Add(pictureBox45);
            scrollPane.Controls.Add(contLikeC41);
            scrollPane.Controls.Add(contDislikeC41);
            scrollPane.Controls.Add(contLikeC42);
            scrollPane.Controls.Add(contDislikeC42);
            scrollPane.Controls.Add(contLikeC43);
            scrollPane.Controls.Add(contDislikeC43);
            scrollPane.Controls.Add(contLikeC44);
            scrollPane.Controls.Add(contDislikeC44);
            scrollPane.Controls.Add(contLikeC45);
            scrollPane.Controls.Add(contDislikeC45);
            scrollPane.Controls.Add(label81);
            scrollPane.Controls.Add(label82);
            scrollPane.Controls.Add(label83);
            scrollPane.Controls.Add(label84);
            scrollPane.Controls.Add(label85);
            scrollPane.Controls.Add(label86);
            scrollPane.Controls.Add(label87);
            scrollPane.Controls.Add(label88);
            scrollPane.Controls.Add(label89);
            scrollPane.Controls.Add(label90);

            // C1-L10 --------------------------------------------------------------------------

            PictureBox pictureBox46 = new PictureBox();
            pictureBox46.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/eminem.jpeg"); 
            pictureBox46.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox46.Size = new Size(180, 190); 
            pictureBox46.Location = new Point(110, 3030); 

            PictureBox like46 = new PictureBox();
            like46.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like46.SizeMode = PictureBoxSizeMode.StretchImage;
            like46.Size = new Size(50, 30);
            like46.Location = new Point(110, 3280);
            like46.Click += UpVotes_Click;
            Label contLikeC46 = new Label();
            contLikeC46.Font = gothamFont;
            contLikeC46.Text = "100";
            contLikeC46.ForeColor = Color.White;
            contLikeC46.AutoSize = false;
            contLikeC46.Size = new Size(50, 20);
            contLikeC46.Location = new Point(158, 3285);

            PictureBox dislike46 = new PictureBox();
            dislike46.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike46.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike46.Size = new Size(50, 30);
            dislike46.Location = new Point(210, 3280);
            dislike46.Click += DownVotes_Click;
            Label contDislikeC46 = new Label();
            contDislikeC46.Font = gothamFont;
            contDislikeC46.Text = "0";
            contDislikeC46.ForeColor = Color.White;
            contDislikeC46.AutoSize = false;
            contDislikeC46.Size = new Size(50, 20);
            contDislikeC46.Location = new Point(258, 3285);
            
            Label label91 = new Label();            
            label91.Font = gothamFont;
            label91.Text = "The Real Slim Shady";
            label91.ForeColor = Color.White;
            label91.BackColor = Color.FromArgb(18, 18, 18);
            label91.AutoSize = false;
            label91.Size = new Size(180, 20);
            label91.Location = new Point(110, 3230);

            Label label92 = new Label();
            label92.Font = gothamFont;
            label92.Text = "Eminem";
            label92.ForeColor = Color.White;
            label92.BackColor = Color.FromArgb(18, 18, 18);
            label92.AutoSize = false;
            label92.Size = new Size(180, 20);
            label92.Location = new Point(110, 3250);

            // C2-L10 --------------------------------------------------------------------------------

            PictureBox pictureBox47 = new PictureBox();
            pictureBox47.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/eminem.jpeg"); 
            pictureBox47.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox47.Size = new Size(180, 190); 
            pictureBox47.Location = new Point(350, 3030); 

            PictureBox like47 = new PictureBox();
            like47.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like47.SizeMode = PictureBoxSizeMode.StretchImage;
            like47.Size = new Size(50, 30);
            like47.Location = new Point(350, 3280);
            like47.Click += UpVotes_Click;
            Label contLikeC47 = new Label();
            contLikeC47.Font = gothamFont;
            contLikeC47.Text = "100";
            contLikeC47.ForeColor = Color.White;
            contLikeC47.AutoSize = false;
            contLikeC47.Size = new Size(50, 20);
            contLikeC47.Location = new Point(398, 3285);

            PictureBox dislike47 = new PictureBox();
            dislike47.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike47.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike47.Size = new Size(50, 30);
            dislike47.Location = new Point(450, 3280);
            dislike47.Click += DownVotes_Click;
            Label contDislikeC47 = new Label();
            contDislikeC47.Font = gothamFont;
            contDislikeC47.Text = "0";
            contDislikeC47.ForeColor = Color.White;
            contDislikeC47.AutoSize = false;
            contDislikeC47.Size = new Size(50, 20);
            contDislikeC47.Location = new Point(498, 3285);
            
            Label label93 = new Label();
            label93.Font = gothamFont;
            label93.Text = "Superman";
            label93.ForeColor = Color.White;
            label93.BackColor = Color.FromArgb(18, 18, 18);
            label93.AutoSize = false;
            label93.Size = new Size(180, 20);
            label93.Location = new Point(350, 3230);

            Label label94 = new Label();
            label94.Font = gothamFont;
            label94.Text = "Eminem";
            label94.ForeColor = Color.White;
            label94.BackColor = Color.FromArgb(18, 18, 18);
            label94.AutoSize = false;
            label94.Size = new Size(180, 20);
            label94.Location = new Point(350, 3250);

            //C3-L9 --------------------------------------------------------------------------------

            PictureBox pictureBox48 = new PictureBox();
            pictureBox48.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/eminem.jpeg"); 
            pictureBox48.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox48.Size = new Size(180, 190); 
            pictureBox48.Location = new Point(590, 3030); 

            PictureBox like48 = new PictureBox();
            like48.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like48.SizeMode = PictureBoxSizeMode.StretchImage;
            like48.Size = new Size(50, 30);
            like48.Location = new Point(590, 3280);
            like48.Click += UpVotes_Click;
            Label contLikeC48 = new Label();
            contLikeC48.Font = gothamFont;
            contLikeC48.Text = "0";
            contLikeC48.ForeColor = Color.White;
            contLikeC48.AutoSize = false;
            contLikeC48.Size = new Size(50, 20);
            contLikeC48.Location = new Point(638, 3285);
            
            PictureBox dislike48 = new PictureBox();
            dislike48.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike48.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike48.Size = new Size(50, 30);
            dislike48.Location = new Point(690, 3280);
            dislike48.Click += DownVotes_Click;
            Label contDislikeC48 = new Label();
            contDislikeC48.Font = gothamFont;
            contDislikeC48.Text = "0";
            contDislikeC48.ForeColor = Color.White;
            contDislikeC48.AutoSize = false;
            contDislikeC48.Size = new Size(50, 20);
            contDislikeC48.Location = new Point(738, 3285);
            
            Label label95 = new Label();
            label95.Font = gothamFont;
            label95.Text = "Godzilla";
            label95.ForeColor = Color.White;
            label95.BackColor = Color.FromArgb(18, 18, 18);
            label95.AutoSize = false;
            label95.Size = new Size(180, 20);
            label95.Location = new Point(590, 3230);

            Label label96 = new Label();
            label96.Font = gothamFont;
            label96.Text = "Eminem";
            label96.ForeColor = Color.White;
            label96.BackColor = Color.FromArgb(18, 18, 18);
            label96.AutoSize = false;
            label96.Size = new Size(180, 20);
            label96.Location = new Point(590, 3250);

            //C4-L10 --------------------------------------------------------------------------------

            PictureBox pictureBox49 = new PictureBox();
            pictureBox49.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/eminem.jpeg"); 
            pictureBox49.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox49.Size = new Size(180, 190); 
            pictureBox49.Location = new Point(830, 3030); 

            PictureBox like49 = new PictureBox();
            like49.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/laik.png");
            like49.SizeMode = PictureBoxSizeMode.StretchImage;
            like49.Size = new Size(50, 30);
            like49.Location = new Point(830, 3280);
            like49.Click += UpVotes_Click;
            Label contLikeC49 = new Label();
            contLikeC49.Font = gothamFont;
            contLikeC49.Text = "0";
            contLikeC49.ForeColor = Color.White;
            contLikeC49.AutoSize = false;
            contLikeC49.Size = new Size(50, 20);
            contLikeC49.Location = new Point(878, 3285);

            PictureBox dislike49 = new PictureBox();
            dislike49.Image = Image.FromFile("C:/Users/benav/IdeaProjects/CommunityPlayer/Cliente/imgs/dislaik.png");
            dislike49.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike49.Size = new Size(50, 30);
            dislike49.Location = new Point(930, 3280);
            dislike49.Click += DownVotes_Click;
            Label contDislikeC49 = new Label();
            contDislikeC49.Font = gothamFont;
            contDislikeC49.Text = "0";
            contDislikeC49.ForeColor = Color.White;
            contDislikeC49.AutoSize = false;
            contDislikeC49.Size = new Size(50, 20);
            contDislikeC49.Location = new Point(978, 3285);
            
            Label label97 = new Label();
            label97.Font = gothamFont;
            label97.Text = "Love The Way You Lie";
            label97.ForeColor = Color.White;
            label97.BackColor = Color.FromArgb(18, 18, 18);
            label97.AutoSize = false;
            label97.Size = new Size(180, 20);
            label97.Location = new Point(830, 3230);

            Label label98 = new Label();
            label98.Font = gothamFont;
            label98.Text = "Eminem";
            label98.ForeColor = Color.White;
            label98.BackColor = Color.FromArgb(18, 18, 18);
            label98.AutoSize = false;
            label98.Size = new Size(180, 20);
            label98.Location = new Point(830, 3250);

            scrollPane.Controls.Add(like46);
            scrollPane.Controls.Add(dislike46);
            scrollPane.Controls.Add(like47);
            scrollPane.Controls.Add(dislike47);
            scrollPane.Controls.Add(like48);
            scrollPane.Controls.Add(dislike48);
            scrollPane.Controls.Add(like49);
            scrollPane.Controls.Add(dislike49);
            scrollPane.Controls.Add(pictureBox46);
            scrollPane.Controls.Add(pictureBox47);
            scrollPane.Controls.Add(pictureBox48);
            scrollPane.Controls.Add(pictureBox49);
            scrollPane.Controls.Add(contLikeC46);
            scrollPane.Controls.Add(contDislikeC46);
            scrollPane.Controls.Add(contLikeC47);
            scrollPane.Controls.Add(contDislikeC47);
            scrollPane.Controls.Add(contLikeC48);
            scrollPane.Controls.Add(contDislikeC48);
            scrollPane.Controls.Add(contLikeC49);
            scrollPane.Controls.Add(contDislikeC49);
            scrollPane.Controls.Add(label91);
            scrollPane.Controls.Add(label92);
            scrollPane.Controls.Add(label93);
            scrollPane.Controls.Add(label94);
            scrollPane.Controls.Add(label95);
            scrollPane.Controls.Add(label96);
            scrollPane.Controls.Add(label97);
            scrollPane.Controls.Add(label98);
            /*//artist2
            for (int i = 0; i < 7; i++)
            {
                Panel songPanelLine2 = new Panel();
                songPanelLine2.BackColor = Color.FromArgb(18, 18, 18);; 
                songPanelLine2.Size = new Size(210, 250); 
                songPanelLine2.Location = new Point(285, 285 * i); 
                scrollPane.Controls.Add(songPanelLine2); 
            }*/
            
            //artist3
            /*for (int i = 0; i < 7; i++)
            {
                Panel songPanelLine3 = new Panel();
                songPanelLine3.BackColor = Color.FromArgb(18, 18, 18);; 
                songPanelLine3.Size = new Size(210, 250); 
                songPanelLine3.Location = new Point(520, 285 * i); 
                scrollPane.Controls.Add(songPanelLine3); 
            }
            
            //artist4
            for (int i = 0; i < 7; i++)
            {
                Panel songPanelLine4 = new Panel();
                songPanelLine4.BackColor = Color.FromArgb(18, 18, 18);; 
                songPanelLine4.Size = new Size(210, 250); 
                songPanelLine4.Location = new Point(760, 285 * i); 
                scrollPane.Controls.Add(songPanelLine4); 
            }

            //artis5
            for (int i = 0; i < 7; i++)
            {
                Panel songPanelLine5 = new Panel();
                songPanelLine5.BackColor = Color.FromArgb(18, 18, 18);; 
                songPanelLine5.Size = new Size(210, 250); 
                songPanelLine5.Location = new Point(995, 285 * i); 
                scrollPane.Controls.Add(songPanelLine5); 
            }

            //artist6
            for (int i = 0; i < 7; i++)
            {
                Panel songPanelLine6 = new Panel();
                songPanelLine6.BackColor = Color.FromArgb(18, 18, 18);; 
                songPanelLine6.Size = new Size(210, 250); 
                songPanelLine6.Location = new Point(995, 285 * i); 
                scrollPane.Controls.Add(songPanelLine6); 
            }

            //artist7
            for (int i = 0; i < 7; i++)
            {
                Panel songPanelLine7 = new Panel();
                songPanelLine7.BackColor = Color.FromArgb(18, 18, 18);; 
                songPanelLine7.Size = new Size(210, 250); 
                songPanelLine7.Location = new Point(995, 285 * i); 
                scrollPane.Controls.Add(songPanelLine7); 
            }*/

            int scrollPaneWidth = (int)(screenWidth * 1);
            int scrollPaneHeight = (int) screenHeight - 60;
            
            scrollPane.Size = new System.Drawing.Size(scrollPaneWidth, scrollPaneHeight);
            scrollPane.Location = new System.Drawing.Point(0, 0);

            mainPanel.Size = new System.Drawing.Size(screenWidth, screenHeight);
            mainPanel.Controls.Add(scrollPane); 
            this.Controls.Add(mainPanel);
        }

        private void UpVotes_Click(object sender, EventArgs e)
            {
                // Acción a realizar cuando se haga clic en el PictureBox
                MessageBox.Show("zzzz");
            }

            private void DownVotes_Click(object sender, EventArgs e)
            {
                // Acción a realizar cuando se haga clic en el PictureBox
                MessageBox.Show("zzzz");
            }
    }
}
