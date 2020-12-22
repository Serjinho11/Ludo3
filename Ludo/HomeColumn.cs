using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo
{
    class HomeColumn : Board
    {
        public PictureBox[] picBaseBox = new PictureBox[21];

        public HomeColumn() { }

        public void HomeCulomnInitialization(Game game)
        {

            picBaseBox[1] = game.picBaseBox1; picBaseBox[2] = game.picBaseBox2; picBaseBox[3] = game.picBaseBox3;
            picBaseBox[4] = game.picBaseBox4; picBaseBox[5] = game.picBaseBox5; picBaseBox[6] = game.picBaseBox6;
            picBaseBox[7] = game.picBaseBox7; picBaseBox[8] = game.picBaseBox8; picBaseBox[9] = game.picBaseBox9;
            picBaseBox[10] = game.picBaseBox10; picBaseBox[11] = game.picBaseBox11; picBaseBox[12] = game.picBaseBox12;
            picBaseBox[13] = game.picBaseBox13; picBaseBox[14] = game.picBaseBox14; picBaseBox[15] = game.picBaseBox15;
            picBaseBox[16] = game.picBaseBox16; picBaseBox[17] = game.picBaseBox17; picBaseBox[18] = game.picBaseBox18;
            picBaseBox[19] = game.picBaseBox19; picBaseBox[20] = game.picBaseBox20;
        }


    }
}
