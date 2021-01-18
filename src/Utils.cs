using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Launcher_FiveM_CS
{
    class Utils
    {
        public static async Task<List<object>> CheckIP_FiveM(string IPAddr)
        {
            List<object> return_val = new List<object>();
            return_val.Add(-1);
            return_val.Add(-1);

            if (!String.IsNullOrEmpty(IPAddr.Trim()))
            {
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
                    return_val[0] = -1;
                }
                if (response_json != "")
                {
                    var decoded = JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JArray>(response_json);
                    return_val[0] = decoded.Count;
                    return_val[1] = 0;
                    for(var i = 0; i < decoded.Count; i++)
                    {
                        var realPing = int.Parse(decoded[i]["ping"].ToString());
                        if(realPing == -1)
                        {
                            realPing = 999;
                        }
                        return_val[1] = int.Parse(return_val[1].ToString()) + realPing;
                    }

                    var av_ping = int.Parse(return_val[1].ToString());
                    if (av_ping > 0) {
                        return_val[1] = av_ping / decoded.Count;
                    }
                }
            }
            return return_val;
        }
        public static bool newCheckIPReach(string IP)
        {
            var bool_return = false;
            try
            {
                if (IP.Contains(':'))
                {
                    string[] splitIP = IP.Split(':');
                    IP = splitIP[0];
                }
                //The IP or Host Entry to lookup
                IPHostEntry ipEntry;
                //The IP Address Array. Holds an array of resolved Host Names.
                IPAddress[] ipAddr;
                //Value of alpha characters
                char[] alpha = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ-".ToCharArray();
                //If alpha characters exist we know we are doing a forward lookup
                if (IP.IndexOfAny(alpha) != -1)
                {
                    ipEntry = Dns.GetHostByName(IP);
                    ipAddr = ipEntry.AddressList;
                    Console.WriteLine("\nHost Name : " + IP);
                    int i = 0;
                    int len = ipAddr.Length;
                    for (i = 0; i < len; i++)
                    {
                        Console.WriteLine("Address {0} : {1} ", i, ipAddr[i].ToString());
                    }
                    bool_return = true;
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(IP))
                    {
                        string[] splitValues = IP.Split('.');
                        if (splitValues.Length == 4)
                        {
                            byte tempForParsing;
                            if (splitValues.All(r => byte.TryParse(r, out tempForParsing)))
                            {
                                bool_return = true;
                            }
                        }
                    }
                }
            }
            catch(System.Net.Sockets.SocketException se)
            {
                // The system had problems resolving the address passed
                if (se.Message.ToString().IndexOf("O nome solicitado é válido") != -1)
                {
                    bool_return = true;
                }
            }
            catch(System.FormatException fe)
            {
                Console.WriteLine(fe.Message.ToString());
            }
            return bool_return;
        }
    }
}
