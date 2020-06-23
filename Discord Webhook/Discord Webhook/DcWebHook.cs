using System;
using System.Collections.Specialized;
using System.Net;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;
public class DcWebHook : IDisposable
{
    private readonly WebClient dWebClient;
    public static NameValueCollection discordValues = new NameValueCollection();
    public string WebHook { get; set; }
    public string UserName { get; set; }
    public string ProfilePicture { get; set; }

    public DcWebHook()
    {
        dWebClient = new WebClient();
    }



    public void SendMessage(string msgSend)
    {
        //var json = new JObject();
        //var embeds = new JObject();
        //json.Add("username", UserName);
        //json.Add("avatar_url", ProfilePicture);
        //json.Add("content", msgSend);
        //embeds.Add("title", "엑슨천재");
        //embeds.Add("description", "엑슨천재");
        //json.Add("embeds", embeds); 

        //string myJson = "{'username': 'myusername','content':'pass'}";
        //using (var client = new HttpClient())
        //{
        //    var response = client.PostAsync(WebHook,
        //         new StringContent(myJson, Encoding.UTF8, "application/json"));
        //}
        discordValues.Add("username", UserName);
        discordValues.Add("avatar_url", ProfilePicture);
        discordValues.Add("content", msgSend);

        dWebClient.UploadValues(WebHook, json);

        Reset();
    }

    public void SendMessage(NameValueCollection msgSend)
    {

        discordValues.Add(msgSend);

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