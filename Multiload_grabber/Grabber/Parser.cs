///<summary>
///Parser is mostly used to parse and hold the downloaded and parsed links. Very important class for this project.
///</summary>
///

using System.Collections.Generic;
using System;
using System.Windows.Forms;
using LocalConst;

namespace MultiloadGrabber
{
    public class Parser
    {
        List<string> sharerapid;
        List<string> multishare;
        List<string> rapidshare;
        List<string> quickshare;
        List<string> hellshare;
        List<string> ulozto;
        List<string> filefactory;
        List<string> grabbedLinks;
        bool failed;

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
                for (int i = 0; i < Const.multiloadServersCount; i++)
                    if (serverArray[i])
                        hash += (int)Math.Pow(2, i);
            sharerapid = new List<string>();
            multishare = new List<string>();
            rapidshare = new List<string>();
            quickshare = new List<string>();
            hellshare = new List<string>();
            ulozto = new List<string>();
            filefactory = new List<string>();
            grabbedLinks = new List<string>();
            failed = false;
            List<UInt32> IDs = new List<uint>();
            foreach (string s in links)
            {
                if (s.IndexOf(Const.multiloadFolder) >= 0)
                {
                    List<UInt32> fromFolder = ParseFolder(s);
                    foreach (uint a in fromFolder)
                        IDs.Add(a);
                }
                else
                {
                    if (s != "")
                    {

                        IDs.Add(parse(s));
                        grabbedLinks.Add(s);
                    }
                }
            }
            string tx = Const.serverURL, ret = "";
            for (int i = 0; i < (IDs.Count - 1); i++)
                tx += "a[]=" + IDs[i].ToString() + "&";
            if (IDs.Count != 0)
                tx += "a[]=" + IDs[IDs.Count - 1].ToString();
            tx += "&serv=" + hash;
            ret = NetworkHandler.getPageSource(tx);
            if (ret == "")
            {
                DebugLog.Zapis("Couldn't connect to the server. Check your internet connection.");
                failed = true;
                return;
            }
            //DebugLog.Zapis(ret);
            string[] splitted = ret.Split('\n');
            for (int i = 0; i < splitted.Length; i++)
            {
                splitted[i] = splitted[i].Trim();
                if (splitted[i].Length < 4 || splitted[i][0] != 'h' || splitted[i][1] != 't' || splitted[i][2] != 't' || splitted[i][3] != 'p')
                    splitted[i] = "-";
            }
            int counter = 0;
            for (int i = 0; i < (IDs.Count * Const.multiloadSupportedServersCount); i++)
            {
                switch (i / IDs.Count)
                {
                    case (int)SupportedServers.Hellshare:
                        if ((hash == 0) || serverArray[(int)Server.Hellshare])
                        {
                            hellshare.Add(splitted[counter]);
                            ++counter;
                        }
                        break;
                    case (int)SupportedServers.ShareRapid:
                        if ((hash == 0) || serverArray[(int)Server.ShareRapid])
                        {
                            sharerapid.Add(splitted[counter]);
                            ++counter;
                        }
                        break;
                    case (int)SupportedServers.Rapidshare:
                        if ((hash == 0) || serverArray[(int)Server.Rapidshare])
                        {
                            rapidshare.Add(splitted[counter]);
                            ++counter;
                        }
                        break;
                    case (int)SupportedServers.Ulozto:
                        if ((hash == 0) || serverArray[(int)Server.Ulozto])
                        {
                            ulozto.Add(splitted[counter]);
                            ++counter;
                        }
                        break;
                    case (int)SupportedServers.Quickshare:
                        if ((hash == 0) || serverArray[(int)Server.Quickshare])
                        {
                            quickshare.Add(splitted[counter]);
                            ++counter;
                        }
                        break;
                    case (int)SupportedServers.Multishare:
                        if ((hash == 0) || serverArray[(int)Server.Multishare])
                        {
                            multishare.Add(splitted[counter]);
                            ++counter;
                        }
                        break;
                    case (int)SupportedServers.FileFactory:
                        if ((hash == 0) || serverArray[(int)Server.FileFactory])
                        {
                            filefactory.Add(splitted[counter]);
                            ++counter;
                        }
                        break;
                }
            }     
        }

        public bool Failed
        {
            get
            {
                return failed;
            }
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
            if (!s.ToLower().Contains(Const.multiloadValidator))
                return 0;
            UInt32 a = 0;
            try
            {
                a = Convert.ToUInt32(s.Substring(Const.multiloadLinkPrefix.Length, s.IndexOf('/', Const.multiloadLinkPrefix.Length) - Const.multiloadLinkPrefix.Length));
            }
            catch (Exception )
            {
                return 0;
            }
            return a;
        }

        public static string[] GetFolderContain(string s)
        {
            string text = NetworkHandler.getPageSource(s);
            int zacatek = text.IndexOf(Const.textAreaHeader), konec = text.LastIndexOf(Const.textAreaFooter);
            text = text.Substring(zacatek + Const.textAreaHeader.Length, konec - zacatek - Const.textAreaHeader.Length);
            return text.Split('\n', '\r');
        }

        public string[] GrabbedLinks
        {
            get
            {
                return grabbedLinks.ToArray();
            }
        }

        public List<uint> ParseFolder(string s)
        {
            List<uint> toReturn = new List<uint>();
            foreach (string t in GetFolderContain(s))
                if ((t.Trim()) != "")
                {
                    toReturn.Add(parse(t));
                    grabbedLinks.Add(t);
                }
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

        public void CopyOneServerLinksTo(TextBox box, Server srv)
        {
            switch(srv)
            {
                case Server.Multishare:
                    foreach (string s in GetMultiShare())
                        box.AppendText(s + System.Environment.NewLine);
                    break;
                case Server.Hellshare:
                    foreach (string s in GetHellShare())
                        box.AppendText(s + System.Environment.NewLine);
                    break;
                case Server.Quickshare:
                    foreach (string s in GetQuickShare())
                        box.AppendText(s + System.Environment.NewLine);
                    break;
               case Server.Rapidshare:
                    foreach (string s in GetRapidShare())
                        box.AppendText(s + System.Environment.NewLine);
                    break;
                case Server.ShareRapid:
                    foreach (string s in GetShareRapid())
                        box.AppendText(s + System.Environment.NewLine);
                    break;
               case Server.Ulozto:
                    foreach (string s in GetUlozTo())
                        box.AppendText(s + System.Environment.NewLine);
                    break;
                case Server.FileFactory:
                    foreach (string s in GetFileFactory())
                        box.AppendText(s + System.Environment.NewLine);
                    break;
                case Server.CZshare:
                case Server.XXXXX:
                    //czshare and XXXXX not aviable
                    break;
            }
        }

        public void CopyLinksTo(TextBox box)
        {
            foreach (Server s in Enum.GetValues(typeof(Server)))
                CopyOneServerLinksTo(box, s);
        }

    }
}