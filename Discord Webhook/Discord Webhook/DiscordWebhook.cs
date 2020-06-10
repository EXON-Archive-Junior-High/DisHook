﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Discord_Webhook
{
    public partial class DiscordWebhook : Form
    {
        public DiscordWebhook()
        {
            InitializeComponent();
        }

        private void DiscordWebhook_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            using (DcWebHook dcWeb = new DcWebHook())
            {
                dcWeb.ProfilePicture = image.Text;
                dcWeb.UserName = name.Text;
                dcWeb.WebHook = Data.discordLink;

                if (repeat.Text == "")
                {
                    MessageBox.Show("숫자를 입력하세요");
                    return;
                }
                if (Convert.ToInt32(repeat.Text) < 6)
                {
                    for (int i = 0; i < Convert.ToInt32(repeat.Text); i++)
                    {
                        dcWeb.SendMessage(content.Text);
                    }
                }
                else
                {
                    for (int i = 0; i < Convert.ToInt32(repeat.Text); i++)
                    {
                        dcWeb.SendMessage(content.Text);
                        Thread.Sleep(3);
                    }
                }
            }
        }
    }
}