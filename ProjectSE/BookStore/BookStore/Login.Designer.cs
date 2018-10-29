namespace BookStore
{
    partial class Login
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
            this.tb_username = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.Label();
            this.textExit = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnExit = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnLogin = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.Label();
            this.pictLogo = new System.Windows.Forms.PictureBox();
            this.pictLock = new System.Windows.Forms.PictureBox();
            this.pictUser = new System.Windows.Forms.PictureBox();
            this.textWelcom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_username.Location = new System.Drawing.Point(240, 290);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(367, 31);
            this.tb_username.TabIndex = 2;
            this.tb_username.Enter += new System.EventHandler(this.Username_Enter);
            this.tb_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_login);
            this.tb_username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // textLogin
            // 
            this.textLogin.AutoSize = true;
            this.textLogin.BackColor = System.Drawing.Color.LightSlateGray;
            this.textLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textLogin.Location = new System.Drawing.Point(265, 437);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(65, 25);
            this.textLogin.TabIndex = 5;
            this.textLogin.Text = "Login";
            this.textLogin.Click += new System.EventHandler(this.textLogin_Click);
            // 
            // textExit
            // 
            this.textExit.AutoSize = true;
            this.textExit.BackColor = System.Drawing.Color.LightSlateGray;
            this.textExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textExit.Location = new System.Drawing.Point(480, 438);
            this.textExit.Name = "textExit";
            this.textExit.Size = new System.Drawing.Size(48, 25);
            this.textExit.TabIndex = 6;
            this.textExit.Text = "Exit";
            this.textExit.Click += new System.EventHandler(this.textExit_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btnExit,
            this.btnLogin,
            this.rectangleShape3});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 600);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExit.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.CornerRadius = 10;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FillColor = System.Drawing.Color.White;
            this.btnExit.FillGradientColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(449, 430);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 39);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.mpExit);
            this.btnExit.MouseLeave += new System.EventHandler(this.mplExit);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnLogin.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.CornerRadius = 10;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FillColor = System.Drawing.Color.White;
            this.btnLogin.FillGradientColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(244, 430);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(106, 39);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseHover += new System.EventHandler(this.mpLogin);
            this.btnLogin.MouseLeave += new System.EventHandler(this.mplLogin);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.Color.White;
            this.rectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape3.CornerRadius = 5;
            this.rectangleShape3.Location = new System.Drawing.Point(88, 246);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(617, 244);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_password.Location = new System.Drawing.Point(241, 362);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(367, 31);
            this.tb_password.TabIndex = 3;
            this.tb_password.Enter += new System.EventHandler(this.Password_Enter);
            this.tb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_login);
            this.tb_password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // textUsername
            // 
            this.textUsername.AutoSize = true;
            this.textUsername.BackColor = System.Drawing.Color.White;
            this.textUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textUsername.Location = new System.Drawing.Point(243, 293);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(110, 25);
            this.textUsername.TabIndex = 7;
            this.textUsername.Text = "Username";
            this.textUsername.Click += new System.EventHandler(this.Click_Username);
            // 
            // textPassword
            // 
            this.textPassword.AutoSize = true;
            this.textPassword.BackColor = System.Drawing.Color.White;
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textPassword.Location = new System.Drawing.Point(244, 365);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(106, 25);
            this.textPassword.TabIndex = 8;
            this.textPassword.Text = "Password";
            this.textPassword.Click += new System.EventHandler(this.Click_Pawword);
            // 
            // pictLogo
            // 
            this.pictLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictLogo.Image = global::BookStore.Properties.Resources.logo_สีขาว_png;
            this.pictLogo.Location = new System.Drawing.Point(301, 8);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(210, 210);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLogo.TabIndex = 12;
            this.pictLogo.TabStop = false;
            // 
            // pictLock
            // 
            this.pictLock.BackColor = System.Drawing.Color.White;
            this.pictLock.Image = global::BookStore.Properties.Resources._lock;
            this.pictLock.Location = new System.Drawing.Point(161, 362);
            this.pictLock.Name = "pictLock";
            this.pictLock.Size = new System.Drawing.Size(37, 38);
            this.pictLock.TabIndex = 11;
            this.pictLock.TabStop = false;
            // 
            // pictUser
            // 
            this.pictUser.BackColor = System.Drawing.Color.White;
            this.pictUser.Image = global::BookStore.Properties.Resources.user;
            this.pictUser.Location = new System.Drawing.Point(161, 290);
            this.pictUser.Name = "pictUser";
            this.pictUser.Size = new System.Drawing.Size(37, 38);
            this.pictUser.TabIndex = 10;
            this.pictUser.TabStop = false;
            // 
            // textWelcom
            // 
            this.textWelcom.AutoSize = true;
            this.textWelcom.BackColor = System.Drawing.Color.Transparent;
            this.textWelcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textWelcom.ForeColor = System.Drawing.Color.White;
            this.textWelcom.Location = new System.Drawing.Point(328, 204);
            this.textWelcom.Name = "textWelcom";
            this.textWelcom.Size = new System.Drawing.Size(159, 37);
            this.textWelcom.TabIndex = 14;
            this.textWelcom.Text = "Welcome!";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "\"Reading is a basic in the living of a good life.\"";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textWelcom);
            this.Controls.Add(this.pictLogo);
            this.Controls.Add(this.pictLock);
            this.Controls.Add(this.pictUser);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.textExit);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookStore";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label textLogin;
        private System.Windows.Forms.Label textExit;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private System.Windows.Forms.TextBox tb_password;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnExit;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnLogin;
        private System.Windows.Forms.Label textUsername;
        private System.Windows.Forms.Label textPassword;
        private System.Windows.Forms.PictureBox pictUser;
        private System.Windows.Forms.PictureBox pictLock;
        private System.Windows.Forms.PictureBox pictLogo;
        private System.Windows.Forms.Label textWelcom;
        private System.Windows.Forms.Label label1;
    }
}

