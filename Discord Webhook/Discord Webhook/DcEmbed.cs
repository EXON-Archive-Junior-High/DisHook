using System;
using System.Collections.Specialized;
using System.Net;

namespace Discord_Webhook
{
    class DcEmbed : IDisposable
    {
        private readonly WebClient dWebClient;
        private static NameValueCollection discordValues = new NameValueCollection();
        public string WebHook { get; set; }
        public string UserName { get; set; }
        public string ProfilePicture { get; set; }
        public string Embed { get; set; }

        public DcEmbed()
        {
            dWebClient = new WebClient();
        }



        public void SendEmbed(string msgSend)
        {

            discordValues.Add("username", UserName);
            discordValues.Add("avatar_url", ProfilePicture);
            discordValues.Add("content", msgSend);
            discordValues.Add("embeds", "");


            dWebClient.UploadValues(WebHook, discordValues);

            Reset();
        }



        public void Reset()
        {
            discordValues.Remove("username");
            discordValues.Remove("avatar_url");
            discordValues.Remove("content");
        }

        public void Dispose()
        {
            dWebClient.Dispose();
        }
    }

    
}
