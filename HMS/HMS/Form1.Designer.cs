namespace HMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuLogin = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.bunifuLoginPicture = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuExit = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomTextbox2 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 511);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuLogin
            // 
            this.bunifuLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuLogin.BackgroundImage")));
            this.bunifuLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuLogin.ButtonText = "Login";
            this.bunifuLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuLogin.ForeColor = System.Drawing.Color.Turquoise;
            this.bunifuLogin.ForeColorHoverState = System.Drawing.Color.Turquoise;
            this.bunifuLogin.Iconimage = null;
            this.bunifuLogin.IconVisible = true;
            this.bunifuLogin.IconZoom = 90D;
            this.bunifuLogin.ImageIconOverlay = false;
            this.bunifuLogin.Location = new System.Drawing.Point(579, 376);
            this.bunifuLogin.Name = "bunifuLogin";
            this.bunifuLogin.Size = new System.Drawing.Size(139, 40);
            this.bunifuLogin.TabIndex = 1;
            this.bunifuLogin.Click += new System.EventHandler(this.bunifuLogin_Click);
            // 
            // bunifuLoginPicture
            // 
            this.bunifuLoginPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuLoginPicture.color = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuLoginPicture.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuLoginPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuLoginPicture.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuLoginPicture.ForeColor = System.Drawing.Color.White;
            this.bunifuLoginPicture.Image = ((System.Drawing.Image)(resources.GetObject("bunifuLoginPicture.Image")));
            this.bunifuLoginPicture.ImagePosition = 20;
            this.bunifuLoginPicture.ImageZoom = 50;
            this.bunifuLoginPicture.LabelPosition = 41;
            this.bunifuLoginPicture.LabelText = "Doctor Login";
            this.bunifuLoginPicture.Location = new System.Drawing.Point(643, 65);
            this.bunifuLoginPicture.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuLoginPicture.Name = "bunifuLoginPicture";
            this.bunifuLoginPicture.Size = new System.Drawing.Size(147, 145);
            this.bunifuLoginPicture.TabIndex = 2;
            // 
            // bunifuExit
            // 
            this.bunifuExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuExit.BackgroundImage")));
            this.bunifuExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuExit.ButtonText = "Exit";
            this.bunifuExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuExit.ForeColor = System.Drawing.Color.Turquoise;
            this.bunifuExit.ForeColorHoverState = System.Drawing.Color.Turquoise;
            this.bunifuExit.Iconimage = null;
            this.bunifuExit.IconVisible = true;
            this.bunifuExit.IconZoom = 90D;
            this.bunifuExit.ImageIconOverlay = false;
            this.bunifuExit.Location = new System.Drawing.Point(742, 376);
            this.bunifuExit.Name = "bunifuExit";
            this.bunifuExit.Size = new System.Drawing.Size(135, 40);
            this.bunifuExit.TabIndex = 3;
            this.bunifuExit.Click += new System.EventHandler(this.bunifuExit_Click);
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(598, 236);
            this.bunifuCustomTextbox1.Multiline = true;
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(245, 43);
            this.bunifuCustomTextbox1.TabIndex = 4;
            this.bunifuCustomTextbox1.Text = "Username";
            this.bunifuCustomTextbox1.Click += new System.EventHandler(this.bunifuCustomTextbox1_Enter);
            this.bunifuCustomTextbox1.DoubleClick += new System.EventHandler(this.bunifuCustomTextbox1_Leave);
            this.bunifuCustomTextbox1.Enter += new System.EventHandler(this.bunifuCustomTextbox1_Enter);
            this.bunifuCustomTextbox1.Leave += new System.EventHandler(this.bunifuCustomTextbox1_Leave);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(553, 442);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(324, 13);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "NOTE: You can not register on this platform because you are not a ";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(553, 455);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(362, 13);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "valid Johns Hopkins Doctor. All valid Doctors are given a unique username ";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(553, 468);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(222, 13);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "and password at the time of their employment.";
            // 
            // bunifuCustomTextbox2
            // 
            this.bunifuCustomTextbox2.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.bunifuCustomTextbox2.Location = new System.Drawing.Point(598, 285);
            this.bunifuCustomTextbox2.Multiline = true;
            this.bunifuCustomTextbox2.Name = "bunifuCustomTextbox2";
            this.bunifuCustomTextbox2.Size = new System.Drawing.Size(245, 43);
            this.bunifuCustomTextbox2.TabIndex = 9;
            this.bunifuCustomTextbox2.Text = "Password";
            this.bunifuCustomTextbox2.Click += new System.EventHandler(this.bunifuCustomTextbox2_Enter);
            this.bunifuCustomTextbox2.DoubleClick += new System.EventHandler(this.bunifuCustomTextbox2_Leave);
            this.bunifuCustomTextbox2.Enter += new System.EventHandler(this.bunifuCustomTextbox2_Enter);
            this.bunifuCustomTextbox2.Leave += new System.EventHandler(this.bunifuCustomTextbox2_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(913, 504);
            this.Controls.Add(this.bunifuCustomTextbox2);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomTextbox1);
            this.Controls.Add(this.bunifuExit);
            this.Controls.Add(this.bunifuLoginPicture);
            this.Controls.Add(this.bunifuLogin);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "JOHNS HOPKINS MEDICAL CENTRE ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuLogin;
        private Bunifu.Framework.UI.BunifuTileButton bunifuLoginPicture;
        private WindowsFormsControlLibrary1.BunifuThinButton bunifuExit;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox2;
    }
}

