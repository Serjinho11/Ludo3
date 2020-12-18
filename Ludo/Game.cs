using System;
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
        Player piesa;
        public PictureBox[] pictureBoxs = new PictureBox[12];


        public Game(PlayerSelection playerSelection)
        {
            ps = playerSelection;
            InitializeComponent();

            pictureBoxs[1] = pictureBox1; pictureBoxs[2] = pictureBox2; pictureBoxs[3] = pictureBox3;
            pictureBoxs[4] = pictureBox4; pictureBoxs[5] = pictureBox5; pictureBoxs[6] = pictureBox6;
            pictureBoxs[7] = pictureBox7; pictureBoxs[8] = pictureBox8; pictureBoxs[9] = pictureBox9;
            pictureBoxs[10] = pictureBox10; pictureBoxs[11] = pictureBox11;
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
            picBoxYellow1.ImageLocation = null;
            pictureBoxs[1].ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Yellow1.png";
            pictureBoxs[1].SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1;
            pictureBoxs[i].ImageLocation = null;
            pictureBoxs[i + 1].ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Yellow1.png";
            pictureBoxs[i + 1].SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
