using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os_form
{
    static class RockGameConstants
    {
        public const string rock = "Taş";
        public const string paper = "Kağıt";
        public const string scissors = "Makas";
    }

    public class RockGame
    {
        public string StartGame(string hand)
        {
            Random random = new Random();
            string[] handList = { RockGameConstants.rock, RockGameConstants.paper, RockGameConstants.scissors };

            int botHandIndex = random.Next(0, 3);
            string message = "Seçiminiz:" + hand + "\n" + "Bilgisayarın seçimi:" + handList[botHandIndex] + "\n";

            if (hand == handList[botHandIndex])
            {
                message += "\nBerabere";
            }
            else if (IsWin(hand, handList[botHandIndex]))
            {
                message += "\n Kazandınız";
            }
            else
            {
                message += "\n Kaybettiniz";
            }
            return message;
        }

        private bool IsWin(string player, string bot)
        {
            return (player == RockGameConstants.rock && bot == RockGameConstants.scissors) ||
                   (player == RockGameConstants.paper && bot == RockGameConstants.rock) || 
                   (player == RockGameConstants.scissors && bot == RockGameConstants.paper);
        }
    }
}
