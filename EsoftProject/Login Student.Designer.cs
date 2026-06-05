namespace EsoftProject
{
    partial class Login_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Student));
            this.linklblregister = new System.Windows.Forms.LinkLabel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.checkboxpassword = new System.Windows.Forms.CheckBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linklblregister
            // 
            this.linklblregister.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linklblregister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linklblregister.AutoSize = true;
            this.linklblregister.BackColor = System.Drawing.Color.Transparent;
            this.linklblregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblregister.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linklblregister.LinkColor = System.Drawing.Color.Red;
            this.linklblregister.Location = new System.Drawing.Point(367, 596);
            this.linklblregister.Name = "linklblregister";
            this.linklblregister.Size = new System.Drawing.Size(413, 24);
            this.linklblregister.TabIndex = 22;
            this.linklblregister.TabStop = true;
            this.linklblregister.Text = "If you haven\'t registered yet, Register Here!";
            this.linklblregister.UseWaitCursor = true;
            this.linklblregister.VisitedLinkColor = System.Drawing.Color.White;
            this.linklblregister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblregister_LinkClicked);
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1015, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(75, 75);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 21;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // checkboxpassword
            // 
            this.checkboxpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkboxpassword.AutoSize = true;
            this.checkboxpassword.BackColor = System.Drawing.Color.Transparent;
            this.checkboxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxpassword.ForeColor = System.Drawing.Color.Red;
            this.checkboxpassword.Location = new System.Drawing.Point(761, 473);
            this.checkboxpassword.Name = "checkboxpassword";
            this.checkboxpassword.Size = new System.Drawing.Size(164, 24);
            this.checkboxpassword.TabIndex = 20;
            this.checkboxpassword.Text = "Show Password";
            this.checkboxpassword.UseVisualStyleBackColor = false;
            this.checkboxpassword.CheckedChanged += new System.EventHandler(this.checkboxpassword_CheckedChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(344, 424);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(583, 45);
            this.txtpassword.TabIndex = 18;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(344, 325);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(583, 45);
            this.txtusername.TabIndex = 19;
            // 
            // lblpassword
            // 
            this.lblpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.Yellow;
            this.lblpassword.Location = new System.Drawing.Point(125, 430);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(175, 39);
            this.lblpassword.TabIndex = 15;
            this.lblpassword.Text = "Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(430, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 69);
            this.label1.TabIndex = 16;
            this.label1.Text = "LOGIN";
            // 
            // lblusername
            // 
            this.lblusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.Yellow;
            this.lblusername.Location = new System.Drawing.Point(125, 328);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(198, 39);
            this.lblusername.TabIndex = 17;
            this.lblusername.Text = "User Name";
            // 
            // pbLogin
            // 
            this.pbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogin.BackColor = System.Drawing.Color.Transparent;
            this.pbLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbLogin.Image")));
            this.pbLogin.Location = new System.Drawing.Point(424, 633);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(305, 138);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 14;
            this.pbLogin.TabStop = false;
            this.pbLogin.Click += new System.EventHandler(this.pbLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1102, 790);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linklblregister);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.checkboxpassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.pbLogin);
            this.DoubleBuffered = true;
            this.Name = "Login_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Student";
            this.Load += new System.EventHandler(this.Login_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklblregister;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.CheckBox checkboxpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}