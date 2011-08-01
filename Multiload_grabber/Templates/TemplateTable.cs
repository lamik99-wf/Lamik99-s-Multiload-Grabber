///<summary>
///TemplateTable holds the list of the templates. Loaded at the program start. Does much of the template coordination job.
///</summary>
///

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultiloadGrabber
{
    public class TemplateTable
    {
        [Serializable]
        public class Dvojice
        {
            string nazev;
            UInt32 soubor;

            public Dvojice(string s, UInt32 i)
            {
                nazev = s;
                soubor = i;
            }

            public string GetNazev()
            {
                return nazev;
            }

            public UInt32 GetID()
            {
                return soubor;
            }
        }

        List<Dvojice> tabulka;
        UInt32 MinUnused;

        public TemplateTable()
        {
            tabulka = new List<Dvojice>();
            MinUnused = 0;
        }

        public void Serialize()
        {
            if (!System.IO.Directory.Exists(Application.StartupPath + "/data"))
                System.IO.Directory.CreateDirectory(Application.StartupPath + "/data");
            System.IO.Stream proud = new System.IO.FileStream(Application.StartupPath + "/data/TemplateList.dat", System.IO.FileMode.Create, System.IO.FileAccess.Write);
            System.Runtime.Serialization.IFormatter formater = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            formater.Binder = new TemplateSupportDeserializationBinder();
            try
            {
                formater.Serialize(proud, tabulka);
                formater.Serialize(proud, MinUnused);
            }
            finally
            {
                proud.Close();
            }
        }

        public void Deserialize()
        {
            try
            {
                System.IO.Stream proud = new System.IO.FileStream(Application.StartupPath + "/data/TemplateList.dat", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                System.Runtime.Serialization.IFormatter formater = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formater.Binder = new TemplateSupportDeserializationBinder();
                try
                {
                    tabulka = (List<Dvojice>)formater.Deserialize(proud);
                    MinUnused = (UInt32)formater.Deserialize(proud);
                }
                finally
                {
                    proud.Close();
                }
            }
            catch (Exception)
            {
            }

            if (tabulka == null)
            {
                tabulka = new List<Dvojice>();
            }
        }

        public Int32 VratPozici(string nazevsablony)
        {
            for (Int32 i = 0; i < tabulka.Count; i++)
            {
                if (nazevsablony == tabulka[i].GetNazev())
                {
                    return (Int32)i;
                }
            }
            return -1;
        }

        public Int32 VratID(string nazevsablony)
        {
            for (Int32 i = 0; i < tabulka.Count; i++)
            {
                if (nazevsablony == tabulka[i].GetNazev())
                {
                    return (Int32)tabulka[i].GetID();
                }
            }
            return -1;
        }

        public string[] GetAllNames()
        {
            List<string> s = new List<string>();
            foreach (Dvojice d in tabulka)
                s.Add(d.GetNazev());
            return s.ToArray();
        }

        public bool DeleteTemplate(string nazevsablony)
        {
            if (VratPozici(nazevsablony) == -1)
                return false;
            tabulka.RemoveAt(VratPozici(nazevsablony));
            Shake();
            return true;
        }

        public bool AddTemplate(string nazevsablony)
        {
            if (VratPozici(nazevsablony) != -1)
                return false;
            tabulka.Add(new Dvojice(nazevsablony, MinUnused));
            ++MinUnused;
            return true;
        }

        void ClearTable()
        {
            tabulka.Clear();
            MinUnused = 0;
        }

        void ClearTemplates()
        {
            if (System.IO.Directory.Exists(Application.StartupPath + "/data"))
                System.IO.Directory.Delete(Application.StartupPath + "/data", true);
            ClearTable();
        }

        void Shake()
        {
            if (MinUnused > 2 * (tabulka.Count))
            {
                string[] jmena = GetAllNames();
                List<Template> sablony = new List<Template>();
                for (int i = 0; i < jmena.Length; i++)
                {
                    Template s = TemplateGetterSetter.GetTemplate(jmena[i], this);
                    if (s != null)
                        sablony.Add(s);
                }
                ClearTemplates();
                for (int i = 0; i < sablony.Count; i++)
                {
                    AddTemplate(sablony[i].Nazev);
                    TemplateGetterSetter.SetTemplate(sablony[i], this);
                }
                //DebugLog.Zapis("Presypano.");
            }
        }
    }
}