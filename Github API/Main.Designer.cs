using System.Windows.Forms;

namespace BMO_Admin
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.nowtime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dText = new System.Windows.Forms.TextBox();
            this.versiontext = new System.Windows.Forms.RichTextBox();
            this.eText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Decode = new System.Windows.Forms.Button();
            this.Encode = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.token = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.repotext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dirtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 15.75F);
            this.label1.Location = new System.Drawing.Point(23, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Decrypt";
            this.label1.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.linkLabel1.Location = new System.Drawing.Point(254, 304);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.linkLabel1.Size = new System.Drawing.Size(86, 21);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "BMO - Github";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.linkLabel2.Location = new System.Drawing.Point(254, 325);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.linkLabel2.Size = new System.Drawing.Size(44, 21);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Config";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // nowtime
            // 
            this.nowtime.AutoSize = true;
            this.nowtime.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.nowtime.Location = new System.Drawing.Point(8, 326);
            this.nowtime.Name = "nowtime";
            this.nowtime.Size = new System.Drawing.Size(39, 21);
            this.nowtime.TabIndex = 0;
            this.nowtime.Text = "Time:";
            this.nowtime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dText
            // 
            this.dText.Font = new System.Drawing.Font("Dubai", 8.999999F);
            this.dText.Location = new System.Drawing.Point(26, 166);
            this.dText.MaxLength = 64;
            this.dText.Name = "dText";
            this.dText.Size = new System.Drawing.Size(205, 28);
            this.dText.TabIndex = 3;
            this.dText.Visible = false;
            // 
            // versiontext
            // 
            this.versiontext.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versiontext.Location = new System.Drawing.Point(254, 88);
            this.versiontext.MaxLength = 128;
            this.versiontext.Name = "versiontext";
            this.versiontext.Size = new System.Drawing.Size(314, 175);
            this.versiontext.TabIndex = 5;
            this.versiontext.Text = "";
            // 
            // eText
            // 
            this.eText.Font = new System.Drawing.Font("Dubai", 8.999999F);
            this.eText.Location = new System.Drawing.Point(26, 87);
            this.eText.MaxLength = 64;
            this.eText.Name = "eText";
            this.eText.Size = new System.Drawing.Size(205, 28);
            this.eText.TabIndex = 1;
            this.eText.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 15.75F);
            this.label3.Location = new System.Drawing.Point(23, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Encrypt";
            this.label3.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Dubai", 8.999999F);
            this.button1.Location = new System.Drawing.Point(316, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Send API Request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Decode
            // 
            this.Decode.Font = new System.Drawing.Font("Dubai", 8.999999F);
            this.Decode.Location = new System.Drawing.Point(179, 198);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(52, 23);
            this.Decode.TabIndex = 4;
            this.Decode.Text = "Go!";
            this.Decode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Decode.UseVisualStyleBackColor = true;
            this.Decode.Visible = false;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // Encode
            // 
            this.Encode.Font = new System.Drawing.Font("Dubai", 8.999999F);
            this.Encode.Location = new System.Drawing.Point(179, 119);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(52, 23);
            this.Encode.TabIndex = 12;
            this.Encode.Text = "Go!";
            this.Encode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.Visible = false;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Dubai", 8.999999F);
            this.login.Location = new System.Drawing.Point(163, 79);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(69, 27);
            this.login.TabIndex = 2;
            this.login.Text = "Login!";
            this.login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // token
            // 
            this.token.Font = new System.Drawing.Font("Dubai", 8.999999F);
            this.token.Location = new System.Drawing.Point(27, 49);
            this.token.MaxLength = 64;
            this.token.Name = "token";
            this.token.Size = new System.Drawing.Size(205, 28);
            this.token.TabIndex = 0;
            this.token.Text = "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";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 15.75F);
            this.label4.Location = new System.Drawing.Point(24, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 34);
            this.label4.TabIndex = 13;
            this.label4.Text = "Github Token";
            // 
            // repotext
            // 
            this.repotext.Font = new System.Drawing.Font("Dubai", 8.999999F);
            this.repotext.Location = new System.Drawing.Point(363, 19);
            this.repotext.MaxLength = 64;
            this.repotext.Name = "repotext";
            this.repotext.Size = new System.Drawing.Size(205, 28);
            this.repotext.TabIndex = 14;
            this.repotext.Text = "BMO_Config";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 15.75F);
            this.label5.Location = new System.Drawing.Point(251, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 34);
            this.label5.TabIndex = 15;
            this.label5.Text = "Repository:";
            // 
            // dirtext
            // 
            this.dirtext.Font = new System.Drawing.Font("Dubai", 8.999999F);
            this.dirtext.Location = new System.Drawing.Point(363, 53);
            this.dirtext.MaxLength = 64;
            this.dirtext.Name = "dirtext";
            this.dirtext.Size = new System.Drawing.Size(205, 28);
            this.dirtext.TabIndex = 16;
            this.dirtext.Text = "data/version.ini";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 15.75F);
            this.label2.Location = new System.Drawing.Point(251, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "Directory:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Dubai", 8.999999F);
            this.button2.Location = new System.Drawing.Point(254, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 26);
            this.button2.TabIndex = 18;
            this.button2.Text = "Get";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Dubai", 8.999999F);
            this.button3.Image = global::Github_API.Properties.Resources.logout_32;
            this.button3.Location = new System.Drawing.Point(519, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 46);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 121);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.login);
            this.Controls.Add(this.token);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dirtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.repotext);
            this.Controls.Add(this.Decode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.versiontext);
            this.Controls.Add(this.dText);
            this.Controls.Add(this.nowtime);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Encode);
            this.Controls.Add(this.eText);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to GitHub API";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label nowtime;
        private Timer timer1;
        private TextBox dText;
        private RichTextBox versiontext;
        private TextBox eText;
        private Label label3;
        private Button button1;
        private Button Decode;
        private Button Encode;
        private Button login;
        private TextBox token;
        private Label label4;
        private TextBox repotext;
        private Label label5;
        private TextBox dirtext;
        private Label label2;
        private Button button2;
        private ImageList imageList1;
        private Button button3;
    }
}