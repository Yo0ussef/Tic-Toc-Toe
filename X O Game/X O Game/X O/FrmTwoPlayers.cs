using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_Game.X_O
{
    public partial class FrmTwoPlayers : Form
    {
        public FrmTwoPlayers()
        {
            InitializeComponent();
        }
        int xo = 0, player1 = 0, player2 = 0;
        bool win = false;
        void getthewinner()
        {
            if (btn1.Text != "" && btn1.Text == btn2.Text && btn1.Text == btn3.Text)
            {
                wineffect(btn1, btn2, btn3);
                win = true;
            }
            else if (btn4.Text != "" && btn4.Text == btn5.Text && btn4.Text == btn6.Text)
            {
                wineffect(btn4, btn5, btn6);
                win = true;
            }
            else if (btn7.Text != "" && btn7.Text == btn8.Text && btn7.Text == btn8.Text)
            {
                wineffect(btn7, btn8, btn9);
                win = true;
            }
            else if (btn1.Text != "" && btn4.Text == btn1.Text && btn4.Text == btn7.Text)
            {
                wineffect(btn1, btn4, btn7);
                win = true;
            }
            else if (btn2.Text != "" && btn2.Text == btn5.Text && btn2.Text == btn8.Text)
            {
                wineffect(btn5, btn2, btn8);
                win = true;
            }
            else if (btn3.Text != "" && btn3.Text == btn6.Text && btn3.Text == btn9.Text)
            {
                wineffect(btn9, btn6, btn3);
                win = true;
            }
            else if (btn1.Text != "" && btn1.Text == btn5.Text && btn1.Text == btn9.Text)
            {
                wineffect(btn1, btn5, btn9);
                win = true;
            }
            else if (btn3.Text != "" && btn5.Text == btn3.Text && btn3.Text == btn7.Text)
            {
                wineffect(btn7, btn5, btn3);
                win = true;
            }
        }
        void wineffect(Guna.UI2.WinForms.Guna2Button b1, Guna.UI2.WinForms.Guna2Button b2, Guna.UI2.WinForms.Guna2Button b3)
        {
            b1.ForeColor = b2.ForeColor = b3.ForeColor = Color.Blue;
            if (b1.Text == "X")
            {
                player1++;
                lbl1.Text = player1.ToString();
            }
            else
            {
                player2++;
                lbl2.Text = player2.ToString();
            }
        }
        private void FrmTwoPlayers_Load(object sender, EventArgs e)
        {
            foreach (Control c in guna2Panel5.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Click += new System.EventHandler(btn_click);
                }
            }
        }
        public void btn_click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;
            if (btn.Text.Equals(""))
            {
                if (xo % 2 == 0)
                {
                    btn.Text = "X";
                    btn.ForeColor = Color.Yellow;
                    getthewinner();
                }
                else
                {
                    btn.Text = "O";
                    btn.ForeColor = Color.Red;
                    getthewinner();
                }
                xo++;
            }
        }

        private void btnplayagain_Click(object sender, EventArgs e)
        {
            xo = 0;
            win = false;
            foreach (Control c in guna2Panel5.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Text = "";
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain frm = new FrmMain();
            frm.Show();
        }
    }
}
