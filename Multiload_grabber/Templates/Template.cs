///<summary>
///This is a very simple Template class. It holds the information about templates - its name and the actual template text. Contains very simple 
///properties which handle getting and setting these strings.
///</summary>
///


using System;
using System.Collections.Generic;

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
    }
}