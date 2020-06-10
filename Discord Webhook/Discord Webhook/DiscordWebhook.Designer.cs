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
            this.name = new System.Windows.Forms.TextBox();
            this.image = new System.Windows.Forms.TextBox();
            this.content = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.repeat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.butLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(226, 133);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(260, 21);
            this.name.TabIndex = 1;
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(12, 194);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(738, 21);
            this.image.TabIndex = 2;
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(12, 260);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(738, 85);
            this.content.TabIndex = 3;
            this.content.TextChanged += new System.EventHandler(this.content_TextChanged);
            this.content.KeyUp += new System.Windows.Forms.KeyEventHandler(this.content_KeyUp);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(321, 390);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 4;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Profile Image Link";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Content";
            // 
            // repeat
            // 
            this.repeat.Location = new System.Drawing.Point(312, 363);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(61, 21);
            this.repeat.TabIndex = 9;
            this.repeat.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Repeat";
            // 
            // butLogOut
            // 
            this.butLogOut.Location = new System.Drawing.Point(713, 12);
            this.butLogOut.Name = "butLogOut";
            this.butLogOut.Size = new System.Drawing.Size(75, 23);
            this.butLogOut.TabIndex = 11;
            this.butLogOut.Text = "Log Out";
            this.butLogOut.UseVisualStyleBackColor = true;
            this.butLogOut.Click += new System.EventHandler(this.butLogOut_Click);
            // 
            // DiscordWebhook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butLogOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.repeat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.content);
            this.Controls.Add(this.image);
            this.Controls.Add(this.name);
            this.Name = "DiscordWebhook";
            this.Text = "Discord Webhook";
            this.Load += new System.EventHandler(this.DiscordWebhook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox image;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox repeat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butLogOut;
    }
}

