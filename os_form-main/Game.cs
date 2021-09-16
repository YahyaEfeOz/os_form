using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os_form
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        RockGame rockgame = new RockGame();

        private void rock_click(object sender, EventArgs e)
        {
            messageLabel.Text = rockgame.StartGame(RockGameConstants.rock);
        }

        private void paper_Click(object sender, EventArgs e)
        {
            messageLabel.Text = rockgame.StartGame(RockGameConstants.paper);
        }

        private void sci_Click(object sender, EventArgs e)
        {
            messageLabel.Text = rockgame.StartGame(RockGameConstants.scissors);
        }

        private void messageLabel_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
