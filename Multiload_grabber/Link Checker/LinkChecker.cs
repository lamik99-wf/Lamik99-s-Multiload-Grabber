/// <summary>
/// Link Checker for servers supported by Multiload and this Grabber.
/// 
/// </summary>

using System;
using System.Collections.Generic;

namespace MultiloadGrabber
{
    public class LinkChecker
    {
        const string uloztoChecker = "http://www.uloz.to/linkchecker/?do=linkCheckerForm-submit";
        const string uloztoBegin = "<div style=\"margin:10px 0;line-height:20px;\">";
        const string uloztoEnd = "</div>";
        const string uloztoSplitter = "</a>";
        const string uloztoOk = "<strong>OK</strong>";
        const string uloztoDead = "<strong>ERROR<strong>";

        const string hellshareChecker = "http://www.hellshare.cz/linkchecker?do=LinkChecker-linkcheckerform-submit";
        const string hellshareBegin = "<ul id=\"linkchecker_result_list\" style=\"list-style-type:none;\">";
        const string hellshareEnd = "</ul>";
        const string hellshareSplitter = "</li>";
        const string hellshareOk = "/templates/images/file/icon-file-1-2.png";
        const string hellshareDead = "/templates/images/file/icon-file-1-1.png";

        const string multishareChecker = "http://www.multishare.cz/link-checker/";
        const string multishareBegin = "<h1>Linkchecker</h1>";
        const string multishareEnd = "</div>";
        const string multishareSplitter = "</p>";
        const string multishareOk = "lnkch-ok";
        const string multishareDead = "lnkch-del";

        const string quickshareChecker = "http://www.quickshare.cz/nastroje/link-checker";
        const string quickshareBegin = "<h1>Link checker</h1>";
        const string quickshareEnd = "</table>";
        const string quickshareSplitter = "</tr>";
        const string quickshareOk = "/img/ok.gif";
        const string quickshareDead = "/img/nenalezeno.gif";

        const string filefactoryChecker = "http://filefactory.com/tool/links.php";
        const string filefactoryBegin = "<h1>Link Checker</h1>";
        const string filefactoryEnd = "</table>";
        //splitter, OK and Dead not requied since it doesn't show any dead links

        const string sharerapidOk = "Nahrán na server:";

        public static bool[] CheckUlozTo(string[] links)
        {
            string urls = "urls=";
            for (int i=0;i<links.Length;i++)
            {
                if (links[i] == "-")
                    continue;
                links[i] = links[i].Substring(0, links[i].LastIndexOf('/'));
                urls += (links[i] + "\r\n");
            }
            urls.Trim();
            string res = NetworkHandler.SendPost(uloztoChecker, urls);
            int beg = res.IndexOf(uloztoBegin);
            if (beg == -1)
                return new bool[links.Length];
            int end = res.IndexOf(uloztoEnd, beg);
            if (end == -1 || end < beg)
                return new bool[links.Length];
            res = res.Substring(beg + uloztoBegin.Length, end - beg - uloztoBegin.Length);
            string[] spl = res.Split(uloztoSplitter.Split('€'), StringSplitOptions.RemoveEmptyEntries);
            bool[] ret = new bool[links.Length];
            for (int i = 0; i < links.Length; i++)
            {
                ret[i] = false;
                foreach (string t in spl)
                {
                    if (t.IndexOf(links[i]) != -1)
                        if (t.IndexOf(uloztoOk) != -1)
                        {
                            ret[i] = true;
                            break;
                        }
                }
            }
            return ret;
        }

        public static bool[] CheckHellShare(string[] links)
        {
            string urls = "links=";
            foreach (string s in links)
                urls += (s + "\r\n");
            urls.Trim();
            string res = NetworkHandler.SendPost(hellshareChecker, urls);
            int beg = res.IndexOf(hellshareBegin);
            if (beg == -1)
                return new bool[links.Length];                
            int end = res.IndexOf(hellshareEnd, beg);
            if (end == -1 || end < beg)
                return new bool[links.Length];
            res = res.Substring(beg + hellshareBegin.Length, end - beg - hellshareBegin.Length);
            string[] spl = res.Split(hellshareSplitter.Split('€'), StringSplitOptions.RemoveEmptyEntries);
            bool[] ret = new bool[links.Length];
            for (int i = 0; i < links.Length; i++)
            {
                ret[i] = false;
                foreach (string t in spl)
                {
                    if (t.IndexOf(links[i]) != -1)
                        if (t.IndexOf(hellshareOk) != -1)
                        {
                            ret[i] = true;
                            break;
                        }
                }
            }
            return ret;
        }

        public static bool[] CheckMultiShare(string[] links)
        {
            string urls = "akce=Ov%C4%9B%C5%99it+odkazy&linky=";
            foreach (string s in links)
                urls += (s + "\r\n");
            urls.Trim();
            string res = NetworkHandler.SendPost(multishareChecker, urls);
            int beg = res.IndexOf(multishareBegin);
            int end = res.IndexOf(multishareEnd, beg);
            res = res.Substring(beg + multishareBegin.Length, end - beg - multishareBegin.Length);
            string[] spl = res.Split(multishareSplitter.Split('€'), StringSplitOptions.RemoveEmptyEntries);
            bool[] ret = new bool[links.Length];
            for (int i = 0; i < links.Length; i++)
            {
                if (spl[i].IndexOf(multishareOk) != -1)
                    ret[i] = true;
                else ret[i] = false;
            }
            return ret;
        }

        public static bool CheckShareRapid(string link)
        {
            if (NetworkHandler.getPageSource(link).IndexOf(sharerapidOk) != -1)
                return true;
            else return false;
        }
            

        public static bool[] CheckQuickShare(string[] links)
        {
            string urls = "linky=";
            foreach (string s in links)
                urls += (s + "\r\n");
            urls.Trim();
            string res = NetworkHandler.SendPost(quickshareChecker, urls);
            int beg = res.IndexOf(quickshareBegin);
            int end = res.IndexOf(quickshareEnd, beg);
            res = res.Substring(beg + quickshareBegin.Length, end - beg - quickshareBegin.Length);
            string[] spl = res.Split(quickshareSplitter.Split('€'), StringSplitOptions.RemoveEmptyEntries);
            bool[] ret = new bool[links.Length];
            for (int i = 0; i < links.Length; i++)
            {
                if (spl[i].IndexOf(quickshareOk) != -1)
                    ret[i] = true;
                else ret[i] = false;
            }
            return ret;
        }

        public static bool[] CheckFileFactory(string[] links)
        {
            string urls = "func=links&links=";
            foreach (string s in links)
                urls += (s + "\r\n");
            urls.Trim();
            string res = NetworkHandler.SendPost(filefactoryChecker, urls);
            int beg = res.IndexOf(filefactoryBegin);
            int end = res.IndexOf(filefactoryEnd, beg);
            try
            {
                res = res.Substring(beg + filefactoryBegin.Length, end - beg - filefactoryBegin.Length).Replace('.', '_'); // FileFactory does this automatically
                //in filenames, this is the easiest way to match it
            }
            catch (Exception)
            { }
            bool[] ret = new bool[links.Length];
            for (int i = 0; i < links.Length; i++)
            {
                if (res.IndexOf(links[i].Replace('.', '_')) != -1 && links[i]!="-")
                    ret[i] = true;
                else ret[i] = false;
            }
            return ret;
        }

        public static bool[] CheckRapidShare(string[] links)
        {
            string url = "https://api.rapidshare.com/cgi-bin/rsapi.cgi?sub=checkfiles&files=";
            List<string> filenames = new List<string>();
            List<UInt64> fileids = new List<ulong>();
            foreach (string s in links)
            {
                string[] t = s.TrimEnd('/').Split('/');
                if (t.Length < 2)
                {
                    DebugLog.Zapis("Rapidshare checking : " + s + " is probably not a valid Rapidshare link!");
                    continue;
                }
                fileids.Add(Convert.ToUInt64(t[t.Length - 2]));
                filenames.Add(t[t.Length - 1]);
            }
            if (fileids.Count == 0)
                return new bool[links.Length];
            foreach (UInt64 i in fileids)
                url += i + ",";
            url = url.TrimEnd(',') + "&filenames=";
            foreach (string s in filenames)
                url += s + ",";
            url = url.TrimEnd(',');
            string[] resp = NetworkHandler.getPageSource(url).Split('\n');
            bool[] ret = new bool[links.Length];
            for (int i = 0; i < ret.Length; i++)
            {
                if (resp[i].Trim() == "")
                    continue;
                string[] t = resp[i].Split(',');
                if (t.Length > 4 && (t[4] == "1" || t[4] == "5"))
                    ret[i] = true;
                else ret[i] = false;
            }                
            return ret;
        }

    }
}
