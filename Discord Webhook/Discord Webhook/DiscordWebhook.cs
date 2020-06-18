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

            Menu("Chat", true);
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
                    Send.PerformClick();
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

        private void Send_Click_1(object sender, EventArgs e)
        {
            if (content.Text == null)
            {
                Console.WriteLine("Good");
            }
            else
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
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void Chat_Click(object sender, EventArgs e)
        {
            Menu("Chat", true);
        }

        private void Menu(string menu, bool visible)
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
            }
        }
    }
}
