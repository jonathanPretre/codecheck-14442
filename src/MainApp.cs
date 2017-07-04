using System;
using System.Text;
using Newtonsoft.Json;
using System.Net;

public class MainApp
{
    static public void Main (string[] args)
    {
            var page = new Uri("http://challenge-server.code-check.io/api/recursive/ask");
            string jsonString;

            using (WebClient client = new WebClient())
            {
                client.QueryString.Add("n", args[1]);
                client.QueryString.Add("seed", args[0]);
                client.Encoding = Encoding.UTF8;
                jsonString = client.DownloadString(page);
            }

            dynamic result = JsonConvert.DeserializeObject(jsonString);
            Console.WriteLine(jsonString.result);
    }
}
