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
            this.name.Location = new System.Drawing.Point(205, 89);
            this.name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(223, 21);
            this.name.TabIndex = 1;
            this.name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.name_KeyUp);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(21, 171);
            this.image.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(633, 21);
            this.image.TabIndex = 2;
            this.image.KeyUp += new System.Windows.Forms.KeyEventHandler(this.image_KeyUp);
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(21, 259);
            this.content.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(633, 252);
            this.content.TabIndex = 3;
            this.content.TextChanged += new System.EventHandler(this.content_TextChanged);
            this.content.KeyDown += new System.Windows.Forms.KeyEventHandler(this.content_KeyDown);
            this.content.KeyUp += new System.Windows.Forms.KeyEventHandler(this.content_KeyUp);
            // 
            // Send
            // 
            this.Send.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.Location = new System.Drawing.Point(275, 520);
            this.Send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(64, 31);
            this.Send.TabIndex = 4;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(287, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(272, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Profile Image Link";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(285, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Content";
            // 
            // repeat
            // 
            this.repeat.Location = new System.Drawing.Point(48, 89);
            this.repeat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(53, 21);
            this.repeat.TabIndex = 9;
            this.repeat.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(49, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Repeat";
            // 
            // butLogOut
            // 
            this.butLogOut.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogOut.Location = new System.Drawing.Point(611, 16);
            this.butLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butLogOut.Name = "butLogOut";
            this.butLogOut.Size = new System.Drawing.Size(64, 31);
            this.butLogOut.TabIndex = 11;
            this.butLogOut.Text = "Log Out";
            this.butLogOut.UseVisualStyleBackColor = true;
            this.butLogOut.Click += new System.EventHandler(this.butLogOut_Click);
            // 
            // DiscordWebhook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(686, 600);
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
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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

