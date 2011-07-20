/// <summary>
/// This part of the Grabber is responsible for all network communication.
/// Mostly used by main grabbing method (communication between the program and the server part) and by link checker (to communicate with
/// all filehostings checkers)
/// </summary>
/// 
using System;

namespace MultiloadGrabber
{
    class NetworkHandler
    {
        public static string SendPost(string adress, string data)
        {
            if (System.Net.ServicePointManager.Expect100Continue)
                System.Net.ServicePointManager.Expect100Continue = false;

            System.Net.WebRequest req = System.Net.WebRequest.Create(adress);

            req.ContentType = "application/x-www-form-urlencoded";
            req.Method = "POST";

            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(data);
            req.ContentLength = bytes.Length;

            System.IO.Stream os = req.GetRequestStream();
            os.Write(bytes, 0, bytes.Length);
            os.Close();

            System.Net.WebResponse resp = req.GetResponse();
            if (resp == null) return null;

            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            return sr.ReadToEnd().Trim();
        }

        public static string getPageSource(string URL)
        {
            System.Net.WebClient webClient = new System.Net.WebClient();
            webClient.Encoding = System.Text.Encoding.UTF8;
            string strSource = "";
            try
            {
                strSource = webClient.DownloadString(URL);
            }
            catch (Exception)
            {
            }
            webClient.Dispose();
            return strSource;
        }
    }
}
