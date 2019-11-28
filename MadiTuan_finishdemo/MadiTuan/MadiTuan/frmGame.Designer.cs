namespace MadiTuan
{
    partial class frmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBanCo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnKhoitao = new System.Windows.Forms.Button();
            this.txtSooBanCo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBanCo
            // 
            this.pnlBanCo.AutoSize = true;
            this.pnlBanCo.Location = new System.Drawing.Point(13, 13);
            this.pnlBanCo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBanCo.Name = "pnlBanCo";
            this.pnlBanCo.Size = new System.Drawing.Size(642, 474);
            this.pnlBanCo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnUndo);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnKhoitao);
            this.panel1.Controls.Add(this.txtSooBanCo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(663, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 474);
            this.panel1.TabIndex = 1;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(24, 356);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(82, 53);
            this.btnUndo.TabIndex = 4;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(24, 285);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 49);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnKhoitao
            // 
            this.btnKhoitao.Location = new System.Drawing.Point(147, 285);
            this.btnKhoitao.Name = "btnKhoitao";
            this.btnKhoitao.Size = new System.Drawing.Size(75, 49);
            this.btnKhoitao.TabIndex = 2;
            this.btnKhoitao.Text = "Khởi tạo";
            this.btnKhoitao.UseVisualStyleBackColor = true;
            this.btnKhoitao.Click += new System.EventHandler(this.btnKhoitao_Click);
            // 
            // txtSooBanCo
            // 
            this.txtSooBanCo.Location = new System.Drawing.Point(122, 17);
            this.txtSooBanCo.Name = "txtSooBanCo";
            this.txtSooBanCo.Size = new System.Drawing.Size(100, 26);
            this.txtSooBanCo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số ô bàn cờ:";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(945, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBanCo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ma di tuan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanCo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSooBanCo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKhoitao;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUndo;
    }
}

