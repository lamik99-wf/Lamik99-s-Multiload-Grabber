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
    public partial class hlavniOkno1 : Form
    {
        public TemplateTable tmpTable;

        public bool templateChanged = false;
        public int lastSelected = -1;
        public hlavniOkno1()
        {
            InitializeComponent();
            tmpTable = new TemplateTable();
            if (!System.IO.Directory.Exists(Application.StartupPath+"/data"))
            {
                System.IO.Directory.CreateDirectory(Application.StartupPath+"/data");
            }
            if (System.IO.File.Exists(Application.StartupPath+"/data/TemplateList.dat"))
                tmpTable.Deserialize();
            else tmpTable.Serialize();
        }

        /// <summary>
        /// Main grab-handling method 
        /// sends the needed information to the server, gets response and parse it
        /// </summary>
        private void generuj_Click(object sender, EventArgs e)
        {
            if (foldersOnly.Checked)
            {
                outputLinks.Clear();
                foreach (string s in inputLinks.Lines)
                {
                    if (s.IndexOf("/slozka/") >= 0)
                        foreach (string t in Parser.GetFolderContain(s))
                            outputLinks.AppendText(t + System.Environment.NewLine);
                }
                return;
            }

            Parser p = new Parser(inputLinks.Lines);
       
            outputLinks.Clear();
            if (templates.Checked)
            {
                Template sabl;
                sabl = TemplateGetterSetter.GetTemplate(templateList.Text,tmpTable);
                if (sabl!=null)
                    SablonaParser.Parse(sabl, p, outputLinks);
            }
            else
            {
                if (allServers.Checked || Multishare.Checked)
                    foreach (string s in p.GetMultiShare())
                    {
                        outputLinks.AppendText(s + System.Environment.NewLine);
                    }
                if (allServers.Checked || hellshare.Checked)
                    foreach (string s in p.GetHellShare())
                    {
                        outputLinks.AppendText(s + System.Environment.NewLine);
                    }
                if (allServers.Checked || Quickshare.Checked)
                    foreach (string s in p.GetQuickShare())
                    {
                        outputLinks.AppendText(s + System.Environment.NewLine);
                    }
                if (allServers.Checked || Rapidshare.Checked)
                    foreach (string s in p.GetRapidShare())
                    {
                        outputLinks.AppendText(s + System.Environment.NewLine);
                    }
                if (allServers.Checked || Sharerapid.Checked)
                    foreach (string s in p.GetShareRapid())
                    {
                        outputLinks.AppendText(s + System.Environment.NewLine);
                    }
                if (allServers.Checked || Ulozto.Checked)
                    foreach (string s in p.GetUlozTo())
                    {
                        outputLinks.AppendText(s + System.Environment.NewLine);
                    }
                if (allServers.Checked || FileFactory.Checked)
                    foreach (string s in p.GetFileFactory())
                    {
                        outputLinks.AppendText(s + System.Environment.NewLine);
                    }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (selectServers.Checked)
                serverPanel.Show();
            else serverPanel.Hide();
        }

        private void Sablony_CheckedChanged(object sender, EventArgs e)
        {
            if (templates.Checked)
            {
                templateListPanel.Show();

                if (templateList.Items.Count != 0)
                    templateList.Text = (string)templateList.Items[0];
            }
            else templateListPanel.Hide();
        }

        private void OutputLinky_MouseClick(object sender, MouseEventArgs e)
        {
            outputLinks.SelectAll();
        }

        private void MenuKonec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!System.IO.Directory.Exists(Application.StartupPath+"/data"))
                System.IO.Directory.CreateDirectory(Application.StartupPath+"/data");
            tmpTable.Serialize();
        }

        private void přidatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (templateEditPanel.Visible)
                button3_Click(this, EventArgs.Empty);
            templateEditList.Items.Clear();
            foreach (string s in tmpTable.GetAllNames())
                templateEditList.Items.Add(s);
            templateEditBox.ResetText();
            templateEditPanel.Show();
            grabber.Hide();
            templateChanged = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (templateChanged && templateEditList.SelectedIndex >= 0)
            {
                System.Windows.Forms.DialogResult res = MessageBox.Show("Chcete uložit změny v šabloně " + templateEditList.SelectedItem.ToString() + "?", "Uložit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (res)
                {
                    case System.Windows.Forms.DialogResult.No:
                        break;
                    case System.Windows.Forms.DialogResult.None:
                    case System.Windows.Forms.DialogResult.Cancel:
                        return;
                    case System.Windows.Forms.DialogResult.Yes:
                        List<string> sezn = new List<string>();
                        foreach (string s in templateEditBox.Lines)
                            sezn.Add(s);
                        Template sabl = new Template(templateEditList.SelectedItem.ToString(), sezn);
                        TemplateGetterSetter.SetTemplate(sabl, tmpTable);
                        break;
                }
            }
            else
            {
                if (templateChanged)
                    zTextuToolStripMenuItem_Click(sender, e);
            }
            templateEditPanel.Hide();
            lastSelected = -1;
            grabber.Show();
            templateList.Items.Clear();
            foreach (string s in tmpTable.GetAllNames())
                templateList.Items.Add(s);
            if (templateList.Items.Count != 0)
                templateList.Text = templateList.Items[0].ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (templateEditList.SelectedIndex >= 0)
            {
                if (templateChanged && lastSelected != -1)
                {
                    System.Windows.Forms.DialogResult res = MessageBox.Show("Chcete uložit změny v šabloně " + templateEditList.Items[lastSelected].ToString() + "?", "Uložit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    switch (res)
                    {
                        case System.Windows.Forms.DialogResult.No:
                            break;
                        case System.Windows.Forms.DialogResult.None:
                        case System.Windows.Forms.DialogResult.Cancel:
                            return;
                        case System.Windows.Forms.DialogResult.Yes:
                            List<string> sezn = new List<string>();
                            foreach (string s in templateEditBox.Lines)
                                sezn.Add(s);
                            Template sabl = new Template(templateEditList.Items[lastSelected].ToString(), sezn);
                            TemplateGetterSetter.SetTemplate(sabl, tmpTable);
                            break;
                    }
                }
                templateEditBox.Clear();
                lastSelected = templateEditList.SelectedIndex;
                Template templ = TemplateGetterSetter.GetTemplate(templateEditList.SelectedItem.ToString(), tmpTable);
                foreach (string s in templ.SablonaText)
                    templateEditBox.AppendText(s + System.Environment.NewLine);
                templateChanged = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            templateList.Items.Clear();
            foreach (string s in tmpTable.GetAllNames())
                templateList.Items.Add(s);
            if (templateList.Items.Count != 0)
                templateList.Text = templateList.Items[0].ToString();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            templateEditPanel.Height = grabber.Height = FindForm().Height - 73;
            grabber.Width = templateEditPanel.Width = FindForm().Width - 32;
            MoznostiPanel.Left = generuj.Left = (grabber.Width / 2) - 72;
            generuj.Top = grabber.Height - 39;
            multiLoadLinky.Height = grabber.Height - 28;
            vystupLinky.Height = grabber.Height - 28;
            inputLinks.Width = outputLinks.Width = (grabber.Width / 2) - 102;
            inputLinks.Height = outputLinks.Height = grabber.Height - 52;
            multiLoadLinky.Width = (grabber.Width / 2) - 90;
            vystupLinky.Left = (grabber.Width / 2) + 82;
            vystupLinky.Width = multiLoadLinky.Width;            
        }

        private void SablonaEditBox_TextChanged(object sender, EventArgs e)
        {
            if (!templateChanged)
                templateChanged = true;
        }

        private void odstranitŠablonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (templateEditList.SelectedIndex >= 0)
            {
                System.Windows.Forms.DialogResult vysledek = MessageBox.Show("Opravdu chcete smazat šablonu " + templateEditList.SelectedItem.ToString() + "?", "Odstranit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (vysledek)
                {
                    case System.Windows.Forms.DialogResult.No:
                        break;
                    case System.Windows.Forms.DialogResult.None:
                    case System.Windows.Forms.DialogResult.Cancel:
                        return;
                    case System.Windows.Forms.DialogResult.Yes:
                        int a = tmpTable.VratID(templateEditList.SelectedItem.ToString());
                        if (a >= 0 && System.IO.File.Exists(Application.StartupPath+@"/data/Template" + a + ".dat"))
                        {
                            System.IO.File.Delete(Application.StartupPath+@"/data/Template" + a + ".dat");
                            tmpTable.DeleteTemplate(templateEditList.SelectedItem.ToString());
                            templateEditList.Items.RemoveAt(templateEditList.SelectedIndex);
                            tmpTable.Serialize();
                            templateEditBox.Clear();
                        }
                        break;
                }
                templateChanged = false;
            }
            else MessageBox.Show("Není vybrána žádná šablona!","Chyba",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void sablonaListContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (templateEditList.SelectedIndex >= 0)
                kopieZVybranéToolStripMenuItem.Enabled = true;
            else kopieZVybranéToolStripMenuItem.Enabled = false;

        }

        private void kopieZVybranéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (templateChanged)
            {
                System.Windows.Forms.DialogResult res = MessageBox.Show("Chcete uložit změny v šabloně " + templateEditList.SelectedItem.ToString() + "?", "Uložit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (res)
                {
                    case System.Windows.Forms.DialogResult.No:
                        break;
                    case System.Windows.Forms.DialogResult.None:
                    case System.Windows.Forms.DialogResult.Cancel:
                        return;
                    case System.Windows.Forms.DialogResult.Yes:
                        List<string> sezn = new List<string>();
                        foreach (string s in templateEditBox.Lines)
                            sezn.Add(s);
                        Template sabl = new Template(templateEditList.SelectedItem.ToString(), sezn);
                        TemplateGetterSetter.SetTemplate(sabl, tmpTable);
                        break;
                }
            }
            string nazev = Dialogy.InputDialogBox.Show("Zadejte jméno nové šablony : ", "", "Multiload Grabber");
            if (nazev != null && nazev != "")
            {
                templateEditBox.Clear();
                Template sablon = TemplateGetterSetter.GetTemplate(templateEditList.SelectedItem.ToString(), tmpTable);
                foreach (string s in sablon.SablonaText)
                    templateEditBox.AppendText(s + System.Environment.NewLine);
                List<string> sezn= new List<string>();
                foreach(string s in templateEditBox.Lines)
                    sezn.Add(s);
                Template sablo = new Template(nazev, sezn);
                tmpTable.AddTemplate(sablo.Nazev);
                TemplateGetterSetter.SetTemplate(sablo, tmpTable);
                templateEditList.Items.Add(sablo.Nazev);
                tmpTable.Serialize();
                templateChanged = false;
                templateEditList.SelectedIndex = templateEditList.Items.Count - 1;
            }
            templateChanged = false;
        }

        private void zTextuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (templateChanged && templateEditList.SelectedIndex>=0)
            {
                System.Windows.Forms.DialogResult vysledek = MessageBox.Show("Chcete uložit změny v šabloně " + templateEditList.SelectedItem.ToString() + "?", "Uložit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (vysledek)
                {
                    case System.Windows.Forms.DialogResult.No:
                        break;
                    case System.Windows.Forms.DialogResult.None:
                    case System.Windows.Forms.DialogResult.Cancel:
                        return;
                    case System.Windows.Forms.DialogResult.Yes:
                        List<string> sezn = new List<string>();
                        foreach (string s in templateEditBox.Lines)
                            sezn.Add(s);
                        Template sabl = new Template(templateEditList.SelectedItem.ToString(), sezn);
                        TemplateGetterSetter.SetTemplate(sabl, tmpTable);
                        break;
                }
            }
            string nazev = Dialogy.InputDialogBox.Show("Zadejte jméno nové šablony : ", "", "Multiload Grabber");
            if (nazev != null && nazev != "")
            {
                List<string> sezn = new List<string>();
                foreach (string s in templateEditBox.Lines)
                    sezn.Add(s);
                Template sablo = new Template(nazev, sezn);
                tmpTable.AddTemplate(sablo.Nazev);
                TemplateGetterSetter.SetTemplate(sablo, tmpTable);
                templateEditList.Items.Add(sablo.Nazev);
                tmpTable.Serialize();
                templateChanged = false;
                templateEditBox.Clear();
                templateChanged = false;
            }
            templateEditList.SelectedIndex = templateEditList.Items.Count-1;
            templateChanged = false;
        }

        private void prázdnáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (templateChanged)
            {
                System.Windows.Forms.DialogResult vysledek = MessageBox.Show("Chcete uložit změny v šabloně " + templateEditList.SelectedItem.ToString() + "?", "Uložit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (vysledek)
                {
                    case System.Windows.Forms.DialogResult.No:
                        break;
                    case System.Windows.Forms.DialogResult.None:
                    case System.Windows.Forms.DialogResult.Cancel:
                        return;
                    case System.Windows.Forms.DialogResult.Yes:
                        List<string> sezn = new List<string>();
                        foreach (string s in templateEditBox.Lines)
                            sezn.Add(s);
                        Template sabl = new Template(templateEditList.SelectedItem.ToString(), sezn);
                        TemplateGetterSetter.SetTemplate(sabl, tmpTable);
                        break;
                }
            }
            string nazev = Dialogy.InputDialogBox.Show("Zadejte jméno nové šablony : ", "", "Multiload Grabber");
            if (nazev != null && nazev != "")
            {
                templateEditBox.Clear();
                Template sablo = new Template(nazev, null);
                tmpTable.AddTemplate(sablo.Nazev);
                TemplateGetterSetter.SetTemplate(sablo, tmpTable);
                templateEditList.Items.Add(sablo.Nazev);
                tmpTable.Serialize();
                templateEditBox.Clear();
                templateEditList.SelectedIndex = templateEditList.Items.Count - 1;
            }
            templateChanged = false;
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bool proslo = true;
                Template sabl = TemplateGetterSetter.GetTemplate(openFileDialog1.FileName);
                if (sabl != null)
                {
                    while (!tmpTable.AddTemplate(sabl.Nazev))
                    {
                        if (DialogResult.Yes == MessageBox.Show("Šablona s názvem \"" + sabl.Nazev + "\" již v databázi existuje. Chcete nově vkládanou šablonu přejmenovat?", "Upozornění", MessageBoxButtons.YesNo))
                            sabl.Nazev = Dialogy.InputDialogBox.Show("Zadejte nový název šablony : ", "", "Multiload Grabber");
                        else
                        {
                            proslo = false;
                            break;
                        }
                    }
                }
                else proslo = false;
                if (proslo)
                {
                    TemplateGetterSetter.SetTemplate(sabl, tmpTable);
                    templateEditList.Items.Add(sabl.Nazev);
                    tmpTable.Serialize();
                    MessageBox.Show("Šablona "+sabl.Nazev+" byla úspěšně importována.");
                    přidatToolStripMenuItem_Click(sender, e);
                    templateEditList.SelectedIndex = templateEditList.Items.Count - 1;
                }
                else
                {
                    MessageBox.Show("Import šablony se nezdařil.");
                }
            }
        }

        private void přejmenovatŠablonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool okay = true;
            Template templ = null;
            if (templateEditList.SelectedIndex >= 0 && templateEditList.SelectedIndex < templateEditList.Items.Count)
            {
                string name = Dialogy.InputDialogBox.Show("Zadejte nové jméno pro šablonu " + templateEditList.SelectedItem.ToString(), "", "Multiload Grabber");
                if (tmpTable.VratID(name) == -1)
                {
                    int a = tmpTable.VratID(templateEditList.SelectedItem.ToString());
                    if (a >= 0 && System.IO.File.Exists(Application.StartupPath + @"/data/Template" + a + ".dat"))
                    {
                        templ = TemplateGetterSetter.GetTemplate(Application.StartupPath + @"/data/Template" + a + ".dat");
                        templ.Nazev = name;
                        System.IO.File.Delete(Application.StartupPath + @"/data/Template" + a + ".dat");
                        tmpTable.DeleteTemplate(templateEditList.SelectedItem.ToString());
                        templateEditList.Items.RemoveAt(templateEditList.SelectedIndex);
                        tmpTable.AddTemplate(name);
                        TemplateGetterSetter.SetTemplate(templ, tmpTable);
                        templateEditList.Items.Insert(a, templ.Nazev);
                        tmpTable.Serialize();
                    }
                    else okay = false;
                }
                else okay = false;
            }
            else okay = false;
            if (okay && templ != null)
            {
                MessageBox.Show("Šablona " + templ.Nazev + " byla úspěšně přejmenována.");
            }
            else
            {
                MessageBox.Show("Přejmenování šablony se nezdařilo.");
            }
        }

        private void debugTestyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Parser.Test());
        }

        private void linkCheckerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = new LinkCheckerForm();
            form1.ShowDialog();
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new AboutBox1();
            about.ShowDialog();
        }

        private void zkontrolovatAktualizaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string changelogURL = "http://mlgrabber.php5.cz/changelog.txt";
            string s = NetworkHandler.getPageSource(changelogURL);
            string[] spl = s.Split('\n');
            if (spl.Length > 0 && spl[0].Trim() != System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString())
            {
                if (MessageBox.Show("Nová verze programu je k dispozici! Chcete přejít na domovskou stránku programu?", "Nová verze k dispozici", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    System.Diagnostics.Process.Start("http://sourceforge.net/projects/mlgrabber/");
            }
            else MessageBox.Show("Vaše verze programu je aktuální!");
        }
    }     

    public class DebugLog
    {
        public static void Zapis(string co)
        {
            System.IO.FileStream proud = new System.IO.FileStream(@".\debug.txt", System.IO.FileMode.Append, System.IO.FileAccess.Write);
            System.IO.StreamWriter zapisovac = new System.IO.StreamWriter(proud);
            zapisovac.WriteLine(co);
            zapisovac.Close();
            proud.Close();
        }
    }
}
