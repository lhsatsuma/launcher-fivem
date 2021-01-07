using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using System.Net.NetworkInformation;
using static System.Console;
using System.Windows.Forms;

namespace Launcher_FiveM_CS
{
    class Utils
    {
        public static async Task<int> CheckIP_FiveM(string IPAddr)
        {
            int return_val = 0;
            if (String.IsNullOrEmpty(IPAddr.Trim()))
            {
                return -1;
            }
            if (!IPAddr.Contains(':'))
            {
                IPAddr += ":30120";
            }
            var response_json = "";
            try
            {
                var client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(1);
                // Create the HttpContent for the form to be posted.
                var requestContent = new FormUrlEncodedContent(new[] {
                    new KeyValuePair<string, string>("text", "This is a block of text"),
                });

                // Get the response.
                HttpResponseMessage response = await client.PostAsync("http://" + IPAddr + "/players.json", requestContent);

                // Get the response content.
                HttpContent responseContent = response.Content;

                // Get the stream of the content.
                using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
                {
                    // Write the output.
                    response_json += await reader.ReadToEndAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return_val = -1;
            }
            if (response_json != "")
            {
                var decoded = JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JArray>(response_json);
                return_val = decoded.Count;
            }
            return return_val;
        }
        public static async Task<bool> CheckIPReach(string IP)
        {
            var return_bool = false;
            if (!String.IsNullOrEmpty(IP))
            {
                if (IP.Contains(':'))
                {
                    var IP_Split = new List<String>(IP.Split(new char[] { ':' }));
                    IP = IP_Split[0];
                }
                    try
                {
                    Ping pinger = new Ping();
                    
                    PingReply resposta = await pinger.SendPingAsync(IP, 1);
                    if (!String.IsNullOrEmpty(resposta.Address.ToString()))
                    {
                        return_bool = true;
                    }
                }
                catch
                {
                    //Don't do nothing
                }
            }
            return return_bool;
        }

        private static void pinger_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            try
            {
                PingReply resposta = e.Reply;
                if (e.Cancelled)
                {
                    WriteLine($"Ping para {e.UserState.ToString()} foi cancelado");
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Exception lançada durante o ping : {ex.Message}");
            }
        }
    }
}
