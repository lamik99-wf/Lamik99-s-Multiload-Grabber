///<summary>
///This class is used to parse the template text. It should replace the placeholders in the templates for grabbed links. The output is directly 
///to the textbox provided.
///</summary>
///

using System.Windows.Forms;
namespace MultiloadGrabber
{
    public class SablonaParser
    {
        public static void Parse(Template sablona, Parser p, TextBox output)
        {
            foreach (string s in sablona.SablonaText)
            {
                string t = s;
                t = t.Replace("÷MULTISHARE÷", p.MultishareString());
                t = t.Replace("÷HELLSHARE÷", p.HellshareString());
                t = t.Replace("÷RAPIDSHARE÷", p.RapidshareString());
                t = t.Replace("÷SHARERAPID÷", p.SharerapidString());
                t = t.Replace("÷QUICKSHARE÷", p.QuickshareString());
                t = t.Replace("÷FILEFACTORY÷", p.FilefactoryString());
                t = t.Replace("÷ULOZTO÷", p.UloztoString());
                output.AppendText(t + System.Environment.NewLine);
            }
        }
    }
}