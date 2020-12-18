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
    public partial class PlayerSelection : Form
    {
        int playerSelectat = 0;


        public PlayerSelection()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRed.Checked == true)
            {
                playerSelectat++;
            }
            if (playerSelectat >= 2)
            {
                btnStart.Visible = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBlue.Checked == true)
            {
                playerSelectat++;
            }
            if (playerSelectat >= 2)
            {
                btnStart.Visible = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYellow.Checked == true)
            {
                playerSelectat++;
            }
            if (playerSelectat >= 2)
            {
                btnStart.Visible = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxGreen.Checked == true)
            {
                playerSelectat++;
            }
            if (playerSelectat >= 2)
            {
                btnStart.Visible = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Game game = new Game(this);
            this.Hide();
            game.Show();
        }
    }
}
