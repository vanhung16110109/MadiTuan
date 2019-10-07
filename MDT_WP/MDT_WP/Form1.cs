using MDT_WP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDT_WP
{
public partial class frmMain : Form
    {
        Image quanMa = Resources.ma;
        // khai bao bien tao ra o co
        Button[,] btnO = new Button[10, 10];
        public void VeBanCo(int n)
        {
            int width = 70;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 != 0)
                        {
                            btnO[i, j] = new Button();
                            btnO[i, j].Width = width; // chieu rong
                            btnO[i, j].Height = width; // chieu cao
                            btnO[i, j].BackColor = Color.Black;
                            btnO[i, j].Location = new Point(i * width, j * width); // thiet lap vi tri cua nut
                            btnO[i, j].Text = "";  // thiet lap nut khong hien thi hinh anh
                            pnlBanCo.Controls.Add(btnO[i, j]); // add vao panel
                            btnO[i, j].Click += new EventHandler(conMa);
                           // btnO[i, j].Image = quanMa;
                        }
                        else
                        {
                            btnO[i, j] = new Button();
                            btnO[i, j].Width = width; // chieu rong
                            btnO[i, j].Height = width; // chieu cao
                            btnO[i, j].BackColor = Color.White;
                            btnO[i, j].Location = new Point(i * width, j * width); // thiet lap vi tri cua nut
                            btnO[i, j].Text = "";  // thiet lap nut khong hien thi hinh anh
                            pnlBanCo.Controls.Add(btnO[i, j]); // add vao panel
                            btnO[i, j].Click += new EventHandler(conMa);
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            btnO[i, j] = new Button();
                            btnO[i, j].Width = width; // chieu rong
                            btnO[i, j].Height = width; // chieu cao
                            btnO[i, j].BackColor = Color.Black;
                            btnO[i, j].Location = new Point(i * width, j * width); // thiet lap vi tri cua nut
                            btnO[i, j].Text = "";  // thiet lap nut khong hien thi hinh anh
                            pnlBanCo.Controls.Add(btnO[i, j]); // add vao panel
                            btnO[i, j].Click += new EventHandler(conMa);
                        }
                        else
                        {
                            btnO[i, j] = new Button();
                            btnO[i, j].Width = width; // chieu rong
                            btnO[i, j].Height = width; // chieu cao
                            btnO[i, j].BackColor = Color.White;
                            btnO[i, j].Location = new Point(i * width, j * width); // thiet lap vi tri cua nut
                            btnO[i, j].Text = "";  // thiet lap nut khong hien thi hinh anh
                            pnlBanCo.Controls.Add(btnO[i, j]); // add vao panel
                            btnO[i, j].Click += new EventHandler(conMa);
                        }
                    }
                }                             
            }
        }
        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //khoi tao vi tri, kich thuoc, them vao panel
            
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            int soOBanCo;
            soOBanCo = int.Parse(this.txtSoO.Text);
            VeBanCo(soOBanCo);
        }

        private void conMa(object sender, EventArgs e)
        {
            //((Button)sender).Text = "conma"; // ep kieu doi tuong sender thanh button
            
            ((Button)sender).BackgroundImage = quanMa;            
        }

    }
}
