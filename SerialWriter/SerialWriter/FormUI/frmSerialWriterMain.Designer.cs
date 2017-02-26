namespace SerialWriter
{
    partial class mtrfrmSerialWriterMain
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
            this.spBarcodeScanner = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tSmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tSmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tSmiSaveConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tSmiClear = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSmiConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.tSmiStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSmiLight = new System.Windows.Forms.ToolStripMenuItem();
            this.tSmiDark = new System.Windows.Forms.ToolStripMenuItem();
            this.tSmiScreenshot = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tSmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.plTop = new System.Windows.Forms.Panel();
            this.plMid = new System.Windows.Forms.Panel();
            this.lbItemScan = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mtrLSend = new MetroFramework.Controls.MetroLink();
            this.plButton = new System.Windows.Forms.Panel();
            this.mtrlblSendResult = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mtrLAdd = new MetroFramework.Controls.MetroLink();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtrlblItems = new MetroFramework.Controls.MetroLink();
            this.mtrcboComPort = new MetroFramework.Controls.MetroComboBox();
            this.plTopSpace = new System.Windows.Forms.Panel();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.menuStrip.SuspendLayout();
            this.plTop.SuspendLayout();
            this.plMid.SuspendLayout();
            this.panel3.SuspendLayout();
            this.plButton.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.settingsToolStripMenuItem,
            this.tsmHelp});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(268, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSmiNew,
            this.tSmiOpen,
            this.tSmiSaveConfig,
            this.tSmiClear});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(41, 23);
            this.tsmFile.Text = "File";
            // 
            // tSmiNew
            // 
            this.tSmiNew.Name = "tSmiNew";
            this.tSmiNew.Size = new System.Drawing.Size(150, 24);
            this.tSmiNew.Text = "New";
            this.tSmiNew.Click += new System.EventHandler(this.tSmiNew_Click);
            // 
            // tSmiOpen
            // 
            this.tSmiOpen.Name = "tSmiOpen";
            this.tSmiOpen.Size = new System.Drawing.Size(150, 24);
            this.tSmiOpen.Text = "Open";
            this.tSmiOpen.Click += new System.EventHandler(this.tSmiOpen_Click);
            // 
            // tSmiSaveConfig
            // 
            this.tSmiSaveConfig.Name = "tSmiSaveConfig";
            this.tSmiSaveConfig.Size = new System.Drawing.Size(150, 24);
            this.tSmiSaveConfig.Text = "Save Config";
            this.tSmiSaveConfig.Click += new System.EventHandler(this.tSmiSaveConfig_Click);
            // 
            // tSmiClear
            // 
            this.tSmiClear.Name = "tSmiClear";
            this.tSmiClear.Size = new System.Drawing.Size(150, 24);
            this.tSmiClear.Text = "Clear";
            this.tSmiClear.Click += new System.EventHandler(this.tSmiClear_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSmiConfiguration,
            this.tSmiStyle,
            this.themeToolStripMenuItem,
            this.tSmiScreenshot});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // tSmiConfiguration
            // 
            this.tSmiConfiguration.Name = "tSmiConfiguration";
            this.tSmiConfiguration.Size = new System.Drawing.Size(162, 24);
            this.tSmiConfiguration.Text = "Configuration";
            this.tSmiConfiguration.Click += new System.EventHandler(this.tSmiConfiguration_Click);
            // 
            // tSmiStyle
            // 
            this.tSmiStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueToolStripMenuItem,
            this.brownToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.magentaToolStripMenuItem,
            this.orangeToolStripMenuItem,
            this.redToolStripMenuItem,
            this.pinkToolStripMenuItem,
            this.tealToolStripMenuItem,
            this.yellowToolStripMenuItem});
            this.tSmiStyle.Name = "tSmiStyle";
            this.tSmiStyle.Size = new System.Drawing.Size(162, 24);
            this.tSmiStyle.Text = "Style";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // brownToolStripMenuItem
            // 
            this.brownToolStripMenuItem.Name = "brownToolStripMenuItem";
            this.brownToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.brownToolStripMenuItem.Text = "Brown";
            this.brownToolStripMenuItem.Click += new System.EventHandler(this.brownToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // magentaToolStripMenuItem
            // 
            this.magentaToolStripMenuItem.Name = "magentaToolStripMenuItem";
            this.magentaToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.magentaToolStripMenuItem.Text = "Magenta";
            this.magentaToolStripMenuItem.Click += new System.EventHandler(this.magentaToolStripMenuItem_Click);
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            this.orangeToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.orangeToolStripMenuItem.Text = "Orange";
            this.orangeToolStripMenuItem.Click += new System.EventHandler(this.orangeToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // pinkToolStripMenuItem
            // 
            this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
            this.pinkToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.pinkToolStripMenuItem.Text = "Pink";
            this.pinkToolStripMenuItem.Click += new System.EventHandler(this.pinkToolStripMenuItem_Click);
            // 
            // tealToolStripMenuItem
            // 
            this.tealToolStripMenuItem.Name = "tealToolStripMenuItem";
            this.tealToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.tealToolStripMenuItem.Text = "Teal";
            this.tealToolStripMenuItem.Click += new System.EventHandler(this.tealToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSmiLight,
            this.tSmiDark});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // tSmiLight
            // 
            this.tSmiLight.Name = "tSmiLight";
            this.tSmiLight.Size = new System.Drawing.Size(109, 24);
            this.tSmiLight.Text = "Light";
            this.tSmiLight.Click += new System.EventHandler(this.tSmiLight_Click);
            // 
            // tSmiDark
            // 
            this.tSmiDark.Name = "tSmiDark";
            this.tSmiDark.Size = new System.Drawing.Size(109, 24);
            this.tSmiDark.Text = "Dark";
            this.tSmiDark.Click += new System.EventHandler(this.tSmiDark_Click);
            // 
            // tSmiScreenshot
            // 
            this.tSmiScreenshot.Name = "tSmiScreenshot";
            this.tSmiScreenshot.Size = new System.Drawing.Size(162, 24);
            this.tSmiScreenshot.Text = "Screenshot";
            this.tSmiScreenshot.Click += new System.EventHandler(this.tSmiScreenshot_Click);
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSmiAbout});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(49, 23);
            this.tsmHelp.Text = "Help";
            // 
            // tSmiAbout
            // 
            this.tSmiAbout.Name = "tSmiAbout";
            this.tSmiAbout.Size = new System.Drawing.Size(116, 24);
            this.tSmiAbout.Text = "About";
            this.tSmiAbout.Click += new System.EventHandler(this.tSmiAbout_Click);
            // 
            // plTop
            // 
            this.plTop.Controls.Add(this.plMid);
            this.plTop.Controls.Add(this.panel1);
            this.plTop.Controls.Add(this.plTopSpace);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plTop.Location = new System.Drawing.Point(20, 87);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(268, 391);
            this.plTop.TabIndex = 1;
            // 
            // plMid
            // 
            this.plMid.Controls.Add(this.lbItemScan);
            this.plMid.Controls.Add(this.panel3);
            this.plMid.Controls.Add(this.plButton);
            this.plMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMid.Location = new System.Drawing.Point(0, 32);
            this.plMid.Name = "plMid";
            this.plMid.Size = new System.Drawing.Size(268, 359);
            this.plMid.TabIndex = 5;
            // 
            // lbItemScan
            // 
            this.lbItemScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbItemScan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemScan.FormattingEnabled = true;
            this.lbItemScan.ItemHeight = 18;
            this.lbItemScan.Location = new System.Drawing.Point(0, 0);
            this.lbItemScan.Name = "lbItemScan";
            this.lbItemScan.Size = new System.Drawing.Size(268, 314);
            this.lbItemScan.TabIndex = 3;
            this.lbItemScan.DoubleClick += new System.EventHandler(this.lbItemScan_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.mtrLSend);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 314);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 20);
            this.panel3.TabIndex = 5;
            // 
            // mtrLSend
            // 
            this.mtrLSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtrLSend.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mtrLSend.ForeColor = System.Drawing.Color.Black;
            this.mtrLSend.Location = new System.Drawing.Point(0, 0);
            this.mtrLSend.Name = "mtrLSend";
            this.mtrLSend.Size = new System.Drawing.Size(266, 18);
            this.mtrLSend.TabIndex = 0;
            this.mtrLSend.Text = "Send";
            this.mtrLSend.UseSelectable = true;
            this.mtrLSend.UseStyleColors = true;
            this.mtrLSend.Click += new System.EventHandler(this.mtrLSend_Click);
            // 
            // plButton
            // 
            this.plButton.Controls.Add(this.mtrlblSendResult);
            this.plButton.Controls.Add(this.panel2);
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 334);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(268, 25);
            this.plButton.TabIndex = 4;
            // 
            // mtrlblSendResult
            // 
            // 
            // 
            // 
            this.mtrlblSendResult.CustomButton.Image = null;
            this.mtrlblSendResult.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.mtrlblSendResult.CustomButton.Name = "";
            this.mtrlblSendResult.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtrlblSendResult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtrlblSendResult.CustomButton.TabIndex = 1;
            this.mtrlblSendResult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtrlblSendResult.CustomButton.UseSelectable = true;
            this.mtrlblSendResult.CustomButton.Visible = false;
            this.mtrlblSendResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtrlblSendResult.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtrlblSendResult.Lines = new string[] {
        "___"};
            this.mtrlblSendResult.Location = new System.Drawing.Point(50, 0);
            this.mtrlblSendResult.MaxLength = 32767;
            this.mtrlblSendResult.Name = "mtrlblSendResult";
            this.mtrlblSendResult.PasswordChar = '\0';
            this.mtrlblSendResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtrlblSendResult.SelectedText = "";
            this.mtrlblSendResult.SelectionLength = 0;
            this.mtrlblSendResult.SelectionStart = 0;
            this.mtrlblSendResult.Size = new System.Drawing.Size(218, 25);
            this.mtrlblSendResult.TabIndex = 5;
            this.mtrlblSendResult.Text = "___";
            this.mtrlblSendResult.UseSelectable = true;
            this.mtrlblSendResult.UseStyleColors = true;
            this.mtrlblSendResult.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtrlblSendResult.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mtrLAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 25);
            this.panel2.TabIndex = 7;
            // 
            // mtrLAdd
            // 
            this.mtrLAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtrLAdd.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mtrLAdd.ForeColor = System.Drawing.Color.Black;
            this.mtrLAdd.Location = new System.Drawing.Point(0, 0);
            this.mtrLAdd.Name = "mtrLAdd";
            this.mtrLAdd.Size = new System.Drawing.Size(50, 25);
            this.mtrLAdd.TabIndex = 1;
            this.mtrLAdd.Text = "Add";
            this.mtrLAdd.UseSelectable = true;
            this.mtrLAdd.UseStyleColors = true;
            this.mtrLAdd.Click += new System.EventHandler(this.mtrLAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mtrlblItems);
            this.panel1.Controls.Add(this.mtrcboComPort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 22);
            this.panel1.TabIndex = 4;
            // 
            // mtrlblItems
            // 
            this.mtrlblItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtrlblItems.Location = new System.Drawing.Point(0, 0);
            this.mtrlblItems.Name = "mtrlblItems";
            this.mtrlblItems.Size = new System.Drawing.Size(147, 22);
            this.mtrlblItems.TabIndex = 5;
            this.mtrlblItems.Text = "Item/s:";
            this.mtrlblItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtrlblItems.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtrlblItems.UseSelectable = true;
            this.mtrlblItems.UseStyleColors = true;
            // 
            // mtrcboComPort
            // 
            this.mtrcboComPort.AllowDrop = true;
            this.mtrcboComPort.Dock = System.Windows.Forms.DockStyle.Right;
            this.mtrcboComPort.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.mtrcboComPort.FormattingEnabled = true;
            this.mtrcboComPort.ItemHeight = 19;
            this.mtrcboComPort.Location = new System.Drawing.Point(147, 0);
            this.mtrcboComPort.Name = "mtrcboComPort";
            this.mtrcboComPort.Size = new System.Drawing.Size(121, 25);
            this.mtrcboComPort.Sorted = true;
            this.mtrcboComPort.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtrcboComPort.TabIndex = 3;
            this.mtrcboComPort.UseSelectable = true;
            this.mtrcboComPort.UseStyleColors = true;
            this.mtrcboComPort.SelectedIndexChanged += new System.EventHandler(this.mtrcboComPort_SelectedIndexChanged);
            // 
            // plTopSpace
            // 
            this.plTopSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTopSpace.Location = new System.Drawing.Point(0, 0);
            this.plTopSpace.Name = "plTopSpace";
            this.plTopSpace.Size = new System.Drawing.Size(268, 10);
            this.plTopSpace.TabIndex = 3;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // mtrfrmSerialWriterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 498);
            this.Controls.Add(this.plTop);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mtrfrmSerialWriterMain";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Serial Writer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.plTop.ResumeLayout(false);
            this.plMid.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.plButton.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort spBarcodeScanner;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tSmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tSmiNew;
        private System.Windows.Forms.ToolStripMenuItem tSmiClear;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tSmiAbout;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSmiConfiguration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plTopSpace;
        private System.Windows.Forms.Panel plMid;
        private System.Windows.Forms.ListBox lbItemScan;
        private System.Windows.Forms.Panel plButton;
        private System.Windows.Forms.ToolStripMenuItem tSmiStyle;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private MetroFramework.Controls.MetroComboBox mtrcboComPort;
        private System.Windows.Forms.ToolStripMenuItem brownToolStripMenuItem;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLink mtrlblItems;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSmiLight;
        private System.Windows.Forms.ToolStripMenuItem tSmiDark;
        private System.Windows.Forms.ToolStripMenuItem tSmiSaveConfig;
        private System.Windows.Forms.ToolStripMenuItem tSmiScreenshot;
        private MetroFramework.Controls.MetroTextBox mtrlblSendResult;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLink mtrLSend;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLink mtrLAdd;
    }
}