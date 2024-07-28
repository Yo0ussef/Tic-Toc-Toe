using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using X_O_Game.X_O;

namespace X_O_Game.X_O
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btn1player_Click(object sender, EventArgs e)
        {
            FrmOnePlayer frm = new FrmOnePlayer();
            frm.Show();
            this.Hide();
        }

        private void btn2players_Click(object sender, EventArgs e)
        {
            FrmTwoPlayers frm = new FrmTwoPlayers();
            frm.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
