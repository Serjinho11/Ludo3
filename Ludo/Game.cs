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
        PlayerSelection ps;
        PictureBox[] pictureBoxs = new PictureBox[12];

        public Game(PlayerSelection playerSelection)
        {
            ps = playerSelection;
            InitializeComponent();

            pictureBoxs[1] = pictureBox1; pictureBoxs[2] = pictureBox2; pictureBoxs[3] = pictureBox3;
            pictureBoxs[4] = pictureBox4; pictureBoxs[5] = pictureBox5; pictureBoxs[6] = pictureBox6;
            pictureBoxs[7] = pictureBox7; pictureBoxs[8] = pictureBox8; pictureBoxs[9] = pictureBox9;
            pictureBoxs[10] = pictureBox10; pictureBoxs[11] = pictureBox11;


            PunePieselePeTabla();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ps.Show();
        }

        public void PunePieselePeTabla()
        {
            //green
            if (ps.checkBoxGreen.Checked == true)
            {

                picBoxGreen2.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Green2.png";
                picBoxGreen2.SizeMode = PictureBoxSizeMode.StretchImage;

                picBoxGreen1.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Green3.png";
                picBoxGreen1.SizeMode = PictureBoxSizeMode.StretchImage;

                picBoxGreen3.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Green4.png";
                picBoxGreen3.SizeMode = PictureBoxSizeMode.StretchImage;

                picBoxGreen4.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Green1.png";
                picBoxGreen4.SizeMode = PictureBoxSizeMode.StretchImage;

            }

            if (ps.checkBoxBlue.Checked == true)
            {
                picBoxBlue1.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Blue1.png";
                picBoxBlue1.SizeMode = PictureBoxSizeMode.StretchImage;

                picBoxBlue2.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Blue1.png";
                picBoxBlue2.SizeMode = PictureBoxSizeMode.StretchImage;

                picBoxBlue3.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Blue1.png";
                picBoxBlue3.SizeMode = PictureBoxSizeMode.StretchImage;

                picBoxBlue4.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Blue1.png";
                picBoxBlue4.SizeMode = PictureBoxSizeMode.StretchImage;

            }

            if (ps.checkBoxYellow.Checked == true)
            {
                picBoxYellow1.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Yellow1.png";
                picBoxYellow1.SizeMode = PictureBoxSizeMode.StretchImage;

                picBoxYellow2.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Yellow1.png";
                picBoxYellow2.SizeMode = PictureBoxSizeMode.StretchImage;

                picBoxYellow3.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Yellow1.png";
                picBoxYellow3.SizeMode = PictureBoxSizeMode.StretchImage;

                picBoxYellow4.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Yellow1.png";
                picBoxYellow4.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (ps.checkBoxRed.Checked == true)
            {
                picBoxRed1.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Red1.png";
                picBoxRed1.SizeMode = PictureBoxSizeMode.StretchImage;

                picBoxRed2.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Red1.png";
                picBoxRed2.SizeMode = PictureBoxSizeMode.StretchImage;

                picBoxRed3.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Red1.png";
                picBoxRed3.SizeMode = PictureBoxSizeMode.StretchImage;

                picBoxRed4.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Red1.png";
                picBoxRed4.SizeMode = PictureBoxSizeMode.StretchImage;
            }
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
