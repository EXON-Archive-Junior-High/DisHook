namespace Discord_Webhook
{
    partial class DiscordWebhook
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscordWebhook));
            this.name = new System.Windows.Forms.TextBox();
            this.image = new System.Windows.Forms.TextBox();
            this.content = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.repeat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.setting = new System.Windows.Forms.PictureBox();
            this.Chat = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.resetRepeat = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Send)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Location = new System.Drawing.Point(117, 96);
            this.name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(259, 21);
            this.name.TabIndex = 1;
            this.name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.name_KeyUp);
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Location = new System.Drawing.Point(117, 166);
            this.image.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(613, 21);
            this.image.TabIndex = 2;
            this.image.KeyUp += new System.Windows.Forms.KeyEventHandler(this.image_KeyUp);
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.White;
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.content.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.Location = new System.Drawing.Point(117, 240);
            this.content.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(613, 230);
            this.content.TabIndex = 3;
            this.content.TextChanged += new System.EventHandler(this.content_TextChanged);
            this.content.KeyDown += new System.Windows.Forms.KeyEventHandler(this.content_KeyDown);
            this.content.KeyUp += new System.Windows.Forms.KeyEventHandler(this.content_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(112, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(112, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Profile Image Link";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(112, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Content";
            // 
            // repeat
            // 
            this.repeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repeat.Location = new System.Drawing.Point(429, 95);
            this.repeat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(61, 21);
            this.repeat.TabIndex = 9;
            this.repeat.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(424, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Repeat";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.setting);
            this.panel1.Controls.Add(this.Chat);
            this.panel1.Location = new System.Drawing.Point(19, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 539);
            this.panel1.TabIndex = 13;
            // 
            // setting
            // 
            this.setting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("setting.BackgroundImage")));
            this.setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setting.Location = new System.Drawing.Point(5, 129);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(58, 58);
            this.setting.TabIndex = 16;
            this.setting.TabStop = false;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // Chat
            // 
            this.Chat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Chat.BackgroundImage")));
            this.Chat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chat.Location = new System.Drawing.Point(5, 32);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(55, 58);
            this.Chat.TabIndex = 15;
            this.Chat.TabStop = false;
            this.Chat.Click += new System.EventHandler(this.Chat_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(104, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(77, 43);
            this.title.TabIndex = 14;
            this.title.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(114, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(114, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.Color.Transparent;
            this.Send.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Send.BackgroundImage")));
            this.Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Send.Location = new System.Drawing.Point(117, 500);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(100, 50);
            this.Send.TabIndex = 20;
            this.Send.TabStop = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.Location = new System.Drawing.Point(650, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(100, 50);
            this.logout.TabIndex = 21;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click_1);
            // 
            // resetRepeat
            // 
            this.resetRepeat.AutoSize = true;
            this.resetRepeat.BackColor = System.Drawing.Color.Transparent;
            this.resetRepeat.ForeColor = System.Drawing.Color.White;
            this.resetRepeat.Location = new System.Drawing.Point(117, 350);
            this.resetRepeat.Name = "resetRepeat";
            this.resetRepeat.Size = new System.Drawing.Size(102, 19);
            this.resetRepeat.TabIndex = 23;
            this.resetRepeat.Text = "Reset Repeat";
            this.resetRepeat.UseVisualStyleBackColor = false;
            this.resetRepeat.CheckedChanged += new System.EventHandler(this.resetRepeat_CheckedChanged);
            // 
            // DiscordWebhook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(762, 562);
            this.Controls.Add(this.resetRepeat);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.repeat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.content);
            this.Controls.Add(this.image);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiscordWebhook";
            this.Text = " DisHook";
            this.Load += new System.EventHandler(this.DiscordWebhook_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Send)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox image;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox repeat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Chat;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox setting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Send;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.CheckBox resetRepeat;
    }
}

