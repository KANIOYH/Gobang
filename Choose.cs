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
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void createGame_Click(object sender, EventArgs e)
        {
            Server a = new Server();
            a.Show();
        }

        private void joinGame_Click(object sender, EventArgs e)
        {
            Client b = new Client();
            b.Show();
        }
    }
}
