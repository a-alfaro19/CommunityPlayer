using System;
using System.Drawing;
using System.Net.Sockets;
using System.Reflection;
using System.Windows.Forms;

namespace ClientGUI
{
    public partial class MainForm : Form
    {
        private Panel scrollPane;
        private int[] likesCount;
        private int[] dislikesCount;

        private int serverPort;
        private TcpClient client;
        private StreamWriter writer;

        private 

        public MainForm(int serverPort)
        {
            this.serverPort = serverPort;
            // InitializeComponent();
            InitializeContent();
            
        }

        private void ConnectToServer() {
            try {
                client = new TcpClient("localhost", serverPort);
                writer = new StreamWriter(client.GetStream());
                new Thread(ReceiveMessages).Start();

            } catch (Exception ex) {
                MessageBox.Show("Error connecting to server: " + ex.Message);
            }
        }

        private void ReceiveMessages() {
            try {
                var reader = new StreamReader(client.GetStream());
                while (true)
                {
                    string message = reader.ReadLine();
                    if (message != null)
                    {
                        Invoke((Action)(() => textBoxReceivedMessages.AppendText(message + "\n")));
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error receiving messages: " + ex.Message);
            }
        }

        private void InitializeContent()
        {
            int screenWidth = 1350;
            int screenHeight = 800;

            likesCount = new int[49];
            dislikesCount = new int[49]; 

            Panel mainPanel = new Panel();
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.BackColor = Color.FromArgb(2, 2, 2);

            scrollPane = new Panel();
            scrollPane.AutoScroll = true;
            scrollPane.BackColor = Color.FromArgb(4, 4, 4);

            Font gothamFont = new Font("Gotham", 12, FontStyle.Bold);

            // Line 1
            addControllers(Path.GetFullPath(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\badbunny.jpeg"), "Bad Bunny", "La Santa", 110, 60, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\badbunny.jpeg", "Bad Bunny", "LOS PITS", 350, 60, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\badbunny.jpeg", "Bad Bunny", "MONACO", 590, 60, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\badbunny.jpeg", "Bad Bunny", "Ojitos Lindos", 830, 60, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\badbunny.jpeg", "Bad Bunny", "P FKN R", 1070, 60, scrollPane, gothamFont, 0);
            // Line 2
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\badbunny.jpeg", "Bad Bunny", "Tití Me Preguntó", 110, 390, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\badbunny.jpeg", "Bad Bunny", "un x100to", 350, 390, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\ed.jpeg", "Ed Sheeran", "Bad Habits", 590, 390, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\ed.jpeg", "Ed Sheeran", "Happier", 830, 390, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\ed.jpeg", "Ed Sheeran", "Perfect", 1070, 390, scrollPane, gothamFont, 0);
            //Line 3
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\ed.jpeg", "Ed Sheeran", "Photograph", 110, 720, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\ed.jpeg", "Ed Sheeran", "Shape of You", 350, 720, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\ed.jpeg", "Ed Sheeran", "Shivers", 590, 720, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\ed.jpeg", "Ed Sheeran", "Thinking Out Loud", 830, 720, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\frank.jpeg", "Frank Ocean", "Chanel", 1070, 720, scrollPane, gothamFont, 0);
            //Line 4
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\frank.jpeg", "Frank Ocean", "In My Room", 110, 1050, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\frank.jpeg", "Frank Ocean", "Ivy", 350, 1050, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\frank.jpeg", "Frank Ocean", "Lost", 590, 1050, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\frank.jpeg", "Frank Ocean", "Novacane", 830, 1050, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\frank.jpeg", "Frank Ocean", "Pink + White", 1070, 1050, scrollPane, gothamFont, 0);
            //Line 5
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\frank.jpeg", "Frank Ocean", "White Ferrari", 110, 1380, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\abel.jpeg", "The Weeknd", "Blinding Lights", 350, 1380, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\abel.jpeg", "The Weeknd", "Call Out My Name", 590, 1380, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\abel.jpeg", "The Weeknd", "Die For You", 830, 1380, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\abel.jpeg", "The Weeknd", "I Fell It Coming", 1070, 1380, scrollPane, gothamFont, 0);
            //Line 6
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\abel.jpeg", "The Weeknd", "Popular", 110, 1710, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\abel.jpeg", "The Weeknd", "Starboy", 350, 1710, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\abel.jpeg", "The Weeknd", "True Colors", 590, 1710, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\joji.jpeg", "Joji", "Feeling Like The End", 830, 1710, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\joji.jpeg", "Joji", "Glimpse of Us", 1070, 1710, scrollPane, gothamFont, 0);
            //Line 7
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\joji.jpeg", "Joji", "Sanctuary", 110, 2040, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\joji.jpeg", "Joji", "SLOW DANCING IN THE DARK", 350, 2040, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\joji.jpeg", "Joji", "TEST DRIVE", 590, 2040, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\joji.jpeg", "Joji", "worldstar money", 830, 2040, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\joji.jpeg", "Joji", "YEAH RIGHT", 1070, 2040, scrollPane, gothamFont, 0);
            //Line 8
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\traviesoscott.jpeg", "Travis Scott", "CAROUSEL", 110, 2370, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\traviesoscott.jpeg", "Travis Scott", "goosebumps", 350, 2370, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\traviesoscott.jpeg", "Travis Scott", "MELTDOWN", 590, 2370, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\traviesoscott.jpeg", "Travis Scott", "MY EYES", 830, 2370, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\traviesoscott.jpeg", "Travis Scott", "pick up the phone", 1070, 2370, scrollPane, gothamFont, 0);
            //Line 9
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\traviesoscott.jpeg", "Travis Scott", "sdp interlude", 110, 2700, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\traviesoscott.jpeg", "Travis Scott", "STARGAZING", 350, 2700, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\eminem.jpeg", "Eminem", "Godzilla", 590, 2700, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\eminem.jpeg", "Eminem", "Lose Yourself", 830, 2700, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\eminem.jpeg", "Eminem", "Love The Way You Lie", 1070, 2700, scrollPane, gothamFont, 0);
            //Line 10 
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\eminem.jpeg", "Eminem", "Mockingbird", 110, 3030, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\eminem.jpeg", "Eminem", "Superman", 350, 3030, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\eminem.jpeg", "Eminem", "The Real Slim Shady", 590, 3030, scrollPane, gothamFont, 0);
            addControllers(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\eminem.jpeg", "Eminem", "Without Me", 830, 3030, scrollPane, gothamFont, 0);

            mainPanel.Controls.Add(scrollPane);
            this.Controls.Add(mainPanel);

            int scrollPaneWidth = (int)(screenWidth * 1);
            int scrollPaneHeight = (int)screenHeight - 60;

            scrollPane.Size = new Size(scrollPaneWidth, scrollPaneHeight);
            scrollPane.Location = new Point(0, 0);
            mainPanel.Size = new Size(screenWidth, screenHeight);
        }

        private void addControllers(string imagePath, string artist, string song, int x, int y, Panel scrollPane, Font font, int index)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(imagePath);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(180, 190);
            pictureBox.Location = new Point(x, y);

            PictureBox like = new PictureBox();
            like.Image = Image.FromFile(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\laik.png");
            like.SizeMode = PictureBoxSizeMode.StretchImage;
            like.Size = new Size(50, 30);
            like.Location = new Point(x, y + 250);
            //like label
            Label contLike = new Label();
            contLike.Name = "contLike" + index;
            contLike.Font = font;
            contLike.Text = likesCount[index].ToString();
            contLike.ForeColor = Color.White;
            contLike.AutoSize = false;
            contLike.Size = new Size(50, 20);
            contLike.Location = new Point(x + 50, y + 255);
            like.Click += (sender, e) => UpVotes_Click(sender, e, contLike);

            PictureBox dislike = new PictureBox();
            dislike.Image = Image.FromFile(@"C:\Users\andre\OneDrive\Documents\GitHub\CommunityPlayer\Cliente\imgs\dislaik.png");
            dislike.SizeMode = PictureBoxSizeMode.StretchImage;
            dislike.Size = new Size(50, 30);
            dislike.Location = new Point(x + 90, y + 250);
            //dislike label
            Label contDislike = new Label();
            contDislike.Name = "contDislike" + index; 
            contDislike.Font = font;
            contDislike.Text = dislikesCount[index].ToString();
            contDislike.ForeColor = Color.White;
            contDislike.AutoSize = false;
            contDislike.Size = new Size(50, 20);
            contDislike.Location = new Point(x + 140, y + 255);
            dislike.Click += (sender, e) => DownVotes_Click(sender, e, contDislike);

            Label labelArtist = new Label();
            labelArtist.Font = font;
            labelArtist.Text = artist;
            labelArtist.ForeColor = Color.White;
            labelArtist.BackColor = Color.FromArgb(18, 18, 18);
            labelArtist.AutoSize = false;
            labelArtist.Size = new Size(180, 20);
            labelArtist.Location = new Point(x, y + 200);

            Label labelSong = new Label();
            labelSong.Font = font;
            labelSong.Text = song;
            labelSong.ForeColor = Color.White;
            labelSong.BackColor = Color.FromArgb(18, 18, 18);
            labelSong.AutoSize = false;
            labelSong.Size = new Size(180, 20);
            labelSong.Location = new Point(x, y + 220);

            scrollPane.Controls.Add(pictureBox);
            scrollPane.Controls.Add(like);
            scrollPane.Controls.Add(dislike);
            scrollPane.Controls.Add(contLike);
            scrollPane.Controls.Add(contDislike);
            scrollPane.Controls.Add(labelArtist);
            scrollPane.Controls.Add(labelSong);
        }

        private void UpVotes_Click(object sender, EventArgs e, Label contLike)
        {
            PictureBox upVoteButton = (PictureBox)sender;
            contLike.Text = (int.Parse(contLike.Text) + 1).ToString();
        }

        private void DownVotes_Click(object sender, EventArgs e, Label contDislike)
        {
            PictureBox downVoteButton = (PictureBox)sender;
            contDislike.Text = (int.Parse(contDislike.Text) + 1).ToString();
        }

        private void updateCounts()
        {
            for (int i = 0; i < likesCount.Length; i++)
            {
                Control[] likeLabels = scrollPane.Controls.Find("contLike" + i, true); 
                Control[] dislikeLabels = scrollPane.Controls.Find("contDislike" + i, true); 
                
                foreach (Label likeLabel in likeLabels)
                {
                    likeLabel.Text = likesCount[i].ToString();
                }

                foreach (Label dislikeLabel in dislikeLabels)
                {
                    dislikeLabel.Text = dislikesCount[i].ToString();
                }
            }
        }
    }
}
