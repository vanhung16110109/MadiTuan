namespace MDT_WP
{
    partial class frmMain
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
            this.txtSoO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlBanCo
            // 
            this.pnlBanCo.AutoSize = true;
            this.pnlBanCo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBanCo.Location = new System.Drawing.Point(13, 13);
            this.pnlBanCo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBanCo.Name = "pnlBanCo";
            this.pnlBanCo.Size = new System.Drawing.Size(367, 182);
            this.pnlBanCo.TabIndex = 0;
            // 
            // txtSoO
            // 
            this.txtSoO.Location = new System.Drawing.Point(796, 13);
            this.txtSoO.Name = "txtSoO";
            this.txtSoO.Size = new System.Drawing.Size(52, 26);
            this.txtSoO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số ô:";
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(736, 55);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(112, 39);
            this.btnTao.TabIndex = 3;
            this.btnTao.Text = "Tạo bàn cờ";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(860, 326);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoO);
            this.Controls.Add(this.pnlBanCo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình chính";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanCo;
        private System.Windows.Forms.TextBox txtSoO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTao;
    }
}

