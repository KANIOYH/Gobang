using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace 五子棋
{
    public partial class Gameing : Form
    {
        public Graphics myGra;
        Pen pen = new Pen(Color.Gray, 2);
        public Action game = new Action();
        int connectType = 0;
        Client client = null;
        Server server = null;
        public Gameing()
        {
            InitializeComponent();
            game.init();
            
        }
        public Gameing(Server server)
        {
            InitializeComponent();
            game.init();
            connectType = 1;
            this.server = server;
            link_l.Text = "Server命令提示";

        }
        public Gameing(Client client)
        {
            InitializeComponent();
            game.init();
            connectType = 2;
            this.client = client;
            link_l.Text = "Client命令提示";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            nowP.Text = "当前棋手 :白方";
            Graphics myGra = pad.CreateGraphics();
            int x = 15;
            int y = 15;
            myGra.DrawLine(new Pen(Color.Black, 10), 0, 0, 0, 600);
            myGra.DrawLine(new Pen(Color.Black, 10), 0, 0, 600, 0);
            myGra.DrawLine(new Pen(Color.Black, 5), 602, 0, 602, 602);
            myGra.DrawLine(new Pen(Color.Black, 5), 0, 600, 600, 600);
            for (int i = 0; i < 39; i++)
            {
                myGra.DrawLine(pen, x, 15, x, 585);
                myGra.DrawLine(pen, 15, y, 585, y);
                x += 15;
                y += 15;
            }
            if(connectType != 2)
            pad.MouseClick += pad_MouseClick;
        }
        public void msgdone(string msg)
        {           
            List<string> list = new List<string>(msg.Split(','));
            if (list[0] == "o")
            {               
                game.piece[Convert.ToInt32(list[1]) / 15, Convert.ToInt32(list[2]) / 15] = game.nowPlayer;
                Graphics myGra = pad.CreateGraphics();
                if (game.nowPlayer == -1)
                    myGra.FillEllipse(Brushes.Black, Convert.ToInt32(list[1]), Convert.ToInt32(list[2]), 14, 14);
                else
                    myGra.FillEllipse(Brushes.White, Convert.ToInt32(list[1]), Convert.ToInt32(list[2]), 14, 14);
                label1.Text = "落子完成，位置：" + Convert.ToInt32(list[1]) / 15 + "  "+ Convert.ToInt32(list[2]) / 15;
                game.playerChange(ref game.nowPlayer);
                pad.MouseClick += pad_MouseClick;
                if (game.isWin(game.nowPlayer))
                {
                    if (game.nowPlayer == 1)
                        MessageBox.Show("白方胜局！\n\n黑方败北");
                    else
                        MessageBox.Show("黑方胜局！\n\n白方败北");
                    pad.MouseClick -= pad_MouseClick;
                    this.Close();
                }
            }
        }
        private void pad_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics myGra = pad.CreateGraphics();
            string msg = "";
            float x = (float)(((int)(e.X / 15.0 + 0.5) * 15 ) -7);
            float y = (float)(((int)(e.Y / 15.0 + 0.5) * 15 ) - 7);

            if (myGra != null && game.piece[(int)x / 15, (int)y / 15] == 0)
            {
                System.Media.SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"down.wav";
                sp.Play();
                if (game.nowPlayer < 0)
                {
                    myGra.FillEllipse(Brushes.Black, x, y, 14, 14);
                    game.piece[(int)x / 15, (int)y / 15] = -1;
                    nowP.Text = "当前棋手 :白方";
                }
                else
                {
                    myGra.FillEllipse(Brushes.White, x, y, 14, 14);
                    game.piece[(int)x / 15, (int)y / 15] = 1;
                    nowP.Text = "当前棋手 :黑方";
                }
                if (game.isWin(game.nowPlayer))
                {
                    if(game.nowPlayer == 1)
                    MessageBox.Show("白方胜局！\n\n黑方败北" );
                    else
                    MessageBox.Show("黑方胜局！\n\n白方败北");
                    pad.MouseClick -= pad_MouseClick;
                    this.Close();
                }
                if(connectType != 0)
                pad.MouseClick -= pad_MouseClick;
                msg = "o," + x.ToString() +","+ y.ToString() + "," +  game.nowPlayer.ToString();
                game.playerChange(ref game.nowPlayer);
                label1.Text = "落子完成，位置：" + ((int)x / 15) + "  " + ((int)y / 15);
            }
            else 
            {
                label1.Text = "不能这么做，尝试落子位置：" + ((int)x / 15) +"  "+ ((int)y / 15) +"  "+ game.piece[(int)x / 15, (int)y / 15];
                msg = "error";
            }
            if(connectType == 1)
            {
                server.sendMsg(msg);
            }
            else if(connectType == 2)
            {
                client.sendMsg(msg);
            }
            
        }
    }
}
