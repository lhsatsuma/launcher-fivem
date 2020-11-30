using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Launcher_FiveM_CS
{
    class ConfigHelper
    {
        private string filePath;
        public ConfigHelper()
        {
            this.filePath = Environment.GetEnvironmentVariable("LocalAppData") + "/launcher_fivem.settings";
        }
        public void SetContent(ServerList content)
        {

            File.WriteAllText(this.filePath, Base64Encode(JsonConvert.SerializeObject(content)));
        }
        public ServerList GetContent()
        {
            if (File.Exists(this.filePath))
            {
                return JsonConvert.DeserializeObject<ServerList>(Base64Decode(File.ReadAllText(this.filePath)));
            }
            else
            {
                return new ServerList();
            }
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
