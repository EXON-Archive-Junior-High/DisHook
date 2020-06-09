using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void Send_Click(object sender, EventArgs e)
        {
            using (DcWebHook dcWeb = new DcWebHook())
            {
                dcWeb.ProfilePicture = image.Text;
                dcWeb.UserName = name.Text;
                dcWeb.WebHook = channel.Text;
                dcWeb.SendMessage(content.Text);
            }
        }
    }
}
