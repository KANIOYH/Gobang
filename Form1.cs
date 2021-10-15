using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 五子棋
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gameing game = new Gameing();//text1
            game.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Choose choose = new Choose();
            choose.Show();
        }
    }
}
