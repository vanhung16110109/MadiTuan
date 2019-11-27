using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadiTuan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            
                
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            frmGame frm_game = new frmGame();
            frm_game.ShowDialog();

        }
    }
}
