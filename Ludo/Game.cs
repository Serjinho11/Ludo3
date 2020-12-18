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


        public Game(PlayerSelection playerSelection)
        {
            ps = playerSelection;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ps.Show();
        }
    }
}
