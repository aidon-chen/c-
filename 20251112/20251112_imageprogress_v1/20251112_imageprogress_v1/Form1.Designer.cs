namespace _20251112_imageprogress_v1
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
            picOrg = new PictureBox();
            picProc = new PictureBox();
            btnOpenImage = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picOrg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProc).BeginInit();
            SuspendLayout();
            // 
            // picOrg
            // 
            picOrg.BorderStyle = BorderStyle.FixedSingle;
            picOrg.Location = new Point(98, 73);
            picOrg.Name = "picOrg";
            picOrg.Size = new Size(298, 405);
            picOrg.TabIndex = 0;
            picOrg.TabStop = false;
            // 
            // picProc
            // 
            picProc.BorderStyle = BorderStyle.FixedSingle;
            picProc.Location = new Point(586, 73);
            picProc.Name = "picProc";
            picProc.Size = new Size(298, 405);
            picProc.TabIndex = 1;
            picProc.TabStop = false;
            // 
            // btnOpenImage
            // 
            btnOpenImage.Location = new Point(40, 538);
            btnOpenImage.Name = "btnOpenImage";
            btnOpenImage.Size = new Size(193, 63);
            btnOpenImage.TabIndex = 2;
            btnOpenImage.Text = "打开图片";
            btnOpenImage.UseVisualStyleBackColor = true;
            btnOpenImage.Click += btnOpenImage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 25);
            label1.Name = "label1";
            label1.Size = new Size(63, 24);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 646);
            Controls.Add(label1);
            Controls.Add(btnOpenImage);
            Controls.Add(picProc);
            Controls.Add(picOrg);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picOrg).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picOrg;
        private PictureBox picProc;
        private Button btnOpenImage;
        private Label label1;
    }
}
