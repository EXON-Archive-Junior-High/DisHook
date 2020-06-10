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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            Data.discordLink = webhookLink.Text;
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if(Data.discordLink == null)
            {
                MessageBox.Show("apiLink를 입력하시지 않았습니다.");
                e.Cancel = true;
                
            }
        }
    }
}
