using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using LocalConst;

namespace MultiloadGrabber
{
    public partial class LinkCheckerForm : Form
    {
        public LinkCheckerForm()
        {
            InitializeComponent();
        }

        Action<object> LinkCheckTask = (object o) =>
        {
            {
                Parser p = ((Parser)((object[])o)[0]);
                int server = ((int)((object[])o)[1]);
                DataGridView grid = ((DataGridView)((object[])o)[2]);
                bool[] res = null;
                string[] links = null;
                switch (server)
                {
                    case 0:
                        res = LinkChecker.CheckMultiShare(links = p.GetMultiShare());
                        break;
                    case 1:
                        res = LinkChecker.CheckHellShare(links = p.GetHellShare());
                        break;
                    case 2:
                        res = LinkChecker.CheckQuickShare(links = p.GetQuickShare());
                        break;
                    case 3:
                        res = LinkChecker.CheckRapidShare(links = p.GetRapidShare());
                        break;
                    case 4:
                        for (int i = 0; i < p.GetShareRapid().Length; i++)
                        {
                            if (p.GetShareRapid()[i] == "-")
                                grid[server, i].Style.BackColor = Color.Gray;
                            else
                            {
                                if (LinkChecker.CheckShareRapid(p.GetShareRapid()[i]))
                                    grid[server, i].Style.BackColor = Color.Green;
                                else
                                    grid[server, i].Style.BackColor = Color.Red;
                            }
                        }
                        return;
                    case 5:
                        res = LinkChecker.CheckUlozTo(links = p.GetUlozTo());
                        break;
                    case 6:
                        res = LinkChecker.CheckFileFactory(links = p.GetFileFactory());
                        break;
                }
                if (res == null)
                    return;
                for (int i = 0; i < res.Length; i++)
                    if (links[i] != "-")
                    {
                        if (res[i] == true)
                            grid[server, i].Style.BackColor = Color.Green;
                        else
                            grid[server, i].Style.BackColor = Color.Red;
                    }
                    else
                        grid[server, i].Style.BackColor = Color.Gray;

            }
        };

        private void button1_Click(object sender, EventArgs e)
        {
            linkCheckerResults.RowCount = 0;
            linkCheckerResults.ColumnCount = 0;

            Parser p = new Parser(inputLinks.Lines, null);
            if (p.Failed)
            {
                DebugLog.Zapis("Parser couldn't connect to the Internet. Link checking failed.");
                return;
            }           

            int max = 7;

            string[] grabbed = p.GrabbedLinks;

            linkCheckerResults.RowCount = grabbed.Length;
            linkCheckerResults.ColumnCount = 7;
            linkCheckerResults.CurrentCell = null;
            linkCheckerResults.ClearSelection();
            for (int i = 0; i < grabbed.Length; i++)
            {
                if (grabbed[i].Length < 30)
                    linkCheckerResults.Rows[i].HeaderCell.Value = grabbed[i];
                else
                {
                    linkCheckerResults.Rows[i].HeaderCell.Value = "..." + grabbed[i].Substring(grabbed[i].Length - 27);
                    linkCheckerResults.Rows[i].HeaderCell.ToolTipText = grabbed[i];
                }
            }

            Task[] ulohy = new Task[7];
            for (int i=0; i<max;i++)
            {
                linkCheckerResults.Columns[i].HeaderCell.Value = Const.servers[i];
                if (excludeSR.Checked && i == 4)
                    continue;
                ulohy[i] = Task.Factory.StartNew(LinkCheckTask, new object[]{p, i, linkCheckerResults});
            }
        }

        private void linkCheckerResults_SelectionChanged(object sender, EventArgs e)
        {
            linkCheckerResults.CurrentCell = null;
            linkCheckerResults.ClearSelection();
        }
    }
}
