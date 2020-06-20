using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Net;

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
            login.ShowDialog();

            VisibleMenu("Chat", true);
            VisibleMenu("Setting", false);
            ChangeMenu("Chat", true);

        }


        private void content_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void content_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!e.Shift)
                {
                    Send_click();
                    content.Text = string.Empty;

                }

            }
        }



        private void content_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void name_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                image.Focus();
            }
        }


        private void image_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                content.Focus();
            }
        }






        private void ChangeMenu(string menu, bool visible)
        {
            switch (menu)
            {
                case "Chat":
                    title.Text = "Chat";
                    label2.Text = "Name";
                    label3.Text = "Profile Image Link";
                    label4.Text = "Content";
                    label5.Text = "Repeat";
                    break;

                case "Setting":
                    title.Text = "Setting";
                    label2.Text = "Developer";
                    label1.Text = "EXON";
                    label3.Text = "Info";
                    label6.Text = "엑슨이 만든 디스코드 커스텀 웹훅 프로그램입니다.";
                    label4.Text = "Contact";
                    label7.Text = "Github: https://github.com/1-EXON \n" +
                        "Discord: EXON#0062\n";
                    break;
            }
        }

        private void VisibleMenu(string menu, bool visible)
        {
            switch (menu)
            {
                case "Chat":
                    name.Visible = visible;
                    image.Visible = visible;
                    content.Visible = visible;
                    repeat.Visible = visible;
                    label5.Visible = visible;
                    Send.Visible = visible;
                    break;

                case "Setting":
                    label1.Visible = visible;
                    label6.Visible = visible;
                    label7.Visible = visible;
                    resetRepeat.Visible = visible;
                    label8.Visible = visible;
                    break;

            }
        }

        private void Chat_Click(object sender, EventArgs e)
        {
            VisibleMenu("Chat", true);
            VisibleMenu("Setting", false);
            ChangeMenu("Chat", true);
        }

        private void setting_Click(object sender, EventArgs e)
        {
            ChangeMenu("Setting", true);
            VisibleMenu("Setting", true);
            VisibleMenu("Chat", false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/1-EXON");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/1-EXON");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/1-EXON/DisHook");
        }

        private void Send_Click(object sender, EventArgs e)
        {
            Send_click();
            content.Text = string.Empty;
        }

        private void Send_click()
        {
            if (content.Text == string.Empty)
            {
                MessageBox.Show("메세지를 입력하세요");
                Console.WriteLine("Empty");
            }
            else
            {
                using (DcWebHook dcWeb = new DcWebHook())
                {
                    dcWeb.ProfilePicture = image.Text;
                    dcWeb.UserName = name.Text;
                    dcWeb.WebHook = Data.discordLink;

                    //Emved TEST

                    //NameValueCollection embed = new NameValueCollection
                    //{
                    //    {
                    //        "username",
                    //        this.name.Text
                    //    },
                    //    {
                    //        "avatar_url",
                    //        this.image.Text
                    //    },
                    //    {
                    //        "content",
                    //        this.content.Text
                    //    },
                    //    {
                    //        "title",
                    //        this.content.Text
                    //    }
                    //};

                    if (repeat.Text == "")
                    {
                        MessageBox.Show("숫자를 입력하세요");
                        return;
                    }

                    else if (Convert.ToInt32(repeat.Text) < 6)
                    {

                        for (int i = 0; i < Convert.ToInt32(repeat.Text); i++)
                        {
                            dcWeb.SendMessage(content.Text);

                        }
                    }

                    //서른개 넘어가면 1초도 에러
                    else if (Convert.ToInt32(repeat.Text) <= 0)
                    {
                        MessageBox.Show("0 이하의 수는 입력하실 수 없습니다.");
                    }
                    else
                    {

                        for (int i = 0; i < Convert.ToInt32(repeat.Text); i++)
                        {
                            dcWeb.SendMessage(content.Text);
                            Thread.Sleep(1 * 1000);
                        }
                    }
                }
            }

            if (Data.resetRepeat == true)
            {
                repeat.Text = "1";
            }

        }
        private void logout_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void resetRepeat_CheckedChanged(object sender, EventArgs e)
        {
            Data.resetRepeat = resetRepeat.Checked;
        }
    }
}
