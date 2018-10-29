namespace BookStore
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nameform = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.pictCancel = new System.Windows.Forms.PictureBox();
            this.pictOK = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictOK)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUserID
            // 
            this.tbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbUserID.Location = new System.Drawing.Point(174, 73);
            this.tbUserID.MaxLength = 50;
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(509, 26);
            this.tbUserID.TabIndex = 6;
            this.tbUserID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnter);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPassword.Location = new System.Drawing.Point(174, 105);
            this.tbPassword.MaxLength = 50;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(509, 26);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnter);
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbTitle.Location = new System.Drawing.Point(174, 137);
            this.tbTitle.MaxLength = 10;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(509, 26);
            this.tbTitle.TabIndex = 8;
            this.tbTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnter);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbFirstName.Location = new System.Drawing.Point(174, 169);
            this.tbFirstName.MaxLength = 60;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(509, 26);
            this.tbFirstName.TabIndex = 9;
            this.tbFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnter);
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbLastName.Location = new System.Drawing.Point(174, 201);
            this.tbLastName.MaxLength = 60;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(509, 26);
            this.tbLastName.TabIndex = 10;
            this.tbLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnter);
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbAddress.Location = new System.Drawing.Point(174, 233);
            this.tbAddress.MaxLength = 200;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(509, 26);
            this.tbAddress.TabIndex = 11;
            this.tbAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(52, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "ที่อยู่";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(52, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "นามสกุล";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(52, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "ชื่อ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(52, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "คำนำหน้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(52, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "รหัสผ่าน";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(52, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "รหัสพนักงาน";
            // 
            // Nameform
            // 
            this.Nameform.AutoSize = true;
            this.Nameform.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Nameform.Location = new System.Drawing.Point(270, 19);
            this.Nameform.Name = "Nameform";
            this.Nameform.Size = new System.Drawing.Size(239, 37);
            this.Nameform.TabIndex = 18;
            this.Nameform.Text = "เพิ่มข้อมูลพนักงาน";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(52, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "เบอร์โทร";
            // 
            // tbTel
            // 
            this.tbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbTel.Location = new System.Drawing.Point(174, 265);
            this.tbTel.MaxLength = 10;
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(509, 26);
            this.tbTel.TabIndex = 23;
            this.tbTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressEnter);
            this.tbTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressNumber);
            // 
            // pictCancel
            // 
            this.pictCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictCancel.Image = ((System.Drawing.Image)(resources.GetObject("pictCancel.Image")));
            this.pictCancel.Location = new System.Drawing.Point(633, 314);
            this.pictCancel.Name = "pictCancel";
            this.pictCancel.Size = new System.Drawing.Size(50, 50);
            this.pictCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictCancel.TabIndex = 22;
            this.pictCancel.TabStop = false;
            this.pictCancel.Click += new System.EventHandler(this.pictCancel_Click);
            this.pictCancel.MouseLeave += new System.EventHandler(this.mplCancel);
            this.pictCancel.MouseHover += new System.EventHandler(this.mpCancel);
            // 
            // pictOK
            // 
            this.pictOK.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictOK.Image = ((System.Drawing.Image)(resources.GetObject("pictOK.Image")));
            this.pictOK.Location = new System.Drawing.Point(543, 314);
            this.pictOK.Name = "pictOK";
            this.pictOK.Size = new System.Drawing.Size(50, 50);
            this.pictOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictOK.TabIndex = 21;
            this.pictOK.TabStop = false;
            this.pictOK.Click += new System.EventHandler(this.pictOK_Click);
            this.pictOK.MouseLeave += new System.EventHandler(this.mplOK);
            this.pictOK.MouseHover += new System.EventHandler(this.mpOK);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.pictCancel);
            this.Controls.Add(this.pictOK);
            this.Controls.Add(this.Nameform);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserID);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(768, 432);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(768, 432);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nameform;
        public System.Windows.Forms.TextBox tbUserID;
        public System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pictOK;
        private System.Windows.Forms.PictureBox pictCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTel;
    }
}