﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo
{
    public partial class Game : Form
    {

        public PlayerSelection ps;
        Piesa piesa;
        public PictureBox[] pictureBoxs = new PictureBox[53];
        int i = 1;
        Random rand = new Random();
        int r;
        public Game(PlayerSelection playerSelection)
        {

            InitializeComponent();
            ps = playerSelection;

            InitializeazaTabla();


            piesa = new Piesa();

            piesa.PunePieselePeTabla(this);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ps.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int j = 1;
            picBoxYellow1.ImageLocation = null;
            pictureBoxs[1].ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Yellow1.png";
            pictureBoxs[1].SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            r = rand.Next(1, 7);
            button2.Text = r.ToString();

            pictureBoxs[i].ImageLocation = null;
            pictureBoxs[i = i + r].ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Yellow1.png";
            pictureBoxs[i].SizeMode = PictureBoxSizeMode.StretchImage;

        }


        public void InitializeazaTabla()
        {

            pictureBoxs[1] = pictureBox1; pictureBoxs[2] = pictureBox2; pictureBoxs[3] = pictureBox3;
            pictureBoxs[4] = pictureBox4; pictureBoxs[5] = pictureBox5; pictureBoxs[6] = pictureBox6;
            pictureBoxs[7] = pictureBox7; pictureBoxs[8] = pictureBox8; pictureBoxs[9] = pictureBox9;
            pictureBoxs[10] = pictureBox10; pictureBoxs[11] = pictureBox11; pictureBoxs[12] = pictureBox12;

            pictureBoxs[13] = pictureBox13; pictureBoxs[14] = pictureBox14; pictureBoxs[15] = pictureBox15;
            pictureBoxs[16] = pictureBox16; pictureBoxs[17] = pictureBox17; pictureBoxs[18] = pictureBox18;
            pictureBoxs[19] = pictureBox19; pictureBoxs[20] = pictureBox20; pictureBoxs[21] = pictureBox21;
            pictureBoxs[22] = pictureBox22; pictureBoxs[23] = pictureBox23; pictureBoxs[24] = pictureBox24;

            pictureBoxs[25] = pictureBox25; pictureBoxs[26] = pictureBox26; pictureBoxs[27] = pictureBox27;
            pictureBoxs[28] = pictureBox28; pictureBoxs[29] = pictureBox29; pictureBoxs[30] = pictureBox30;
            pictureBoxs[31] = pictureBox31; pictureBoxs[32] = pictureBox32; pictureBoxs[33] = pictureBox33;
            pictureBoxs[34] = pictureBox34; pictureBoxs[35] = pictureBox35; pictureBoxs[36] = pictureBox36;

            pictureBoxs[37] = pictureBox37; pictureBoxs[38] = pictureBox38; pictureBoxs[39] = pictureBox39;
            pictureBoxs[40] = pictureBox40; pictureBoxs[41] = pictureBox41; pictureBoxs[42] = pictureBox42;
            pictureBoxs[43] = pictureBox43; pictureBoxs[44] = pictureBox44; pictureBoxs[45] = pictureBox45;
            pictureBoxs[46] = pictureBox46; pictureBoxs[47] = pictureBox47; pictureBoxs[48] = pictureBox48;

            pictureBoxs[49] = pictureBox49; pictureBoxs[50] = pictureBox50; pictureBoxs[51] = pictureBox51;
            pictureBoxs[52] = pictureBox52;

        }
    }
}
