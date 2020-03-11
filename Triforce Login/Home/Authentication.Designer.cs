namespace Triforce_Login
{
    partial class Authentication
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Entrar = new System.Windows.Forms.Button();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buy = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.key = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.serial = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.viewserial = new System.Windows.Forms.PictureBox();
            this.viewkey = new System.Windows.Forms.PictureBox();
            this.admin = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sleep = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewserial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 473);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Entrar
            // 
            this.Entrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Entrar.BackgroundImage")));
            this.Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrar.ForeColor = System.Drawing.Color.White;
            this.Entrar.Location = new System.Drawing.Point(27, 322);
            this.Entrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(369, 55);
            this.Entrar.TabIndex = 12;
            this.Entrar.Text = "Login";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.DarkOrchid;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(155, 95);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(106, 46);
            this.bunifuCustomLabel4.TabIndex = 18;
            this.bunifuCustomLabel4.Text = "Login";
            // 
            // buy
            // 
            this.buy.AutoSize = true;
            this.buy.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buy.ForeColor = System.Drawing.Color.DarkOrchid;
            this.buy.Location = new System.Drawing.Point(261, 404);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(70, 20);
            this.buy.TabIndex = 17;
            this.buy.Text = "Buy now";
            this.buy.Click += new System.EventHandler(this.buy_Click_1);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(76, 404);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(176, 20);
            this.bunifuCustomLabel2.TabIndex = 16;
            this.bunifuCustomLabel2.Text = "Don\'t have access yet ?";
            // 
            // user
            // 
            this.user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user.Enabled = false;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user.HintForeColor = System.Drawing.Color.DimGray;
            this.user.HintText = "";
            this.user.isPassword = false;
            this.user.LineFocusedColor = System.Drawing.Color.DimGray;
            this.user.LineIdleColor = System.Drawing.Color.DimGray;
            this.user.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.user.LineThickness = 3;
            this.user.Location = new System.Drawing.Point(27, 242);
            this.user.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(371, 44);
            this.user.TabIndex = 14;
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // key
            // 
            this.key.AutoSize = true;
            this.key.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.key.ForeColor = System.Drawing.Color.Black;
            this.key.Location = new System.Drawing.Point(43, 262);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(15, 20);
            this.key.TabIndex = 19;
            this.key.Text = "-";
            this.key.Click += new System.EventHandler(this.key_Click);
            // 
            // serial
            // 
            this.serial.AutoSize = true;
            this.serial.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.serial.ForeColor = System.Drawing.Color.Black;
            this.serial.Location = new System.Drawing.Point(168, 197);
            this.serial.Name = "serial";
            this.serial.Size = new System.Drawing.Size(15, 20);
            this.serial.TabIndex = 20;
            this.serial.Text = "-";
            this.serial.Click += new System.EventHandler(this.serial_Click_1);
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Enabled = false;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.DimGray;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.DimGray;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.DimGray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(28, 178);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(368, 44);
            this.bunifuMaterialTextbox1.TabIndex = 21;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // viewserial
            // 
            this.viewserial.BackColor = System.Drawing.Color.Transparent;
            this.viewserial.Image = ((System.Drawing.Image)(resources.GetObject("viewserial.Image")));
            this.viewserial.Location = new System.Drawing.Point(35, 196);
            this.viewserial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewserial.Name = "viewserial";
            this.viewserial.Size = new System.Drawing.Size(23, 21);
            this.viewserial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewserial.TabIndex = 22;
            this.viewserial.TabStop = false;
            this.viewserial.Click += new System.EventHandler(this.viewserial_Click);
            // 
            // viewkey
            // 
            this.viewkey.BackColor = System.Drawing.Color.Transparent;
            this.viewkey.Image = ((System.Drawing.Image)(resources.GetObject("viewkey.Image")));
            this.viewkey.Location = new System.Drawing.Point(35, 260);
            this.viewkey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewkey.Name = "viewkey";
            this.viewkey.Size = new System.Drawing.Size(23, 21);
            this.viewkey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewkey.TabIndex = 23;
            this.viewkey.TabStop = false;
            this.viewkey.Click += new System.EventHandler(this.viewkey_Click);
            // 
            // admin
            // 
            this.admin.Image = ((System.Drawing.Image)(resources.GetObject("admin.Image")));
            this.admin.Location = new System.Drawing.Point(5, 6);
            this.admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(35, 32);
            this.admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.admin.TabIndex = 24;
            this.admin.TabStop = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sleep
            // 
            this.sleep.Image = ((System.Drawing.Image)(resources.GetObject("sleep.Image")));
            this.sleep.Location = new System.Drawing.Point(25, 50);
            this.sleep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sleep.Name = "sleep";
            this.sleep.Size = new System.Drawing.Size(373, 402);
            this.sleep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sleep.TabIndex = 25;
            this.sleep.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(35, 441);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(349, 10);
            this.progressBar1.TabIndex = 51;
            this.progressBar1.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(377, 9);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 74;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 518);
            this.Controls.Add(this.sleep);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.viewkey);
            this.Controls.Add(this.viewserial);
            this.Controls.Add(this.serial);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.key);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.user);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authentication";
            this.Opacity = 0.93D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Authentication_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewserial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Entrar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel buy;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox user;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel serial;
        private Bunifu.Framework.UI.BunifuCustomLabel key;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.PictureBox viewserial;
        private System.Windows.Forms.PictureBox viewkey;
        private System.Windows.Forms.PictureBox admin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox sleep;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

