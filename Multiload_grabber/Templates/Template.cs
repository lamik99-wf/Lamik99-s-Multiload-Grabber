///<summary>
///This is a very simple Template class. It holds the information about templates - its name and the actual template text. Contains very simple 
///properties which handle getting and setting these strings.
///</summary>
///

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace MultiloadGrabber
{
    [Serializable]
    public class Template
    {
        enum Servers {CZshare, Hellshare, ShareRapid, Rapidshare, Ulozto, Quickshare, Multishare, XXXXX, FileFactory};

        string nazev;
        List<string> sablona;

        public Template(string sNazev, List<string> textSablony)
        {
            nazev = sNazev;
            sablona = new List<string>();
            if (textSablony != null)
                foreach (string s in textSablony)
                    sablona.Add(s);
        }

        public List<string> SablonaText
        {
            get
            {
                return sablona;
            }
        }

        public string Nazev
        {
            get
            {
                return nazev;
            }
            set
            {
                nazev = value;
            }
        }

        public bool[] GetServersIncluded()
        {
            bool[] ret = new bool[9];
            foreach (string s in SablonaText)
            {
                if (s.IndexOf("÷MULTISHARE÷") != -1)
                    ret[(int)Servers.Multishare] = true;
                if (s.IndexOf("÷HELLSHARE÷") != -1)
                    ret[(int)Servers.Hellshare] = true;
                if (s.IndexOf("÷RAPIDSHARE÷") != -1)
                    ret[(int)Servers.Rapidshare] = true;
                if (s.IndexOf("÷SHARERAPID÷") != -1)
                    ret[(int)Servers.ShareRapid] = true;
                if (s.IndexOf("÷QUICKSHARE÷") != -1)
                    ret[(int)Servers.Quickshare] = true;
                if (s.IndexOf("÷FILEFACTORY÷") != -1)
                    ret[(int)Servers.FileFactory] = true;
                if (s.IndexOf("÷ULOZTO÷") != -1)
                    ret[(int)Servers.Ulozto] = true;
            }
            return ret;
        }
    }

    /// <summary>
    /// Older templates/template tables have different class names. Since the files are still in the old format, the following piece of
    /// code is needed to secure the backward compatibility.
    /// </summary>

    public sealed class TemplateSupportDeserializationBinder : System.Runtime.Serialization.SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            Type typeToDeserialize = null;

            typeName = typeName.Replace("WindowsFormsApplication1.SablonaTable+Dvojice", "MultiloadGrabber.TemplateTable+Dvojice");
            typeName = typeName.Replace("WindowsFormsApplication1.Sablona", "MultiloadGrabber.Template");

            typeToDeserialize = Type.GetType(String.Format("{0}, {1}",
                    typeName, assemblyName));

            return typeToDeserialize;
        }
    }

}

