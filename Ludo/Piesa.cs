using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo
{
    class Piesa 
    {
        public Piesa()
        {


        }


        public void PunePieselePeTabla(Game game)
        {
            //green
            if (game.ps.checkBoxGreen.Checked == true)
            {

                game.picBoxGreen1.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Green1.png";
                game.picBoxGreen1.SizeMode = PictureBoxSizeMode.StretchImage;

                game.picBoxGreen2.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Green1.png";
                game.picBoxGreen2.SizeMode = PictureBoxSizeMode.StretchImage;

                game.picBoxGreen3.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Green1.png";
                game.picBoxGreen3.SizeMode = PictureBoxSizeMode.StretchImage;

                game.picBoxGreen4.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Green1.png";
                game.picBoxGreen4.SizeMode = PictureBoxSizeMode.StretchImage;

            }

            //blue
            if (game.ps.checkBoxBlue.Checked == true)
            {

                game.picBoxBlue1.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Blue1.png";
                game.picBoxBlue1.SizeMode = PictureBoxSizeMode.StretchImage;

                game.picBoxBlue2.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Blue1.png";
                game.picBoxBlue2.SizeMode = PictureBoxSizeMode.StretchImage;

                game.picBoxBlue3.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Blue1.png";
                game.picBoxBlue3.SizeMode = PictureBoxSizeMode.StretchImage;

                game.picBoxBlue4.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Blue1.png";
                game.picBoxBlue4.SizeMode = PictureBoxSizeMode.StretchImage;

            }

            //yellow
            if (game.ps.checkBoxYellow.Checked == true)
            {

                game.picBoxYellow1.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Yellow1.png";
                game.picBoxYellow1.SizeMode = PictureBoxSizeMode.StretchImage;

                game.picBoxYellow2.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Yellow1.png";
                game.picBoxYellow2.SizeMode = PictureBoxSizeMode.StretchImage;

                game.picBoxYellow3.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Yellow1.png";
                game.picBoxYellow3.SizeMode = PictureBoxSizeMode.StretchImage;

                game.picBoxYellow4.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Yellow1.png";
                game.picBoxYellow4.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            //red
            if (game.ps.checkBoxRed.Checked == true)
            {

                game.picBoxRed1.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Red1.png";
                game.picBoxRed1.SizeMode = PictureBoxSizeMode.StretchImage;

                game.picBoxRed2.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Red1.png";
                game.picBoxRed2.SizeMode = PictureBoxSizeMode.StretchImage;

                game.picBoxRed3.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Red1.png";
                game.picBoxRed3.SizeMode = PictureBoxSizeMode.StretchImage;

                game.picBoxRed4.ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Red1.png";
                game.picBoxRed4.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
