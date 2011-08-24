///<Summary>
///This part of the program is responsible for loading and saving templates from/to the disk drive. Mostly called by TemplateTable.
///</summary>
///

using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace MultiloadGrabber
{
    public class TemplateGetterSetter
    {
        public static Template GetTemplate(string filename)
        {
            System.IO.Stream proud = new System.IO.FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.Runtime.Serialization.IFormatter formater = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            formater.Binder = new TemplateSupportDeserializationBinder();
            Template sabl = null;
            try
            {
                sabl = (Template)formater.Deserialize(proud);
            }
            catch
            {
                proud.Close();
                return null;
            }
            finally
            {
                proud.Close();
            }
            return sabl;
        }
        public static Template GetTemplate(string s, TemplateTable tmpTable)
        {
            if (tmpTable.VratID(s) == -1)
                return null;
            return GetTemplate(Application.StartupPath + "/data/Template" + tmpTable.VratID(s) + ".dat");
        }
        public static void SetTemplate(Template sabl, TemplateTable tmpTable)
        {
            int a = -1;
            if ((a = tmpTable.VratID(sabl.Nazev)) == -1)
                return;
            else
            {
                if (!System.IO.Directory.Exists(Application.StartupPath + "/data"))
                    System.IO.Directory.CreateDirectory(Application.StartupPath + "/data");
                System.IO.Stream proud = new System.IO.FileStream((Application.StartupPath + "/data/Template" + a + ".dat"), System.IO.FileMode.Create, System.IO.FileAccess.Write);
                System.Runtime.Serialization.IFormatter formater = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                try
                {
                    formater.Serialize(proud, sabl);
                }
                finally
                {
                    proud.Close();
                }
            }
        }
    }
}

    