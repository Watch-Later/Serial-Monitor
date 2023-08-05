﻿namespace Serial_Monitor {
    partial class MainWindow {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            ODModules.Column column1 = new ODModules.Column();
            ODModules.Column column2 = new ODModules.Column();
            ODModules.Column column3 = new ODModules.Column();
            ODModules.Column column4 = new ODModules.Column();
            ODModules.ListItem listItem1 = new ODModules.ListItem();
            ODModules.ListSubItem listSubItem1 = new ODModules.ListSubItem();
            ODModules.ListSubItem listSubItem2 = new ODModules.ListSubItem();
            ODModules.ListSubItem listSubItem3 = new ODModules.ListSubItem();
            ODModules.Tab tab1 = new ODModules.Tab();
            this.tsMain = new ODModules.ToolStrip();
            this.ddbPorts = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ddbBAUDRate = new System.Windows.Forms.ToolStripDropDownButton();
            this.ddbBits = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnBits5 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBits6 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBits7 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBits8 = new System.Windows.Forms.ToolStripMenuItem();
            this.ddbParity = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnParityNone = new System.Windows.Forms.ToolStripMenuItem();
            this.btnParityEven = new System.Windows.Forms.ToolStripMenuItem();
            this.btnParityOdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnParitySpace = new System.Windows.Forms.ToolStripMenuItem();
            this.btnParityMark = new System.Windows.Forms.ToolStripMenuItem();
            this.ddbStopBits = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnStopBitsNone = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStopBits1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStopBits15 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStopBits2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.btnDisconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ddbInputFormat = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnInFormText = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInFormStream = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInFormCCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInFormModbusRTU = new System.Windows.Forms.ToolStripMenuItem();
            this.ddbOutputFormat = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnOutFormText = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOutFormCCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOutFormModbusRTU = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRun = new System.Windows.Forms.ToolStripSplitButton();
            this.runFromStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator25 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRunCursor = new System.Windows.Forms.ToolStripButton();
            this.btnPause = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClearTerminal = new System.Windows.Forms.ToolStripButton();
            this.btnTopMost = new System.Windows.Forms.ToolStripButton();
            this.pnlRenamePanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new ODModules.Button();
            this.navigator1 = new ODModules.Navigator();
            this.lstStepProgram = new ODModules.ListControl();
            this.cmStepEditor = new ODModules.ContextMenu();
            this.addCommandToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.enableSelectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disableSelectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain = new ODModules.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewStep = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenStep = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveStep = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveAsStep = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRecentProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOptViewDataOnly = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOptViewTime = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOptViewDate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOptViewDateTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOptViewSource = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.channelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuShowStepPrg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuClearTerminal = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoom50 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoom75 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoom100 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoom110 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoom120 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuTopMost = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuFullScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemoveChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.ddbChannels = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRenameChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuModbusMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator28 = new System.Windows.Forms.ToolStripSeparator();
            this.btnChannelPort = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChannelBaud = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChannelDataBits = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChanDB5 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChanDB6 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChanDB7 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChanDB = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChannelParity = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChannelNoParity = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChannelEvenParity = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChannelOddParity = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChannelSpaceParity = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChannelMarkParity = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChannelStopBits = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChannelStopBits0 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChannelStopBits1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChannelStopBits15 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChannelStopBits2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrgNewStepLine = new System.Windows.Forms.ToolStripMenuItem();
            this.addCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrgRemoveStepLines = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrgMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrgMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEnableSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToggleSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDisableSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.setStepCursorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.activeProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator26 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRunPrg = new System.Windows.Forms.ToolStripMenuItem();
            this.runProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPausePrg = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStopPrg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator27 = new System.Windows.Forms.ToolStripSeparator();
            this.newProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyPadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.modbusRegistersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmStepPrg = new ODModules.ContextMenu();
            this.tmrProg = new System.Windows.Forms.Timer(this.components);
            this.pnlStepProgram = new ODModules.LabelPanel();
            this.tabHeader1 = new ODModules.TabHeader();
            this.pnlMainConsole = new System.Windows.Forms.Panel();
            this.Output = new ODModules.ConsoleInterface();
            this.smMain = new ODModules.StatusMenu();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTxBytes = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRxBytes = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMain.SuspendLayout();
            this.pnlRenamePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cmStepEditor.SuspendLayout();
            this.msMain.SuspendLayout();
            this.pnlStepProgram.SuspendLayout();
            this.pnlMainConsole.SuspendLayout();
            this.smMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.BackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tsMain.BackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMain.ItemCheckedBackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tsMain.ItemCheckedBackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tsMain.ItemForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddbPorts,
            this.toolStripSeparator1,
            this.ddbBAUDRate,
            this.ddbBits,
            this.ddbParity,
            this.ddbStopBits,
            this.toolStripSeparator2,
            this.btnConnect,
            this.btnDisconnect,
            this.toolStripSeparator3,
            this.ddbInputFormat,
            this.ddbOutputFormat,
            this.toolStripSeparator4,
            this.btnRun,
            this.btnRunCursor,
            this.btnPause,
            this.btnStop,
            this.toolStripSeparator5,
            this.btnClearTerminal,
            this.btnTopMost});
            this.tsMain.ItemSelectedBackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsMain.ItemSelectedBackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsMain.ItemSelectedForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsMain.Location = new System.Drawing.Point(0, 42);
            this.tsMain.MenuBackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tsMain.MenuBackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tsMain.MenuBorderColor = System.Drawing.Color.DimGray;
            this.tsMain.MenuSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.tsMain.MenuSymbolColor = System.Drawing.Color.LightGray;
            this.tsMain.Name = "tsMain";
            this.tsMain.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.tsMain.Size = new System.Drawing.Size(1293, 42);
            this.tsMain.StripItemSelectedBackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsMain.StripItemSelectedBackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "Main Tools";
            // 
            // ddbPorts
            // 
            this.ddbPorts.ForeColor = System.Drawing.Color.White;
            this.ddbPorts.Image = ((System.Drawing.Image)(resources.GetObject("ddbPorts.Image")));
            this.ddbPorts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ddbPorts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbPorts.Name = "ddbPorts";
            this.ddbPorts.Size = new System.Drawing.Size(216, 36);
            this.ddbPorts.Text = "No ports found";
            this.ddbPorts.ToolTipText = "Port";
            this.ddbPorts.DropDownOpening += new System.EventHandler(this.ddbPorts_DropDownOpening);
            this.ddbPorts.Click += new System.EventHandler(this.ddbPorts_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // ddbBAUDRate
            // 
            this.ddbBAUDRate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbBAUDRate.ForeColor = System.Drawing.Color.White;
            this.ddbBAUDRate.Image = ((System.Drawing.Image)(resources.GetObject("ddbBAUDRate.Image")));
            this.ddbBAUDRate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ddbBAUDRate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbBAUDRate.Name = "ddbBAUDRate";
            this.ddbBAUDRate.Size = new System.Drawing.Size(88, 36);
            this.ddbBAUDRate.Text = "9600";
            this.ddbBAUDRate.ToolTipText = "Baud Rate";
            // 
            // ddbBits
            // 
            this.ddbBits.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbBits.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBits5,
            this.btnBits6,
            this.btnBits7,
            this.btnBits8});
            this.ddbBits.ForeColor = System.Drawing.Color.White;
            this.ddbBits.Image = ((System.Drawing.Image)(resources.GetObject("ddbBits.Image")));
            this.ddbBits.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ddbBits.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbBits.Name = "ddbBits";
            this.ddbBits.Size = new System.Drawing.Size(49, 36);
            this.ddbBits.Text = "8";
            this.ddbBits.ToolTipText = "Bits";
            // 
            // btnBits5
            // 
            this.btnBits5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBits5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBits5.Name = "btnBits5";
            this.btnBits5.Size = new System.Drawing.Size(205, 44);
            this.btnBits5.Tag = "5";
            this.btnBits5.Text = "5 bits";
            this.btnBits5.Click += new System.EventHandler(this.btnBits5_Click);
            // 
            // btnBits6
            // 
            this.btnBits6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBits6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBits6.Name = "btnBits6";
            this.btnBits6.Size = new System.Drawing.Size(205, 44);
            this.btnBits6.Tag = "6";
            this.btnBits6.Text = "6 bits";
            this.btnBits6.Click += new System.EventHandler(this.btnBits6_Click);
            // 
            // btnBits7
            // 
            this.btnBits7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBits7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBits7.Name = "btnBits7";
            this.btnBits7.Size = new System.Drawing.Size(205, 44);
            this.btnBits7.Tag = "7";
            this.btnBits7.Text = "7 bits";
            this.btnBits7.Click += new System.EventHandler(this.btnBits7_Click);
            // 
            // btnBits8
            // 
            this.btnBits8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBits8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBits8.Name = "btnBits8";
            this.btnBits8.Size = new System.Drawing.Size(205, 44);
            this.btnBits8.Tag = "8";
            this.btnBits8.Text = "8 bits";
            this.btnBits8.Click += new System.EventHandler(this.btnBits8_Click);
            // 
            // ddbParity
            // 
            this.ddbParity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbParity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnParityNone,
            this.btnParityEven,
            this.btnParityOdd,
            this.btnParitySpace,
            this.btnParityMark});
            this.ddbParity.ForeColor = System.Drawing.Color.White;
            this.ddbParity.Image = ((System.Drawing.Image)(resources.GetObject("ddbParity.Image")));
            this.ddbParity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ddbParity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbParity.Name = "ddbParity";
            this.ddbParity.Size = new System.Drawing.Size(54, 36);
            this.ddbParity.Text = "N";
            this.ddbParity.ToolTipText = "Parity";
            // 
            // btnParityNone
            // 
            this.btnParityNone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnParityNone.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnParityNone.Name = "btnParityNone";
            this.btnParityNone.Size = new System.Drawing.Size(275, 44);
            this.btnParityNone.Tag = "N";
            this.btnParityNone.Text = "No Parity";
            this.btnParityNone.Click += new System.EventHandler(this.btnParityNone_Click);
            // 
            // btnParityEven
            // 
            this.btnParityEven.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnParityEven.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnParityEven.Name = "btnParityEven";
            this.btnParityEven.Size = new System.Drawing.Size(275, 44);
            this.btnParityEven.Tag = "E";
            this.btnParityEven.Text = "Even Parity";
            this.btnParityEven.Click += new System.EventHandler(this.btnParityEven_Click);
            // 
            // btnParityOdd
            // 
            this.btnParityOdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnParityOdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnParityOdd.Name = "btnParityOdd";
            this.btnParityOdd.Size = new System.Drawing.Size(275, 44);
            this.btnParityOdd.Tag = "O";
            this.btnParityOdd.Text = "Odd Parity";
            this.btnParityOdd.Click += new System.EventHandler(this.btnParityOdd_Click);
            // 
            // btnParitySpace
            // 
            this.btnParitySpace.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnParitySpace.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnParitySpace.Name = "btnParitySpace";
            this.btnParitySpace.Size = new System.Drawing.Size(275, 44);
            this.btnParitySpace.Tag = "S";
            this.btnParitySpace.Text = "Space Parity";
            this.btnParitySpace.Click += new System.EventHandler(this.btnParitySpace_Click);
            // 
            // btnParityMark
            // 
            this.btnParityMark.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnParityMark.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnParityMark.Name = "btnParityMark";
            this.btnParityMark.Size = new System.Drawing.Size(275, 44);
            this.btnParityMark.Tag = "M";
            this.btnParityMark.Text = "Mark Parity";
            this.btnParityMark.Click += new System.EventHandler(this.btnParityMark_Click);
            // 
            // ddbStopBits
            // 
            this.ddbStopBits.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbStopBits.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStopBitsNone,
            this.btnStopBits1,
            this.btnStopBits15,
            this.btnStopBits2});
            this.ddbStopBits.ForeColor = System.Drawing.Color.White;
            this.ddbStopBits.Image = ((System.Drawing.Image)(resources.GetObject("ddbStopBits.Image")));
            this.ddbStopBits.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ddbStopBits.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbStopBits.Name = "ddbStopBits";
            this.ddbStopBits.Size = new System.Drawing.Size(49, 36);
            this.ddbStopBits.Text = "1";
            this.ddbStopBits.ToolTipText = "Stop Bits";
            // 
            // btnStopBitsNone
            // 
            this.btnStopBitsNone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStopBitsNone.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStopBitsNone.Name = "btnStopBitsNone";
            this.btnStopBitsNone.Size = new System.Drawing.Size(278, 44);
            this.btnStopBitsNone.Tag = "0";
            this.btnStopBitsNone.Text = "0 Stop Bits";
            this.btnStopBitsNone.Visible = false;
            this.btnStopBitsNone.Click += new System.EventHandler(this.btnStopBitsNone_Click);
            // 
            // btnStopBits1
            // 
            this.btnStopBits1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStopBits1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStopBits1.Name = "btnStopBits1";
            this.btnStopBits1.Size = new System.Drawing.Size(278, 44);
            this.btnStopBits1.Tag = "1";
            this.btnStopBits1.Text = "1 Stop Bit";
            this.btnStopBits1.Click += new System.EventHandler(this.btnStopBits1_Click);
            // 
            // btnStopBits15
            // 
            this.btnStopBits15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStopBits15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStopBits15.Name = "btnStopBits15";
            this.btnStopBits15.Size = new System.Drawing.Size(278, 44);
            this.btnStopBits15.Tag = "1.5";
            this.btnStopBits15.Text = "1.5 Stop Bits";
            this.btnStopBits15.Click += new System.EventHandler(this.btnStopBits15_Click);
            // 
            // btnStopBits2
            // 
            this.btnStopBits2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStopBits2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStopBits2.Name = "btnStopBits2";
            this.btnStopBits2.Size = new System.Drawing.Size(278, 44);
            this.btnStopBits2.Tag = "2";
            this.btnStopBits2.Text = "2 Stop Bits";
            this.btnStopBits2.Click += new System.EventHandler(this.btnStopBits2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // btnConnect
            // 
            this.btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(46, 36);
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("btnDisconnect.Image")));
            this.btnDisconnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(46, 36);
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // ddbInputFormat
            // 
            this.ddbInputFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInFormText,
            this.btnInFormStream,
            this.btnInFormCCommand,
            this.btnInFormModbusRTU});
            this.ddbInputFormat.ForeColor = System.Drawing.Color.White;
            this.ddbInputFormat.Image = ((System.Drawing.Image)(resources.GetObject("ddbInputFormat.Image")));
            this.ddbInputFormat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ddbInputFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbInputFormat.Name = "ddbInputFormat";
            this.ddbInputFormat.Size = new System.Drawing.Size(95, 36);
            this.ddbInputFormat.Text = "Text";
            this.ddbInputFormat.ToolTipText = "Input Format";
            // 
            // btnInFormText
            // 
            this.btnInFormText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInFormText.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInFormText.Name = "btnInFormText";
            this.btnInFormText.Size = new System.Drawing.Size(294, 44);
            this.btnInFormText.Tag = "frmTxt";
            this.btnInFormText.Text = "Text";
            this.btnInFormText.Click += new System.EventHandler(this.btnInFormText_Click);
            // 
            // btnInFormStream
            // 
            this.btnInFormStream.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInFormStream.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInFormStream.Name = "btnInFormStream";
            this.btnInFormStream.Size = new System.Drawing.Size(294, 44);
            this.btnInFormStream.Tag = "frmStream";
            this.btnInFormStream.Text = "Binary Stream";
            this.btnInFormStream.Click += new System.EventHandler(this.btnInFormStream_Click);
            // 
            // btnInFormCCommand
            // 
            this.btnInFormCCommand.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInFormCCommand.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInFormCCommand.Name = "btnInFormCCommand";
            this.btnInFormCCommand.Size = new System.Drawing.Size(294, 44);
            this.btnInFormCCommand.Tag = "frmCCommand";
            this.btnInFormCCommand.Text = "C Command";
            this.btnInFormCCommand.Click += new System.EventHandler(this.btnInFormCCommand_Click);
            // 
            // btnInFormModbusRTU
            // 
            this.btnInFormModbusRTU.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInFormModbusRTU.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInFormModbusRTU.Name = "btnInFormModbusRTU";
            this.btnInFormModbusRTU.Size = new System.Drawing.Size(294, 44);
            this.btnInFormModbusRTU.Tag = "frmModbusRTU";
            this.btnInFormModbusRTU.Text = "Modbus RTU";
            this.btnInFormModbusRTU.Click += new System.EventHandler(this.btnInFormModbusRTU_Click);
            // 
            // ddbOutputFormat
            // 
            this.ddbOutputFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOutFormText,
            this.btnOutFormCCommand,
            this.btnOutFormModbusRTU});
            this.ddbOutputFormat.ForeColor = System.Drawing.Color.White;
            this.ddbOutputFormat.Image = ((System.Drawing.Image)(resources.GetObject("ddbOutputFormat.Image")));
            this.ddbOutputFormat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ddbOutputFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbOutputFormat.Name = "ddbOutputFormat";
            this.ddbOutputFormat.Size = new System.Drawing.Size(95, 36);
            this.ddbOutputFormat.Tag = "frmTxt";
            this.ddbOutputFormat.Text = "Text";
            this.ddbOutputFormat.ToolTipText = "Output Format";
            // 
            // btnOutFormText
            // 
            this.btnOutFormText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOutFormText.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOutFormText.Name = "btnOutFormText";
            this.btnOutFormText.Size = new System.Drawing.Size(284, 44);
            this.btnOutFormText.Tag = "frmTxt";
            this.btnOutFormText.Text = "Text";
            this.btnOutFormText.Click += new System.EventHandler(this.btnOutFormText_Click);
            // 
            // btnOutFormCCommand
            // 
            this.btnOutFormCCommand.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOutFormCCommand.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOutFormCCommand.Name = "btnOutFormCCommand";
            this.btnOutFormCCommand.Size = new System.Drawing.Size(284, 44);
            this.btnOutFormCCommand.Tag = "frmCCommand";
            this.btnOutFormCCommand.Text = "C Command";
            this.btnOutFormCCommand.Click += new System.EventHandler(this.btnOutFormCCommand_Click);
            // 
            // btnOutFormModbusRTU
            // 
            this.btnOutFormModbusRTU.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOutFormModbusRTU.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOutFormModbusRTU.Name = "btnOutFormModbusRTU";
            this.btnOutFormModbusRTU.Size = new System.Drawing.Size(284, 44);
            this.btnOutFormModbusRTU.Tag = "frmModbusRTU";
            this.btnOutFormModbusRTU.Text = "Modbus RTU";
            this.btnOutFormModbusRTU.Click += new System.EventHandler(this.btnOutFormModbusRTU_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 42);
            // 
            // btnRun
            // 
            this.btnRun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runFromStartToolStripMenuItem,
            this.toolStripSeparator25});
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(111, 36);
            this.btnRun.Text = "Main";
            this.btnRun.ButtonClick += new System.EventHandler(this.btnRun_ButtonClick);
            this.btnRun.DropDownOpening += new System.EventHandler(this.btnRun_DropDownOpening);
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // runFromStartToolStripMenuItem
            // 
            this.runFromStartToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.runFromStartToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.runFromStartToolStripMenuItem.Name = "runFromStartToolStripMenuItem";
            this.runFromStartToolStripMenuItem.Size = new System.Drawing.Size(302, 44);
            this.runFromStartToolStripMenuItem.Text = "Run from Start";
            this.runFromStartToolStripMenuItem.Click += new System.EventHandler(this.runFromStartToolStripMenuItem_Click);
            // 
            // toolStripSeparator25
            // 
            this.toolStripSeparator25.Name = "toolStripSeparator25";
            this.toolStripSeparator25.Size = new System.Drawing.Size(299, 6);
            // 
            // btnRunCursor
            // 
            this.btnRunCursor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRunCursor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRunCursor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRunCursor.Name = "btnRunCursor";
            this.btnRunCursor.Size = new System.Drawing.Size(46, 36);
            this.btnRunCursor.Text = "Run";
            this.btnRunCursor.Click += new System.EventHandler(this.btnRunCursor_Click);
            // 
            // btnPause
            // 
            this.btnPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPause.Enabled = false;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(46, 36);
            this.btnPause.Text = "Pause";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Enabled = false;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(46, 36);
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 42);
            // 
            // btnClearTerminal
            // 
            this.btnClearTerminal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClearTerminal.Image = ((System.Drawing.Image)(resources.GetObject("btnClearTerminal.Image")));
            this.btnClearTerminal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClearTerminal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearTerminal.Name = "btnClearTerminal";
            this.btnClearTerminal.Size = new System.Drawing.Size(46, 36);
            this.btnClearTerminal.Text = "Clear Terminal";
            this.btnClearTerminal.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnTopMost
            // 
            this.btnTopMost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTopMost.Image = ((System.Drawing.Image)(resources.GetObject("btnTopMost.Image")));
            this.btnTopMost.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTopMost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTopMost.Name = "btnTopMost";
            this.btnTopMost.Size = new System.Drawing.Size(46, 36);
            this.btnTopMost.Text = "Window Top Most";
            this.btnTopMost.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // pnlRenamePanel
            // 
            this.pnlRenamePanel.AutoSize = true;
            this.pnlRenamePanel.Controls.Add(this.textBox1);
            this.pnlRenamePanel.Controls.Add(this.panel2);
            this.pnlRenamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRenamePanel.Location = new System.Drawing.Point(0, 0);
            this.pnlRenamePanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlRenamePanel.Name = "pnlRenamePanel";
            this.pnlRenamePanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.pnlRenamePanel.Size = new System.Drawing.Size(1293, 38);
            this.pnlRenamePanel.TabIndex = 3;
            this.pnlRenamePanel.Visible = false;
            this.pnlRenamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRenamePanel_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1117, 36);
            this.textBox1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1117, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 36);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AllowGroupUnchecking = false;
            this.button1.BackColorCheckedNorth = System.Drawing.Color.Orange;
            this.button1.BackColorCheckedSouth = System.Drawing.Color.Orange;
            this.button1.BackColorDownNorth = System.Drawing.Color.DimGray;
            this.button1.BackColorDownSouth = System.Drawing.Color.DimGray;
            this.button1.BackColorHoverNorth = System.Drawing.Color.SkyBlue;
            this.button1.BackColorHoverSouth = System.Drawing.Color.SkyBlue;
            this.button1.BackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button1.BackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.BorderColorCheckedNorth = System.Drawing.Color.Black;
            this.button1.BorderColorCheckedSouth = System.Drawing.Color.Black;
            this.button1.BorderColorDownNorth = System.Drawing.Color.Black;
            this.button1.BorderColorDownSouth = System.Drawing.Color.Black;
            this.button1.BorderColorHoverNorth = System.Drawing.Color.Black;
            this.button1.BorderColorHoverSouth = System.Drawing.Color.Black;
            this.button1.BorderColorNorth = System.Drawing.Color.Black;
            this.button1.BorderColorShadow = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.BorderColorSouth = System.Drawing.Color.Black;
            this.button1.BorderRadius = 5;
            this.button1.Checked = false;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.GroupMaximumChecked = 2;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.RadioButtonGroup = "";
            this.button1.SecondaryFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.SecondaryText = "";
            this.button1.Size = new System.Drawing.Size(176, 36);
            this.button1.Style = ODModules.ButtonStyle.Square;
            this.button1.TabIndex = 0;
            this.button1.Text = "Rename";
            this.button1.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            this.button1.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            this.button1.Type = ODModules.ButtonType.Button;
            this.button1.ButtonClicked += new ODModules.Button.ButtonClickedHandler(this.button1_ButtonClicked);
            // 
            // navigator1
            // 
            this.navigator1.ArrowColor = System.Drawing.Color.Black;
            this.navigator1.ArrowMouseOverColor = System.Drawing.Color.DodgerBlue;
            this.navigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.navigator1.DisplayStyle = ODModules.Navigator.Style.Right;
            this.navigator1.DisplayText = "StateName";
            this.navigator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigator1.ForeColor = System.Drawing.Color.White;
            this.navigator1.LinkedList = null;
            this.navigator1.Location = new System.Drawing.Point(0, 38);
            this.navigator1.Margin = new System.Windows.Forms.Padding(6);
            this.navigator1.MidColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.navigator1.Name = "navigator1";
            this.navigator1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.navigator1.SelectedItem = -1;
            this.navigator1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.navigator1.ShowAnimations = true;
            this.navigator1.Size = new System.Drawing.Size(150, 316);
            this.navigator1.TabIndex = 1;
            this.navigator1.SelectedIndexChanged += new ODModules.Navigator.SelectedIndexChangedHandler(this.navigator1_SelectedIndexChanged);
            this.navigator1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.navigator1_MouseClick);
            // 
            // lstStepProgram
            // 
            this.lstStepProgram.AllowColumnSpanning = true;
            this.lstStepProgram.AllowMouseWheel = true;
            this.lstStepProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.lstStepProgram.ColumnColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lstStepProgram.ColumnForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstStepProgram.ColumnLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            column1.ColumnAlignment = ODModules.ColumnTextAlignment.Center;
            column1.DisplayType = ODModules.ColumnDisplayType.LineCount;
            column1.DropDownRight = false;
            column1.DropDownVisible = true;
            column1.FixedWidth = false;
            column1.ItemAlignment = ODModules.ItemTextAlignment.Center;
            column1.Text = "Step";
            column1.UseItemBackColor = false;
            column1.UseItemForeColor = false;
            column1.Visible = true;
            column1.Width = 50;
            column2.ColumnAlignment = ODModules.ColumnTextAlignment.Left;
            column2.DisplayType = ODModules.ColumnDisplayType.Checkbox;
            column2.DropDownRight = false;
            column2.DropDownVisible = true;
            column2.FixedWidth = true;
            column2.ItemAlignment = ODModules.ItemTextAlignment.Left;
            column2.Text = "";
            column2.UseItemBackColor = false;
            column2.UseItemForeColor = false;
            column2.Visible = true;
            column2.Width = 40;
            column3.ColumnAlignment = ODModules.ColumnTextAlignment.Left;
            column3.DisplayType = ODModules.ColumnDisplayType.DropDown;
            column3.DropDownRight = false;
            column3.DropDownVisible = true;
            column3.FixedWidth = false;
            column3.ItemAlignment = ODModules.ItemTextAlignment.Left;
            column3.Text = "Command";
            column3.UseItemBackColor = false;
            column3.UseItemForeColor = false;
            column3.Visible = true;
            column3.Width = 100;
            column4.ColumnAlignment = ODModules.ColumnTextAlignment.Left;
            column4.DisplayType = ODModules.ColumnDisplayType.DropDown;
            column4.DropDownRight = false;
            column4.DropDownVisible = true;
            column4.FixedWidth = false;
            column4.ItemAlignment = ODModules.ItemTextAlignment.Left;
            column4.Text = "Arguments";
            column4.UseItemBackColor = false;
            column4.UseItemForeColor = false;
            column4.Visible = true;
            column4.Width = 1103;
            this.lstStepProgram.Columns.Add(column1);
            this.lstStepProgram.Columns.Add(column2);
            this.lstStepProgram.Columns.Add(column3);
            this.lstStepProgram.Columns.Add(column4);
            this.lstStepProgram.ContextMenuStrip = this.cmStepEditor;
            this.lstStepProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStepProgram.DropDownMouseDown = System.Drawing.Color.DimGray;
            this.lstStepProgram.DropDownMouseOver = System.Drawing.Color.LightGray;
            this.lstStepProgram.ExternalItems = null;
            this.lstStepProgram.Filter = null;
            this.lstStepProgram.FilterColumn = 0;
            this.lstStepProgram.ForeColor = System.Drawing.Color.White;
            this.lstStepProgram.GridlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lstStepProgram.HighlightStrength = 128;
            this.lstStepProgram.HorScroll = new decimal(new int[] {
            0,
            0,
            0,
            0});
            listItem1.BackColor = System.Drawing.Color.Transparent;
            listItem1.Checked = false;
            listItem1.ForeColor = System.Drawing.Color.Black;
            listItem1.Name = "";
            listItem1.Selected = false;
            listSubItem1.BackColor = System.Drawing.Color.Transparent;
            listSubItem1.Checked = true;
            listSubItem1.ForeColor = System.Drawing.Color.Black;
            listSubItem1.Name = "";
            listSubItem1.Tag = null;
            listSubItem1.Text = "";
            listSubItem2.BackColor = System.Drawing.Color.Transparent;
            listSubItem2.Checked = false;
            listSubItem2.ForeColor = System.Drawing.Color.Black;
            listSubItem2.Name = "";
            listSubItem2.Tag = null;
            listSubItem2.Text = "No Operation";
            listSubItem3.BackColor = System.Drawing.Color.Transparent;
            listSubItem3.Checked = false;
            listSubItem3.ForeColor = System.Drawing.Color.Black;
            listSubItem3.Name = "";
            listSubItem3.Tag = null;
            listSubItem3.Text = "";
            listItem1.SubItems.Add(listSubItem1);
            listItem1.SubItems.Add(listSubItem2);
            listItem1.SubItems.Add(listSubItem3);
            listItem1.Tag = null;
            listItem1.Text = "";
            this.lstStepProgram.Items.Add(listItem1);
            this.lstStepProgram.LineMarkerIndex = 0;
            this.lstStepProgram.Location = new System.Drawing.Point(0, 95);
            this.lstStepProgram.Margin = new System.Windows.Forms.Padding(6);
            this.lstStepProgram.MarkerBorderColor = System.Drawing.Color.LimeGreen;
            this.lstStepProgram.MarkerFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.lstStepProgram.MarkerStyle = ODModules.MarkerStyleType.PointerWithBox;
            this.lstStepProgram.Name = "lstStepProgram";
            this.lstStepProgram.RowColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.lstStepProgram.ScrollBarMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lstStepProgram.ScrollBarNorth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstStepProgram.ScrollBarSouth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstStepProgram.ScrollItems = 3;
            this.lstStepProgram.SelectedColor = System.Drawing.Color.SteelBlue;
            this.lstStepProgram.SelectionColor = System.Drawing.Color.Gray;
            this.lstStepProgram.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lstStepProgram.ShowGrid = true;
            this.lstStepProgram.ShowMarker = true;
            this.lstStepProgram.ShowRowColors = true;
            this.lstStepProgram.Size = new System.Drawing.Size(1293, 242);
            this.lstStepProgram.SpanColumn = 3;
            this.lstStepProgram.TabIndex = 0;
            this.lstStepProgram.UseLocalList = false;
            this.lstStepProgram.VerScroll = 0;
            this.lstStepProgram.DropDownClicked += new ODModules.ListControl.DropDownClickedHandler(this.lstStepProgram_DropDownClicked);
            this.lstStepProgram.Load += new System.EventHandler(this.lstStepProgram_Load);
            this.lstStepProgram.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstStepProgram_KeyDown);
            this.lstStepProgram.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstStepProgram_MouseClick);
            // 
            // cmStepEditor
            // 
            this.cmStepEditor.ActionSymbolForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cmStepEditor.BorderColor = System.Drawing.Color.Black;
            this.cmStepEditor.ForeColor = System.Drawing.Color.White;
            this.cmStepEditor.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmStepEditor.InsetShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmStepEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCommandToolStripMenuItem1,
            this.removeSelectedToolStripMenuItem,
            this.toolStripSeparator20,
            this.enableSelectedToolStripMenuItem1,
            this.disableSelectedToolStripMenuItem1,
            this.toolStripSeparator21,
            this.runToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.cmStepEditor.MenuBackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cmStepEditor.MenuBackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cmStepEditor.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmStepEditor.Name = "cmStepEditor";
            this.cmStepEditor.ShowInsetShadow = true;
            this.cmStepEditor.ShowItemInsetShadow = true;
            this.cmStepEditor.Size = new System.Drawing.Size(273, 282);
            // 
            // addCommandToolStripMenuItem1
            // 
            this.addCommandToolStripMenuItem1.Name = "addCommandToolStripMenuItem1";
            this.addCommandToolStripMenuItem1.Size = new System.Drawing.Size(272, 38);
            this.addCommandToolStripMenuItem1.Text = "Add Command";
            this.addCommandToolStripMenuItem1.Click += new System.EventHandler(this.addCommandToolStripMenuItem1_Click);
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.removeSelectedToolStripMenuItem.Text = "Remove Selected";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedToolStripMenuItem_Click);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(269, 6);
            // 
            // enableSelectedToolStripMenuItem1
            // 
            this.enableSelectedToolStripMenuItem1.Name = "enableSelectedToolStripMenuItem1";
            this.enableSelectedToolStripMenuItem1.Size = new System.Drawing.Size(272, 38);
            this.enableSelectedToolStripMenuItem1.Text = "Enable Selected";
            this.enableSelectedToolStripMenuItem1.Click += new System.EventHandler(this.enableSelectedToolStripMenuItem1_Click);
            // 
            // disableSelectedToolStripMenuItem1
            // 
            this.disableSelectedToolStripMenuItem1.Name = "disableSelectedToolStripMenuItem1";
            this.disableSelectedToolStripMenuItem1.Size = new System.Drawing.Size(272, 38);
            this.disableSelectedToolStripMenuItem1.Text = "Disable Selected";
            this.disableSelectedToolStripMenuItem1.Click += new System.EventHandler(this.disableSelectedToolStripMenuItem1_Click);
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(269, 6);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Enabled = false;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(272, 38);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.msMain.BackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.msMain.BackColorNorthFadeIn = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.msMain.BackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.msMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.msMain.ItemForeColor = System.Drawing.Color.White;
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.terminalToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.btnPrgNewStepLine,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMain.ItemSelectedBackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.msMain.ItemSelectedBackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.msMain.ItemSelectedForeColor = System.Drawing.Color.White;
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.MenuBackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.msMain.MenuBackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.msMain.MenuBorderColor = System.Drawing.Color.DimGray;
            this.msMain.MenuSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.msMain.MenuSymbolColor = System.Drawing.Color.White;
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1293, 42);
            this.msMain.StripItemSelectedBackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.msMain.StripItemSelectedBackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.msMain.TabIndex = 2;
            this.msMain.Text = "Main Menu";
            this.msMain.UseNorthFadeIn = true;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewStep,
            this.btnOpenStep,
            this.toolStripSeparator,
            this.btnSaveStep,
            this.btnSaveAsStep,
            this.toolStripSeparator6,
            this.btnPrint,
            this.btnPrintPreview,
            this.toolStripSeparator7,
            this.btnRecentProjects,
            this.toolStripSeparator8,
            this.btnMenuExit});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 38);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // btnNewStep
            // 
            this.btnNewStep.ForeColor = System.Drawing.Color.White;
            this.btnNewStep.Image = ((System.Drawing.Image)(resources.GetObject("btnNewStep.Image")));
            this.btnNewStep.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewStep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewStep.Name = "btnNewStep";
            this.btnNewStep.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnNewStep.Size = new System.Drawing.Size(309, 44);
            this.btnNewStep.Text = "&New";
            this.btnNewStep.Click += new System.EventHandler(this.btnNewStep_Click);
            // 
            // btnOpenStep
            // 
            this.btnOpenStep.ForeColor = System.Drawing.Color.White;
            this.btnOpenStep.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenStep.Image")));
            this.btnOpenStep.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOpenStep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenStep.Name = "btnOpenStep";
            this.btnOpenStep.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnOpenStep.Size = new System.Drawing.Size(309, 44);
            this.btnOpenStep.Text = "&Open";
            this.btnOpenStep.Click += new System.EventHandler(this.btnOpenStep_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(306, 6);
            // 
            // btnSaveStep
            // 
            this.btnSaveStep.ForeColor = System.Drawing.Color.White;
            this.btnSaveStep.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveStep.Image")));
            this.btnSaveStep.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSaveStep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveStep.Name = "btnSaveStep";
            this.btnSaveStep.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSaveStep.Size = new System.Drawing.Size(309, 44);
            this.btnSaveStep.Text = "&Save";
            this.btnSaveStep.Click += new System.EventHandler(this.btnSaveStep_Click);
            // 
            // btnSaveAsStep
            // 
            this.btnSaveAsStep.ForeColor = System.Drawing.Color.White;
            this.btnSaveAsStep.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSaveAsStep.Name = "btnSaveAsStep";
            this.btnSaveAsStep.Size = new System.Drawing.Size(309, 44);
            this.btnSaveAsStep.Text = "Save &As";
            this.btnSaveAsStep.Click += new System.EventHandler(this.btnSaveAsStep_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(306, 6);
            this.toolStripSeparator6.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.btnPrint.Size = new System.Drawing.Size(309, 44);
            this.btnPrint.Text = "&Print";
            this.btnPrint.Visible = false;
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.ForeColor = System.Drawing.Color.White;
            this.btnPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPreview.Image")));
            this.btnPrintPreview.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(309, 44);
            this.btnPrintPreview.Text = "Print Pre&view";
            this.btnPrintPreview.Visible = false;
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(306, 6);
            // 
            // btnRecentProjects
            // 
            this.btnRecentProjects.ForeColor = System.Drawing.Color.White;
            this.btnRecentProjects.Name = "btnRecentProjects";
            this.btnRecentProjects.Size = new System.Drawing.Size(309, 44);
            this.btnRecentProjects.Text = "Recent Projects";
            this.btnRecentProjects.DropDownOpening += new System.EventHandler(this.btnRecentProjects_DropDownOpening);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(306, 6);
            // 
            // btnMenuExit
            // 
            this.btnMenuExit.ForeColor = System.Drawing.Color.White;
            this.btnMenuExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMenuExit.Name = "btnMenuExit";
            this.btnMenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.btnMenuExit.Size = new System.Drawing.Size(309, 44);
            this.btnMenuExit.Text = "E&xit";
            this.btnMenuExit.Click += new System.EventHandler(this.btnMenuExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator15,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator9,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.undoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(327, 44);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.redoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(327, 44);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(324, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(327, 44);
            this.cutToolStripMenuItem.Text = "Cu&t";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(327, 44);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(327, 44);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(327, 44);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(324, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.selectAllToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(327, 44);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // terminalToolStripMenuItem
            // 
            this.terminalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOptViewDataOnly,
            this.btnOptViewTime,
            this.btnOptViewDate,
            this.btnOptViewDateTime,
            this.toolStripSeparator16,
            this.btnOptViewSource,
            this.toolStripSeparator13,
            this.channelsToolStripMenuItem,
            this.btnMenuShowStepPrg,
            this.toolStripSeparator11,
            this.btnMenuClearTerminal,
            this.zoomToolStripMenuItem,
            this.toolStripSeparator12,
            this.btnMenuTopMost,
            this.btnMenuFullScreen});
            this.terminalToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.terminalToolStripMenuItem.Name = "terminalToolStripMenuItem";
            this.terminalToolStripMenuItem.Size = new System.Drawing.Size(85, 38);
            this.terminalToolStripMenuItem.Text = "&View";
            // 
            // btnOptViewDataOnly
            // 
            this.btnOptViewDataOnly.Checked = true;
            this.btnOptViewDataOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnOptViewDataOnly.ForeColor = System.Drawing.Color.White;
            this.btnOptViewDataOnly.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOptViewDataOnly.Name = "btnOptViewDataOnly";
            this.btnOptViewDataOnly.Size = new System.Drawing.Size(343, 44);
            this.btnOptViewDataOnly.Text = "Data &Only";
            this.btnOptViewDataOnly.Click += new System.EventHandler(this.btnOptViewDataOnly_Click);
            // 
            // btnOptViewTime
            // 
            this.btnOptViewTime.ForeColor = System.Drawing.Color.White;
            this.btnOptViewTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOptViewTime.Name = "btnOptViewTime";
            this.btnOptViewTime.Size = new System.Drawing.Size(343, 44);
            this.btnOptViewTime.Text = "&Time Stamps";
            this.btnOptViewTime.Click += new System.EventHandler(this.btnOptViewTime_Click);
            // 
            // btnOptViewDate
            // 
            this.btnOptViewDate.ForeColor = System.Drawing.Color.White;
            this.btnOptViewDate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOptViewDate.Name = "btnOptViewDate";
            this.btnOptViewDate.Size = new System.Drawing.Size(343, 44);
            this.btnOptViewDate.Text = "&Date Stamps";
            this.btnOptViewDate.Click += new System.EventHandler(this.btnOptViewData_Click);
            // 
            // btnOptViewDateTime
            // 
            this.btnOptViewDateTime.ForeColor = System.Drawing.Color.White;
            this.btnOptViewDateTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOptViewDateTime.Name = "btnOptViewDateTime";
            this.btnOptViewDateTime.ShortcutKeyDisplayString = "";
            this.btnOptViewDateTime.Size = new System.Drawing.Size(343, 44);
            this.btnOptViewDateTime.Text = "Date/Time &Stamps";
            this.btnOptViewDateTime.Click += new System.EventHandler(this.btnOptViewDateTime_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(340, 6);
            // 
            // btnOptViewSource
            // 
            this.btnOptViewSource.Checked = true;
            this.btnOptViewSource.CheckOnClick = true;
            this.btnOptViewSource.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnOptViewSource.ForeColor = System.Drawing.Color.White;
            this.btnOptViewSource.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOptViewSource.Name = "btnOptViewSource";
            this.btnOptViewSource.Size = new System.Drawing.Size(343, 44);
            this.btnOptViewSource.Text = "Show Source";
            this.btnOptViewSource.Click += new System.EventHandler(this.btnOptViewSource_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(340, 6);
            // 
            // channelsToolStripMenuItem
            // 
            this.channelsToolStripMenuItem.Checked = true;
            this.channelsToolStripMenuItem.CheckOnClick = true;
            this.channelsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.channelsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.channelsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.channelsToolStripMenuItem.Name = "channelsToolStripMenuItem";
            this.channelsToolStripMenuItem.Size = new System.Drawing.Size(343, 44);
            this.channelsToolStripMenuItem.Text = "Channels";
            this.channelsToolStripMenuItem.Click += new System.EventHandler(this.channelsToolStripMenuItem_Click);
            // 
            // btnMenuShowStepPrg
            // 
            this.btnMenuShowStepPrg.Checked = true;
            this.btnMenuShowStepPrg.CheckOnClick = true;
            this.btnMenuShowStepPrg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnMenuShowStepPrg.ForeColor = System.Drawing.Color.White;
            this.btnMenuShowStepPrg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMenuShowStepPrg.Name = "btnMenuShowStepPrg";
            this.btnMenuShowStepPrg.Size = new System.Drawing.Size(343, 44);
            this.btnMenuShowStepPrg.Text = "Step Program";
            this.btnMenuShowStepPrg.Click += new System.EventHandler(this.btnMenuShowStepPrg_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(340, 6);
            // 
            // btnMenuClearTerminal
            // 
            this.btnMenuClearTerminal.ForeColor = System.Drawing.Color.White;
            this.btnMenuClearTerminal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMenuClearTerminal.Name = "btnMenuClearTerminal";
            this.btnMenuClearTerminal.Size = new System.Drawing.Size(343, 44);
            this.btnMenuClearTerminal.Text = "&Clear Terminal";
            this.btnMenuClearTerminal.Click += new System.EventHandler(this.btnMenuClearTerminal_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnZoom50,
            this.btnZoom75,
            this.btnZoom100,
            this.btnZoom110,
            this.btnZoom120});
            this.zoomToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.zoomToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(343, 44);
            this.zoomToolStripMenuItem.Text = "&Zoom";
            // 
            // btnZoom50
            // 
            this.btnZoom50.ForeColor = System.Drawing.Color.White;
            this.btnZoom50.Name = "btnZoom50";
            this.btnZoom50.Size = new System.Drawing.Size(206, 44);
            this.btnZoom50.Text = "50%";
            this.btnZoom50.Click += new System.EventHandler(this.btnZoom50_Click);
            // 
            // btnZoom75
            // 
            this.btnZoom75.ForeColor = System.Drawing.Color.White;
            this.btnZoom75.Name = "btnZoom75";
            this.btnZoom75.Size = new System.Drawing.Size(206, 44);
            this.btnZoom75.Text = "75%";
            this.btnZoom75.Click += new System.EventHandler(this.btnZoom75_Click);
            // 
            // btnZoom100
            // 
            this.btnZoom100.ForeColor = System.Drawing.Color.White;
            this.btnZoom100.Name = "btnZoom100";
            this.btnZoom100.Size = new System.Drawing.Size(206, 44);
            this.btnZoom100.Text = "100%";
            this.btnZoom100.Click += new System.EventHandler(this.btnZoom100_Click);
            // 
            // btnZoom110
            // 
            this.btnZoom110.ForeColor = System.Drawing.Color.White;
            this.btnZoom110.Name = "btnZoom110";
            this.btnZoom110.Size = new System.Drawing.Size(206, 44);
            this.btnZoom110.Text = "110%";
            this.btnZoom110.Click += new System.EventHandler(this.btnZoom110_Click);
            // 
            // btnZoom120
            // 
            this.btnZoom120.ForeColor = System.Drawing.Color.White;
            this.btnZoom120.Name = "btnZoom120";
            this.btnZoom120.Size = new System.Drawing.Size(206, 44);
            this.btnZoom120.Text = "120%";
            this.btnZoom120.Click += new System.EventHandler(this.btnZoom120_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(340, 6);
            // 
            // btnMenuTopMost
            // 
            this.btnMenuTopMost.ForeColor = System.Drawing.Color.White;
            this.btnMenuTopMost.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMenuTopMost.Name = "btnMenuTopMost";
            this.btnMenuTopMost.Size = new System.Drawing.Size(343, 44);
            this.btnMenuTopMost.Text = "&Top Most";
            this.btnMenuTopMost.Click += new System.EventHandler(this.btnMenuTopMost_Click);
            // 
            // btnMenuFullScreen
            // 
            this.btnMenuFullScreen.ForeColor = System.Drawing.Color.White;
            this.btnMenuFullScreen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMenuFullScreen.Name = "btnMenuFullScreen";
            this.btnMenuFullScreen.Size = new System.Drawing.Size(343, 44);
            this.btnMenuFullScreen.Text = "&Full Screen";
            this.btnMenuFullScreen.Click += new System.EventHandler(this.btnMenuFullScreen_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewChannel,
            this.btnRemoveChannel,
            this.toolStripSeparator23,
            this.ddbChannels,
            this.btnRenameChannel,
            this.toolStripSeparator24,
            this.btnMenuModbusMaster,
            this.toolStripSeparator28,
            this.btnChannelPort,
            this.btnChannelBaud,
            this.btnChannelDataBits,
            this.btnChannelParity,
            this.btnChannelStopBits});
            this.projectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(122, 38);
            this.projectToolStripMenuItem.Text = "Channel";
            // 
            // btnNewChannel
            // 
            this.btnNewChannel.ForeColor = System.Drawing.Color.White;
            this.btnNewChannel.Name = "btnNewChannel";
            this.btnNewChannel.Size = new System.Drawing.Size(359, 44);
            this.btnNewChannel.Text = "New Channel";
            this.btnNewChannel.Click += new System.EventHandler(this.btnNewChannel_Click);
            // 
            // btnRemoveChannel
            // 
            this.btnRemoveChannel.ForeColor = System.Drawing.Color.White;
            this.btnRemoveChannel.Name = "btnRemoveChannel";
            this.btnRemoveChannel.Size = new System.Drawing.Size(359, 44);
            this.btnRemoveChannel.Text = "Remove Channel";
            this.btnRemoveChannel.Click += new System.EventHandler(this.btnRemoveChannel_Click);
            // 
            // toolStripSeparator23
            // 
            this.toolStripSeparator23.Name = "toolStripSeparator23";
            this.toolStripSeparator23.Size = new System.Drawing.Size(356, 6);
            // 
            // ddbChannels
            // 
            this.ddbChannels.ForeColor = System.Drawing.Color.White;
            this.ddbChannels.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ddbChannels.Name = "ddbChannels";
            this.ddbChannels.Size = new System.Drawing.Size(359, 44);
            this.ddbChannels.Text = "Switch Channel";
            this.ddbChannels.DropDownOpening += new System.EventHandler(this.ddbChannels_DropDownOpening);
            // 
            // btnRenameChannel
            // 
            this.btnRenameChannel.ForeColor = System.Drawing.Color.White;
            this.btnRenameChannel.Name = "btnRenameChannel";
            this.btnRenameChannel.Size = new System.Drawing.Size(359, 44);
            this.btnRenameChannel.Text = "Rename Channel";
            this.btnRenameChannel.Click += new System.EventHandler(this.renameChannelToolStripMenuItem1_Click);
            // 
            // toolStripSeparator24
            // 
            this.toolStripSeparator24.Name = "toolStripSeparator24";
            this.toolStripSeparator24.Size = new System.Drawing.Size(356, 6);
            // 
            // btnMenuModbusMaster
            // 
            this.btnMenuModbusMaster.CheckOnClick = true;
            this.btnMenuModbusMaster.ForeColor = System.Drawing.Color.White;
            this.btnMenuModbusMaster.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMenuModbusMaster.Name = "btnMenuModbusMaster";
            this.btnMenuModbusMaster.Size = new System.Drawing.Size(359, 44);
            this.btnMenuModbusMaster.Text = "Modbus Master";
            this.btnMenuModbusMaster.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator28
            // 
            this.toolStripSeparator28.Name = "toolStripSeparator28";
            this.toolStripSeparator28.Size = new System.Drawing.Size(356, 6);
            // 
            // btnChannelPort
            // 
            this.btnChannelPort.ForeColor = System.Drawing.Color.White;
            this.btnChannelPort.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChannelPort.Name = "btnChannelPort";
            this.btnChannelPort.Size = new System.Drawing.Size(359, 44);
            this.btnChannelPort.Text = "Port";
            // 
            // btnChannelBaud
            // 
            this.btnChannelBaud.ForeColor = System.Drawing.Color.White;
            this.btnChannelBaud.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChannelBaud.Name = "btnChannelBaud";
            this.btnChannelBaud.Size = new System.Drawing.Size(359, 44);
            this.btnChannelBaud.Text = "Baud Rate";
            // 
            // btnChannelDataBits
            // 
            this.btnChannelDataBits.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChanDB5,
            this.btnChanDB6,
            this.btnChanDB7,
            this.btnChanDB});
            this.btnChannelDataBits.ForeColor = System.Drawing.Color.White;
            this.btnChannelDataBits.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChannelDataBits.Name = "btnChannelDataBits";
            this.btnChannelDataBits.Size = new System.Drawing.Size(359, 44);
            this.btnChannelDataBits.Text = "Data Bits";
            // 
            // btnChanDB5
            // 
            this.btnChanDB5.ForeColor = System.Drawing.Color.White;
            this.btnChanDB5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChanDB5.Name = "btnChanDB5";
            this.btnChanDB5.Size = new System.Drawing.Size(160, 44);
            this.btnChanDB5.Tag = "5";
            this.btnChanDB5.Text = "5";
            this.btnChanDB5.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // btnChanDB6
            // 
            this.btnChanDB6.ForeColor = System.Drawing.Color.White;
            this.btnChanDB6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChanDB6.Name = "btnChanDB6";
            this.btnChanDB6.Size = new System.Drawing.Size(160, 44);
            this.btnChanDB6.Tag = "6";
            this.btnChanDB6.Text = "6";
            this.btnChanDB6.Click += new System.EventHandler(this.btnChanDB6_Click);
            // 
            // btnChanDB7
            // 
            this.btnChanDB7.ForeColor = System.Drawing.Color.White;
            this.btnChanDB7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChanDB7.Name = "btnChanDB7";
            this.btnChanDB7.Size = new System.Drawing.Size(160, 44);
            this.btnChanDB7.Tag = "7";
            this.btnChanDB7.Text = "7";
            this.btnChanDB7.Click += new System.EventHandler(this.btnChanDB7_Click);
            // 
            // btnChanDB
            // 
            this.btnChanDB.ForeColor = System.Drawing.Color.White;
            this.btnChanDB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChanDB.Name = "btnChanDB";
            this.btnChanDB.Size = new System.Drawing.Size(160, 44);
            this.btnChanDB.Tag = "8";
            this.btnChanDB.Text = "8";
            this.btnChanDB.Click += new System.EventHandler(this.btnChanDB_Click);
            // 
            // btnChannelParity
            // 
            this.btnChannelParity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChannelNoParity,
            this.btnChannelEvenParity,
            this.btnChannelOddParity,
            this.btnChannelSpaceParity,
            this.btnChannelMarkParity});
            this.btnChannelParity.ForeColor = System.Drawing.Color.White;
            this.btnChannelParity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChannelParity.Name = "btnChannelParity";
            this.btnChannelParity.Size = new System.Drawing.Size(359, 44);
            this.btnChannelParity.Text = "Parity";
            // 
            // btnChannelNoParity
            // 
            this.btnChannelNoParity.ForeColor = System.Drawing.Color.White;
            this.btnChannelNoParity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChannelNoParity.Name = "btnChannelNoParity";
            this.btnChannelNoParity.Size = new System.Drawing.Size(275, 44);
            this.btnChannelNoParity.Tag = "N";
            this.btnChannelNoParity.Text = "No Parity";
            this.btnChannelNoParity.Click += new System.EventHandler(this.btnChannelNoParity_Click);
            // 
            // btnChannelEvenParity
            // 
            this.btnChannelEvenParity.ForeColor = System.Drawing.Color.White;
            this.btnChannelEvenParity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChannelEvenParity.Name = "btnChannelEvenParity";
            this.btnChannelEvenParity.Size = new System.Drawing.Size(275, 44);
            this.btnChannelEvenParity.Tag = "E";
            this.btnChannelEvenParity.Text = "Even Parity";
            this.btnChannelEvenParity.Click += new System.EventHandler(this.btnChannelEvenParity_Click);
            // 
            // btnChannelOddParity
            // 
            this.btnChannelOddParity.ForeColor = System.Drawing.Color.White;
            this.btnChannelOddParity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChannelOddParity.Name = "btnChannelOddParity";
            this.btnChannelOddParity.Size = new System.Drawing.Size(275, 44);
            this.btnChannelOddParity.Tag = "O";
            this.btnChannelOddParity.Text = "Odd Parity";
            this.btnChannelOddParity.Click += new System.EventHandler(this.btnChannelOddParity_Click);
            // 
            // btnChannelSpaceParity
            // 
            this.btnChannelSpaceParity.ForeColor = System.Drawing.Color.White;
            this.btnChannelSpaceParity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChannelSpaceParity.Name = "btnChannelSpaceParity";
            this.btnChannelSpaceParity.Size = new System.Drawing.Size(275, 44);
            this.btnChannelSpaceParity.Tag = "S";
            this.btnChannelSpaceParity.Text = "Space Parity";
            this.btnChannelSpaceParity.Click += new System.EventHandler(this.btnChannelSpaceParity_Click);
            // 
            // btnChannelMarkParity
            // 
            this.btnChannelMarkParity.ForeColor = System.Drawing.Color.White;
            this.btnChannelMarkParity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChannelMarkParity.Name = "btnChannelMarkParity";
            this.btnChannelMarkParity.Size = new System.Drawing.Size(275, 44);
            this.btnChannelMarkParity.Tag = "M";
            this.btnChannelMarkParity.Text = "Mark Parity";
            this.btnChannelMarkParity.Click += new System.EventHandler(this.btnChannelMarkParity_Click);
            // 
            // btnChannelStopBits
            // 
            this.btnChannelStopBits.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChannelStopBits0,
            this.btnChannelStopBits1,
            this.btnChannelStopBits15,
            this.btnChannelStopBits2});
            this.btnChannelStopBits.ForeColor = System.Drawing.Color.White;
            this.btnChannelStopBits.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChannelStopBits.Name = "btnChannelStopBits";
            this.btnChannelStopBits.Size = new System.Drawing.Size(359, 44);
            this.btnChannelStopBits.Text = "Stop Bits";
            // 
            // btnChannelStopBits0
            // 
            this.btnChannelStopBits0.ForeColor = System.Drawing.Color.White;
            this.btnChannelStopBits0.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChannelStopBits0.Name = "btnChannelStopBits0";
            this.btnChannelStopBits0.Size = new System.Drawing.Size(278, 44);
            this.btnChannelStopBits0.Tag = "0";
            this.btnChannelStopBits0.Text = "0 Stop Bits";
            this.btnChannelStopBits0.Click += new System.EventHandler(this.btnChannelStopBits0_Click);
            // 
            // btnChannelStopBits1
            // 
            this.btnChannelStopBits1.ForeColor = System.Drawing.Color.White;
            this.btnChannelStopBits1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChannelStopBits1.Name = "btnChannelStopBits1";
            this.btnChannelStopBits1.Size = new System.Drawing.Size(278, 44);
            this.btnChannelStopBits1.Tag = "1";
            this.btnChannelStopBits1.Text = "1 Stop Bits";
            this.btnChannelStopBits1.Click += new System.EventHandler(this.btnChannelStopBits1_Click);
            // 
            // btnChannelStopBits15
            // 
            this.btnChannelStopBits15.ForeColor = System.Drawing.Color.White;
            this.btnChannelStopBits15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChannelStopBits15.Name = "btnChannelStopBits15";
            this.btnChannelStopBits15.Size = new System.Drawing.Size(278, 44);
            this.btnChannelStopBits15.Tag = "1.5";
            this.btnChannelStopBits15.Text = "1.5 Stop Bits";
            this.btnChannelStopBits15.Click += new System.EventHandler(this.btnChannelStopBits15_Click);
            // 
            // btnChannelStopBits2
            // 
            this.btnChannelStopBits2.ForeColor = System.Drawing.Color.White;
            this.btnChannelStopBits2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChannelStopBits2.Name = "btnChannelStopBits2";
            this.btnChannelStopBits2.Size = new System.Drawing.Size(278, 44);
            this.btnChannelStopBits2.Tag = "2";
            this.btnChannelStopBits2.Text = "2 Stop Bits ";
            this.btnChannelStopBits2.Click += new System.EventHandler(this.btnChannelStopBits2_Click);
            // 
            // btnPrgNewStepLine
            // 
            this.btnPrgNewStepLine.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCommandToolStripMenuItem,
            this.btnPrgRemoveStepLines,
            this.toolStripSeparator17,
            this.btnPrgMoveUp,
            this.btnPrgMoveDown,
            this.toolStripSeparator18,
            this.btnEnableSelected,
            this.btnToggleSelected,
            this.btnDisableSelected,
            this.toolStripSeparator19,
            this.setStepCursorToolStripMenuItem,
            this.toolStripSeparator22,
            this.activeProgramToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.toolStripSeparator26,
            this.btnRunPrg,
            this.runProgramToolStripMenuItem,
            this.btnPausePrg,
            this.btnStopPrg,
            this.toolStripSeparator27,
            this.newProgramToolStripMenuItem,
            this.removeProgramToolStripMenuItem});
            this.btnPrgNewStepLine.ForeColor = System.Drawing.Color.White;
            this.btnPrgNewStepLine.Name = "btnPrgNewStepLine";
            this.btnPrgNewStepLine.Size = new System.Drawing.Size(124, 38);
            this.btnPrgNewStepLine.Text = "Program";
            // 
            // addCommandToolStripMenuItem
            // 
            this.addCommandToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addCommandToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addCommandToolStripMenuItem.Name = "addCommandToolStripMenuItem";
            this.addCommandToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.addCommandToolStripMenuItem.Size = new System.Drawing.Size(529, 44);
            this.addCommandToolStripMenuItem.Text = "Add Command";
            this.addCommandToolStripMenuItem.Click += new System.EventHandler(this.addCommandToolStripMenuItem_Click);
            // 
            // btnPrgRemoveStepLines
            // 
            this.btnPrgRemoveStepLines.ForeColor = System.Drawing.Color.White;
            this.btnPrgRemoveStepLines.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrgRemoveStepLines.Name = "btnPrgRemoveStepLines";
            this.btnPrgRemoveStepLines.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.btnPrgRemoveStepLines.Size = new System.Drawing.Size(529, 44);
            this.btnPrgRemoveStepLines.Text = "Remove Selected";
            this.btnPrgRemoveStepLines.Click += new System.EventHandler(this.btnPrgRemoveStepLines_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(526, 6);
            // 
            // btnPrgMoveUp
            // 
            this.btnPrgMoveUp.ForeColor = System.Drawing.Color.White;
            this.btnPrgMoveUp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrgMoveUp.Name = "btnPrgMoveUp";
            this.btnPrgMoveUp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.btnPrgMoveUp.Size = new System.Drawing.Size(529, 44);
            this.btnPrgMoveUp.Text = "Move Up";
            this.btnPrgMoveUp.Click += new System.EventHandler(this.btnPrgMoveUp_Click);
            // 
            // btnPrgMoveDown
            // 
            this.btnPrgMoveDown.ForeColor = System.Drawing.Color.White;
            this.btnPrgMoveDown.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrgMoveDown.Name = "btnPrgMoveDown";
            this.btnPrgMoveDown.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.btnPrgMoveDown.Size = new System.Drawing.Size(529, 44);
            this.btnPrgMoveDown.Text = "Move Down";
            this.btnPrgMoveDown.Click += new System.EventHandler(this.btnPrgMoveDown_Click);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(526, 6);
            // 
            // btnEnableSelected
            // 
            this.btnEnableSelected.ForeColor = System.Drawing.Color.White;
            this.btnEnableSelected.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEnableSelected.Name = "btnEnableSelected";
            this.btnEnableSelected.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.btnEnableSelected.Size = new System.Drawing.Size(529, 44);
            this.btnEnableSelected.Text = "Enable Selected";
            this.btnEnableSelected.Click += new System.EventHandler(this.enableSelectedToolStripMenuItem_Click);
            // 
            // btnToggleSelected
            // 
            this.btnToggleSelected.ForeColor = System.Drawing.Color.White;
            this.btnToggleSelected.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnToggleSelected.Name = "btnToggleSelected";
            this.btnToggleSelected.Size = new System.Drawing.Size(529, 44);
            this.btnToggleSelected.Text = "Toggle Enable";
            this.btnToggleSelected.Click += new System.EventHandler(this.toggleEnableToolStripMenuItem_Click);
            // 
            // btnDisableSelected
            // 
            this.btnDisableSelected.ForeColor = System.Drawing.Color.White;
            this.btnDisableSelected.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDisableSelected.Name = "btnDisableSelected";
            this.btnDisableSelected.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.btnDisableSelected.Size = new System.Drawing.Size(529, 44);
            this.btnDisableSelected.Text = "Disable Selected";
            this.btnDisableSelected.Click += new System.EventHandler(this.disableSelectedToolStripMenuItem_Click);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(526, 6);
            // 
            // setStepCursorToolStripMenuItem
            // 
            this.setStepCursorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.setStepCursorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.setStepCursorToolStripMenuItem.Name = "setStepCursorToolStripMenuItem";
            this.setStepCursorToolStripMenuItem.Size = new System.Drawing.Size(529, 44);
            this.setStepCursorToolStripMenuItem.Text = "Set Step Cursor";
            this.setStepCursorToolStripMenuItem.Click += new System.EventHandler(this.setStepCursorToolStripMenuItem_Click);
            // 
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            this.toolStripSeparator22.Size = new System.Drawing.Size(526, 6);
            // 
            // activeProgramToolStripMenuItem
            // 
            this.activeProgramToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.activeProgramToolStripMenuItem.Name = "activeProgramToolStripMenuItem";
            this.activeProgramToolStripMenuItem.Size = new System.Drawing.Size(529, 44);
            this.activeProgramToolStripMenuItem.Text = "Active Program";
            this.activeProgramToolStripMenuItem.DropDownOpening += new System.EventHandler(this.activeProgramToolStripMenuItem_DropDownOpening);
            this.activeProgramToolStripMenuItem.Click += new System.EventHandler(this.activeProgramToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(529, 44);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator26
            // 
            this.toolStripSeparator26.Name = "toolStripSeparator26";
            this.toolStripSeparator26.Size = new System.Drawing.Size(526, 6);
            // 
            // btnRunPrg
            // 
            this.btnRunPrg.ForeColor = System.Drawing.Color.White;
            this.btnRunPrg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRunPrg.Name = "btnRunPrg";
            this.btnRunPrg.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.btnRunPrg.Size = new System.Drawing.Size(529, 44);
            this.btnRunPrg.Text = "Run Program from Start";
            this.btnRunPrg.Click += new System.EventHandler(this.btnRunPrg_Click);
            // 
            // runProgramToolStripMenuItem
            // 
            this.runProgramToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.runProgramToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.runProgramToolStripMenuItem.Name = "runProgramToolStripMenuItem";
            this.runProgramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Space)));
            this.runProgramToolStripMenuItem.Size = new System.Drawing.Size(529, 44);
            this.runProgramToolStripMenuItem.Text = "Run Program";
            this.runProgramToolStripMenuItem.Click += new System.EventHandler(this.runProgramToolStripMenuItem_Click);
            // 
            // btnPausePrg
            // 
            this.btnPausePrg.Enabled = false;
            this.btnPausePrg.ForeColor = System.Drawing.Color.White;
            this.btnPausePrg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPausePrg.Name = "btnPausePrg";
            this.btnPausePrg.Size = new System.Drawing.Size(529, 44);
            this.btnPausePrg.Text = "Pause Program";
            this.btnPausePrg.Click += new System.EventHandler(this.btnPausePrg_Click);
            // 
            // btnStopPrg
            // 
            this.btnStopPrg.Enabled = false;
            this.btnStopPrg.ForeColor = System.Drawing.Color.White;
            this.btnStopPrg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStopPrg.Name = "btnStopPrg";
            this.btnStopPrg.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.btnStopPrg.Size = new System.Drawing.Size(529, 44);
            this.btnStopPrg.Text = "Stop Program";
            this.btnStopPrg.Click += new System.EventHandler(this.btnStopPrg_Click);
            // 
            // toolStripSeparator27
            // 
            this.toolStripSeparator27.Name = "toolStripSeparator27";
            this.toolStripSeparator27.Size = new System.Drawing.Size(526, 6);
            this.toolStripSeparator27.Click += new System.EventHandler(this.toolStripSeparator27_Click);
            // 
            // newProgramToolStripMenuItem
            // 
            this.newProgramToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newProgramToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newProgramToolStripMenuItem.Name = "newProgramToolStripMenuItem";
            this.newProgramToolStripMenuItem.Size = new System.Drawing.Size(529, 44);
            this.newProgramToolStripMenuItem.Text = "New Program";
            this.newProgramToolStripMenuItem.Click += new System.EventHandler(this.newProgramToolStripMenuItem_Click);
            // 
            // removeProgramToolStripMenuItem
            // 
            this.removeProgramToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.removeProgramToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.removeProgramToolStripMenuItem.Name = "removeProgramToolStripMenuItem";
            this.removeProgramToolStripMenuItem.Size = new System.Drawing.Size(529, 44);
            this.removeProgramToolStripMenuItem.Text = "Remove Program";
            this.removeProgramToolStripMenuItem.Click += new System.EventHandler(this.removeProgramToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyPadToolStripMenuItem,
            this.btnMonitor,
            this.modbusRegistersToolStripMenuItem,
            this.toolStripSeparator14,
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(89, 38);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // keyPadToolStripMenuItem
            // 
            this.keyPadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.keyPadToolStripMenuItem.Name = "keyPadToolStripMenuItem";
            this.keyPadToolStripMenuItem.Size = new System.Drawing.Size(337, 44);
            this.keyPadToolStripMenuItem.Text = "&Keypad";
            this.keyPadToolStripMenuItem.Click += new System.EventHandler(this.keyPadToolStripMenuItem_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.ForeColor = System.Drawing.Color.White;
            this.btnMonitor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(337, 44);
            this.btnMonitor.Text = "&Monitor";
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // modbusRegistersToolStripMenuItem
            // 
            this.modbusRegistersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modbusRegistersToolStripMenuItem.Name = "modbusRegistersToolStripMenuItem";
            this.modbusRegistersToolStripMenuItem.Size = new System.Drawing.Size(337, 44);
            this.modbusRegistersToolStripMenuItem.Text = "Modbus Registers";
            this.modbusRegistersToolStripMenuItem.Click += new System.EventHandler(this.modbusRegistersToolStripMenuItem_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(334, 6);
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customizeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(337, 44);
            this.customizeToolStripMenuItem.Text = "&Customize";
            this.customizeToolStripMenuItem.Visible = false;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.optionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(337, 44);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator10,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(84, 38);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.contentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.indexToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.searchToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(240, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cmStepPrg
            // 
            this.cmStepPrg.ActionSymbolForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cmStepPrg.BorderColor = System.Drawing.Color.Black;
            this.cmStepPrg.ForeColor = System.Drawing.Color.White;
            this.cmStepPrg.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmStepPrg.InsetShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmStepPrg.MenuBackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cmStepPrg.MenuBackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cmStepPrg.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmStepPrg.Name = "cmStepPrg";
            this.cmStepPrg.ShowInsetShadow = true;
            this.cmStepPrg.ShowItemInsetShadow = true;
            this.cmStepPrg.Size = new System.Drawing.Size(61, 4);
            // 
            // tmrProg
            // 
            this.tmrProg.Enabled = true;
            this.tmrProg.Interval = 1;
            this.tmrProg.Tick += new System.EventHandler(this.tmrProg_Tick);
            // 
            // pnlStepProgram
            // 
            this.pnlStepProgram.ArrowColor = System.Drawing.Color.DarkGray;
            this.pnlStepProgram.ArrowMouseOverColor = System.Drawing.Color.DodgerBlue;
            this.pnlStepProgram.CloseColor = System.Drawing.Color.DarkGray;
            this.pnlStepProgram.CloseMouseOverColor = System.Drawing.Color.Brown;
            this.pnlStepProgram.Collapsed = false;
            this.pnlStepProgram.Controls.Add(this.lstStepProgram);
            this.pnlStepProgram.Controls.Add(this.tabHeader1);
            this.pnlStepProgram.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStepProgram.DropShadow = false;
            this.pnlStepProgram.DropShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlStepProgram.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlStepProgram.LabelFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlStepProgram.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlStepProgram.Location = new System.Drawing.Point(0, 438);
            this.pnlStepProgram.Margin = new System.Windows.Forms.Padding(6);
            this.pnlStepProgram.Name = "pnlStepProgram";
            this.pnlStepProgram.OverrideCollapseControl = true;
            this.pnlStepProgram.Padding = new System.Windows.Forms.Padding(0, 37, 0, 0);
            this.pnlStepProgram.PanelCollapsible = true;
            this.pnlStepProgram.ResizeControl = ODModules.LabelPanel.ResizeDirection.Top;
            this.pnlStepProgram.ShowCloseButton = true;
            this.pnlStepProgram.Size = new System.Drawing.Size(1293, 337);
            this.pnlStepProgram.TabIndex = 3;
            this.pnlStepProgram.Text = "Step Program";
            this.pnlStepProgram.CloseButtonClicked += new ODModules.LabelPanel.CloseClickedHandler(this.pnlStepProgram_CloseButtonClicked);
            // 
            // tabHeader1
            // 
            this.tabHeader1.ArrowColor = System.Drawing.Color.DarkGray;
            this.tabHeader1.ArrowDisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabHeader1.ArrowHoverColor = System.Drawing.Color.SteelBlue;
            this.tabHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tabHeader1.BindedTabControl = null;
            this.tabHeader1.CloseHoverColor = System.Drawing.Color.Brown;
            this.tabHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabHeader1.ForeColor = System.Drawing.Color.White;
            this.tabHeader1.Location = new System.Drawing.Point(0, 37);
            this.tabHeader1.Margin = new System.Windows.Forms.Padding(6);
            this.tabHeader1.Name = "tabHeader1";
            this.tabHeader1.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.tabHeader1.SelectedIndex = 0;
            this.tabHeader1.ShowAddButton = true;
            this.tabHeader1.Size = new System.Drawing.Size(1293, 58);
            this.tabHeader1.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabHeader1.TabBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabHeader1.TabClickedBackColor = System.Drawing.Color.DarkGray;
            this.tabHeader1.TabHoverBackColor = System.Drawing.Color.LightGray;
            this.tabHeader1.TabIndex = 2;
            tab1.Selected = true;
            tab1.Tag = null;
            tab1.Text = "Main";
            this.tabHeader1.Tabs.Add(tab1);
            this.tabHeader1.TabSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabHeader1.TabSelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabHeader1.TabSelectedForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabHeader1.TabStyle = ODModules.TabHeader.TabStyles.Normal;
            this.tabHeader1.UseBindingTabControl = false;
            this.tabHeader1.AddButtonClicked += new ODModules.TabHeader.AddButtonClickedHandler(this.tabHeader1_AddButtonClicked);
            this.tabHeader1.CloseButtonClicked += new ODModules.TabHeader.CloseButtonClickedHandler(this.tabHeader1_CloseButtonClicked);
            this.tabHeader1.SelectedIndexChanged += new ODModules.TabHeader.SelectedIndexChangedHandler(this.tabHeader1_SelectedIndexChanged);
            this.tabHeader1.Load += new System.EventHandler(this.tabHeader1_Load);
            // 
            // pnlMainConsole
            // 
            this.pnlMainConsole.Controls.Add(this.Output);
            this.pnlMainConsole.Controls.Add(this.navigator1);
            this.pnlMainConsole.Controls.Add(this.pnlRenamePanel);
            this.pnlMainConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainConsole.Location = new System.Drawing.Point(0, 84);
            this.pnlMainConsole.Margin = new System.Windows.Forms.Padding(6);
            this.pnlMainConsole.Name = "pnlMainConsole";
            this.pnlMainConsole.Size = new System.Drawing.Size(1293, 354);
            this.pnlMainConsole.TabIndex = 3;
            // 
            // Output
            // 
            this.Output.AllowCommandEntry = true;
            this.Output.AllowMouseSelection = false;
            this.Output.AllowMouseWheelZoom = false;
            this.Output.BufferLength = 10000;
            this.Output.CursorFlashSpeed = 0.5F;
            this.Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Output.ExtraLineAfterCommandEntered = false;
            this.Output.FlashCursor = false;
            this.Output.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output.HorScroll = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Output.LineFormatting = true;
            this.Output.Location = new System.Drawing.Point(150, 38);
            this.Output.Margin = new System.Windows.Forms.Padding(6);
            this.Output.MaximumLength = 100;
            this.Output.Name = "Output";
            this.Output.OriginForeColor = System.Drawing.Color.Silver;
            this.Output.Padding = new System.Windows.Forms.Padding(9, 11, 0, 0);
            this.Output.PrintOnEntry = true;
            this.Output.ScrollBarMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Output.ScrollBarNorth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Output.ScrollBarSouth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Output.SecondaryFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Output.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.Output.ShowOrigin = true;
            this.Output.Size = new System.Drawing.Size(1143, 316);
            this.Output.TabIndex = 0;
            this.Output.TimeStampForeColor = System.Drawing.Color.Gray;
            this.Output.TimeStamps = ODModules.ConsoleInterface.TimeStampFormat.NoTimeStamps;
            this.Output.VerScroll = 0;
            this.Output.Zoom = 100;
            this.Output.CommandEntered += new ODModules.ConsoleInterface.CommandEnteredEventHandler(this.Output_CommandEntered);
            this.Output.Click += new System.EventHandler(this.Output_Click);
            this.Output.Enter += new System.EventHandler(this.Output_Enter);
            this.Output.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Output_MouseClick);
            this.Output.Validated += new System.EventHandler(this.Output_Validated);
            // 
            // smMain
            // 
            this.smMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.smMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblTxBytes,
            this.toolStripStatusLabel3,
            this.lblRxBytes});
            this.smMain.Location = new System.Drawing.Point(0, 775);
            this.smMain.MenuSeparatorColor = System.Drawing.Color.WhiteSmoke;
            this.smMain.Name = "smMain";
            this.smMain.Padding = new System.Windows.Forms.Padding(2, 0, 26, 0);
            this.smMain.Size = new System.Drawing.Size(1293, 42);
            this.smMain.SizingGrip = false;
            this.smMain.TabIndex = 4;
            this.smMain.Text = "statusMenu1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Silver;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(46, 32);
            this.toolStripStatusLabel1.Text = "TX:";
            // 
            // lblTxBytes
            // 
            this.lblTxBytes.ForeColor = System.Drawing.Color.White;
            this.lblTxBytes.Name = "lblTxBytes";
            this.lblTxBytes.Size = new System.Drawing.Size(27, 32);
            this.lblTxBytes.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Silver;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(47, 32);
            this.toolStripStatusLabel3.Text = "RX:";
            // 
            // lblRxBytes
            // 
            this.lblRxBytes.ForeColor = System.Drawing.Color.White;
            this.lblRxBytes.Name = "lblRxBytes";
            this.lblRxBytes.Size = new System.Drawing.Size(27, 32);
            this.lblRxBytes.Text = "0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1293, 817);
            this.Controls.Add(this.pnlMainConsole);
            this.Controls.Add(this.pnlStepProgram);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.smMain);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainWindow";
            this.Text = "Untitled - Serial Monitor";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.pnlRenamePanel.ResumeLayout(false);
            this.pnlRenamePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.cmStepEditor.ResumeLayout(false);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pnlStepProgram.ResumeLayout(false);
            this.pnlMainConsole.ResumeLayout(false);
            this.pnlMainConsole.PerformLayout();
            this.smMain.ResumeLayout(false);
            this.smMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ODModules.ToolStrip tsMain;
        private ToolStripDropDownButton ddbPorts;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton ddbBAUDRate;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnConnect;
        private ToolStripButton btnDisconnect;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripDropDownButton ddbOutputFormat;
        private ToolStripDropDownButton ddbParity;
        private ToolStripDropDownButton ddbStopBits;
        private ToolStripMenuItem btnStopBitsNone;
        private ToolStripMenuItem btnStopBits1;
        private ToolStripMenuItem btnStopBits15;
        private ToolStripMenuItem btnStopBits2;
        private ToolStripDropDownButton ddbBits;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem btnParityNone;
        private ToolStripMenuItem btnParityEven;
        private ToolStripMenuItem btnParityOdd;
        private ToolStripMenuItem btnParitySpace;
        private ToolStripMenuItem btnParityMark;
        private ToolStripMenuItem btnBits5;
        private ToolStripMenuItem btnBits6;
        private ToolStripMenuItem btnBits7;
        private ToolStripMenuItem btnBits8;
        private ToolStripDropDownButton ddbInputFormat;
        private ToolStripButton btnStop;
        private ToolStripButton btnPause;
        private ToolStripMenuItem btnInFormText;
        private ToolStripMenuItem btnInFormStream;
        private ToolStripMenuItem btnInFormCCommand;
        private ToolStripMenuItem btnOutFormText;
        private ToolStripMenuItem btnOutFormCCommand;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btnClearTerminal;
        private ToolStripButton btnTopMost;
        private ODModules.MenuStrip msMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem btnNewStep;
        private ToolStripMenuItem btnOpenStep;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem btnSaveStep;
        private ToolStripMenuItem btnSaveAsStep;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem btnPrint;
        private ToolStripMenuItem btnPrintPreview;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem btnMenuExit;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem terminalToolStripMenuItem;
        private ToolStripMenuItem btnMenuClearTerminal;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem btnZoom50;
        private ToolStripMenuItem btnZoom75;
        private ToolStripMenuItem btnZoom100;
        private ToolStripMenuItem btnZoom110;
        private ToolStripMenuItem btnZoom120;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripMenuItem btnMenuTopMost;
        private ToolStripMenuItem btnMenuFullScreen;
        private ToolStripMenuItem btnOptViewDataOnly;
        private ToolStripMenuItem btnOptViewTime;
        private ToolStripMenuItem btnOptViewDate;
        private ToolStripMenuItem btnOptViewDateTime;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripMenuItem btnMenuShowStepPrg;
        private ODModules.ListControl lstStepProgram;
        private ODModules.Navigator navigator1;
        private ToolStripMenuItem monitorToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripMenuItem btnMonitor;
        private ToolStripSeparator toolStripSeparator15;
        private Panel pnlRenamePanel;
        private TextBox textBox1;
        private Panel panel2;
        private ODModules.Button button1;
        private ToolStripSeparator toolStripSeparator16;
        private ToolStripMenuItem btnOptViewSource;
        private ODModules.ContextMenu cmStepPrg;
        private ToolStripMenuItem btnPrgNewStepLine;
        private ToolStripMenuItem addCommandToolStripMenuItem;
        private ToolStripMenuItem btnPrgRemoveStepLines;
        private ToolStripSeparator toolStripSeparator17;
        private ToolStripMenuItem btnPrgMoveUp;
        private ToolStripMenuItem btnPrgMoveDown;
        private System.Windows.Forms.Timer tmrProg;
        private ToolStripSeparator toolStripSeparator18;
        private ToolStripMenuItem btnRunPrg;
        private ToolStripMenuItem btnPausePrg;
        private ToolStripMenuItem btnStopPrg;
        private ODModules.ContextMenu cmStepEditor;
        private ToolStripMenuItem addCommandToolStripMenuItem1;
        private ToolStripMenuItem removeSelectedToolStripMenuItem;
        private ToolStripMenuItem btnEnableSelected;
        private ToolStripMenuItem btnToggleSelected;
        private ToolStripMenuItem btnDisableSelected;
        private ToolStripSeparator toolStripSeparator19;
        private ToolStripSeparator toolStripSeparator20;
        private ToolStripMenuItem enableSelectedToolStripMenuItem1;
        private ToolStripMenuItem disableSelectedToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator21;
        private ToolStripMenuItem runToolStripMenuItem;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ODModules.LabelPanel pnlStepProgram;
        private Panel pnlMainConsole;
        private ODModules.ConsoleInterface Output;
        private ToolStripMenuItem setStepCursorToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator22;
        private ToolStripMenuItem runProgramToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private ToolStripButton btnRunCursor;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem btnNewChannel;
        private ToolStripMenuItem btnRemoveChannel;
        private ToolStripSeparator toolStripSeparator23;
        private ToolStripMenuItem btnRenameChannel;
        private ToolStripMenuItem btnRecentProjects;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem channelsToolStripMenuItem;
        private ODModules.StatusMenu smMain;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblTxBytes;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel lblRxBytes;
        private ToolStripMenuItem keyPadToolStripMenuItem;
        private ToolStripMenuItem btnInFormModbusRTU;
        private ToolStripMenuItem btnOutFormModbusRTU;
        private ToolStripSeparator toolStripSeparator24;
        private ToolStripMenuItem btnMenuModbusMaster;
        private ToolStripMenuItem modbusRegistersToolStripMenuItem;
        private ToolStripSplitButton btnRun;
        private ToolStripMenuItem runFromStartToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator25;
        private ToolStripMenuItem activeProgramToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator26;
        private ToolStripMenuItem propertiesToolStripMenuItem;
        private ODModules.TabHeader tabHeader1;
        private ToolStripSeparator toolStripSeparator27;
        private ToolStripMenuItem newProgramToolStripMenuItem;
        private ToolStripMenuItem removeProgramToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator28;
        private ToolStripMenuItem btnChannelPort;
        private ToolStripMenuItem btnChannelBaud;
        private ToolStripMenuItem btnChannelDataBits;
        private ToolStripMenuItem btnChannelParity;
        private ToolStripMenuItem btnChannelStopBits;
        private ToolStripMenuItem btnChanDB5;
        private ToolStripMenuItem btnChanDB6;
        private ToolStripMenuItem btnChanDB7;
        private ToolStripMenuItem btnChanDB;
        private ToolStripMenuItem btnChannelNoParity;
        private ToolStripMenuItem btnChannelEvenParity;
        private ToolStripMenuItem btnChannelOddParity;
        private ToolStripMenuItem btnChannelSpaceParity;
        private ToolStripMenuItem btnChannelMarkParity;
        private ToolStripMenuItem btnChannelStopBits0;
        private ToolStripMenuItem btnChannelStopBits1;
        private ToolStripMenuItem btnChannelStopBits15;
        private ToolStripMenuItem btnChannelStopBits2;
        private ToolStripMenuItem ddbChannels;
    }
}