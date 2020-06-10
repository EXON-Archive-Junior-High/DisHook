using System;
using System.Collections.Specialized;
using System.Net;

public class DcWebHook : IDisposable
{
    private readonly WebClient dWebClient;
    private static NameValueCollection discordValues = new NameValueCollection();
    public string WebHook { get; set; }
    public string UserName { get; set; }
    public string ProfilePicture { get; set; }

    public DcWebHook()
    {
        dWebClient = new WebClient();
    }

    private int?[] EnterIndex;

    public void SendMessage(string msgSend)
    {
        EnterIndex = new int?[100];
        int enterIndex = 0;

        discordValues.Add("username", UserName);
        discordValues.Add("avatar_url", ProfilePicture);

        if (!msgSend.Contains(@"\n"))
        {
            discordValues.Add("content", msgSend);
        }
        else
        {
            char[] msgSendChar = new char[msgSend.Length];
            for (int i = 0; i < msgSend.Length; i++)
            {

                foreach(char a in msgSend)
                {
                    int j = 0;

                    msgSendChar[j] = a;
                    j++;
                }
                if (msgSendChar[i] == '\\')
                {
                    if (msgSendChar[i++] == 'n')
                    {
                        EnterIndex[enterIndex] = msgSendChar[i];
                        enterIndex++;
                    }
                }
            }

            for(int i = 0; i < EnterIndex.Length; i++)
            {
                if (EnterIndex[i] == null)
                {
                    return;
                }
                

                foreach (/*하는중*/)
                {
                    
                }
            }


        }


        dWebClient.UploadValues(WebHook, discordValues);

        discordValues.Remove("username");
        discordValues.Remove("avatar_url");
        discordValues.Remove("content");
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