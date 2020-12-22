using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo
{
    class Road : Board
    {
        public PictureBox[] pictureBoxs = new PictureBox[53];



        public Road() { }

        public void RoadInitialization(Game game)
        {

            pictureBoxs[1] = game.pictureBox1; pictureBoxs[2] = game.pictureBox2; pictureBoxs[3] = game.pictureBox3;
            pictureBoxs[4] = game.pictureBox4; pictureBoxs[5] = game.pictureBox5; pictureBoxs[6] = game.pictureBox6;
            pictureBoxs[7] = game.pictureBox7; pictureBoxs[8] = game.pictureBox8; pictureBoxs[9] = game.pictureBox9;
            pictureBoxs[10] = game.pictureBox10; pictureBoxs[11] = game.pictureBox11; pictureBoxs[12] = game.pictureBox12;

            pictureBoxs[13] = game.pictureBox13; pictureBoxs[14] = game.pictureBox14; pictureBoxs[15] = game.pictureBox15;
            pictureBoxs[16] = game.pictureBox16; pictureBoxs[17] = game.pictureBox17; pictureBoxs[18] = game.pictureBox18;
            pictureBoxs[19] = game.pictureBox19; pictureBoxs[20] = game.pictureBox20; pictureBoxs[21] = game.pictureBox21;
            pictureBoxs[22] = game.pictureBox22; pictureBoxs[23] = game.pictureBox23; pictureBoxs[24] = game.pictureBox24;

            pictureBoxs[25] = game.pictureBox25; pictureBoxs[26] = game.pictureBox26; pictureBoxs[27] = game.pictureBox27;
            pictureBoxs[28] = game.pictureBox28; pictureBoxs[29] = game.pictureBox29; pictureBoxs[30] = game.pictureBox30;
            pictureBoxs[31] = game.pictureBox31; pictureBoxs[32] = game.pictureBox32; pictureBoxs[33] = game.pictureBox33;
            pictureBoxs[34] = game.pictureBox34; pictureBoxs[35] = game.pictureBox35; pictureBoxs[36] = game.pictureBox36;

            pictureBoxs[37] = game.pictureBox37; pictureBoxs[38] = game.pictureBox38; pictureBoxs[39] = game.pictureBox39;
            pictureBoxs[40] = game.pictureBox40; pictureBoxs[41] = game.pictureBox41; pictureBoxs[42] = game.pictureBox42;
            pictureBoxs[43] = game.pictureBox43; pictureBoxs[44] = game.pictureBox44; pictureBoxs[45] = game.pictureBox45;
            pictureBoxs[46] = game.pictureBox46; pictureBoxs[47] = game.pictureBox47; pictureBoxs[48] = game.pictureBox48;

            pictureBoxs[49] = game.pictureBox49; pictureBoxs[50] = game.pictureBox50; pictureBoxs[51] = game.pictureBox51;
            pictureBoxs[52] = game.pictureBox52;

        }
    }
}
