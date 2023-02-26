namespace en_tr
{
    partial class FrmSecim
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecim));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btntren = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnentr = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btntren
            // 
            this.btntren.ActiveBorderThickness = 1;
            this.btntren.ActiveCornerRadius = 20;
            this.btntren.ActiveFillColor = System.Drawing.Color.LightGreen;
            this.btntren.ActiveForecolor = System.Drawing.Color.White;
            this.btntren.ActiveLineColor = System.Drawing.Color.LightGreen;
            this.btntren.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntren.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntren.BackgroundImage")));
            this.btntren.ButtonText = "SEÇ";
            this.btntren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntren.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntren.ForeColor = System.Drawing.Color.Black;
            this.btntren.IdleBorderThickness = 1;
            this.btntren.IdleCornerRadius = 20;
            this.btntren.IdleFillColor = System.Drawing.Color.White;
            this.btntren.IdleForecolor = System.Drawing.Color.Black;
            this.btntren.IdleLineColor = System.Drawing.Color.Black;
            this.btntren.Location = new System.Drawing.Point(188, 152);
            this.btntren.Margin = new System.Windows.Forms.Padding(5);
            this.btntren.Name = "btntren";
            this.btntren.Size = new System.Drawing.Size(181, 41);
            this.btntren.TabIndex = 1;
            this.btntren.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btntren.Click += new System.EventHandler(this.btntren_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Türkçe Kelimelerin İngilizce Karşılığını Bul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "İngilizce Kelimelerin Türkçe Karşılığını Bul";
            // 
            // btnentr
            // 
            this.btnentr.ActiveBorderThickness = 1;
            this.btnentr.ActiveCornerRadius = 20;
            this.btnentr.ActiveFillColor = System.Drawing.Color.LightGreen;
            this.btnentr.ActiveForecolor = System.Drawing.Color.White;
            this.btnentr.ActiveLineColor = System.Drawing.Color.LightGreen;
            this.btnentr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnentr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnentr.BackgroundImage")));
            this.btnentr.ButtonText = "SEÇ";
            this.btnentr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnentr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentr.ForeColor = System.Drawing.Color.Black;
            this.btnentr.IdleBorderThickness = 1;
            this.btnentr.IdleCornerRadius = 20;
            this.btnentr.IdleFillColor = System.Drawing.Color.White;
            this.btnentr.IdleForecolor = System.Drawing.Color.Black;
            this.btnentr.IdleLineColor = System.Drawing.Color.Black;
            this.btnentr.Location = new System.Drawing.Point(188, 278);
            this.btnentr.Margin = new System.Windows.Forms.Padding(5);
            this.btnentr.Name = "btnentr";
            this.btnentr.Size = new System.Drawing.Size(181, 41);
            this.btnentr.TabIndex = 4;
            this.btnentr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnentr.Click += new System.EventHandler(this.btnentr_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(497, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(551, 354);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnentr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntren);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "V";
            this.Load += new System.EventHandler(this.FrmSecim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnentr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btntren;
    }
}