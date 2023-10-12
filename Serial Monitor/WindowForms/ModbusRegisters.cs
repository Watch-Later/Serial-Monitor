﻿using ODModules;
using Serial_Monitor.Classes;
using Serial_Monitor.Classes.Enums;
using Serial_Monitor.Classes.Modbus;
using Serial_Monitor.Classes.Step_Programs;
using Serial_Monitor.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Serial_Monitor.Classes.Enums.ModbusEnums;
using ListControl = ODModules.ListControl;

namespace Serial_Monitor {
    public partial class ModbusRegisters : Form, Interfaces.ITheme {
        public Form? Attached = null;
        protected override CreateParams CreateParams {
            get {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        public ModbusRegisters() {
            InitializeComponent();
            tbDataPages.DebugMode = false;
            mdiClient.TileWindows = true;
        }
        bool showFormats = true;
        public bool ShowFormats {
            get {
                return showFormats;
            }
            set {
                showFormatsToolStripMenuItem.Checked = value;
                showFormats = value;
                ShowHideColumns();
            }
        }
        DataSelection dataSet = DataSelection.ModbusDataCoils;
        DataSelection DataSet {
            get { return dataSet; }
            set {
                dataSet = value;
                lblTypeSelection.Text = EnumManager.ModbusDataSelectionToString(value).A;
                if (value == DataSelection.ModbusDataCoils) {
                    btnDiscrete.Checked = false;
                    btnHolding.Checked = false;
                    btnCoils.Checked = true;
                    btnInputRegisters.Checked = false;
                }
                else if (value == DataSelection.ModbusDataDiscreteInputs) {
                    btnDiscrete.Checked = true;
                    btnHolding.Checked = false;
                    btnCoils.Checked = false;
                    btnInputRegisters.Checked = false;
                }
                else if (value == DataSelection.ModbusDataInputRegisters) {
                    btnDiscrete.Checked = false;
                    btnHolding.Checked = false;
                    btnCoils.Checked = false;
                    btnInputRegisters.Checked = true;
                }
                else if (value == DataSelection.ModbusDataHoldingRegisters) {
                    btnDiscrete.Checked = false;
                    btnHolding.Checked = true;
                    btnCoils.Checked = false;
                    btnInputRegisters.Checked = false;
                }
                SetEditors();
                ClearEditors();
                ShowHideColumns();
                LoadRegisters();
                CheckModbusDataSelection();
            }
        }
        private DataEditor currentEditorView = DataEditor.MasterView;
        private DataEditor CurrentEditorView {
            get { return currentEditorView; }
            set {
                currentEditorView = value;
                if (value == DataEditor.MasterView) {
                    btnViewMaster.Checked = true;
                    btnViewSnapshot.Checked = false;
                    showFormatsToolStripMenuItem.Checked = showFormats;
                    showFormatsToolStripMenuItem.Enabled = true;
                    goToToolStripMenuItem.Enabled = true;
                    if (CurrentManager != null) {
                        btnMenuModbusMaster.Checked = CurrentManager.IsMaster;
                        btnMenuModbusMaster.Enabled = true;
                    }
                    else {
                        btnMenuModbusMaster.Enabled = false;
                    }
                    setIOFormatsToModbusRTUToolStripMenuItem.Enabled = true;
                    writeCoilToolStripMenuItem.Enabled = true;
                    writeRegisterToolStripMenuItem.Enabled = true;
                }
                else {
                    goToToolStripMenuItem.Enabled = false;
                    btnViewMaster.Checked = false;
                    btnViewSnapshot.Checked = true;
                    if (SnapshotCurrentIndex < 0) {
                        showFormatsToolStripMenuItem.Checked = false;
                        showFormatsToolStripMenuItem.Enabled = false;
                        btnMenuModbusMaster.Enabled = false;
                        btnMenuModbusMaster.Checked = false;
                        setIOFormatsToModbusRTUToolStripMenuItem.Enabled = false;
                        writeCoilToolStripMenuItem.Enabled = false;
                        writeRegisterToolStripMenuItem.Enabled = false;
                    }
                    else {
                        setIOFormatsToModbusRTUToolStripMenuItem.Enabled = true;
                        showFormatsToolStripMenuItem.Enabled = true;
                        try {
                            if (mdiClient.ChildForms[SnapshotCurrentIndex].GetType() == typeof(ToolWindows.ModbusRegister)) {
                                bool FormatsVisable = ((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).ShowFormats;
                                showFormatsToolStripMenuItem.Checked = FormatsVisable;
                                btnMenuModbusMaster.Enabled = true;
                                btnMenuModbusMaster.Checked = false;
                                SerialManager? Man = ((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).Snapshot.Manager;
                                if (Man  != null) {
                                    btnMenuModbusMaster.Checked = Man.IsMaster;
                                }
                                else {
                                    btnMenuModbusMaster.Enabled = true;
                                    btnMenuModbusMaster.Checked = false;
                                }
                                writeCoilToolStripMenuItem.Enabled = true;
                                writeRegisterToolStripMenuItem.Enabled = true;
                            }
                        }
                        catch { showFormatsToolStripMenuItem.Enabled = false; }
                    }
                }
                ChangeLockView();
                SetEditors();
            }
        }
        int snapShotCurrentIndex = -1;
        public int SnapshotCurrentIndex {
            get { return snapShotCurrentIndex; }
            set {
                snapShotCurrentIndex = value;
                CurrentEditorView = currentEditorView;
                SetEditors();
            }
        }
        private void SetEditors() {
            if (currentEditorView == DataEditor.MasterView) {
                if (dataSet > DataSelection.ModbusDataDiscreteInputs) {
                    ddbDisplayFormat.Enabled = true;
                    ddpDataSize.Enabled = true;
                }
                else {
                    ddbDisplayFormat.Enabled = false;
                    ddpDataSize.Enabled = false;
                }
            }
            else {
                try {
                    if (mdiClient.ChildForms[SnapshotCurrentIndex].GetType() == typeof(ToolWindows.ModbusRegister)) {
                        if (((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).Snapshot.Selection > DataSelection.ModbusDataDiscreteInputs) {
                            ddbDisplayFormat.Enabled = true;
                            ddpDataSize.Enabled = true;
                        }
                        else {
                            ddbDisplayFormat.Enabled = false;
                            ddpDataSize.Enabled = false;
                        }
                    }
                    else {
                        ddbDisplayFormat.Enabled = false;
                        ddpDataSize.Enabled = false;
                    }
                }
                catch {
                    ddbDisplayFormat.Enabled = false;
                    ddpDataSize.Enabled = false;
                }
            }
        }
        public void GetIndexFromForm(ToolWindows.ModbusRegister? RegisterEditor) {
            if (RegisterEditor == null) { SnapshotCurrentIndex = -1; return; }
            int Index = 0;
            if (mdiClient.ChildForms.Count <= 0) { SnapshotCurrentIndex = -1; }
            foreach (Components.MdiClientForm Frm in mdiClient.ChildForms) {
                if (Frm.GetType() == typeof(ToolWindows.ModbusRegister)) {
                    if (((ToolWindows.ModbusRegister)Frm).ID == RegisterEditor.ID) {
                        SnapshotCurrentIndex = Index; break;
                    }
                }
                Index++;
            }
        }
        public void GetIndexFromForm() {
            int Index = 0;
            if (mdiClient.ChildForms.Count <= 0) { SnapshotCurrentIndex = -1; }
            SnapshotCurrentIndex = mdiClient.ChildForms.Count - 1;
        }
        private void ModbusRegisters_Load(object sender, EventArgs e) {
            //if (Attached != null) {
            //    if (Attached.GetType() == typeof(Form1)) {
            //        ((Form1)Attached).
            //    }
            //}
            btnApplyOnClick.Checked = ModbusSupport.SendOnChange;
            btnModbusApplyonClick.Checked = ModbusSupport.SendOnChange;
            AdjustUserInterface();
            ShowHideColumns();
            EnumManager.LoadDataFormats(cmDisplayFormats, CmDisplayFormat_Click);
            EnumManager.LoadDataSizes(cmDataSize, CmDisplaySize_Click);
            EnumManager.LoadDataFormats(ddbDisplayFormat, CmDisplayFormatList_Click);
            EnumManager.LoadDataSizes(ddpDataSize, CmDisplaySizeList_Click);
            RecolorAll();
            AddIcons();
            SystemManager.ChannelAdded += SystemManager_ChannelAdded;
            SystemManager.ChannelRemoved += SystemManager_ChannelRemoved;
            SystemManager.ChannelRenamed += SystemManager_ChannelRenamed;
            SystemManager.ModbusReceived += SystemManager_ModbusReceived;
            SystemManager.ModbusRegisterRenamed += SystemManager_ModbusRegisterRenamed;
            ProjectManager.DocumentLoaded += ProjectManager_DocumentLoaded;
            SystemManager.ModbusPropertyChanged += SystemManager_ModbusPropertyChanged;
            SystemManager.ChannelPropertyChanged += SystemManager_ChannelPropertyChanged;
            ModbusSupport.SnapshotClosed += ModbusSupport_SnapshotClosed;

            navigator1.LinkedList = SystemManager.SerialManagers;
            navigator1.SelectedItem = 0;
            navigator1.Invalidate();
            try {
                CurrentManager = SystemManager.SerialManagers[0];
            }
            catch { }
            if (DesignerSetup.IsWindows10OrGreater() == true) {
                DesignerSetup.UseImmersiveDarkMode(this.Handle, true);
            }
            LoadRegisters();

            mdiClient.MdiForm.MainMenuStrip = msMain;
            LoadForms();
        }

        private void SystemManager_ChannelPropertyChanged(SerialManager sender) {
            CurrentEditorView = currentEditorView;
        }

        private void AdjustUserInterface() {
            msMain.Padding = DesignerSetup.ScalePadding(msMain.Padding);
            tsMain.Padding = DesignerSetup.ScalePadding(tsMain.Padding);
            cmDataSize.Padding = DesignerSetup.ScalePadding(cmDataSize.Padding);
            cmDisplayFormats.Padding = DesignerSetup.ScalePadding(cmDisplayFormats.Padding);
            cmMonitor.Padding = DesignerSetup.ScalePadding(cmMonitor.Padding);
            lstMonitor.ScaleColumnWidths();
            //navigator1.Width = DesignerSetup.ScaleInteger(navigator1.Width);
        }
        private void CmDisplayFormatList_Click(object? sender, EventArgs e) {
            if (currentEditorView == DataEditor.MasterView) {
                ModbusEditor.ChangeDisplayFormatList(sender, lstMonitor);
            }
            else {
                if (mdiClient.ChildForms[SnapshotCurrentIndex].GetType() == typeof(ToolWindows.ModbusRegister)) {
                    ModbusEditor.ChangeDisplayFormatList(sender, ((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).lstRegisters);
                }
            }

        }
        private void CmDisplaySizeList_Click(object? sender, EventArgs e) {
            if (currentEditorView == DataEditor.MasterView) {
                ModbusEditor.ChangeSizeList(sender, lstMonitor);
            }
            else {
                if (mdiClient.ChildForms[SnapshotCurrentIndex].GetType() == typeof(ToolWindows.ModbusRegister)) {
                    ModbusEditor.ChangeSizeList(sender, ((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).lstRegisters);
                }
            }
        }
        private void CmDisplayFormat_Click(object? sender, EventArgs e) {
            object? ButtonData = ModbusEditor.GetContextMenuItemData(sender);
            object? Data = ModbusEditor.GetContextMenuData(sender);
            if (Data == null) { return; }
            if (ButtonData == null) { return; }
            if (ButtonData.GetType()! != typeof(ModbusEnums.DataFormat)) { return; }
            DataFormat Frmt = (DataFormat)ButtonData;
            if (Data.GetType() == typeof(DropDownClickedEventArgs)) {
                DropDownClickedEventArgs Args = (DropDownClickedEventArgs)Data;
                if (Args.ParentItem == null) { return; }
                if (Args.ParentItem.Tag == null) { return; }
                if (Args.ParentItem.Tag.GetType() == typeof(ModbusRegister)) {
                    ModbusRegister Reg = (ModbusRegister)Args.ParentItem.Tag;
                    Reg.Format = Frmt;
                    Args.ParentItem[Args.Column].Text = EnumManager.DataFormatToString(Reg.Format).A;
                    Args.ParentItem[ModbusEditor.Indx_Size].Text = EnumManager.DataSizeToString(Reg.Size);
                    Args.ParentItem[ModbusEditor.Indx_Value].Text = Reg.FormattedValue;
                    ModbusEditor.RetroactivelyApplyFormatChanges(Args.Item, lstMonitor);
                    lstMonitor.Invalidate();
                }
            }
        }
        private void CmDisplaySize_Click(object? sender, EventArgs e) {
            object? ButtonData = ModbusEditor.GetContextMenuItemData(sender);
            object? Data = ModbusEditor.GetContextMenuData(sender);
            if (Data == null) { return; }
            if (ButtonData == null) { return; }
            if (ButtonData.GetType()! != typeof(ModbusEnums.DataSize)) { return; }
            DataSize Frmt = (DataSize)ButtonData;
            if (Data.GetType() == typeof(DropDownClickedEventArgs)) {
                DropDownClickedEventArgs Args = (DropDownClickedEventArgs)Data;
                if (Args.ParentItem == null) { return; }
                if (Args.ParentItem.Tag == null) { return; }
                if (Args.ParentItem.Tag.GetType() == typeof(ModbusRegister)) {
                    ModbusRegister Reg = (ModbusRegister)Args.ParentItem.Tag;
                    Reg.Size = Frmt;
                    Args.ParentItem[Args.Column].Text = EnumManager.DataSizeToString(Reg.Size);
                    Args.ParentItem[ModbusEditor.Indx_Display].Text = EnumManager.DataFormatToString(Reg.Format).A;
                    Args.ParentItem[ModbusEditor.Indx_Value].Text = Reg.FormattedValue;
                    ModbusEditor.RetroactivelyApplyFormatChanges(Args.Item, lstMonitor);
                    lstMonitor.Invalidate();
                }
            }
        }

        private void LoadForms() {
            foreach (ModbusSnapshot Snap in ModbusSupport.Snapshots) {
                ToolWindows.ModbusRegister frm = new ToolWindows.ModbusRegister(Snap, true);
                mdiClient.AddChild(frm);
            }
        }
        private void SystemManager_ModbusPropertyChanged(SerialManager parentManager, object Data, int Index, DataSelection DataType) {
            // lstRegisters.ExternalItems[Index]
            if (CurrentManager == null) { return; }
            if (CurrentManager.ID != parentManager.ID) { return; }
            try {
                if (lstMonitor.Items[Index].SubItems.Count <= ModbusEditor.Indx_Value) {
                    switch (dataSet) {
                        case DataSelection.ModbusDataCoils:
                            lstMonitor.Items[Index][ModbusEditor.Indx_Value].Text = CurrentManager.Coils[Index].Value.ToString();
                            break;
                        case DataSelection.ModbusDataDiscreteInputs:
                            lstMonitor.Items[Index][ModbusEditor.Indx_Value].Text = CurrentManager.DiscreteInputs[Index].Value.ToString();
                            break;
                        case DataSelection.ModbusDataInputRegisters:
                            lstMonitor.Items[Index][ModbusEditor.Indx_Display].Text = EnumManager.DataFormatToString(CurrentManager.InputRegisters[Index].Format).A;
                            lstMonitor.Items[Index][ModbusEditor.Indx_Size].Text = EnumManager.DataSizeToString(CurrentManager.InputRegisters[Index].Size);
                            lstMonitor.Items[Index][ModbusEditor.Indx_Signed].Checked = CurrentManager.InputRegisters[Index].Signed;
                            lstMonitor.Items[Index][ModbusEditor.Indx_Value].Text = CurrentManager.InputRegisters[Index].FormattedValue;
                            break;
                        case DataSelection.ModbusDataHoldingRegisters:
                            lstMonitor.Items[Index][ModbusEditor.Indx_Display].Text = EnumManager.DataFormatToString(CurrentManager.HoldingRegisters[Index].Format).A;
                            lstMonitor.Items[Index][ModbusEditor.Indx_Size].Text = EnumManager.DataSizeToString(CurrentManager.HoldingRegisters[Index].Size);
                            lstMonitor.Items[Index][ModbusEditor.Indx_Signed].Checked = CurrentManager.HoldingRegisters[Index].Signed;
                            lstMonitor.Items[Index][ModbusEditor.Indx_Value].Text = CurrentManager.HoldingRegisters[Index].FormattedValue;
                            break;
                    }
                }
            }
            catch { }
            lstMonitor.Invalidate();
        }
        private void SystemManager_ModbusRegisterRenamed(SerialManager parentManager, object Data, int Index, DataSelection DataType) {
            if (Data == null) { return; }
            if (CurrentManager == null) { return; }
            if (CurrentManager.ID == parentManager.ID) {
                if (Data.GetType() == typeof(ModbusCoil)) {
                    if (DataSet == DataType) {
                        ModbusCoil DigitalData = (ModbusCoil)Data;
                        if (ItemInBounds(Index, 1)) {
                            lstMonitor.Items[Index][ModbusEditor.Indx_Name].Text = DigitalData.Name.ToString();
                        }
                    }
                }
                else if (Data.GetType() == typeof(ModbusRegister)) {
                    if (DataSet == DataType) {
                        ModbusRegister DigitalData = (ModbusRegister)Data;
                        if (ItemInBounds(Index, 1)) {
                            lstMonitor.Items[Index][ModbusEditor.Indx_Name].Text = DigitalData.Name.ToString();
                        }
                    }
                }
                navigator1.Invalidate();
            }
        }
        private void SystemManager_ChannelRenamed(SerialManager sender) {
            navigator1.Invalidate();

        }
        private void ProjectManager_DocumentLoaded() {
            navigator1.SelectedItem = 0;
            CurrentManager = SystemManager.SerialManagers[0];
            LoadRegisters();

            LoadForms();
        }
        #region Theme
        public void ApplyTheme() {

            RecolorAll();
            AddIcons();
        }
        private void RecolorAll() {
            ApplicationManager.IsDark = Properties.Settings.Default.THM_SET_IsDark;
            this.SuspendLayout();
            BackColor = Properties.Settings.Default.THM_COL_Editor;

            Classes.Theming.ThemeManager.ThemeControl(thDataPagesHeader);
            Classes.Theming.ThemeManager.ThemeControl(msMain);
            Classes.Theming.ThemeManager.ThemeControl(tsMain);
            Classes.Theming.ThemeManager.ThemeControl(lstMonitor);
            Classes.Theming.ThemeManager.ThemeControl(tbDataPages);
            Classes.Theming.ThemeManager.ThemeControl(navigator1);

            Classes.Theming.ThemeManager.ThemeControl(cmDataSize);
            Classes.Theming.ThemeManager.ThemeControl(cmDisplayFormats);
            Classes.Theming.ThemeManager.ThemeControl(cmMonitor);
            mdiClient.BackColor = Properties.Settings.Default.THM_COL_Editor;
            this.ResumeLayout();
        }
        #endregion
        bool LockedEditor = false;
        public void AddIcons() {
            DesignerSetup.LinkSVGtoControl(Properties.Resources.BooleanData, btnCoils, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));
            DesignerSetup.LinkSVGtoControl(Properties.Resources.BooleanData, btnDiscrete, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));
            DesignerSetup.LinkSVGtoControl(Properties.Resources.DomainType, btnHolding, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));
            DesignerSetup.LinkSVGtoControl(Properties.Resources.DomainType, btnInputRegisters, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));

            DesignerSetup.LinkSVGtoControl(Properties.Resources.BringForward, btnMenuTopMost, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));

            DesignerSetup.LinkSVGtoControl(Properties.Resources.NewItem, newToolStripMenuItem, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));

            DesignerSetup.LinkSVGtoControl(Properties.Resources.Copy, copyToolStripMenuItem, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));
            DesignerSetup.LinkSVGtoControl(Properties.Resources.Paste, pasteToolStripMenuItem, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));

            DesignerSetup.LinkSVGtoControl(Properties.Resources.NewDeploymentPackage_16x, newToolStripMenuItem1, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));

            //DesignerSetup.LinkSVGtoControl(Properties.Resources.SaveAs_16x, saveAsToolStripMenuItem, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));
            DesignerSetup.LinkSVGtoControl(Properties.Resources.Save_16x, saveToolStripMenuItem, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));
            DesignerSetup.LinkSVGtoControl(Properties.Resources.OpenFile_16x, openToolStripMenuItem, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));

            DesignerSetup.LinkSVGtoControl(Properties.Resources.ApplyCodeChanges, btnApplyOnClick, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));
            ChangeLockedIcon(LockedEditor);
        }
        private void SystemManager_ChannelAdded(int RemovedIndex) {
            navigator1.Invalidate();
        }
        private void SystemManager_ChannelRemoved(int RemovedIndex) {
            if (navigator1.SelectedItem >= navigator1.ItemCount) {
                navigator1.SelectedItem -= 1;
            }
            else {
                navigator1.Invalidate();
            }
        }
        private void ChangeLockedIcon(bool Input) {
            if (Input == true) {
                DesignerSetup.LinkSVGtoControl(Properties.Resources.Lock, btnLockEditor, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));
                btnLockEditor.Text = "Lock Editor";
            }
            else {
                DesignerSetup.LinkSVGtoControl(Properties.Resources.Unlock, btnLockEditor, DesignerSetup.GetSize(DesignerSetup.IconSize.Small));
                btnLockEditor.Text = "Unlock Editor";
            }
            btnModbusLockEditors.Checked = Input;
        }

        SerialManager? CurrentManager = null;

        private void ClearEditors() {
            foreach (Control ctrl in lstMonitor.Controls) {
                if (ctrl.GetType() == typeof(Components.EditValue)) {
                    ((Components.EditValue)ctrl).PushValue();
                }
            }
        }
        private void CheckModbusDataSelection() {
            string DataView = EnumManager.ModbusDataSelectionToString(DataSet).B;
            foreach (ToolStripItem Tsi in viewToolStripMenuItem.DropDownItems) {
                if (Tsi.Tag != null) {
                    string TagData = Tsi.Tag.ToString() ?? "";
                    if (TagData.StartsWith("mbType")) {
                        if (TagData == DataView) {
                            ((ToolStripMenuItem)Tsi).Checked = true;
                        }
                        else {
                            ((ToolStripMenuItem)Tsi).Checked = false;
                        }
                    }
                }
            }
        }
        private void navigator1_SelectedIndexChanged(object sender, int SelectedIndex) {
            if (SystemManager.SerialManagers.Count > 0) {
                if ((SelectedIndex >= 0) && (SelectedIndex < SystemManager.SerialManagers.Count)) {
                    CurrentManager = SystemManager.SerialManagers[SelectedIndex];
                    LoadRegisters();
                }
            }
        }
        private void ShowHideColumns() {
            if (showFormats == false) {
                lstMonitor.Columns[ModbusEditor.Indx_Size].Visible = false;
                lstMonitor.Columns[ModbusEditor.Indx_Signed].Visible = false;
                lstMonitor.Columns[ModbusEditor.Indx_Display].Visible = false;
                return;
            }
            else {
                lstMonitor.Columns[ModbusEditor.Indx_Display].Visible = true;
            }
            if (DataSet == DataSelection.ModbusDataCoils) {
                if (showFormats == true) {
                    lstMonitor.Columns[ModbusEditor.Indx_Size].Visible = false;
                    lstMonitor.Columns[ModbusEditor.Indx_Signed].Visible = false;
                }
            }
            else if (DataSet == DataSelection.ModbusDataDiscreteInputs) {
                if (showFormats == true) {
                    lstMonitor.Columns[ModbusEditor.Indx_Size].Visible = false;
                    lstMonitor.Columns[ModbusEditor.Indx_Signed].Visible = false;
                }
            }
            else if (DataSet == DataSelection.ModbusDataInputRegisters) {
                if (showFormats == true) {
                    lstMonitor.Columns[ModbusEditor.Indx_Size].Visible = true;
                    lstMonitor.Columns[ModbusEditor.Indx_Signed].Visible = true;
                }
            }
            else if (DataSet == DataSelection.ModbusDataHoldingRegisters) {
                if (showFormats == true) {
                    lstMonitor.Columns[ModbusEditor.Indx_Size].Visible = true;
                    lstMonitor.Columns[ModbusEditor.Indx_Signed].Visible = true;
                }
            }
        }
        private void LoadRegisters() {
            lstMonitor.LineRemoveAll();
            if (CurrentManager == null) { return; }
            if (DataSet == DataSelection.ModbusDataCoils) {
                foreach (ModbusCoil Coil in CurrentManager.Coils) {
                    AddMonitorItem(Coil);
                }
            }
            else if (DataSet == DataSelection.ModbusDataDiscreteInputs) {
                foreach (ModbusCoil Coil in CurrentManager.DiscreteInputs) {
                    AddMonitorItem(Coil);
                }
            }
            else if (DataSet == DataSelection.ModbusDataInputRegisters) {
                foreach (ModbusRegister Coil in CurrentManager.InputRegisters) {
                    AddMonitorItem(Coil);
                }
            }
            else if (DataSet == DataSelection.ModbusDataHoldingRegisters) {
                foreach (ModbusRegister Coil in CurrentManager.HoldingRegisters) {
                    AddMonitorItem(Coil);
                }
            }
            lstMonitor.Invalidate();
        }
        private void AddMonitorItem(ModbusCoil Coil) {
            ListItem PLi = new ListItem();
            PLi.Tag = Coil;
            ListSubItem CLi1 = new ListSubItem(Coil.Name);
            ListSubItem CLi2 = new ListSubItem("Boolean");
            ListSubItem CLi3 = new ListSubItem();
            ListSubItem CLi4 = new ListSubItem();
            ListSubItem CLi5 = new ListSubItem(Coil.Value.ToString());
            PLi.SubItems.Add(CLi1);
            PLi.SubItems.Add(CLi2);
            PLi.SubItems.Add(CLi3);
            PLi.SubItems.Add(CLi4);
            PLi.SubItems.Add(CLi5);
            lstMonitor.Items.Add(PLi);
        }
        private void AddMonitorItem(ModbusRegister Register) {
            ListItem PLi = new ListItem();
            PLi.Tag = Register;
            ListSubItem CLi1 = new ListSubItem(Register.Name);
            ListSubItem CLi2 = new ListSubItem(EnumManager.DataFormatToString(Register.Format).A);
            ListSubItem CLi3 = new ListSubItem(EnumManager.DataSizeToString(Register.Size));
            ListSubItem CLi4 = new ListSubItem(Register.Signed);
            ListSubItem CLi5 = new ListSubItem(Register.FormattedValue);
            PLi.SubItems.Add(CLi1);
            PLi.SubItems.Add(CLi2);
            PLi.SubItems.Add(CLi3);
            PLi.SubItems.Add(CLi4);
            PLi.SubItems.Add(CLi5);
            lstMonitor.Items.Add(PLi);
        }


        private void btnDiscrete_Click(object sender, EventArgs e) {
            DataSet = DataSelection.ModbusDataDiscreteInputs;
        }
        private void btnHolding_Click(object sender, EventArgs e) {
            DataSet = DataSelection.ModbusDataHoldingRegisters;
        }
        private void btnInputRegisters_Click(object sender, EventArgs e) {
            DataSet = DataSelection.ModbusDataInputRegisters;
        }
        private void btnCoils_Click(object sender, EventArgs e) {
            DataSet = DataSelection.ModbusDataCoils;
        }

        private void ModbusRegisters_FormClosing(object sender, FormClosingEventArgs e) {
            SystemManager.ChannelAdded -= SystemManager_ChannelAdded;
            SystemManager.ChannelRemoved -= SystemManager_ChannelRemoved;
            SystemManager.ChannelRenamed -= SystemManager_ChannelRenamed;
            SystemManager.ModbusReceived -= SystemManager_ModbusReceived;
            SystemManager.ModbusRegisterRenamed -= SystemManager_ModbusRegisterRenamed;
            ProjectManager.DocumentLoaded -= ProjectManager_DocumentLoaded;
            SystemManager.ModbusPropertyChanged -= SystemManager_ModbusPropertyChanged;
            SystemManager.ChannelPropertyChanged -= SystemManager_ChannelPropertyChanged;

            ModbusSupport.SnapshotClosed -= ModbusSupport_SnapshotClosed;

            EnumManager.ClearClickHandles(cmDisplayFormats, CmDisplayFormat_Click);
            EnumManager.ClearClickHandles(cmDataSize, CmDisplaySize_Click);
            EnumManager.ClearClickHandles(ddbDisplayFormat, CmDisplayFormatList_Click);
            EnumManager.ClearClickHandles(ddpDataSize, CmDisplaySizeList_Click);
            lstMonitor.LineRemoveAll();
            GC.Collect();
        }
        private void SystemManager_ModbusReceived(SerialManager parentManager, object Data, int Index, DataSelection DataType) {
            if (Data == null) { return; }
            if (CurrentManager == null) { return; }
            if (CurrentManager.ID == parentManager.ID) {
                if (Data.GetType() == typeof(ModbusCoil)) {
                    if (DataSet == DataType) {
                        ModbusCoil DigitalData = (ModbusCoil)Data;
                        if (ItemInBounds(Index, ModbusEditor.Indx_Value)) {
                            lstMonitor.Items[Index][ModbusEditor.Indx_Value].Text = DigitalData.Value.ToString();
                        }
                    }
                }
                else if (Data.GetType() == typeof(ModbusRegister)) {
                    if (DataSet == DataType) {
                        ModbusRegister DigitalData = (ModbusRegister)Data;
                        if (ItemInBounds(Index, ModbusEditor.Indx_Value)) {
                            lstMonitor.Items[Index][ModbusEditor.Indx_Value].Text = DigitalData.FormattedValue;
                        }
                    }
                }
                lstMonitor.Invalidate();
            }
        }
        private bool ItemInBounds(int Index, uint Column) {
            if (Index < 0) { return false; }
            if (lstMonitor.Items.Count > 0) {
                if (Index < lstMonitor.Items.Count) {
                    if (Column == 0) {
                        return true;
                    }
                    else {
                        if (lstMonitor.Items[Index].SubItems.Count > 0) {
                            if (lstMonitor.Items[Index].SubItems.Count > Column - 1) {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        Point LastPoint = Point.Empty;

        private void EdVal_ArrowKeyPress(bool IsUp) {
            if (IsUp == false) {

            }
        }

        bool ApplyOnClick = false;
        private void lstMonitor_ItemCheckedChanged(object sender, ItemCheckedChangeEventArgs e) {
            ListItem? LstItem = e.ParentItem;
            if (LstItem == null) { return; }
            object? DataTag = LstItem.Tag;
            if (DataTag == null) { return; }
            if (e.Column == ModbusEditor.Indx_Signed) {
                if (DataTag.GetType() == typeof(ModbusRegister)) {
                    ModbusRegister Reg = (ModbusRegister)DataTag;
                    Reg.Signed = e.Checked;
                    LstItem[ModbusEditor.Indx_Value].Text = Reg.FormattedValue;
                    lstMonitor.Invalidate();
                }
            }
        }
        private void lstMonitor_DropDownClicked(object sender, DropDownClickedEventArgs e) {
            ListItem? LstItem = e.ParentItem;
            if (LstItem == null) { return; }
            object? DataTag = LstItem.Tag;
            if (DataTag == null) { return; }
            if (LstItem.SubItems.Count < 5) { return; }
            if (e.Column == ModbusEditor.Indx_Name) {
                //AddRenameBox(e, lstMonitor);
                ModbusEditor.AddRenameBox(e, lstMonitor, DataSet, EdVal_ArrowKeyPress);
            }
            else if (e.Column == ModbusEditor.Indx_Display) {
                if (DataTag.GetType() == typeof(ModbusRegister)) {
                    ModbusEditor.CheckItem(cmDisplayFormats, ((ModbusRegister)DataTag).Format);
                    cmDisplayFormats.Tag = e;
                    cmDisplayFormats.Show(ModbusEditor.AddPoint(e));
                }
            }
            else if (e.Column == ModbusEditor.Indx_Size) {
                if (DataTag.GetType() == typeof(ModbusRegister)) {
                    ModbusEditor.CheckItem(cmDataSize, ((ModbusRegister)DataTag).Size);
                    cmDataSize.Tag = e;
                    cmDataSize.Show(ModbusEditor.AddPoint(e));
                }
            }
            else if (e.Column == ModbusEditor.Indx_Value) {
                if (LockedEditor == true) { return; }
                if (DataTag.GetType() == typeof(ModbusCoil)) {
                    ModbusCoil coil = (ModbusCoil)DataTag;
                    if (ModbusEditor.CanChangeValue(CurrentManager, coil.ComponentType) == false) { return; }
                    coil.Value = !coil.Value;

                    LstItem[ModbusEditor.Indx_Value].Text = coil.Value.ToString();
                    if (ModbusSupport.SendOnChange == false) { return; }
                    SystemManager.SendModbusCommand(CurrentManager, DataSet, "Write Coil " + e.Item.ToString() + " = " + coil.Value.ToString());
                }
                else if (DataTag.GetType() == typeof(ModbusRegister)) {
                    if (ModbusEditor.CanChangeValue(CurrentManager, ((ModbusRegister)DataTag).ComponentType) == false) { return; }
                    ModbusEditor.AddValueBox(e, lstMonitor, DataSet, EdVal_ArrowKeyPress);
                }
            }
            lstMonitor.Invalidate();
        }



        private void btnApplyOnClick_Click(object sender, EventArgs e) {
            btnApplyOnClick.Checked = !btnApplyOnClick.Checked;
            btnModbusApplyonClick.Checked = btnApplyOnClick.Checked;
            ModbusSupport.SendOnChange = btnModbusApplyonClick.Checked;
        }
        private void btnModbusApplyonClick_Click(object sender, EventArgs e) {
            btnModbusApplyonClick.Checked = !btnModbusApplyonClick.Checked;
            btnApplyOnClick.Checked = btnModbusApplyonClick.Checked;
            ModbusSupport.SendOnChange = btnModbusApplyonClick.Checked;
        }
        private void btnModbusLockEditors_Click(object sender, EventArgs e) {
            UnlockLockEditors();
        }
        private void btnLockEditor_Click(object sender, EventArgs e) {
            UnlockLockEditors();
        }
        private void UnlockLockEditors() {
            if (CurrentEditorView == DataEditor.MasterView) {
                LockedEditor = !LockedEditor;
                ChangeLockedIcon(LockedEditor);
            }
            else {
                try {
                    if (mdiClient.ChildForms[SnapshotCurrentIndex].GetType() == typeof(ToolWindows.ModbusRegister)) {
                        bool FormatsVisable = ((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).Locked;
                        ((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).Locked = !FormatsVisable;
                        ChangeLockedIcon(((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).Locked);
                    }
                }
                catch { }
            }
            CurrentEditorView = currentEditorView;
        }
        private void ChangeLockView() {
            if (CurrentEditorView == DataEditor.MasterView) {
                btnLockEditor.Enabled = true;
                btnModbusLockEditors.Enabled = true;
                ChangeLockedIcon(LockedEditor);
            }
            else {
                try {
                    if (SnapshotCurrentIndex >= 0) {
                        if (mdiClient.ChildForms[SnapshotCurrentIndex].GetType() == typeof(ToolWindows.ModbusRegister)) {
                            ChangeLockedIcon(((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).Locked);
                        }
                        btnLockEditor.Enabled = true;
                        btnModbusLockEditors.Enabled = true;
                    }
                    else {
                        btnLockEditor.Enabled = false;
                        btnModbusLockEditors.Enabled = false;
                    }
                }
                catch { }
            }
        }
        private void ModbusRegisters_VisibleChanged(object sender, EventArgs e) {
            Classes.ApplicationManager.InvokeApplicationEvent();
        }
        private void ModbusRegisters_SizeChanged(object sender, EventArgs e) {
            Classes.ApplicationManager.InvokeApplicationEvent();
        }
        private void ModbusRegisters_FormClosed(object sender, FormClosedEventArgs e) {
            Classes.ApplicationManager.InvokeApplicationEvent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void viewCoilsToolStripMenuItem_Click(object sender, EventArgs e) {
            DataSet = DataSelection.ModbusDataCoils;
        }
        private void viewDiscreteInputsToolStripMenuItem_Click(object sender, EventArgs e) {
            DataSet = DataSelection.ModbusDataDiscreteInputs;
        }
        private void viewHoldingRegistersToolStripMenuItem_Click(object sender, EventArgs e) {
            DataSet = DataSelection.ModbusDataHoldingRegisters;
        }
        private void viewInputRegistersToolStripMenuItem_Click(object sender, EventArgs e) {
            DataSet = DataSelection.ModbusDataInputRegisters;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
            Settings ConfigApp = new Settings();
            ApplicationManager.OpenInternalApplicationOnce(ConfigApp, true);
        }


        private void TopMostSetting() {
            btnTopMost.Checked = !btnTopMost.Checked;
            btnMenuTopMost.Checked = !btnMenuTopMost.Checked;
            this.TopMost = !this.TopMost;
        }

        private void btnMenuTopMost_Click(object sender, EventArgs e) {
            TopMostSetting();
        }
        private void windowTopMostToolStripMenuItem_Click(object sender, EventArgs e) {
            TopMostSetting();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            Dialogs.InsertModbusSnapshot InsSnap = new Dialogs.InsertModbusSnapshot();
            // PrgProp.SelectedProgram = (ProgramObject)lstStepProgram.Tag;
            ApplicationManager.OpenInternalApplicationAsDialog(InsSnap, this);
            if (InsSnap.DialogResult == DialogResult.OK) {
                if (InsSnap.Manager != null) {
                    ToolWindows.ModbusRegister frm = ModbusSupport.NewSnapshotForm(InsSnap.DisplayName, InsSnap.Manager, InsSnap.DataSet, InsSnap.Address, InsSnap.Quantity);
                    mdiClient.AddChild(frm);
                }
            }

        }
        private void windowManagerToolStripMenuItem_Click(object sender, EventArgs e) {
            WindowForms.WindowManager WindowMan = new WindowForms.WindowManager();
            Classes.ApplicationManager.OpenInternalApplicationOnce(WindowMan, true);
        }

        private void snapshotSelectionToolStripMenuItem_Click(object sender, EventArgs e) {
            AddSelectionToSnapshot();
        }
        private void addSelectionToSnapshotToolStripMenuItem_Click(object sender, EventArgs e) {
            AddSelectionToSnapshot();
        }
        private void AddSelectionToSnapshot() {
            if (CurrentManager == null) { return; }
            if (lstMonitor.SelectedItems() >= 1) {
                int Address = lstMonitor.SelectedIndex;
                int Count = lstMonitor.SelectedItems();
                bool IsConcurrent = true;
                int ItemCount = 0;
                bool LastSelectionStatus = true;
                List<int> Values = new List<int>();
                for (int i = Address; i < lstMonitor.Items.Count; i++) {
                    if (LastSelectionStatus != lstMonitor.Items[i].Selected) {
                        IsConcurrent = false;
                    }
                    if (lstMonitor.Items[i].Selected == true) {
                        ItemCount++;
                        LastSelectionStatus = true;
                        Values.Add(i);
                    }
                    else {
                        LastSelectionStatus = false;
                    }
                    if (ItemCount >= Count) {
                        break;
                    }
                }
                if (IsConcurrent) {
                    ToolWindows.ModbusRegister frm = ModbusSupport.NewSnapshotForm("", CurrentManager, DataSet, Address, Count);
                    mdiClient.AddChild(frm);
                }
                else {
                    if (Values.Count > 0) {
                        ToolWindows.ModbusRegister frm = ModbusSupport.NewSnapshotForm("", CurrentManager, DataSet, Values);
                        mdiClient.AddChild(frm);
                    }
                }

            }

        }

        private void showFormatsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (currentEditorView == DataEditor.MasterView) {
                ShowFormats = !ShowFormats;
            }
            else if (currentEditorView == DataEditor.SnapshotView) {
                try {
                    if (mdiClient.ChildForms[SnapshotCurrentIndex].GetType() == typeof(ToolWindows.ModbusRegister)) {
                        bool FormatsVisable = ((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).ShowFormats;
                        ((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).ShowFormats = !FormatsVisable;
                        CurrentEditorView = currentEditorView;
                    }
                }
                catch { }
            }
        }

        private void btnViewMaster_Click(object sender, EventArgs e) {
            thDataPagesHeader.SelectedIndex = 0;
        }
        private void btnViewSnapshot_Click(object sender, EventArgs e) {
            thDataPagesHeader.SelectedIndex = 1;
        }

        private void thDataPagesHeader_SelectedIndexChanged(object sender, int CurrentIndex, int PreviousIndex) {
            if (CurrentIndex == 0) {
                CurrentEditorView = DataEditor.MasterView;
            }
            else if (CurrentIndex == 1) {
                CurrentEditorView = DataEditor.SnapshotView;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ProgramManager.MainInstance == null) { return; }
            ProgramManager.MainInstance.OpenFileViaDialog();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ProgramManager.MainInstance == null) { return; }
            ProgramManager.MainInstance.Save();
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ProgramManager.MainInstance == null) { return; }
            ProgramManager.MainInstance.Save(true);
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e) {
            if (ProgramManager.MainInstance == null) { return; }
            ProgramManager.MainInstance.New();
        }
        private enum DataEditor {
            MasterView = 0x00,
            SnapshotView = 0x01
        }

        private void mdiClient_OnChildActivated(object sender, MdiClientForm child) {
            if (child.GetType() == typeof(ToolWindows.ModbusRegister)) {
                GetIndexFromForm((ToolWindows.ModbusRegister)child);
            }
        }
        private void ModbusSupport_SnapshotClosed() {
            GetIndexFromForm();
        }
        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            mdiClient.TileWindows = !mdiClient.TileWindows;
            tileHorizontalToolStripMenuItem.Checked = !tileHorizontalToolStripMenuItem.Checked;
        }
        private void Reset() {
            ModbusClipboardFlags Flags = ModbusClipboardFlags.IncludeNothing;
            Flags |= ModbusClipboardFlags.IncludeName;
            Flags |= ModbusClipboardFlags.IncludeFormat;
            Flags |= ModbusClipboardFlags.IncludeSize;
            Flags |= ModbusClipboardFlags.IncludeValue;
            if (currentEditorView == DataEditor.MasterView) {
                ModbusEditor.Reset(lstMonitor, Flags);
            }
            else {
                try {

                    if (mdiClient.ChildForms[SnapshotCurrentIndex].GetType() == typeof(ToolWindows.ModbusRegister)) {
                        ModbusEditor.Reset(((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).lstRegisters, Flags);
                    }
                }
                catch { }
            }
        }
        private void Copy() {
            ModbusClipboardFlags Flags = ModbusClipboardFlags.IncludeNothing;
            Flags |= ModbusClipboardFlags.IncludeName;
            Flags |= ModbusClipboardFlags.IncludeFormat;
            Flags |= ModbusClipboardFlags.IncludeSize;
            Flags |= ModbusClipboardFlags.IncludeValue;
            CopyWithFlags(Flags);
        }
        private void CopyWithFlags(ModbusClipboardFlags Flags) {
            if (currentEditorView == DataEditor.MasterView) {
                ModbusEditor.CopyRegisters(lstMonitor, Flags);
            }
            else {
                try {
                    if (mdiClient.ChildForms[SnapshotCurrentIndex].GetType() == typeof(ToolWindows.ModbusRegister)) {
                        ModbusEditor.CopyRegisters(((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).lstRegisters, Flags);
                    }
                }
                catch { }
            }
        }
        private void Paste() {
            if (currentEditorView == DataEditor.MasterView) {
                ModbusEditor.PasteRegisters(lstMonitor);
            }
            else {
                try {
                    if (mdiClient.ChildForms[SnapshotCurrentIndex].GetType() == typeof(ToolWindows.ModbusRegister)) {
                        ModbusEditor.PasteRegisters(((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).lstRegisters);
                    }
                }
                catch { }
            }
        }
        private void CopyAsText() {
            if (currentEditorView == DataEditor.MasterView) {
                ModbusEditor.CopyRegistersAsText(lstMonitor);
            }
            else {
                try {
                    if (mdiClient.ChildForms[SnapshotCurrentIndex].GetType() == typeof(ToolWindows.ModbusRegister)) {
                        ModbusEditor.CopyRegistersAsText(((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).lstRegisters);
                    }
                }
                catch { }
            }
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            Copy();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
            Paste();
        }
        private void copyAsTextToolStripMenuItem_Click(object sender, EventArgs e) {
            CopyAsText();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e) {
            Copy();
        }
        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e) {
            Paste();
        }
        private void resetToolStripMenuItem_Click(object sender, EventArgs e) {
            Reset();
        }
        private void copyNamesToolStripMenuItem_Click(object sender, EventArgs e) {
            ModbusClipboardFlags Flags = ModbusClipboardFlags.IncludeName;
            CopyWithFlags(Flags);
        }
        private void copyFormatsToolStripMenuItem_Click(object sender, EventArgs e) {
            ModbusClipboardFlags Flags = ModbusClipboardFlags.IncludeNothing;
            Flags |= ModbusClipboardFlags.IncludeFormat;
            Flags |= ModbusClipboardFlags.IncludeSize;
            CopyWithFlags(Flags);
        }
        private void copyValuesToolStripMenuItem_Click(object sender, EventArgs e) {
            ModbusClipboardFlags Flags = ModbusClipboardFlags.IncludeValue;
            CopyWithFlags(Flags);
        }

        private void goToToolStripMenuItem1_Click(object sender, EventArgs e) {
            Dialogs.GoTo GoToAddress = new Dialogs.GoTo();
            GoToAddress.IsNumeric = true;
            if (ApplicationManager.OpenInternalApplicationAsDialog(GoToAddress, this) == DialogResult.OK) {
                lstMonitor.VerScroll = GoToAddress.Address;
            }
        }
        private void goToRegisterToolStripMenuItem_Click(object sender, EventArgs e) {
            if (lstMonitor.CurrentItems.Count <= 0) { return; }
            Dialogs.GoTo GoToRegister = new Dialogs.GoTo();
            GoToRegister.IsNumeric = false;
            if (ApplicationManager.OpenInternalApplicationAsDialog(GoToRegister, this) == DialogResult.OK) {
                int Marked = -1;
                string Temp = GoToRegister.GoToText;
                for (int i = 0; i < lstMonitor.CurrentItems.Count; i++) {
                    object? DataTag = lstMonitor.CurrentItems[i].Tag;
                    if (DataTag != null) {
                        if (DataTag.GetType() == typeof(Classes.Modbus.ModbusCoil)) {
                            if (((Classes.Modbus.ModbusCoil)DataTag).Name == Temp) {
                                Marked = i;
                                break;
                            }
                        }
                        else if (DataTag.GetType() == typeof(Classes.Modbus.ModbusRegister)) {
                            if (((Classes.Modbus.ModbusRegister)DataTag).Name == Temp) {
                                Marked = i;
                                break;
                            }
                        }
                    }
                }
                if (Marked >= 0) {
                    lstMonitor.VerScroll = Marked;
                }
            }
        }

        private void writeCoilToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                if (currentEditorView == DataEditor.MasterView) {
                    if (CurrentManager == null) { return; }
                    if (CurrentManager.IsMaster == false) { return; }
                    Dialogs.WriteCoil CmdWrite = new Dialogs.WriteCoil(CurrentManager);
                    ApplicationManager.OpenInternalApplicationAsDialog(CmdWrite, this);

                }
                else {
                    if (mdiClient.ChildForms[SnapshotCurrentIndex].GetType() == typeof(ToolWindows.ModbusRegister)) {
                        SerialManager? SerMan = ((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).Snapshot.Manager;
                        if (SerMan == null) { return; }
                        if (SerMan.IsMaster == false) { return; }
                        Dialogs.WriteCoil CmdWrite = new Dialogs.WriteCoil(SerMan);
                        ApplicationManager.OpenInternalApplicationAsDialog(CmdWrite, this);
                    }
                }
            }
            catch { }
        }

        private void writeRegisterToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                if (currentEditorView == DataEditor.MasterView) {
                    if (CurrentManager == null) { return; }
                    if (CurrentManager.IsMaster == false) { return; }
                    Dialogs.WriteRegister CmdWrite = new Dialogs.WriteRegister(CurrentManager);
                    ApplicationManager.OpenInternalApplicationAsDialog(CmdWrite, this);

                }
                else {
                    if (mdiClient.ChildForms[SnapshotCurrentIndex].GetType() == typeof(ToolWindows.ModbusRegister)) {
                        SerialManager? SerMan = ((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).Snapshot.Manager;
                        if (SerMan == null) { return; }
                        if (SerMan.IsMaster == false) { return; }
                        Dialogs.WriteRegister CmdWrite = new Dialogs.WriteRegister(SerMan);
                        ApplicationManager.OpenInternalApplicationAsDialog(CmdWrite, this);
                    }
                }
            }
            catch { }
        }

        private void btnMenuModbusMaster_Click(object sender, EventArgs e) {
            try {
                if (currentEditorView == DataEditor.MasterView) {
                    if (CurrentManager == null) { return; }
                    CurrentManager.IsMaster = !CurrentManager.IsMaster;
                    btnMenuModbusMaster.Checked = CurrentManager.IsMaster;

                }
                else {
                    if (mdiClient.ChildForms[SnapshotCurrentIndex].GetType() == typeof(ToolWindows.ModbusRegister)) {
                        SerialManager? SerMan = ((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).Snapshot.Manager;
                        if (SerMan == null) { return; }
                        SerMan.IsMaster = !SerMan.IsMaster;
                        btnMenuModbusMaster.Checked = SerMan.IsMaster;
                    }
                }
            }
            catch { }
        }

        private void setIOFormatsToModbusRTUToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                if (currentEditorView == DataEditor.MasterView) {
                    if (CurrentManager == null) { return; }
                    CurrentManager.InputFormat = FormatEnums.StreamInputFormat.ModbusRTU;
                    CurrentManager.OutputFormat = FormatEnums.StreamOutputFormat.ModbusRTU;

                }
                else {
                    if (mdiClient.ChildForms[SnapshotCurrentIndex].GetType() == typeof(ToolWindows.ModbusRegister)) {
                        SerialManager? SerMan = ((ToolWindows.ModbusRegister)mdiClient.ChildForms[SnapshotCurrentIndex]).Snapshot.Manager;
                        if (SerMan == null) { return; }
                        SerMan.InputFormat = FormatEnums.StreamInputFormat.ModbusRTU;
                        SerMan.OutputFormat = FormatEnums.StreamOutputFormat.ModbusRTU;
                    }
                }
            }
            catch { }
        }
    }
}
