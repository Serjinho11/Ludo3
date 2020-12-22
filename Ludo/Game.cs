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
        Piese piesa = new Piese();
        int i = 1, S = 0;
        int k = 1;
        int rnd;

        Random rand = new Random();

        Road road = new Road();
        HomeColumn homeColumn = new HomeColumn();


        public Game(PlayerSelection playerSelection)
        {

            InitializeComponent();
            ps = playerSelection;



            piesa.PunePieselePeTabla(this);

            road.RoadInitialization(this);
            homeColumn.HomeCulomnInitialization(this);
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
            road.pictureBoxs[1].ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Yellow1.png";
            road.pictureBoxs[1].SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rnd = rand.Next(1, 7);
            button2.Text = rnd.ToString();
            //if (rnd + S < 51)
            if (i < 51)
            {

                S = i;
                road.pictureBoxs[i].ImageLocation = null;
                road.pictureBoxs[i = i + rnd].ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Yellow1.png";
                road.pictureBoxs[i].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                road.pictureBoxs[i].ImageLocation = null;
                homeColumn.picBaseBox[k].ImageLocation = null;
                homeColumn.picBaseBox[k = k + 1].ImageLocation = @"C:\Users\Sergiu\Desktop\L\Ludo\Resources\Yellow1.png";
                homeColumn.picBaseBox[k].SizeMode = PictureBoxSizeMode.StretchImage;


            }


            label7.Text = i.ToString();

        }



    }
}
