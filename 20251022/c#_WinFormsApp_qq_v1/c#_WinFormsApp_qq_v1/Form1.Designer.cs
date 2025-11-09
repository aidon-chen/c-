namespace c__WinFormsApp_qq_v1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            pichead = new PictureBox();
            pictureBox1 = new PictureBox();
            txtAccount = new TextBox();
            textBox2 = new TextBox();
            pictureBox3 = new PictureBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            labFindPasswards = new Label();
            labSignUp = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel2 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            picAdd = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictSetUp = new PictureBox();
            picMinus = new PictureBox();
            picClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pichead).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictSetUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft YaHei UI", 12F);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(117, 315);
            button1.Name = "button1";
            button1.Size = new Size(258, 33);
            button1.TabIndex = 0;
            button1.Text = "登录";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pichead
            // 
            pichead.BackColor = Color.Transparent;
            pichead.BackgroundImage = Properties.Resources.b566292218baf3a7acbfb0ae6c76ac40;
            pichead.BackgroundImageLayout = ImageLayout.Stretch;
            pichead.Location = new Point(165, 60);
            pichead.Name = "pichead";
            pichead.Size = new Size(144, 136);
            pichead.TabIndex = 2;
            pichead.TabStop = false;
            pichead.MouseEnter += pichead_MouseEnter;
            pichead.MouseLeave += pichead_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(117, 193);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 32);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtAccount
            // 
            txtAccount.BorderStyle = BorderStyle.None;
            txtAccount.Font = new Font("Microsoft YaHei UI", 13F);
            txtAccount.Location = new Point(145, 202);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(207, 23);
            txtAccount.TabIndex = 4;
            txtAccount.MouseEnter += txtAccount_MouseEnter;
            txtAccount.MouseLeave += txtAccount_MouseLeave;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft YaHei UI", 13F);
            textBox2.Location = new Point(145, 249);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 23);
            textBox2.TabIndex = 5;
            textBox2.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(117, 243);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 29);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(117, 288);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 21);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "自动登录";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.Location = new Point(220, 288);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(75, 21);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "记住密码";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // labFindPasswards
            // 
            labFindPasswards.AutoSize = true;
            labFindPasswards.BackColor = Color.Transparent;
            labFindPasswards.ForeColor = Color.DarkGray;
            labFindPasswards.Location = new Point(315, 289);
            labFindPasswards.Name = "labFindPasswards";
            labFindPasswards.Size = new Size(56, 17);
            labFindPasswards.TabIndex = 9;
            labFindPasswards.Text = "找回密码";
            labFindPasswards.MouseEnter += labFindPasswards_MouseEnter;
            labFindPasswards.MouseLeave += labFindPasswards_MouseLeave;
            // 
            // labSignUp
            // 
            labSignUp.AutoSize = true;
            labSignUp.BackColor = Color.Transparent;
            labSignUp.ForeColor = Color.DarkGray;
            labSignUp.Location = new Point(33, 325);
            labSignUp.Name = "labSignUp";
            labSignUp.Size = new Size(56, 17);
            labSignUp.TabIndex = 10;
            labSignUp.Text = "注册账号";
            labSignUp.MouseEnter += labSignUp_MouseEnter;
            labSignUp.MouseLeave += labSignUp_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(117, 227);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 3);
            panel1.TabIndex = 11;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(453, 316);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 32);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(340, 243);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 32);
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(117, 278);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 3);
            panel2.TabIndex = 12;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(344, 195);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 32);
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(3, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 32);
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // picAdd
            // 
            picAdd.BackColor = Color.Transparent;
            picAdd.BackgroundImage = (Image)resources.GetObject("picAdd.BackgroundImage");
            picAdd.BackgroundImageLayout = ImageLayout.Stretch;
            picAdd.Location = new Point(220, 111);
            picAdd.Name = "picAdd";
            picAdd.Size = new Size(39, 41);
            picAdd.TabIndex = 16;
            picAdd.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick_1;
            // 
            // pictSetUp
            // 
            pictSetUp.BackColor = Color.Transparent;
            pictSetUp.BackgroundImage = (Image)resources.GetObject("pictSetUp.BackgroundImage");
            pictSetUp.Location = new Point(387, 3);
            pictSetUp.Name = "pictSetUp";
            pictSetUp.Size = new Size(31, 32);
            pictSetUp.TabIndex = 17;
            pictSetUp.TabStop = false;
            pictSetUp.MouseEnter += pictSetUp_MouseEnter;
            pictSetUp.MouseLeave += pictSetUp_MouseLeave;
            // 
            // picMinus
            // 
            picMinus.BackColor = Color.Transparent;
            picMinus.BackgroundImage = (Image)resources.GetObject("picMinus.BackgroundImage");
            picMinus.BackgroundImageLayout = ImageLayout.Center;
            picMinus.Location = new Point(424, 3);
            picMinus.Name = "picMinus";
            picMinus.Size = new Size(31, 32);
            picMinus.TabIndex = 18;
            picMinus.TabStop = false;
            picMinus.MouseEnter += pictSetUp_MouseEnter;
            picMinus.MouseLeave += pictSetUp_MouseLeave;
            // 
            // picClose
            // 
            picClose.BackColor = Color.Transparent;
            picClose.BackgroundImage = (Image)resources.GetObject("picClose.BackgroundImage");
            picClose.BackgroundImageLayout = ImageLayout.Center;
            picClose.Location = new Point(461, 3);
            picClose.Name = "picClose";
            picClose.Size = new Size(31, 32);
            picClose.TabIndex = 19;
            picClose.TabStop = false;
            picClose.MouseEnter += picClose_MouseEnter;
            picClose.MouseLeave += picClose_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.back;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(496, 369);
            Controls.Add(picClose);
            Controls.Add(picMinus);
            Controls.Add(pictSetUp);
            Controls.Add(pichead);
            Controls.Add(picAdd);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(panel2);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            Controls.Add(labSignUp);
            Controls.Add(labFindPasswards);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(txtAccount);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pichead).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictSetUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinus).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pichead;
        private PictureBox pictureBox1;
        private TextBox txtAccount;
        private TextBox textBox2;
        private PictureBox pictureBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label labFindPasswards;
        private Label labSignUp;
        private Panel panel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Panel panel2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox picAdd;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictSetUp;
        private PictureBox picMinus;
        private PictureBox picClose;
    }
}
