///<summary>
///This is a very simple Template class. It holds the information about templates - its name and the actual template text. Contains very simple 
///properties which handle getting and setting these strings.
///</summary>
///

using System;
using System.Collections.Generic;
using LocalConst;

namespace MultiloadGrabber
{
    [Serializable]
    public class Template
    {
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
                    ret[(int)Server.Multishare] = true;
                if (s.IndexOf("÷HELLSHARE÷") != -1)
                    ret[(int)Server.Hellshare] = true;
                if (s.IndexOf("÷RAPIDSHARE÷") != -1)
                    ret[(int)Server.Rapidshare] = true;
                if (s.IndexOf("÷SHARERAPID÷") != -1)
                    ret[(int)Server.ShareRapid] = true;
                if (s.IndexOf("÷QUICKSHARE÷") != -1)
                    ret[(int)Server.Quickshare] = true;
                if (s.IndexOf("÷FILEFACTORY÷") != -1)
                    ret[(int)Server.FileFactory] = true;
                if (s.IndexOf("÷ULOZTO÷") != -1)
                    ret[(int)Server.Ulozto] = true;
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

