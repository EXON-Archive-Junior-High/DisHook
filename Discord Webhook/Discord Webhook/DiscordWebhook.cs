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
        }
        static string contentCopy;
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
                else if (Convert.ToInt32(repeat.Text) < 6)
                {
                    for (int i = 0; i < Convert.ToInt32(repeat.Text); i++)
                    {
                        dcWeb.SendMessage(contentCopy);
                        
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
                        dcWeb.SendMessage(contentCopy);
                        Thread.Sleep(1 * 1000);
                    }
                }
            }
        }


        private void content_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void content_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Shift)
                {
                    content.Text += Environment.NewLine;
                }
                else
                {
                    contentCopy = content.Text;
                    content.Text = string.Empty;
                    Send.PerformClick();

                }
            }
        }

        private void butLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        public static void MainClose()
        {
            
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
    }
}
