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
            this.Text = "DisHook v1.5";

            Login login = new Login();
            login.ShowDialog();

            VisibleMenu("Chat", true);
            VisibleMenu("Setting", false);
            ChangeMenu("Chat", true);

            ButtonGradation();
            ChageThema();
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
                    //엔터지우기 하는중
                    char[] contentChar = content.Text.ToCharArray();

                    Send_click();

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




        #region Menu

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
                    resetContent.Visible = visible;
                    buttonGradation.Visible = visible;
                    Thema.Visible = visible;
                    break;

            }
        }

        #endregion

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

        #region Info
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

        #endregion

        private void Send_Click(object sender, EventArgs e)
        {
            Send_click();
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

                    #region Embed Test
                    //Embed TEST

                    //NameValueCollection embed = new NameValueCollection
                    //{    
                    //    {
                    //        "title",
                    //        this.content.Text
                    //    },
                    //    {
                    //        "description",
                    //        "안녕"
                    //    },
                    //    {
                    //        "color",
                    //        "#ffffff"
                    //    }
                    //};
                    //    NameValueCollection msg = new NameValueCollection
                    //    {
                    //        {
                    //            "username",
                    //            this.name.Text
                    //        },
                    //        {
                    //            "avatar_url",
                    //            this.image.Text
                    //        },
                    //        {
                    //            "content",
                    //            this.content.Text
                    //        },
                    //        { 
                    //            "embeds",
                    //            {
                    //                {

                    //                    "title",
                    //                    this.content.Text
                    //                },
                    //                {
                    //                    "description",
                    //                    "안녕"
                    //                },
                    //                {
                    //                    "color",
                    //                    "#ffffff"
                    //                },
                    //            }
                    //        }

                    //    };
                    #endregion



                    if (repeat.Text == "")
                    {
                        MessageBox.Show("숫자를 입력하세요");
                        return;
                    }

                    else if (Convert.ToInt32(repeat.Text) < 6)
                    {

                        for (int i = 0; i < Convert.ToInt32(repeat.Text); i++)
                        {
                            dcWeb.SendMessage(content.Text);//

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
                            dcWeb.SendMessage(content.Text);//
                            Thread.Sleep(1 * 1000);
                        }
                    }
                }
            }

            if (resetRepeat.Checked)
            {
                repeat.Text = "1";
            }

            if (resetContent.Checked)
            {
                content.Text = string.Empty;
            }

        }
        private void logout_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void resetRepeat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void help_but_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=MAsQZ71_LGM");
        }

        private void resetContent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ButtonGradation();
        }

        private void ButtonGradation()
        {
            if (!buttonGradation.Checked)
            {
                Chat.BackgroundImage = Image.FromFile(@"Image/comment.png");
                setting.BackgroundImage = Image.FromFile(@"Image/settings.png");
            }
            else
            {
                Chat.BackgroundImage = Image.FromFile(@"Image/1.png");
                setting.BackgroundImage = Image.FromFile(@"Image/settings1.png");
            }
        }

        private void Thema_CheckedChanged(object sender, EventArgs e)
        {
            ChageThema();
        }

        private void ChageThema()
        {
            if (!Thema.Checked)
            {
                
                this.BackgroundImage = Image.FromFile(@"Image/White.png");
                title.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black; 

                label1.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;

                Thema.ForeColor = Color.Black;
                resetContent.ForeColor = Color.Black;
                resetRepeat.ForeColor = Color.Black;
                buttonGradation.ForeColor = Color.Black;
            }
            else
            {
                this.BackgroundImage = Image.FromFile(@"Image/배경.png");
                title.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;

                label1.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;

                Thema.ForeColor = Color.White;
                resetContent.ForeColor = Color.White;
                resetRepeat.ForeColor = Color.White;
                buttonGradation.ForeColor = Color.White;
            }
        }
    }
}
