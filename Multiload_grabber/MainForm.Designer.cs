namespace MultiloadGrabber
{
    partial class hlavniOkno1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hlavniOkno1));
            this.generuj = new System.Windows.Forms.Button();
            this.inputLinks = new System.Windows.Forms.TextBox();
            this.grabber = new System.Windows.Forms.GroupBox();
            this.MoznostiPanel = new System.Windows.Forms.GroupBox();
            this.foldersOnly = new System.Windows.Forms.RadioButton();
            this.templates = new System.Windows.Forms.RadioButton();
            this.selectServers = new System.Windows.Forms.RadioButton();
            this.allServers = new System.Windows.Forms.RadioButton();
            this.templateListPanel = new System.Windows.Forms.GroupBox();
            this.templateList = new System.Windows.Forms.ComboBox();
            this.serverPanel = new System.Windows.Forms.GroupBox();
            this.FileFactory = new System.Windows.Forms.CheckBox();
            this.Rapidshare = new System.Windows.Forms.CheckBox();
            this.Sharerapid = new System.Windows.Forms.CheckBox();
            this.Quickshare = new System.Windows.Forms.CheckBox();
            this.Ulozto = new System.Windows.Forms.CheckBox();
            this.hellshare = new System.Windows.Forms.CheckBox();
            this.Multishare = new System.Windows.Forms.CheckBox();
            this.vystupLinky = new System.Windows.Forms.GroupBox();
            this.outputLinks = new System.Windows.Forms.TextBox();
            this.multiLoadLinky = new System.Windows.Forms.GroupBox();
            this.sablonaListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.novaSablonaContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.prázdnáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopieZVybranéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zTextuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odstranitŠablonuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přejmenovatŠablonuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateEditPanel = new System.Windows.Forms.GroupBox();
            this.sablonaHotovoButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.templateEditList = new System.Windows.Forms.ListBox();
            this.textSablony = new System.Windows.Forms.GroupBox();
            this.templateEditBox = new System.Windows.Forms.TextBox();
            this.menuSoubor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTemplates = new System.Windows.Forms.ToolStripMenuItem();
            this.přidatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOddelovac1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuKonec = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nastaveníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nápovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zkontrolovatAktualizaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugTestyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grabber.SuspendLayout();
            this.MoznostiPanel.SuspendLayout();
            this.templateListPanel.SuspendLayout();
            this.serverPanel.SuspendLayout();
            this.vystupLinky.SuspendLayout();
            this.multiLoadLinky.SuspendLayout();
            this.sablonaListContextMenu.SuspendLayout();
            this.templateEditPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.textSablony.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generuj
            // 
            this.generuj.Location = new System.Drawing.Point(388, 301);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(148, 30);
            this.generuj.TabIndex = 0;
            this.generuj.Text = "Generuj";
            this.generuj.UseVisualStyleBackColor = true;
            this.generuj.Click += new System.EventHandler(this.generuj_Click);
            // 
            // inputLinks
            // 
            this.inputLinks.Location = new System.Drawing.Point(6, 18);
            this.inputLinks.Multiline = true;
            this.inputLinks.Name = "inputLinks";
            this.inputLinks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inputLinks.Size = new System.Drawing.Size(358, 288);
            this.inputLinks.TabIndex = 1;
            this.inputLinks.WordWrap = false;
            // 
            // grabber
            // 
            this.grabber.Controls.Add(this.MoznostiPanel);
            this.grabber.Controls.Add(this.vystupLinky);
            this.grabber.Controls.Add(this.multiLoadLinky);
            this.grabber.Controls.Add(this.generuj);
            this.grabber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grabber.Location = new System.Drawing.Point(12, 27);
            this.grabber.Name = "grabber";
            this.grabber.Size = new System.Drawing.Size(920, 337);
            this.grabber.TabIndex = 3;
            this.grabber.TabStop = false;
            this.grabber.Text = "Grabber odkazů";
            // 
            // MoznostiPanel
            // 
            this.MoznostiPanel.Controls.Add(this.foldersOnly);
            this.MoznostiPanel.Controls.Add(this.templates);
            this.MoznostiPanel.Controls.Add(this.selectServers);
            this.MoznostiPanel.Controls.Add(this.allServers);
            this.MoznostiPanel.Controls.Add(this.templateListPanel);
            this.MoznostiPanel.Controls.Add(this.serverPanel);
            this.MoznostiPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MoznostiPanel.Location = new System.Drawing.Point(388, 19);
            this.MoznostiPanel.Name = "MoznostiPanel";
            this.MoznostiPanel.Size = new System.Drawing.Size(148, 271);
            this.MoznostiPanel.TabIndex = 5;
            this.MoznostiPanel.TabStop = false;
            this.MoznostiPanel.Text = "Možnosti";
            // 
            // foldersOnly
            // 
            this.foldersOnly.AutoSize = true;
            this.foldersOnly.Location = new System.Drawing.Point(14, 87);
            this.foldersOnly.Name = "foldersOnly";
            this.foldersOnly.Size = new System.Drawing.Size(87, 17);
            this.foldersOnly.TabIndex = 5;
            this.foldersOnly.TabStop = true;
            this.foldersOnly.Text = "Pouze složky";
            this.foldersOnly.UseVisualStyleBackColor = true;
            // 
            // templates
            // 
            this.templates.AutoSize = true;
            this.templates.Location = new System.Drawing.Point(14, 64);
            this.templates.Name = "templates";
            this.templates.Size = new System.Drawing.Size(63, 17);
            this.templates.TabIndex = 2;
            this.templates.Text = "Šablony";
            this.templates.UseVisualStyleBackColor = true;
            this.templates.CheckedChanged += new System.EventHandler(this.Sablony_CheckedChanged);
            // 
            // selectServers
            // 
            this.selectServers.AutoSize = true;
            this.selectServers.Location = new System.Drawing.Point(14, 41);
            this.selectServers.Name = "selectServers";
            this.selectServers.Size = new System.Drawing.Size(110, 17);
            this.selectServers.TabIndex = 1;
            this.selectServers.Text = "Jednotlivé servery";
            this.selectServers.UseVisualStyleBackColor = true;
            this.selectServers.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // allServers
            // 
            this.allServers.AutoSize = true;
            this.allServers.Checked = true;
            this.allServers.Location = new System.Drawing.Point(14, 18);
            this.allServers.Name = "allServers";
            this.allServers.Size = new System.Drawing.Size(103, 17);
            this.allServers.TabIndex = 0;
            this.allServers.TabStop = true;
            this.allServers.Text = "Všechny servery";
            this.allServers.UseVisualStyleBackColor = true;
            // 
            // templateListPanel
            // 
            this.templateListPanel.Controls.Add(this.templateList);
            this.templateListPanel.Location = new System.Drawing.Point(6, 109);
            this.templateListPanel.Name = "templateListPanel";
            this.templateListPanel.Size = new System.Drawing.Size(132, 59);
            this.templateListPanel.TabIndex = 4;
            this.templateListPanel.TabStop = false;
            this.templateListPanel.Text = "Šablony";
            this.templateListPanel.Visible = false;
            // 
            // templateList
            // 
            this.templateList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.templateList.Items.AddRange(new object[] {
            "BBcode graficky",
            "BBcode textově"});
            this.templateList.Location = new System.Drawing.Point(6, 19);
            this.templateList.Name = "templateList";
            this.templateList.Size = new System.Drawing.Size(120, 21);
            this.templateList.TabIndex = 0;
            this.templateList.Tag = "";
            // 
            // serverPanel
            // 
            this.serverPanel.Controls.Add(this.FileFactory);
            this.serverPanel.Controls.Add(this.Rapidshare);
            this.serverPanel.Controls.Add(this.Sharerapid);
            this.serverPanel.Controls.Add(this.Quickshare);
            this.serverPanel.Controls.Add(this.Ulozto);
            this.serverPanel.Controls.Add(this.hellshare);
            this.serverPanel.Controls.Add(this.Multishare);
            this.serverPanel.Location = new System.Drawing.Point(6, 109);
            this.serverPanel.Name = "serverPanel";
            this.serverPanel.Size = new System.Drawing.Size(132, 156);
            this.serverPanel.TabIndex = 3;
            this.serverPanel.TabStop = false;
            this.serverPanel.Text = "Servery";
            this.serverPanel.Visible = false;
            // 
            // FileFactory
            // 
            this.FileFactory.AutoSize = true;
            this.FileFactory.Location = new System.Drawing.Point(8, 129);
            this.FileFactory.Name = "FileFactory";
            this.FileFactory.Size = new System.Drawing.Size(77, 17);
            this.FileFactory.TabIndex = 6;
            this.FileFactory.Text = "FileFactory";
            this.FileFactory.UseVisualStyleBackColor = true;
            // 
            // Rapidshare
            // 
            this.Rapidshare.AutoSize = true;
            this.Rapidshare.Location = new System.Drawing.Point(8, 74);
            this.Rapidshare.Name = "Rapidshare";
            this.Rapidshare.Size = new System.Drawing.Size(80, 17);
            this.Rapidshare.TabIndex = 5;
            this.Rapidshare.Text = "Rapidshare";
            this.Rapidshare.UseVisualStyleBackColor = true;
            // 
            // Sharerapid
            // 
            this.Sharerapid.AutoSize = true;
            this.Sharerapid.Location = new System.Drawing.Point(8, 93);
            this.Sharerapid.Name = "Sharerapid";
            this.Sharerapid.Size = new System.Drawing.Size(85, 17);
            this.Sharerapid.TabIndex = 4;
            this.Sharerapid.Text = "Share-Rapid";
            this.Sharerapid.UseVisualStyleBackColor = true;
            // 
            // Quickshare
            // 
            this.Quickshare.AutoSize = true;
            this.Quickshare.Location = new System.Drawing.Point(8, 55);
            this.Quickshare.Name = "Quickshare";
            this.Quickshare.Size = new System.Drawing.Size(82, 17);
            this.Quickshare.TabIndex = 3;
            this.Quickshare.Text = "QuickShare";
            this.Quickshare.UseVisualStyleBackColor = true;
            // 
            // Ulozto
            // 
            this.Ulozto.AutoSize = true;
            this.Ulozto.Location = new System.Drawing.Point(8, 111);
            this.Ulozto.Name = "Ulozto";
            this.Ulozto.Size = new System.Drawing.Size(59, 17);
            this.Ulozto.TabIndex = 2;
            this.Ulozto.Text = "Uloz.to";
            this.Ulozto.UseVisualStyleBackColor = true;
            // 
            // hellshare
            // 
            this.hellshare.AutoSize = true;
            this.hellshare.Location = new System.Drawing.Point(8, 36);
            this.hellshare.Name = "hellshare";
            this.hellshare.Size = new System.Drawing.Size(70, 17);
            this.hellshare.TabIndex = 1;
            this.hellshare.Text = "Hellshare";
            this.hellshare.UseVisualStyleBackColor = true;
            // 
            // Multishare
            // 
            this.Multishare.AutoSize = true;
            this.Multishare.Location = new System.Drawing.Point(8, 17);
            this.Multishare.Name = "Multishare";
            this.Multishare.Size = new System.Drawing.Size(74, 17);
            this.Multishare.TabIndex = 0;
            this.Multishare.Text = "Multishare";
            this.Multishare.UseVisualStyleBackColor = true;
            // 
            // vystupLinky
            // 
            this.vystupLinky.Controls.Add(this.outputLinks);
            this.vystupLinky.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vystupLinky.Location = new System.Drawing.Point(542, 19);
            this.vystupLinky.Name = "vystupLinky";
            this.vystupLinky.Size = new System.Drawing.Size(370, 312);
            this.vystupLinky.TabIndex = 4;
            this.vystupLinky.TabStop = false;
            this.vystupLinky.Text = "Zpracované linky";
            // 
            // outputLinks
            // 
            this.outputLinks.Location = new System.Drawing.Point(6, 18);
            this.outputLinks.Multiline = true;
            this.outputLinks.Name = "outputLinks";
            this.outputLinks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputLinks.Size = new System.Drawing.Size(358, 289);
            this.outputLinks.TabIndex = 1;
            this.outputLinks.WordWrap = false;
            this.outputLinks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OutputLinky_MouseClick);
            // 
            // multiLoadLinky
            // 
            this.multiLoadLinky.Controls.Add(this.inputLinks);
            this.multiLoadLinky.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multiLoadLinky.Location = new System.Drawing.Point(12, 19);
            this.multiLoadLinky.Name = "multiLoadLinky";
            this.multiLoadLinky.Size = new System.Drawing.Size(370, 312);
            this.multiLoadLinky.TabIndex = 3;
            this.multiLoadLinky.TabStop = false;
            this.multiLoadLinky.Text = "Linky na Multiload";
            // 
            // sablonaListContextMenu
            // 
            this.sablonaListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaSablonaContextMenu,
            this.odstranitŠablonuToolStripMenuItem,
            this.přejmenovatŠablonuToolStripMenuItem});
            this.sablonaListContextMenu.Name = "contextMenuStrip1";
            this.sablonaListContextMenu.Size = new System.Drawing.Size(187, 70);
            this.sablonaListContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.sablonaListContextMenu_Opening);
            // 
            // novaSablonaContextMenu
            // 
            this.novaSablonaContextMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prázdnáToolStripMenuItem,
            this.kopieZVybranéToolStripMenuItem,
            this.zTextuToolStripMenuItem});
            this.novaSablonaContextMenu.Name = "novaSablonaContextMenu";
            this.novaSablonaContextMenu.Size = new System.Drawing.Size(186, 22);
            this.novaSablonaContextMenu.Text = "Nová šablona...";
            // 
            // prázdnáToolStripMenuItem
            // 
            this.prázdnáToolStripMenuItem.Name = "prázdnáToolStripMenuItem";
            this.prázdnáToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.prázdnáToolStripMenuItem.Text = "prázdná";
            this.prázdnáToolStripMenuItem.Click += new System.EventHandler(this.prázdnáToolStripMenuItem_Click);
            // 
            // kopieZVybranéToolStripMenuItem
            // 
            this.kopieZVybranéToolStripMenuItem.Name = "kopieZVybranéToolStripMenuItem";
            this.kopieZVybranéToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.kopieZVybranéToolStripMenuItem.Text = "kopie z vybrané";
            this.kopieZVybranéToolStripMenuItem.Click += new System.EventHandler(this.kopieZVybranéToolStripMenuItem_Click);
            // 
            // zTextuToolStripMenuItem
            // 
            this.zTextuToolStripMenuItem.Name = "zTextuToolStripMenuItem";
            this.zTextuToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.zTextuToolStripMenuItem.Text = "z textu";
            this.zTextuToolStripMenuItem.Click += new System.EventHandler(this.zTextuToolStripMenuItem_Click);
            // 
            // odstranitŠablonuToolStripMenuItem
            // 
            this.odstranitŠablonuToolStripMenuItem.Name = "odstranitŠablonuToolStripMenuItem";
            this.odstranitŠablonuToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.odstranitŠablonuToolStripMenuItem.Text = "Odstranit šablonu";
            this.odstranitŠablonuToolStripMenuItem.Click += new System.EventHandler(this.odstranitŠablonuToolStripMenuItem_Click);
            // 
            // přejmenovatŠablonuToolStripMenuItem
            // 
            this.přejmenovatŠablonuToolStripMenuItem.Name = "přejmenovatŠablonuToolStripMenuItem";
            this.přejmenovatŠablonuToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.přejmenovatŠablonuToolStripMenuItem.Text = "Přejmenovat šablonu";
            this.přejmenovatŠablonuToolStripMenuItem.Click += new System.EventHandler(this.přejmenovatŠablonuToolStripMenuItem_Click);
            // 
            // templateEditPanel
            // 
            this.templateEditPanel.Controls.Add(this.sablonaHotovoButton);
            this.templateEditPanel.Controls.Add(this.groupBox4);
            this.templateEditPanel.Controls.Add(this.textSablony);
            this.templateEditPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.templateEditPanel.Location = new System.Drawing.Point(12, 27);
            this.templateEditPanel.Name = "templateEditPanel";
            this.templateEditPanel.Size = new System.Drawing.Size(920, 326);
            this.templateEditPanel.TabIndex = 5;
            this.templateEditPanel.TabStop = false;
            this.templateEditPanel.Text = "Editace šablon";
            this.templateEditPanel.Visible = false;
            // 
            // sablonaHotovoButton
            // 
            this.sablonaHotovoButton.Location = new System.Drawing.Point(697, 289);
            this.sablonaHotovoButton.Name = "sablonaHotovoButton";
            this.sablonaHotovoButton.Size = new System.Drawing.Size(214, 26);
            this.sablonaHotovoButton.TabIndex = 2;
            this.sablonaHotovoButton.Text = "Hotovo";
            this.sablonaHotovoButton.UseVisualStyleBackColor = true;
            this.sablonaHotovoButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.templateEditList);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(697, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(214, 264);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Šablony";
            // 
            // templateEditList
            // 
            this.templateEditList.ContextMenuStrip = this.sablonaListContextMenu;
            this.templateEditList.FormattingEnabled = true;
            this.templateEditList.Location = new System.Drawing.Point(6, 18);
            this.templateEditList.Name = "templateEditList";
            this.templateEditList.Size = new System.Drawing.Size(202, 238);
            this.templateEditList.TabIndex = 0;
            this.templateEditList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textSablony
            // 
            this.textSablony.Controls.Add(this.templateEditBox);
            this.textSablony.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textSablony.Location = new System.Drawing.Point(12, 19);
            this.textSablony.Name = "textSablony";
            this.textSablony.Size = new System.Drawing.Size(679, 298);
            this.textSablony.TabIndex = 2;
            this.textSablony.TabStop = false;
            this.textSablony.Text = "Šablona";
            // 
            // templateEditBox
            // 
            this.templateEditBox.Location = new System.Drawing.Point(6, 18);
            this.templateEditBox.Multiline = true;
            this.templateEditBox.Name = "templateEditBox";
            this.templateEditBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.templateEditBox.Size = new System.Drawing.Size(667, 274);
            this.templateEditBox.TabIndex = 0;
            this.templateEditBox.WordWrap = false;
            this.templateEditBox.TextChanged += new System.EventHandler(this.SablonaEditBox_TextChanged);
            // 
            // menuSoubor
            // 
            this.menuSoubor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuSoubor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTemplates,
            this.menuOddelovac1,
            this.menuKonec});
            this.menuSoubor.Name = "menuSoubor";
            this.menuSoubor.Size = new System.Drawing.Size(65, 19);
            this.menuSoubor.Text = "Program";
            // 
            // menuTemplates
            // 
            this.menuTemplates.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.přidatToolStripMenuItem,
            this.importToolStripMenuItem});
            this.menuTemplates.Name = "menuTemplates";
            this.menuTemplates.Size = new System.Drawing.Size(116, 22);
            this.menuTemplates.Text = "Šablony";
            // 
            // přidatToolStripMenuItem
            // 
            this.přidatToolStripMenuItem.Name = "přidatToolStripMenuItem";
            this.přidatToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.přidatToolStripMenuItem.Text = "Editace";
            this.přidatToolStripMenuItem.Click += new System.EventHandler(this.přidatToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // menuOddelovac1
            // 
            this.menuOddelovac1.Name = "menuOddelovac1";
            this.menuOddelovac1.Size = new System.Drawing.Size(113, 6);
            // 
            // menuKonec
            // 
            this.menuKonec.Name = "menuKonec";
            this.menuKonec.Size = new System.Drawing.Size(116, 22);
            this.menuKonec.Text = "Konec";
            this.menuKonec.Click += new System.EventHandler(this.MenuKonec_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSoubor,
            this.nastaveníToolStripMenuItem,
            this.nápovědaToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 23);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "Menu";
            this.menuStrip1.ClientSizeChanged += new System.EventHandler(this.Form1_ResizeEnd);
            // 
            // nastaveníToolStripMenuItem
            // 
            this.nastaveníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkCheckerToolStripMenuItem});
            this.nastaveníToolStripMenuItem.Name = "nastaveníToolStripMenuItem";
            this.nastaveníToolStripMenuItem.Size = new System.Drawing.Size(63, 19);
            this.nastaveníToolStripMenuItem.Text = "Nástroje";
            // 
            // linkCheckerToolStripMenuItem
            // 
            this.linkCheckerToolStripMenuItem.Name = "linkCheckerToolStripMenuItem";
            this.linkCheckerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.linkCheckerToolStripMenuItem.Text = "Link Checker";
            this.linkCheckerToolStripMenuItem.Click += new System.EventHandler(this.linkCheckerToolStripMenuItem_Click);
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zkontrolovatAktualizaceToolStripMenuItem,
            this.oProgramuToolStripMenuItem,
            this.debugTestyToolStripMenuItem});
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            this.nápovědaToolStripMenuItem.Size = new System.Drawing.Size(73, 19);
            this.nápovědaToolStripMenuItem.Text = "Nápověda";
            // 
            // zkontrolovatAktualizaceToolStripMenuItem
            // 
            this.zkontrolovatAktualizaceToolStripMenuItem.Name = "zkontrolovatAktualizaceToolStripMenuItem";
            this.zkontrolovatAktualizaceToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.zkontrolovatAktualizaceToolStripMenuItem.Text = "Zkontrolovat aktualizace";
            this.zkontrolovatAktualizaceToolStripMenuItem.Click += new System.EventHandler(this.zkontrolovatAktualizaceToolStripMenuItem_Click);
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // debugTestyToolStripMenuItem
            // 
            this.debugTestyToolStripMenuItem.Name = "debugTestyToolStripMenuItem";
            this.debugTestyToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.debugTestyToolStripMenuItem.Text = "Debug testy";
            this.debugTestyToolStripMenuItem.Visible = false;
            this.debugTestyToolStripMenuItem.Click += new System.EventHandler(this.debugTestyToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.dat";
            this.openFileDialog1.Filter = "Soubory šablon|*.dat";
            // 
            // hlavniOkno1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 376);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.templateEditPanel);
            this.Controls.Add(this.grabber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(952, 410);
            this.Name = "hlavniOkno1";
            this.Text = "Multiload Grabber";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ResizeEnd);
            this.grabber.ResumeLayout(false);
            this.MoznostiPanel.ResumeLayout(false);
            this.MoznostiPanel.PerformLayout();
            this.templateListPanel.ResumeLayout(false);
            this.serverPanel.ResumeLayout(false);
            this.serverPanel.PerformLayout();
            this.vystupLinky.ResumeLayout(false);
            this.vystupLinky.PerformLayout();
            this.multiLoadLinky.ResumeLayout(false);
            this.multiLoadLinky.PerformLayout();
            this.sablonaListContextMenu.ResumeLayout(false);
            this.templateEditPanel.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.textSablony.ResumeLayout(false);
            this.textSablony.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generuj;
        private System.Windows.Forms.TextBox inputLinks;
        private System.Windows.Forms.GroupBox grabber;
        private System.Windows.Forms.GroupBox vystupLinky;
        private System.Windows.Forms.TextBox outputLinks;
        private System.Windows.Forms.GroupBox multiLoadLinky;
        private System.Windows.Forms.GroupBox MoznostiPanel;
        private System.Windows.Forms.RadioButton templates;
        private System.Windows.Forms.RadioButton selectServers;
        private System.Windows.Forms.RadioButton allServers;
        private System.Windows.Forms.GroupBox serverPanel;
        private System.Windows.Forms.CheckBox Rapidshare;
        private System.Windows.Forms.CheckBox Sharerapid;
        private System.Windows.Forms.CheckBox Quickshare;
        private System.Windows.Forms.CheckBox Ulozto;
        private System.Windows.Forms.CheckBox hellshare;
        private System.Windows.Forms.CheckBox Multishare;
        private System.Windows.Forms.GroupBox templateListPanel;
        private System.Windows.Forms.ComboBox templateList;
        private System.Windows.Forms.GroupBox templateEditPanel;
        private System.Windows.Forms.GroupBox textSablony;
        private System.Windows.Forms.TextBox templateEditBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox templateEditList;
        private System.Windows.Forms.Button sablonaHotovoButton;
        private System.Windows.Forms.ContextMenuStrip sablonaListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuSoubor;
        private System.Windows.Forms.ToolStripMenuItem menuKonec;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novaSablonaContextMenu;
        private System.Windows.Forms.ToolStripMenuItem prázdnáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopieZVybranéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odstranitŠablonuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zTextuToolStripMenuItem;
        private System.Windows.Forms.CheckBox FileFactory;
        private System.Windows.Forms.ToolStripMenuItem nápovědaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zkontrolovatAktualizaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.RadioButton foldersOnly;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem přejmenovatŠablonuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugTestyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastaveníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkCheckerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuTemplates;
        private System.Windows.Forms.ToolStripMenuItem přidatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator menuOddelovac1;
    }
}

