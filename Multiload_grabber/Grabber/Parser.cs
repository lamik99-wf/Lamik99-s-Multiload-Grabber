///<summary>
///Parser is mostly used to parse and hold the downloaded and parsed links. Very important class for this project.
///</summary>
///

using System.Collections.Generic;
using System;

namespace MultiloadGrabber
{
    public class Parser
    {
        enum Servers { CZshare, Hellshare, ShareRapid, Rapidshare, Ulozto, Quickshare, Multishare, XXXXX, FileFactory };

        public List<string> sharerapid;
        public List<string> multishare;
        public List<string> rapidshare;
        public List<string> quickshare;
        public List<string> hellshare;
        public List<string> ulozto;
        public List<string> filefactory;
        const string textAreaZahlavi = "<textarea onclick=\"this.select()\" cols=\"50\" rows=\"10\">";
        const string serverURL = @"http://mlgrabber.php5.cz/ServerSide.php?";

        public Parser()
        {
            sharerapid = new List<string>();
            multishare = new List<string>();
            rapidshare = new List<string>();
            quickshare = new List<string>();
            hellshare = new List<string>();
            ulozto = new List<string>();
            filefactory = new List<string>();
        }

        public Parser(string[] links, bool[] serverArray)
        {
            int hash = 0;
            if (serverArray == null)
                hash = 0;
            else
                for (int i = 0; i < 9; i++)
                    if (serverArray[i])
                        hash += (int)Math.Pow(2, i);
            sharerapid = new List<string>();
            multishare = new List<string>();
            rapidshare = new List<string>();
            quickshare = new List<string>();
            hellshare = new List<string>();
            ulozto = new List<string>();
            filefactory = new List<string>();            
            List<UInt32> IDs = new List<uint>();
            foreach (string s in links)
            {
                if (s.IndexOf("/slozka/") >= 0)
                {
                    List<UInt32> fromFolder = ParseFolder(s);
                    foreach (uint a in fromFolder)
                        IDs.Add(a);
                }
                else
                {
                    if (s != "")
                        IDs.Add(parse(s));
                }
            }
            string tx = serverURL, ret = "";
            for (int i = 0; i < (IDs.Count - 1); i++)
                tx += "a[]=" + IDs[i].ToString() + "&";
            if (IDs.Count != 0)
                tx += "a[]=" + IDs[IDs.Count - 1].ToString();
            tx += "&serv=" + hash;
            ret = NetworkHandler.getPageSource(tx);
            string[] splitted = ret.Split('\n');
            for (int i = 0; i < splitted.Length; i++)
            {
                splitted[i] = splitted[i].Trim();
                if (splitted[i].Length < 4 || splitted[i][0] != 'h' || splitted[i][1] != 't' || splitted[i][2] != 't' || splitted[i][3] != 'p')
                    splitted[i] = "-";
            }
            int counter = 0;
            for (int i = 0; i < (IDs.Count * 7); i++)
            {
                switch (i / IDs.Count)
                {
                    case 0:
                        if ((hash == 0) || serverArray[(int)Servers.Hellshare])
                        {
                            hellshare.Add(splitted[counter]);
                            ++counter;
                        }
                        break;
                    case 1:
                        if ((hash == 0) || serverArray[(int)Servers.ShareRapid])
                        {
                            sharerapid.Add(splitted[counter]);
                            ++counter;
                        }
                        break;
                    case 2:
                        if ((hash == 0) || serverArray[(int)Servers.Rapidshare])
                        {
                            rapidshare.Add(splitted[counter]);
                            ++counter;
                        }
                        break;
                    case 3:
                        if ((hash == 0) || serverArray[(int)Servers.Ulozto])
                        {
                            ulozto.Add(splitted[counter]);
                            ++counter;
                        }
                        break;
                    case 4:
                        if ((hash == 0) || serverArray[(int)Servers.Quickshare])
                        {
                            quickshare.Add(splitted[counter]);
                            ++counter;
                        }
                        break;
                    case 5:
                        if ((hash == 0) || serverArray[(int)Servers.Multishare])
                        {
                            multishare.Add(splitted[counter]);
                            ++counter;
                        }
                        break;
                    case 6:
                        if ((hash == 0) || serverArray[(int)Servers.FileFactory])
                        {
                            filefactory.Add(splitted[counter]);
                            ++counter;
                        }
                        break;
                }
            }     
        }

        public static string Test()
        {
            string[] natest = { "https://rapidshare.com/files/2886134649/mistri_ceskeho_animovaneho_filmu_19-xvid-l99-avi.7z", "http://rapidshare.com/files/455690374/Chytte_zlodeje.MPEG.l99.mpg.7z.001", "http://rapidshare.com/files/455690443/Chytte_zlodeje.MPEG.l99.mpg.7z.002", "http://rapidshare.com/files/455805393/Chytte_zlodeje.MPEG.l99.mpg.7z.003", "http://rapidshare.com/files/455805384/Chytte_zlodeje.MPEG.l99.mpg.7z.004", "http://rapidshare.com/files/455718646/Chytte_zlodeje.MPEG.l99.mpg.7z.005", "http://rapidshare.com/files/455709348/Chytte_zlodeje.MPEG.l99.mpg.7z.006", "https://rapidshare.com/files/2886134649/mistri_ceskeho_animovaneho_filmu_19-xvid-l99-avi.7z" };
            return LinkChecker.CheckRapidShare(natest).ToString();
        }

        public string MultishareString()
        {
            string t = "";
            foreach (string s in multishare)
                t += s + System.Environment.NewLine;
            t = t.Trim();
            return t;
        }

        public string SharerapidString()
        {
            string t = "";
            foreach (string s in sharerapid)
                t += s + System.Environment.NewLine;
            t = t.Trim();
            return t;
        }

        public string RapidshareString()
        {
            string t = "";
            foreach (string s in rapidshare)
                t += s + System.Environment.NewLine;
            t = t.Trim();
            return t;
        }

        public string QuickshareString()
        {
            string t = "";
            foreach (string s in quickshare)
                t += s + System.Environment.NewLine;
            t = t.Trim();
            return t;
        }

        public string HellshareString()
        {
            string t = "";
            foreach (string s in hellshare)
                t += s + System.Environment.NewLine;
            t = t.Trim();
            return t;
        }

        public string UloztoString()
        {
            string t = "";
            foreach (string s in ulozto)
                t += s + System.Environment.NewLine;
            t = t.Trim();
            return t;
        }

        public string FilefactoryString()
        {
            string t = "";
            foreach (string s in filefactory)
                t += s + System.Environment.NewLine;
            t = t.Trim();
            return t;
        }

        public UInt32 parse(string s)
        {
            if (!s.ToLower().Contains("multiload"))
                return 0;
            UInt32 a = Convert.ToUInt32(s.Substring(33, s.IndexOf('/', 33) - 33));
            return a;
        }

        public static string[] GetFolderContain(string s)
        {
            string text = NetworkHandler.getPageSource(s);
            int zacatek = text.IndexOf("<textarea"), konec = text.LastIndexOf("</textarea");
            text = text.Substring(zacatek + textAreaZahlavi.Length, konec - zacatek - textAreaZahlavi.Length);
            return text.Split('\n', '\r');
        }

        public List<uint> ParseFolder(string s)
        {
            List<uint> toReturn = new List<uint>();
            foreach (string t in GetFolderContain(s))
                if ((t.Trim()) != "")
                    toReturn.Add(parse(t));
            return toReturn;
        }

        public string[] GetShareRapid()
        {
            return sharerapid.ToArray();
        }

        public string[] GetMultiShare()
        {
            return multishare.ToArray();
        }

        public string[] GetQuickShare()
        {
            return quickshare.ToArray();
        }

        public string[] GetRapidShare()
        {
            return rapidshare.ToArray();
        }

        public string[] GetHellShare()
        {
            return hellshare.ToArray();
        }

        public string[] GetUlozTo()
        {
            return ulozto.ToArray();
        }

        public string[] GetFileFactory()
        {
            return filefactory.ToArray();
        }
    }
}