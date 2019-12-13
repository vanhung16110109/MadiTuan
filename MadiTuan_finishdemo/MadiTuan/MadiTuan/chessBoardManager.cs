using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace MadiTuan
{
    public class chessBoardManager
    {
        Image quanMa = Properties.Resources.ma;
        Image quanMa_dadi = Properties.Resources.quanma;
        public int N;
        public int viTriDong;
        public int viTriCot;
        public int[,] banCo;
        public int[] dy = { -2, -1, 1, 2, 2, 1, -1, -2 };
        public int[] dx = { 1, 2, 2, 1, -1, -2, -2, -1 };
        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }
        private int stepCount;        
        #endregion
            #region Initialize
        public chessBoardManager(Panel chessBoard)
        {
            this.ChessBoard = chessBoard;
            this.StepCount = 1;
            PlaytimeLine = new Stack<playInfo>();
        }
        private List<List<Button>> matrix;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        private Stack<playInfo> playtimeLine;
        public Stack<playInfo> PlaytimeLine
        {
            get
            {
                return playtimeLine;
            }

            set
            {
                playtimeLine = value;
            }
        }
        public int StepCount
        {
            get
            {
                return stepCount;
            }

            set
            {
                stepCount = value;
            }
        }

        



        #endregion
        #region Methods



        public void DrawChessBoard(int n)  //vẽ bàn cờ
        {
            N = n;
            banCo = new int[n, n];
            Matrix = new List<List<Button>>();
            Button oldButton = new Button()
            {
                Width = 0,
                Height = 0,
                Location = new Point(0, 0)
            };
            for (int i = 0; i < n; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j <= n; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 != 0)
                        {
                            Button btn = new Button()
                            {
                                Width = Cons.Chess_width,
                                Height = Cons.Chess_height,
                                Location = new Point(oldButton.Location.X + Cons.Chess_width, oldButton.Location.Y),
                                BackColor = Color.Black,
                                BackgroundImageLayout = ImageLayout.Stretch,
                                Tag = i.ToString(),
                            //    Enabled = false
                            };
                            btn.Click += Btn_Click;
                            ChessBoard.Controls.Add(btn);
                            oldButton = btn;
                            Matrix[i].Add(btn);
                        }
                        else
                        {
                            Button btn = new Button()
                            {
                                Width = Cons.Chess_width,
                                Height = Cons.Chess_height,
                                Location = new Point(oldButton.Location.X + Cons.Chess_width, oldButton.Location.Y),
                                BackColor = Color.White,
                                BackgroundImageLayout = ImageLayout.Stretch,
                                Tag = i.ToString(),
                               // Enabled = false
                            };
                            btn.Click += Btn_Click;
                            ChessBoard.Controls.Add(btn);
                            oldButton = btn;
                            Matrix[i].Add(btn);
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            Button btn = new Button()
                            {
                                Width = Cons.Chess_width,
                                Height = Cons.Chess_height,
                                Location = new Point(oldButton.Location.X + Cons.Chess_width, oldButton.Location.Y),
                                BackColor = Color.Black,
                                BackgroundImageLayout = ImageLayout.Stretch,
                                Tag = i.ToString(),
                               // Enabled = false
                            };
                            btn.Click += Btn_Click;
                            ChessBoard.Controls.Add(btn);
                            oldButton = btn;
                            Matrix[i].Add(btn);
                        }
                        else
                        {
                            Button btn = new Button()
                            {
                                Width = Cons.Chess_width,
                                Height = Cons.Chess_height,
                                Location = new Point(oldButton.Location.X + Cons.Chess_width, oldButton.Location.Y),
                                BackColor = Color.White,
                                BackgroundImageLayout = ImageLayout.Stretch,
                                Tag = i.ToString(),
                               // Enabled = false
                            };
                            btn.Click += Btn_Click;
                            ChessBoard.Controls.Add(btn);
                            oldButton = btn;
                            Matrix[i].Add(btn);
                        }
                    }
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.Chess_height);
                oldButton.Width = 0;
                oldButton.Height = 0;
                
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    banCo[i, j] = 0;
                }
            }
        }

        #endregion
        #region
        private void Btn_Click(object sender, EventArgs e)  // btn click thêm quân mã đã đi, hiện quân mã gợi ý
        {

            Button btn = sender as Button;
            
            btn.BackgroundImage = quanMa_dadi;
                    
            PlaytimeLine.Push(new playInfo(getChessPoint(btn)));   // luu point     

            xoaSinhNuocDi();

            if (isEndGame(btn))
            {               
                Endgame();
            }
            if (btn.BackgroundImage != null)
                return;
        }
        private void Endgame()
        {                        
            MessageBox.Show("Bạn đã chiến thắng!! Thật là thiên tài ^^", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        private bool isEndGame(Button btn)
        {
            return isHandling(btn);
        }
        
        public void xoaSinhNuocDi()
        {
            for(int i = 0;i<N;i++)
            {
                for(int j = 0;j<N;j++)
                {
                    if (Matrix[i][j].BackgroundImage == quanMa)
                    {
                        Matrix[i][j].BackgroundImage = null;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Matrix[i][j].BackgroundImage != quanMa_dadi)
                    {
                        Matrix[i][j].Enabled = false;
                    }
                }
            }
        }
        public bool kiemTraBanCo()  // neu toan 1 la thang
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Matrix[i][j].BackgroundImage == null)
                        return false;                
                }
            }           
            return true;
        }       
        public bool Undo()
        {
            if (PlaytimeLine.Count <= 0)
                return false;                       
            playInfo oldPoint = PlaytimeLine.Pop();
            Button btn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];                               
            btn.BackgroundImage = null;
            btn.Enabled = true;
            xoaSinhNuocDi();
            if (!(PlaytimeLine.Count <= 0))
            {
                oldPoint = PlaytimeLine.Peek();
            }
            timViTri();
            return true;
        }

        public int dem = 0;

        private Point getChessPoint(Button btn)
        {           
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);
            Point point = new Point(horizontal, vertical);
            btn.Enabled = false;           
            return point;
        }
        
        public void setQuanMa()
        {            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Matrix[i][j].BackgroundImage == quanMa_dadi)
                    {
                        Matrix[i][j].Enabled = false;
                        banCo[i, j] = 1;
                    }
                    if(banCo[i, j] == 0)
                    {
                        Matrix[i][j].BackgroundImage = null;
                    }
                }
            }           
        }
        public bool kiemtranuocdiquanMa(Button btn)
        {
            Point point = getChessPoint(btn);
            int i = 0;
            while (i < 8)
            {
                int ty = point.X + dy[i];
                int tx = point.Y + dx[i];
                if ((ty >= 0 && ty < N && tx >= 0 && tx < N && banCo[ty, tx] == 0) && (Matrix[tx][ty].BackgroundImage == quanMa))
                {
                    return true;
                }
                i++;
            }
            return false;
        }
        public void timViTriquanMa(Button btn)
        {
            Point point = getChessPoint(btn);            
            int i = 0;
            while(i<8)
            {
                int ty = point.X + dy[i];
                int tx = point.Y + dx[i];
                if ((ty >= 0 && ty < N && tx >= 0 && tx <N && banCo[ty, tx] == 0) && (Matrix[tx][ty].BackgroundImage != quanMa))
                {
                    if (!(Matrix[tx][ty].BackgroundImage == quanMa_dadi))
                    {
                        Matrix[tx][ty].BackgroundImage = quanMa;
                        Matrix[tx][ty].Enabled = true;
                    }
                }
                i++;
            }
            btn.BackgroundImage = quanMa_dadi;            

            if(!kiemtranuocdiquanMa(btn))
            {
                MessageBox.Show("Không tìm thấy vị trí quân Mã tiếp theo!! Bạn đã thua cuộc ^^", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Stop);
                stopGame();          
            }                    
        }


        public void stopGame()
        {
            for(int i = 0;i<N;i++)
            {
                for(int j = 0;j<N;j++)
                {
                    Matrix[i][j].Enabled = false;
                }
            }
        }
        public void timViTri()  //tim vi tri quan ma, sau khi undo
        {
            playInfo oldPoint = PlaytimeLine.Peek();
            int i = 0;
            while (i < 8)
            {
                int ty = oldPoint.Point.X + dy[i];
                int tx = oldPoint.Point.Y + dx[i];
                if ((ty >= 0 && ty < N && tx >= 0 && tx < N && banCo[ty, tx] == 0) && (Matrix[tx][ty].BackgroundImage != quanMa))
                {
                    if (!(Matrix[tx][ty].BackgroundImage == quanMa_dadi))
                    {
                        Matrix[tx][ty].BackgroundImage = quanMa;
                        Matrix[tx][ty].Enabled = true;
                    }
                }
                i++;
            }           
        }

        private bool isHandling(Button btn)
        {
            Point point = getChessPoint(btn);        
            if(!kiemTraBanCo())
            {   
                        
                timViTriquanMa(btn);                
                return false;
            }
            return true;
        }        
    }
    #endregion
}
