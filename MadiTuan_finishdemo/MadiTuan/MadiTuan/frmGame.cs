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
    public partial class frmGame : Form
    {
        public void loadDaTa()
        {
            ChessBoard = new chessBoardManager(pnlBanCo);
            int soOBanCo = int.Parse(this.txtSooBanCo.Text);                        
            ChessBoard.DrawChessBoard(soOBanCo);          
        }
        #region Properties
        chessBoardManager ChessBoard;
        #endregion

        public frmGame()
        {
            InitializeComponent();
        }              
        private void btnKhoitao_Click(object sender, EventArgs e)
        {           
            loadDaTa();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtSooBanCo.ResetText();
            pnlBanCo.Controls.Clear();
        }


        public void loadUndo()
        {
            try
            {
                ChessBoard.Undo();
            }
            catch(Exception)
            {
                MessageBox.Show("Không thể undo được nữa", "Xảy ra lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            loadUndo();
        }
    }
}
