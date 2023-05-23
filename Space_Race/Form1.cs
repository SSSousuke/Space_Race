using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Race
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string game = "start";
        string result;
        int startCount = 0;
        int stopValue;
        int gameCount = 0;
        int bomb1Count = 0;
        int bomb2Count = 0;
        Random randGen = new Random();
        int randValue;

        //Player
        int playerSpeed = 5;
        int player1Score = 0;
        int player2Score = 0;
        int player1X = 163;
        int player1Y = 480;
        int player2X = 513;
        int player2Y = 480;
        SolidBrush whiteBrush = new SolidBrush(Color.FromArgb(233,230,225));
        SolidBrush grayBrush = new SolidBrush(Color.FromArgb(140, 155, 187));
        SolidBrush blackBrush = new SolidBrush(Color.FromArgb(92, 92, 92));
        SolidBrush redBrush = new SolidBrush(Color.FromArgb(228, 59, 70));
        SolidBrush darkredBrush = new SolidBrush(Color.FromArgb(164, 38, 52));
        SolidBrush blueBrush = new SolidBrush(Color.FromArgb(140, 151, 220));
        SolidBrush darkblueBrush = new SolidBrush(Color.FromArgb(57, 75, 185));
        SolidBrush skyblueBrush = new SolidBrush(Color.FromArgb(30, 169, 180));
        SolidBrush lightskyblueBrush = new SolidBrush(Color.FromArgb(98, 219, 228));
        SolidBrush whiteblueBrush = new SolidBrush(Color.FromArgb(199, 242, 245));
        SolidBrush transparentBrush = new SolidBrush(Color.Transparent);

        //fire
        string player1fire = "false";
        string player2fire = "false";
        SolidBrush orangeBrush = new SolidBrush(Color.FromArgb(249, 118, 34));
        SolidBrush yellowBrush = new SolidBrush(Color.FromArgb(244, 176, 51));
        SolidBrush lightyellowBrush = new SolidBrush(Color.FromArgb(255, 233, 96));

        //bar
        int barY = 0;

        //Gemic
        List<Rectangle> gemic1list = new List<Rectangle>();
        List<Rectangle> gemic2list = new List<Rectangle>();
        int gemicSpeed = 5;

        //Sound
        SoundPlayer bomb = new SoundPlayer(Properties.Resources.bombSound);
        SoundPlayer point = new SoundPlayer(Properties.Resources.point);
        SoundPlayer rocket = new SoundPlayer(Properties.Resources.playerSound);
        SoundPlayer clear = new SoundPlayer(Properties.Resources.gameclear);

        //Key
        bool player1Up = false;
        bool player1Down = false;
        bool player2Up = false;
        bool player2Down = false;
        bool start = false;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Playerhitbox
            Rectangle player1hitbox = new Rectangle(player1X + 6, player1Y - 32, 14, 35);
            Rectangle player2hitbox = new Rectangle(player2X + 6, player2Y - 32, 14, 35);

            //Player1
            Rectangle player1a = new Rectangle(player1X, player1Y, 2, 12);
            Rectangle player1b = new Rectangle(player1X+2, player1Y-3, 2, 12);
            Rectangle player1c = new Rectangle(player1X+4, player1Y-6, 2, 12);
            Rectangle player1d = new Rectangle(player1X + 6, player1Y - 26, 2, 30);
            Rectangle player1e = new Rectangle(player1X + 8, player1Y - 29, 2, 33);
            Rectangle player1f = new Rectangle(player1X + 10, player1Y - 32, 2, 36);
            Rectangle player1g = new Rectangle(player1X + 12, player1Y - 32, 2, 36);
            Rectangle player1h = new Rectangle(player1X + 14, player1Y - 32, 2, 36);
            Rectangle player1i = new Rectangle(player1X + 16, player1Y - 29, 2, 33);
            Rectangle player1j = new Rectangle(player1X + 18, player1Y - 26, 2, 30);
            Rectangle player1k = new Rectangle(player1X + 20, player1Y - 6, 2, 12);
            Rectangle player1l = new Rectangle(player1X + 22, player1Y - 3, 2, 12);
            Rectangle player1m = new Rectangle(player1X + 24, player1Y, 2, 12);
            Rectangle player1n = new Rectangle(player1X + 8, player1Y + 4, 10, 3);
            Rectangle player1o = new Rectangle(player1X + 10, player1Y - 16, 6, 6);
            Rectangle player1p = new Rectangle(player1X + 8, player1Y - 18, 10, 10);
            //player1fire
            Rectangle player1q = new Rectangle(player1X + 8, player1Y + 7, 2, 15);
            Rectangle player1r = new Rectangle(player1X + 10, player1Y + 7, 2, 15);
            Rectangle player1s = new Rectangle(player1X + 12, player1Y + 7, 2, 15);
            Rectangle player1t = new Rectangle(player1X + 14, player1Y + 7, 2, 15);
            Rectangle player1u = new Rectangle(player1X + 16, player1Y + 7, 2, 15);

            //Player2
            Rectangle player2a = new Rectangle(player2X, player2Y, 2, 12);
            Rectangle player2b = new Rectangle(player2X + 2, player2Y - 3, 2, 12);
            Rectangle player2c = new Rectangle(player2X + 4, player2Y - 6, 2, 12);
            Rectangle player2d = new Rectangle(player2X + 6, player2Y - 26, 2, 30);
            Rectangle player2e = new Rectangle(player2X + 8, player2Y - 29, 2, 33);
            Rectangle player2f = new Rectangle(player2X + 10, player2Y - 32, 2, 36);
            Rectangle player2g = new Rectangle(player2X + 12, player2Y - 32, 2, 36);
            Rectangle player2h = new Rectangle(player2X + 14, player2Y - 32, 2, 36);
            Rectangle player2i = new Rectangle(player2X + 16, player2Y - 29, 2, 33);
            Rectangle player2j = new Rectangle(player2X + 18, player2Y - 26, 2, 30);
            Rectangle player2k = new Rectangle(player2X + 20, player2Y - 6, 2, 12);
            Rectangle player2l = new Rectangle(player2X + 22, player2Y - 3, 2, 12);
            Rectangle player2m = new Rectangle(player2X + 24, player2Y, 2, 12);
            Rectangle player2n = new Rectangle(player2X + 8, player2Y + 4, 10, 3);
            Rectangle player2o = new Rectangle(player2X + 10, player2Y - 16, 6, 6);
            Rectangle player2p = new Rectangle(player2X + 8, player2Y - 18, 10, 10);
            //player2fire
            Rectangle player2q = new Rectangle(player2X + 8, player2Y + 7, 2, 15);
            Rectangle player2r = new Rectangle(player2X + 10, player2Y + 7, 2, 15);
            Rectangle player2s = new Rectangle(player2X + 12, player2Y + 7, 2, 15);
            Rectangle player2t = new Rectangle(player2X + 14, player2Y + 7, 2, 15);
            Rectangle player2u = new Rectangle(player2X + 16, player2Y + 7, 2, 15);

            //Bar
            Rectangle bar = new Rectangle(345,barY,10,500);

            switch (game)
            {
                case "start":
                    break;
                case "startPre":
                    //Fillplayer1
                    e.Graphics.FillRectangle(redBrush, player1a);
                    e.Graphics.FillRectangle(darkredBrush, player1b);
                    e.Graphics.FillRectangle(darkredBrush, player1c);
                    e.Graphics.FillRectangle(whiteBrush, player1d);
                    e.Graphics.FillRectangle(whiteBrush, player1e);
                    e.Graphics.FillRectangle(whiteBrush, player1f);
                    e.Graphics.FillRectangle(whiteBrush, player1g);
                    e.Graphics.FillRectangle(whiteBrush, player1h);
                    e.Graphics.FillRectangle(whiteBrush, player1i);
                    e.Graphics.FillRectangle(whiteBrush, player1j);
                    e.Graphics.FillRectangle(darkredBrush, player1k);
                    e.Graphics.FillRectangle(darkredBrush, player1l);
                    e.Graphics.FillRectangle(redBrush, player1m);
                    e.Graphics.FillRectangle(blackBrush, player1n);
                    e.Graphics.FillEllipse(blackBrush, player1p);
                    e.Graphics.FillEllipse(grayBrush, player1o);

                    //Fillplayer2
                    e.Graphics.FillRectangle(blueBrush, player2a);
                    e.Graphics.FillRectangle(darkblueBrush, player2b);
                    e.Graphics.FillRectangle(darkblueBrush, player2c);
                    e.Graphics.FillRectangle(whiteBrush, player2d);
                    e.Graphics.FillRectangle(whiteBrush, player2e);
                    e.Graphics.FillRectangle(whiteBrush, player2f);
                    e.Graphics.FillRectangle(whiteBrush, player2g);
                    e.Graphics.FillRectangle(whiteBrush, player2h);
                    e.Graphics.FillRectangle(whiteBrush, player2i);
                    e.Graphics.FillRectangle(whiteBrush, player2j);
                    e.Graphics.FillRectangle(darkblueBrush, player2k);
                    e.Graphics.FillRectangle(darkblueBrush, player2l);
                    e.Graphics.FillRectangle(blueBrush, player2m);
                    e.Graphics.FillRectangle(blackBrush, player2n);
                    e.Graphics.FillEllipse(blackBrush, player2p);
                    e.Graphics.FillEllipse(grayBrush, player2o);

                    //Fill player1fire
                    e.Graphics.FillRectangle(orangeBrush, player1q.X, player1q.Y, player1q.Width, player1q.Height + 500);
                    e.Graphics.FillRectangle(yellowBrush, player1r.X, player1r.Y, player1r.Width, player1r.Height + 500);
                    e.Graphics.FillRectangle(lightyellowBrush, player1s.X, player1s.Y, player1s.Width, player1s.Height + 500);
                    e.Graphics.FillRectangle(yellowBrush, player1t.X, player1t.Y, player1t.Width, player1t.Height + 500);
                    e.Graphics.FillRectangle(orangeBrush, player1u.X, player1u.Y, player1u.Width, player1u.Height + 500);

                    //Fill player2fire
                    e.Graphics.FillRectangle(skyblueBrush, player2q.X, player2q.Y, player2q.Width, player2q.Height + 500);
                    e.Graphics.FillRectangle(lightskyblueBrush, player2r.X, player2r.Y, player2r.Width, player2r.Height + 500);
                    e.Graphics.FillRectangle(whiteblueBrush, player2s.X, player2s.Y, player2s.Width, player2s.Height + 500);
                    e.Graphics.FillRectangle(lightskyblueBrush, player2t.X, player2t.Y, player2t.Width, player2t.Height + 500);
                    e.Graphics.FillRectangle(skyblueBrush, player2u.X, player2u.Y, player2u.Width, player2u.Height + 500);
                    break;

                case "playing":
                    //Fillplayer1
                    e.Graphics.FillRectangle(redBrush, player1a);
                    e.Graphics.FillRectangle(darkredBrush, player1b);
                    e.Graphics.FillRectangle(darkredBrush, player1c);
                    e.Graphics.FillRectangle(whiteBrush, player1d);
                    e.Graphics.FillRectangle(whiteBrush, player1e);
                    e.Graphics.FillRectangle(whiteBrush, player1f);
                    e.Graphics.FillRectangle(whiteBrush, player1g);
                    e.Graphics.FillRectangle(whiteBrush, player1h);
                    e.Graphics.FillRectangle(whiteBrush, player1i);
                    e.Graphics.FillRectangle(whiteBrush, player1j);
                    e.Graphics.FillRectangle(darkredBrush, player1k);
                    e.Graphics.FillRectangle(darkredBrush, player1l);
                    e.Graphics.FillRectangle(redBrush, player1m);
                    e.Graphics.FillRectangle(blackBrush, player1n);
                    e.Graphics.FillEllipse(blackBrush, player1p);
                    e.Graphics.FillEllipse(grayBrush, player1o);

                    //Fillplayer2
                    e.Graphics.FillRectangle(blueBrush, player2a);
                    e.Graphics.FillRectangle(darkblueBrush, player2b);
                    e.Graphics.FillRectangle(darkblueBrush, player2c);
                    e.Graphics.FillRectangle(whiteBrush, player2d);
                    e.Graphics.FillRectangle(whiteBrush, player2e);
                    e.Graphics.FillRectangle(whiteBrush, player2f);
                    e.Graphics.FillRectangle(whiteBrush, player2g);
                    e.Graphics.FillRectangle(whiteBrush, player2h);
                    e.Graphics.FillRectangle(whiteBrush, player2i);
                    e.Graphics.FillRectangle(whiteBrush, player2j);
                    e.Graphics.FillRectangle(darkblueBrush, player2k);
                    e.Graphics.FillRectangle(darkblueBrush, player2l);
                    e.Graphics.FillRectangle(blueBrush, player2m);
                    e.Graphics.FillRectangle(blackBrush, player2n);
                    e.Graphics.FillEllipse(blackBrush, player2p);
                    e.Graphics.FillEllipse(grayBrush, player2o);

                    //Fillhitbox
                    e.Graphics.FillRectangle(transparentBrush, player1hitbox);
                    e.Graphics.FillRectangle(transparentBrush, player2hitbox);

                    //Fillbar
                    e.Graphics.FillRectangle(whiteBrush, bar);

                    //Fill player1fire
                    if (player1fire == "true")
                    {
                        e.Graphics.FillRectangle(orangeBrush, player1q);
                        e.Graphics.FillRectangle(yellowBrush, player1r);
                        e.Graphics.FillRectangle(lightyellowBrush, player1s);
                        e.Graphics.FillRectangle(yellowBrush, player1t);
                        e.Graphics.FillRectangle(orangeBrush, player1u);
                    }

                    //Fill player2fire
                    if (player2fire == "true")
                    {
                        e.Graphics.FillRectangle(skyblueBrush, player2q);
                        e.Graphics.FillRectangle(lightskyblueBrush, player2r);
                        e.Graphics.FillRectangle(whiteblueBrush, player2s);
                        e.Graphics.FillRectangle(lightskyblueBrush, player2t);
                        e.Graphics.FillRectangle(skyblueBrush, player2u);
                    }

                    //Gemic
                    for (int i = 0; i < gemic1list.Count; i++)
                    {
                        e.Graphics.FillRectangle(whiteBrush, gemic1list[i]);
                    }
                    for (int i = 0; i < gemic2list.Count; i++)
                    {
                        e.Graphics.FillRectangle(whiteBrush, gemic2list[i]);
                    }

                    break;
            }

            switch (result)
            {
                case "player1":
                    //Fillplayer1
                    e.Graphics.FillRectangle(redBrush, player1a);
                    e.Graphics.FillRectangle(darkredBrush, player1b);
                    e.Graphics.FillRectangle(darkredBrush, player1c);
                    e.Graphics.FillRectangle(whiteBrush, player1d);
                    e.Graphics.FillRectangle(whiteBrush, player1e);
                    e.Graphics.FillRectangle(whiteBrush, player1f);
                    e.Graphics.FillRectangle(whiteBrush, player1g);
                    e.Graphics.FillRectangle(whiteBrush, player1h);
                    e.Graphics.FillRectangle(whiteBrush, player1i);
                    e.Graphics.FillRectangle(whiteBrush, player1j);
                    e.Graphics.FillRectangle(darkredBrush, player1k);
                    e.Graphics.FillRectangle(darkredBrush, player1l);
                    e.Graphics.FillRectangle(redBrush, player1m);
                    e.Graphics.FillRectangle(blackBrush, player1n);
                    e.Graphics.FillEllipse(blackBrush, player1p);
                    e.Graphics.FillEllipse(grayBrush, player1o);

                    //Fillplayer1fire
                    e.Graphics.FillRectangle(orangeBrush, player1q.X, player1q.Y, player1q.Width, player1q.Height);
                    e.Graphics.FillRectangle(yellowBrush, player1r.X, player1r.Y, player1r.Width, player1r.Height);
                    e.Graphics.FillRectangle(lightyellowBrush, player1s.X, player1s.Y, player1s.Width, player1s.Height);
                    e.Graphics.FillRectangle(yellowBrush, player1t.X, player1t.Y, player1t.Width, player1t.Height);
                    e.Graphics.FillRectangle(orangeBrush, player1u.X, player1u.Y, player1u.Width, player1u.Height);
                    break;

                case "player2":
                    //Fillplayer2
                    e.Graphics.FillRectangle(blueBrush, player2a);
                    e.Graphics.FillRectangle(darkblueBrush, player2b);
                    e.Graphics.FillRectangle(darkblueBrush, player2c);
                    e.Graphics.FillRectangle(whiteBrush, player2d);
                    e.Graphics.FillRectangle(whiteBrush, player2e);
                    e.Graphics.FillRectangle(whiteBrush, player2f);
                    e.Graphics.FillRectangle(whiteBrush, player2g);
                    e.Graphics.FillRectangle(whiteBrush, player2h);
                    e.Graphics.FillRectangle(whiteBrush, player2i);
                    e.Graphics.FillRectangle(whiteBrush, player2j);
                    e.Graphics.FillRectangle(darkblueBrush, player2k);
                    e.Graphics.FillRectangle(darkblueBrush, player2l);
                    e.Graphics.FillRectangle(blueBrush, player2m);
                    e.Graphics.FillRectangle(blackBrush, player2n);
                    e.Graphics.FillEllipse(blackBrush, player2p);
                    e.Graphics.FillEllipse(grayBrush, player2o);

                    //Fill player2fire
                    e.Graphics.FillRectangle(skyblueBrush, player2q.X, player2q.Y, player2q.Width, player2q.Height);
                    e.Graphics.FillRectangle(lightskyblueBrush, player2r.X, player2r.Y, player2r.Width, player2r.Height);
                    e.Graphics.FillRectangle(whiteblueBrush, player2s.X, player2s.Y, player2s.Width, player2s.Height);
                    e.Graphics.FillRectangle(lightskyblueBrush, player2t.X, player2t.Y, player2t.Width, player2t.Height);
                    e.Graphics.FillRectangle(skyblueBrush, player2u.X, player2u.Y, player2u.Width, player2u.Height);
                    break;

                case "draw":
                    //Fillplayer1
                    e.Graphics.FillRectangle(redBrush, player1a);
                    e.Graphics.FillRectangle(darkredBrush, player1b);
                    e.Graphics.FillRectangle(darkredBrush, player1c);
                    e.Graphics.FillRectangle(whiteBrush, player1d);
                    e.Graphics.FillRectangle(whiteBrush, player1e);
                    e.Graphics.FillRectangle(whiteBrush, player1f);
                    e.Graphics.FillRectangle(whiteBrush, player1g);
                    e.Graphics.FillRectangle(whiteBrush, player1h);
                    e.Graphics.FillRectangle(whiteBrush, player1i);
                    e.Graphics.FillRectangle(whiteBrush, player1j);
                    e.Graphics.FillRectangle(darkredBrush, player1k);
                    e.Graphics.FillRectangle(darkredBrush, player1l);
                    e.Graphics.FillRectangle(redBrush, player1m);
                    e.Graphics.FillRectangle(blackBrush, player1n);
                    e.Graphics.FillEllipse(blackBrush, player1p);
                    e.Graphics.FillEllipse(grayBrush, player1o);

                    //Fillplayer2
                    e.Graphics.FillRectangle(blueBrush, player2a);
                    e.Graphics.FillRectangle(darkblueBrush, player2b);
                    e.Graphics.FillRectangle(darkblueBrush, player2c);
                    e.Graphics.FillRectangle(whiteBrush, player2d);
                    e.Graphics.FillRectangle(whiteBrush, player2e);
                    e.Graphics.FillRectangle(whiteBrush, player2f);
                    e.Graphics.FillRectangle(whiteBrush, player2g);
                    e.Graphics.FillRectangle(whiteBrush, player2h);
                    e.Graphics.FillRectangle(whiteBrush, player2i);
                    e.Graphics.FillRectangle(whiteBrush, player2j);
                    e.Graphics.FillRectangle(darkblueBrush, player2k);
                    e.Graphics.FillRectangle(darkblueBrush, player2l);
                    e.Graphics.FillRectangle(blueBrush, player2m);
                    e.Graphics.FillRectangle(blackBrush, player2n);
                    e.Graphics.FillEllipse(blackBrush, player2p);
                    e.Graphics.FillEllipse(grayBrush, player2o);

                    //Fill player1fire
                    e.Graphics.FillRectangle(orangeBrush, player1q.X, player1q.Y, player1q.Width, player1q.Height);
                    e.Graphics.FillRectangle(yellowBrush, player1r.X, player1r.Y, player1r.Width, player1r.Height);
                    e.Graphics.FillRectangle(lightyellowBrush, player1s.X, player1s.Y, player1s.Width, player1s.Height);
                    e.Graphics.FillRectangle(yellowBrush, player1t.X, player1t.Y, player1t.Width, player1t.Height);
                    e.Graphics.FillRectangle(orangeBrush, player1u.X, player1u.Y, player1u.Width, player1u.Height);

                    //Fill player2fire
                    e.Graphics.FillRectangle(skyblueBrush, player2q.X, player2q.Y, player2q.Width, player2q.Height);
                    e.Graphics.FillRectangle(lightskyblueBrush, player2r.X, player2r.Y, player2r.Width, player2r.Height);
                    e.Graphics.FillRectangle(whiteblueBrush, player2s.X, player2s.Y, player2s.Width, player2s.Height);
                    e.Graphics.FillRectangle(lightskyblueBrush, player2t.X, player2t.Y, player2t.Width, player2t.Height);
                    e.Graphics.FillRectangle(skyblueBrush, player2u.X, player2u.Y, player2u.Width, player2u.Height);
                    break;
            }


        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    player1Up = true;
                    break;
                case Keys.S:
                    player1Down = true;
                    break;
                case Keys.Up:
                    player2Up = true;
                    break;
                case Keys.Down:
                    player2Down = true;
                    break;
                case Keys.Space:
                    start = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    player1Up = false;
                    break;
                case Keys.S:
                    player1Down = false;
                    break;
                case Keys.Up:
                    player2Up = false;
                    break;
                case Keys.Down:
                    player2Down = false;
                    break;
                case Keys.Space:
                    start = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            switch (game)
            {
                case "start":
                    startCount++;
                    titleLabel.Visible = true;
                    titleLabel.Text = "Press “SPACE” to start the game";
                    if (start == true)
                    {
                        titleLabel.Visible = false;
                        player1X = 163;
                        player1Y = 480;
                        player2X = 513;
                        player2Y = 480;
                        startCount = 0;
                        game = "startPre";
                    }

                    if (startCount % 50 == 1)
                    {
                        stopValue = startCount;
                    }

                    if (startCount <= stopValue + 20)
                    {
                        titleLabel.Visible = false;
                    }
                    else
                    {
                        titleLabel.Visible = true;
                    }

                    Refresh();

                    break;

                case "startPre":
                    titleLabel.Visible = false;
                    if (player1Y == 480)
                    {
                        rocket.Play();
                    }
                    player1Y -= playerSpeed*2;
                    player2Y -= playerSpeed*2;

                    if (player1Y == 0)
                    {
                        player1Y = 480;
                        player2Y = 480;
                        this.BackgroundImage = Properties.Resources.playing_Image;
                        player1Label.Visible = true;
                        player2Label.Visible = true;
                        countTimer.Enabled = true;
                        game = "playing";
                    }
                    break;

                case "playing":
                    //MovePlayer
                    if (player1Up == true)
                    {
                        //rocket.Play();
                        player1Y -= playerSpeed;
                        player1fire = "true";
                    }
                    else
                    {
                        player1fire = "false";
                    }

                    if (player1Down == true && player1Y <= 480)
                    {
                        player1Y += playerSpeed;
                    }

                    if (player2Up == true)
                    {
                        //rocket.Play();
                        player2Y -= playerSpeed;
                        player2fire = "true";
                    }
                    else
                    {
                        player2fire = "false";
                    }

                    if (player2Down == true && player2Y <= 480)
                    {
                        player2Y += playerSpeed;
                    }

                    //If player intersect with topwall
                    if (player1Y == 0)
                    {
                        point.Play();
                        player1Score++;
                        player1Y = 480;
                        player2Y = 480;
                    }
                    else if (player2Y == 0)
                    {
                        point.Play();
                        player2Score++;
                        player1Y = 480;
                        player2Y = 480;
                    }

                    //Gemic
                    for (int i = 0; i < gemic1list.Count; i++)
                    {
                        int x = gemic1list[i].X + gemicSpeed;
                        gemic1list[i] = new Rectangle(x, gemic1list[i].Y, 20, 7);
                    }
                    for (int i = 0; i < gemic2list.Count; i++)
                    {
                        int x = gemic2list[i].X - gemicSpeed;
                        gemic2list[i] = new Rectangle(x, gemic2list[i].Y, 20, 7);
                    }

                    randValue = randGen.Next(1, 100);

                    if (randValue <= 10)
                    {
                        randValue = randGen.Next(30, 420);
                        Rectangle gemic1 = new Rectangle(0, randValue, 20, 7);
                        gemic1list.Add(gemic1);
                    }
                    else if (randValue <= 20)
                    {
                        randValue = randGen.Next(30, 420);
                        Rectangle gemic2 = new Rectangle(700, randValue, 20, 7);
                        gemic2list.Add(gemic2);
                    }

                    //If player intersect with gemic
                    Rectangle player1hitbox = new Rectangle(player1X + 6, player1Y - 36, 14, 40);
                    Rectangle player2hitbox = new Rectangle(player2X + 6, player2Y - 36, 14, 40);
                    for (int i = 0; i < gemic1list.Count; i++)
                    {
                        if (player1hitbox.IntersectsWith(gemic1list[i]))
                        {
                            player1bomb_Pic.Location = new Point(player1X,player1Y);
                            player1bomb_Pic.Visible = true;
                            bomb.Play();
                            player1Y = 1000;
                            player1bombTimer.Enabled = true;
                        }
                        if (player2hitbox.IntersectsWith(gemic1list[i]))
                        {
                            player2bomb_Pic.Location = new Point(player2X, player2Y);
                            player2bomb_Pic.Visible = true;
                            bomb.Play();
                            player2Y = 1000;
                            player2bombTimer.Enabled = true;
                        }
                    }
                    for (int i = 0; i < gemic2list.Count; i++)
                    {
                        if (player1hitbox.IntersectsWith(gemic2list[i]))
                        {
                            player1bomb_Pic.Location = new Point(player1X, player1Y);
                            player1bomb_Pic.Visible = true;
                            bomb.Play();
                            player1Y = 1000;
                            player1bombTimer.Enabled = true;
                        }
                        if (player2hitbox.IntersectsWith(gemic2list[i]))
                        {
                            player2bomb_Pic.Location = new Point(player2X, player2Y);
                            player2bomb_Pic.Visible = true;
                            bomb.Play();
                            player2Y = 1000;
                            player2bombTimer.Enabled = true;
                        }
                    }

                    player1Label.Text = $"{player1Score}";
                    player2Label.Text = $"{player2Score}";

                    break;

                case "end":
                    clear.Play();
                    titleLabel.Visible = true;
                    titleLabel.Text = "Play again?";
                    yesButton.Enabled = true;
                    noButton.Enabled = true;
                    yesButton.Visible = true;
                    noButton.Visible = true;
                    if (player1Score > player2Score)
                    {
                        this.BackgroundImage = Properties.Resources.player1win_Pic;
                        player1X = 340;
                        player1Y = 480;
                        game = "";
                        result = "player1";
                    }
                    else if (player1Score < player2Score)
                    {
                        this.BackgroundImage = Properties.Resources.player2win_Pic;
                        player2X = 340;
                        player2Y = 480;
                        game = "";
                        result = "player2";
                    }
                    else if (player1Score == player2Score)
                    {
                        this.BackgroundImage = Properties.Resources.draw_Pic;
                        player1X = 163;
                        player2X = 513;
                        player1Y = 480;
                        player2Y = 480;
                        game = "";
                        result = "draw";
                    }
                    break;
            }           

            switch (result)
            {
                case "player1":
                    player1Y -= playerSpeed * 2;
                    break;
                case "player2":
                    player2Y -= playerSpeed * 2;
                    break;
                case "draw":
                    player1Y -= playerSpeed * 2;
                    player2Y -= playerSpeed * 2;
                    break;
            }

            Refresh();
        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            gameCount++;
            barY += 4;
            
            if (gameCount == 126)
            {
                countTimer.Enabled = false;
                game = "end";
            }
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            yesButton.Enabled = false;
            noButton.Enabled = false;
            yesButton.Visible = false;
            noButton.Visible = false;
            player1Score = 0;
            player2Score = 0;
            player1Label.Text = "0";
            player2Label.Text = "0";
            this.BackgroundImage = Properties.Resources.menu_Image;
            gameCount = 0;
            barY = 0;
            countTimer.Enabled = true;
            game = "start";
            result = "";
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void player1bombTimer_Tick(object sender, EventArgs e)
        {
            bomb1Count++;
            if (bomb1Count == 3)
            {
                bomb1Count= 0;
                player1Y = 480;
                player1bomb_Pic.Visible = false;
                player1bombTimer.Enabled = false;
            }
        }

        private void player2bombTimer_Tick(object sender, EventArgs e)
        {
            bomb2Count++;
            if (bomb2Count == 3)
            {
                bomb2Count = 0;
                player2Y = 480;
                player2bomb_Pic.Visible = false;
                player2bombTimer.Enabled = false;
            }
        }
    }
}
