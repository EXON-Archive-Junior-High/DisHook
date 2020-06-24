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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label8 = new System.Windows.Forms.Label();
            this.help_but = new System.Windows.Forms.PictureBox();
            this.resetContent = new System.Windows.Forms.CheckBox();
            this.buttonGradation = new System.Windows.Forms.CheckBox();
            this.Thema = new System.Windows.Forms.CheckBox();
            this.name = new Guna.UI2.WinForms.Guna2TextBox();
            this.repeat = new Guna.UI2.WinForms.Guna2TextBox();
            this.image = new Guna.UI2.WinForms.Guna2TextBox();
            this.content = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Send)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.help_but)).BeginInit();
            this.SuspendLayout();
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
            this.setting.Location = new System.Drawing.Point(10, 129);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(47, 46);
            this.setting.TabIndex = 16;
            this.setting.TabStop = false;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // Chat
            // 
            this.Chat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Chat.BackgroundImage")));
            this.Chat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chat.Location = new System.Drawing.Point(10, 32);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(47, 49);
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
            this.logout.Location = new System.Drawing.Point(661, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(89, 43);
            this.logout.TabIndex = 21;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click_1);
            // 
            // resetRepeat
            // 
            this.resetRepeat.AutoSize = true;
            this.resetRepeat.BackColor = System.Drawing.Color.Transparent;
            this.resetRepeat.ForeColor = System.Drawing.Color.White;
            this.resetRepeat.Location = new System.Drawing.Point(117, 360);
            this.resetRepeat.Name = "resetRepeat";
            this.resetRepeat.Size = new System.Drawing.Size(102, 19);
            this.resetRepeat.TabIndex = 23;
            this.resetRepeat.Text = "Reset Repeat";
            this.resetRepeat.UseVisualStyleBackColor = false;
            this.resetRepeat.CheckedChanged += new System.EventHandler(this.resetRepeat_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(113, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Setting";
            // 
            // help_but
            // 
            this.help_but.BackColor = System.Drawing.Color.Transparent;
            this.help_but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("help_but.BackgroundImage")));
            this.help_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help_but.Location = new System.Drawing.Point(690, 516);
            this.help_but.Name = "help_but";
            this.help_but.Size = new System.Drawing.Size(60, 35);
            this.help_but.TabIndex = 25;
            this.help_but.TabStop = false;
            this.help_but.Click += new System.EventHandler(this.help_but_Click);
            // 
            // resetContent
            // 
            this.resetContent.AutoSize = true;
            this.resetContent.BackColor = System.Drawing.Color.Transparent;
            this.resetContent.Checked = true;
            this.resetContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.resetContent.ForeColor = System.Drawing.Color.White;
            this.resetContent.Location = new System.Drawing.Point(117, 385);
            this.resetContent.Name = "resetContent";
            this.resetContent.Size = new System.Drawing.Size(105, 19);
            this.resetContent.TabIndex = 26;
            this.resetContent.Text = "Reset Content";
            this.resetContent.UseVisualStyleBackColor = false;
            this.resetContent.CheckedChanged += new System.EventHandler(this.resetContent_CheckedChanged);
            // 
            // buttonGradation
            // 
            this.buttonGradation.AutoSize = true;
            this.buttonGradation.BackColor = System.Drawing.Color.Transparent;
            this.buttonGradation.ForeColor = System.Drawing.Color.White;
            this.buttonGradation.Location = new System.Drawing.Point(117, 410);
            this.buttonGradation.Name = "buttonGradation";
            this.buttonGradation.Size = new System.Drawing.Size(118, 19);
            this.buttonGradation.TabIndex = 27;
            this.buttonGradation.Text = "Button Gradation";
            this.buttonGradation.UseVisualStyleBackColor = false;
            this.buttonGradation.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Thema
            // 
            this.Thema.AutoSize = true;
            this.Thema.BackColor = System.Drawing.Color.Transparent;
            this.Thema.Checked = true;
            this.Thema.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Thema.ForeColor = System.Drawing.Color.White;
            this.Thema.Location = new System.Drawing.Point(117, 335);
            this.Thema.Name = "Thema";
            this.Thema.Size = new System.Drawing.Size(98, 19);
            this.Thema.TabIndex = 28;
            this.Thema.Text = "Black Thema";
            this.Thema.UseVisualStyleBackColor = false;
            this.Thema.CheckedChanged += new System.EventHandler(this.Thema_CheckedChanged);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.BorderColor = System.Drawing.Color.Transparent;
            this.name.BorderRadius = 15;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.DefaultText = "";
            this.name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.DisabledState.Parent = this.name;
            this.name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.FocusedState.Parent = this.name;
            this.name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.HoverState.Parent = this.name;
            this.name.Location = new System.Drawing.Point(112, 95);
            this.name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.PlaceholderText = "";
            this.name.SelectedText = "";
            this.name.ShadowDecoration.Parent = this.name;
            this.name.Size = new System.Drawing.Size(214, 30);
            this.name.TabIndex = 29;
            this.name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.name_KeyUp_1);
            // 
            // repeat
            // 
            this.repeat.BackColor = System.Drawing.Color.Transparent;
            this.repeat.BorderColor = System.Drawing.Color.Transparent;
            this.repeat.BorderRadius = 15;
            this.repeat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.repeat.DefaultText = "1";
            this.repeat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.repeat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.repeat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.repeat.DisabledState.Parent = this.repeat;
            this.repeat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.repeat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.repeat.FocusedState.Parent = this.repeat;
            this.repeat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeat.ForeColor = System.Drawing.Color.Black;
            this.repeat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.repeat.HoverState.Parent = this.repeat;
            this.repeat.Location = new System.Drawing.Point(428, 98);
            this.repeat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.repeat.Name = "repeat";
            this.repeat.PasswordChar = '\0';
            this.repeat.PlaceholderText = "";
            this.repeat.SelectedText = "";
            this.repeat.SelectionStart = 1;
            this.repeat.ShadowDecoration.Parent = this.repeat;
            this.repeat.Size = new System.Drawing.Size(56, 30);
            this.repeat.TabIndex = 30;
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.Transparent;
            this.image.BorderColor = System.Drawing.Color.Transparent;
            this.image.BorderRadius = 15;
            this.image.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.image.DefaultText = "";
            this.image.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.image.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.image.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.image.DisabledState.Parent = this.image;
            this.image.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.image.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.image.FocusedState.Parent = this.image;
            this.image.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image.ForeColor = System.Drawing.Color.Black;
            this.image.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.image.HoverState.Parent = this.image;
            this.image.Location = new System.Drawing.Point(112, 168);
            this.image.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.image.Name = "image";
            this.image.PasswordChar = '\0';
            this.image.PlaceholderText = "";
            this.image.SelectedText = "";
            this.image.ShadowDecoration.Parent = this.image;
            this.image.Size = new System.Drawing.Size(539, 30);
            this.image.TabIndex = 31;
            this.image.KeyUp += new System.Windows.Forms.KeyEventHandler(this.image_KeyUp_1);
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.Transparent;
            this.content.BorderColor = System.Drawing.Color.Transparent;
            this.content.BorderRadius = 15;
            this.content.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.content.DefaultText = "";
            this.content.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.content.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.content.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.content.DisabledState.Parent = this.content;
            this.content.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.content.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.content.FocusedState.Parent = this.content;
            this.content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.ForeColor = System.Drawing.Color.Black;
            this.content.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.content.HoverState.Parent = this.content;
            this.content.Location = new System.Drawing.Point(112, 242);
            this.content.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.PasswordChar = '\0';
            this.content.PlaceholderText = "";
            this.content.SelectedText = "";
            this.content.ShadowDecoration.Parent = this.content;
            this.content.Size = new System.Drawing.Size(539, 234);
            this.content.TabIndex = 32;
            this.content.TextChanged += new System.EventHandler(this.content_TextChanged_1);
            this.content.KeyUp += new System.Windows.Forms.KeyEventHandler(this.content_KeyUp);
            // 
            // DiscordWebhook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(762, 562);
            this.Controls.Add(this.content);
            this.Controls.Add(this.image);
            this.Controls.Add(this.repeat);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Thema);
            this.Controls.Add(this.buttonGradation);
            this.Controls.Add(this.resetContent);
            this.Controls.Add(this.help_but);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.resetRepeat);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DiscordWebhook";
            this.Text = " DisHook";
            this.Load += new System.EventHandler(this.DiscordWebhook_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Send)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.help_but)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox help_but;
        private System.Windows.Forms.CheckBox resetRepeat;
        private System.Windows.Forms.CheckBox resetContent;
        private System.Windows.Forms.CheckBox buttonGradation;
        private System.Windows.Forms.CheckBox Thema;
        private Guna.UI2.WinForms.Guna2TextBox name;
        private Guna.UI2.WinForms.Guna2TextBox repeat;
        private Guna.UI2.WinForms.Guna2TextBox image;
        private Guna.UI2.WinForms.Guna2TextBox content;
    }
}

