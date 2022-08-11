using System;
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
    }
}
