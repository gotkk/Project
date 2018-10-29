namespace BookStore
{
    partial class MenuShop
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pictLogo = new System.Windows.Forms.PictureBox();
            this.tblUser = new System.Windows.Forms.TableLayoutPanel();
            this.textUserName = new System.Windows.Forms.Label();
            this.tblLogout = new System.Windows.Forms.TableLayoutPanel();
            this.pictLogout = new System.Windows.Forms.PictureBox();
            this.tblMenu = new System.Windows.Forms.TableLayoutPanel();
            this.pictCustomer = new System.Windows.Forms.PictureBox();
            this.pictStore = new System.Windows.Forms.PictureBox();
            this.pictSale = new System.Windows.Forms.PictureBox();
            this.pictEnd = new System.Windows.Forms.PictureBox();
            this.toolTipLogout = new System.Windows.Forms.ToolTip(this.components);
            this.tblMain.SuspendLayout();
            this.tblHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            this.tblUser.SuspendLayout();
            this.tblLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogout)).BeginInit();
            this.tblMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.tblHeader, 0, 0);
            this.tblMain.Controls.Add(this.tblMenu, 0, 1);
            this.tblMain.Controls.Add(this.pictEnd, 0, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblMain.Size = new System.Drawing.Size(752, 393);
            this.tblMain.TabIndex = 0;
            // 
            // tblHeader
            // 
            this.tblHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.tblHeader.ColumnCount = 5;
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblHeader.Controls.Add(this.pictLogo, 2, 0);
            this.tblHeader.Controls.Add(this.tblUser, 4, 0);
            this.tblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHeader.Location = new System.Drawing.Point(3, 3);
            this.tblHeader.Name = "tblHeader";
            this.tblHeader.RowCount = 1;
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeader.Size = new System.Drawing.Size(746, 124);
            this.tblHeader.TabIndex = 0;
            // 
            // pictLogo
            // 
            this.pictLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictLogo.Image = global::BookStore.Properties.Resources.logo_สีขาว_png;
            this.pictLogo.Location = new System.Drawing.Point(301, 3);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(143, 118);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLogo.TabIndex = 0;
            this.pictLogo.TabStop = false;
            // 
            // tblUser
            // 
            this.tblUser.ColumnCount = 2;
            this.tblUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblUser.Controls.Add(this.textUserName, 0, 0);
            this.tblUser.Controls.Add(this.tblLogout, 1, 0);
            this.tblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblUser.Location = new System.Drawing.Point(450, 3);
            this.tblUser.Name = "tblUser";
            this.tblUser.RowCount = 1;
            this.tblUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUser.Size = new System.Drawing.Size(293, 118);
            this.tblUser.TabIndex = 1;
            // 
            // textUserName
            // 
            this.textUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textUserName.AutoSize = true;
            this.textUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textUserName.Location = new System.Drawing.Point(32, 40);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(170, 37);
            this.textUserName.TabIndex = 0;
            this.textUserName.Text = "UserName";
            // 
            // tblLogout
            // 
            this.tblLogout.ColumnCount = 1;
            this.tblLogout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLogout.Controls.Add(this.pictLogout, 0, 1);
            this.tblLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLogout.Location = new System.Drawing.Point(208, 3);
            this.tblLogout.Name = "tblLogout";
            this.tblLogout.RowCount = 3;
            this.tblLogout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLogout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLogout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLogout.Size = new System.Drawing.Size(82, 112);
            this.tblLogout.TabIndex = 1;
            // 
            // pictLogout
            // 
            this.pictLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictLogout.Image = global::BookStore.Properties.Resources.logout;
            this.pictLogout.Location = new System.Drawing.Point(3, 40);
            this.pictLogout.Name = "pictLogout";
            this.pictLogout.Size = new System.Drawing.Size(76, 31);
            this.pictLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLogout.TabIndex = 0;
            this.pictLogout.TabStop = false;
            this.toolTipLogout.SetToolTip(this.pictLogout, "Logout to Exit Program");
            this.pictLogout.Click += new System.EventHandler(this.pictLogout_Click);
            this.pictLogout.MouseLeave += new System.EventHandler(this.mplLogout);
            this.pictLogout.MouseHover += new System.EventHandler(this.mpLogout);
            // 
            // tblMenu
            // 
            this.tblMenu.ColumnCount = 3;
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMenu.Controls.Add(this.pictCustomer, 0, 0);
            this.tblMenu.Controls.Add(this.pictStore, 1, 0);
            this.tblMenu.Controls.Add(this.pictSale, 2, 0);
            this.tblMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMenu.Location = new System.Drawing.Point(3, 133);
            this.tblMenu.Name = "tblMenu";
            this.tblMenu.RowCount = 1;
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblMenu.Size = new System.Drawing.Size(746, 125);
            this.tblMenu.TabIndex = 1;
            // 
            // pictCustomer
            // 
            this.pictCustomer.BackColor = System.Drawing.Color.White;
            this.pictCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictCustomer.Image = global::BookStore.Properties.Resources.logo_customer;
            this.pictCustomer.Location = new System.Drawing.Point(3, 3);
            this.pictCustomer.Name = "pictCustomer";
            this.pictCustomer.Size = new System.Drawing.Size(242, 119);
            this.pictCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictCustomer.TabIndex = 0;
            this.pictCustomer.TabStop = false;
            this.pictCustomer.Click += new System.EventHandler(this.pictCustomer_Click);
            this.pictCustomer.MouseLeave += new System.EventHandler(this.mplCustomer);
            this.pictCustomer.MouseHover += new System.EventHandler(this.mpCustomer);
            // 
            // pictStore
            // 
            this.pictStore.BackColor = System.Drawing.Color.White;
            this.pictStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictStore.Image = global::BookStore.Properties.Resources.logo_book1;
            this.pictStore.Location = new System.Drawing.Point(251, 3);
            this.pictStore.Name = "pictStore";
            this.pictStore.Size = new System.Drawing.Size(242, 119);
            this.pictStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictStore.TabIndex = 1;
            this.pictStore.TabStop = false;
            this.pictStore.MouseLeave += new System.EventHandler(this.mplStore);
            this.pictStore.MouseHover += new System.EventHandler(this.mpStore);
            // 
            // pictSale
            // 
            this.pictSale.BackColor = System.Drawing.Color.White;
            this.pictSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictSale.Image = global::BookStore.Properties.Resources.logo_money;
            this.pictSale.Location = new System.Drawing.Point(499, 3);
            this.pictSale.Name = "pictSale";
            this.pictSale.Size = new System.Drawing.Size(244, 119);
            this.pictSale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictSale.TabIndex = 2;
            this.pictSale.TabStop = false;
            this.pictSale.MouseLeave += new System.EventHandler(this.mplSale);
            this.pictSale.MouseHover += new System.EventHandler(this.mpSale);
            // 
            // pictEnd
            // 
            this.pictEnd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictEnd.Image = global::BookStore.Properties.Resources.book_end;
            this.pictEnd.Location = new System.Drawing.Point(3, 264);
            this.pictEnd.Name = "pictEnd";
            this.pictEnd.Size = new System.Drawing.Size(746, 126);
            this.pictEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictEnd.TabIndex = 2;
            this.pictEnd.TabStop = false;
            // 
            // MenuShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.tblMain);
            this.MinimumSize = new System.Drawing.Size(768, 432);
            this.Name = "MenuShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tblMain.ResumeLayout(false);
            this.tblHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            this.tblUser.ResumeLayout(false);
            this.tblUser.PerformLayout();
            this.tblLogout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictLogout)).EndInit();
            this.tblMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictEnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.PictureBox pictLogo;
        private System.Windows.Forms.TableLayoutPanel tblMenu;
        private System.Windows.Forms.PictureBox pictEnd;
        private System.Windows.Forms.PictureBox pictCustomer;
        private System.Windows.Forms.PictureBox pictStore;
        private System.Windows.Forms.PictureBox pictSale;
        private System.Windows.Forms.TableLayoutPanel tblUser;
        private System.Windows.Forms.TableLayoutPanel tblLogout;
        private System.Windows.Forms.PictureBox pictLogout;
        public System.Windows.Forms.Label textUserName;
        private System.Windows.Forms.ToolTip toolTipLogout;
    }
}

