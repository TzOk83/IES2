namespace IES_2
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.lblIsoCode = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblEcuType = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblRepCode = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCOM = new System.Windows.Forms.DataGridView();
            this.comCOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbCompat = new System.Windows.Forms.CheckBox();
            this.cbLOG = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvECU = new System.Windows.Forms.DataGridView();
            this.ecuECU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbHelp = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvParameters = new System.Windows.Forms.DataGridView();
            this.parChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbQueryErrors = new System.Windows.Forms.CheckBox();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvErrors = new System.Windows.Forms.DataGridView();
            this.errDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errMIL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cblTraces = new System.Windows.Forms.CheckedListBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnGraph = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAdjusts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAdj = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.bgwIsoWait = new System.ComponentModel.BackgroundWorker();
            this.bgwParameters = new System.ComponentModel.BackgroundWorker();
            this.bgwTest = new System.ComponentModel.BackgroundWorker();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.infoOptions = new System.Windows.Forms.Label();
            this.infoMessage = new System.Windows.Forms.Label();
            this.bgwDemo = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage0.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCOM)).BeginInit();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvECU)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameters)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjusts)).BeginInit();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AccessibleDescription = null;
            this.panel2.AccessibleName = null;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackgroundImage = null;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.lblIsoCode);
            this.panel2.Controls.Add(this.lblCarModel);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.lblEcuType);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.lblRepCode);
            this.panel2.Controls.Add(this.btnConnect);
            this.panel2.Name = "panel2";
            this.toolTip1.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
            // 
            // label24
            // 
            this.label24.AccessibleDescription = null;
            this.label24.AccessibleName = null;
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            this.toolTip1.SetToolTip(this.label24, resources.GetString("label24.ToolTip"));
            // 
            // lblIsoCode
            // 
            this.lblIsoCode.AccessibleDescription = null;
            this.lblIsoCode.AccessibleName = null;
            resources.ApplyResources(this.lblIsoCode, "lblIsoCode");
            this.lblIsoCode.Name = "lblIsoCode";
            this.toolTip1.SetToolTip(this.lblIsoCode, resources.GetString("lblIsoCode.ToolTip"));
            // 
            // lblCarModel
            // 
            this.lblCarModel.AccessibleDescription = null;
            this.lblCarModel.AccessibleName = null;
            resources.ApplyResources(this.lblCarModel, "lblCarModel");
            this.lblCarModel.Name = "lblCarModel";
            this.toolTip1.SetToolTip(this.lblCarModel, resources.GetString("lblCarModel.ToolTip"));
            // 
            // label20
            // 
            this.label20.AccessibleDescription = null;
            this.label20.AccessibleName = null;
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            this.toolTip1.SetToolTip(this.label20, resources.GetString("label20.ToolTip"));
            // 
            // label22
            // 
            this.label22.AccessibleDescription = null;
            this.label22.AccessibleName = null;
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            this.toolTip1.SetToolTip(this.label22, resources.GetString("label22.ToolTip"));
            // 
            // lblEcuType
            // 
            this.lblEcuType.AccessibleDescription = null;
            this.lblEcuType.AccessibleName = null;
            resources.ApplyResources(this.lblEcuType, "lblEcuType");
            this.lblEcuType.Name = "lblEcuType";
            this.toolTip1.SetToolTip(this.lblEcuType, resources.GetString("lblEcuType.ToolTip"));
            // 
            // label17
            // 
            this.label17.AccessibleDescription = null;
            this.label17.AccessibleName = null;
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            this.toolTip1.SetToolTip(this.label17, resources.GetString("label17.ToolTip"));
            // 
            // lblRepCode
            // 
            this.lblRepCode.AccessibleDescription = null;
            this.lblRepCode.AccessibleName = null;
            resources.ApplyResources(this.lblRepCode, "lblRepCode");
            this.lblRepCode.Name = "lblRepCode";
            this.toolTip1.SetToolTip(this.lblRepCode, resources.GetString("lblRepCode.ToolTip"));
            // 
            // btnConnect
            // 
            this.btnConnect.AccessibleDescription = null;
            this.btnConnect.AccessibleName = null;
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.BackgroundImage = null;
            this.btnConnect.ForeColor = System.Drawing.Color.Red;
            this.btnConnect.Name = "btnConnect";
            this.toolTip1.SetToolTip(this.btnConnect, resources.GetString("btnConnect.ToolTip"));
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = null;
            this.panel1.AccessibleName = null;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackgroundImage = null;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Font = null;
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = null;
            this.tabControl1.AccessibleName = null;
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.BackgroundImage = null;
            this.tabControl1.Controls.Add(this.tabPage0);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.toolTip1.SetToolTip(this.tabControl1, resources.GetString("tabControl1.ToolTip"));
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage0
            // 
            this.tabPage0.AccessibleDescription = null;
            this.tabPage0.AccessibleName = null;
            resources.ApplyResources(this.tabPage0, "tabPage0");
            this.tabPage0.BackgroundImage = null;
            this.tabPage0.Controls.Add(this.tableLayoutPanel4);
            this.tabPage0.Font = null;
            this.tabPage0.Name = "tabPage0";
            this.toolTip1.SetToolTip(this.tabPage0, resources.GetString("tabPage0.ToolTip"));
            this.tabPage0.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AccessibleDescription = null;
            this.tableLayoutPanel4.AccessibleName = null;
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.BackgroundImage = null;
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel4.Font = null;
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.toolTip1.SetToolTip(this.tableLayoutPanel4, resources.GetString("tableLayoutPanel4.ToolTip"));
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleDescription = null;
            this.groupBox2.AccessibleName = null;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackgroundImage = null;
            this.groupBox2.Controls.Add(this.tableLayoutPanel7);
            this.groupBox2.Font = null;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AccessibleDescription = null;
            this.tableLayoutPanel7.AccessibleName = null;
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.BackgroundImage = null;
            this.tableLayoutPanel7.Controls.Add(this.dgvCOM, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel7.Font = null;
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.toolTip1.SetToolTip(this.tableLayoutPanel7, resources.GetString("tableLayoutPanel7.ToolTip"));
            // 
            // dgvCOM
            // 
            this.dgvCOM.AccessibleDescription = null;
            this.dgvCOM.AccessibleName = null;
            this.dgvCOM.AllowUserToAddRows = false;
            this.dgvCOM.AllowUserToDeleteRows = false;
            this.dgvCOM.AllowUserToResizeColumns = false;
            this.dgvCOM.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgvCOM, "dgvCOM");
            this.dgvCOM.BackgroundImage = null;
            this.dgvCOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCOM.ColumnHeadersVisible = false;
            this.dgvCOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comCOM});
            this.dgvCOM.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCOM.Font = null;
            this.dgvCOM.MultiSelect = false;
            this.dgvCOM.Name = "dgvCOM";
            this.dgvCOM.ReadOnly = true;
            this.dgvCOM.RowHeadersVisible = false;
            this.dgvCOM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCOM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.dgvCOM, resources.GetString("dgvCOM.ToolTip"));
            this.dgvCOM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCOM_CellClick);
            // 
            // comCOM
            // 
            this.comCOM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.comCOM, "comCOM");
            this.comCOM.Name = "comCOM";
            this.comCOM.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.AccessibleDescription = null;
            this.panel7.AccessibleName = null;
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.BackgroundImage = null;
            this.panel7.Controls.Add(this.cbCompat);
            this.panel7.Controls.Add(this.cbLOG);
            this.panel7.Font = null;
            this.panel7.Name = "panel7";
            this.toolTip1.SetToolTip(this.panel7, resources.GetString("panel7.ToolTip"));
            // 
            // cbCompat
            // 
            this.cbCompat.AccessibleDescription = null;
            this.cbCompat.AccessibleName = null;
            resources.ApplyResources(this.cbCompat, "cbCompat");
            this.cbCompat.BackgroundImage = null;
            this.cbCompat.Font = null;
            this.cbCompat.Name = "cbCompat";
            this.toolTip1.SetToolTip(this.cbCompat, resources.GetString("cbCompat.ToolTip"));
            this.cbCompat.UseVisualStyleBackColor = true;
            this.cbCompat.CheckedChanged += new System.EventHandler(this.cbCompat_CheckedChanged);
            // 
            // cbLOG
            // 
            this.cbLOG.AccessibleDescription = null;
            this.cbLOG.AccessibleName = null;
            resources.ApplyResources(this.cbLOG, "cbLOG");
            this.cbLOG.BackgroundImage = null;
            this.cbLOG.Font = null;
            this.cbLOG.Name = "cbLOG";
            this.toolTip1.SetToolTip(this.cbLOG, resources.GetString("cbLOG.ToolTip"));
            this.cbLOG.UseVisualStyleBackColor = true;
            this.cbLOG.CheckedChanged += new System.EventHandler(this.cbLOG_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = null;
            this.groupBox1.AccessibleName = null;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackgroundImage = null;
            this.tableLayoutPanel4.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.dgvECU);
            this.groupBox1.Font = null;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // dgvECU
            // 
            this.dgvECU.AccessibleDescription = null;
            this.dgvECU.AccessibleName = null;
            this.dgvECU.AllowUserToAddRows = false;
            this.dgvECU.AllowUserToDeleteRows = false;
            this.dgvECU.AllowUserToResizeColumns = false;
            this.dgvECU.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgvECU, "dgvECU");
            this.dgvECU.BackgroundImage = null;
            this.dgvECU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvECU.ColumnHeadersVisible = false;
            this.dgvECU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ecuECU});
            this.dgvECU.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvECU.Font = null;
            this.dgvECU.MultiSelect = false;
            this.dgvECU.Name = "dgvECU";
            this.dgvECU.ReadOnly = true;
            this.dgvECU.RowHeadersVisible = false;
            this.dgvECU.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvECU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.dgvECU, resources.GetString("dgvECU.ToolTip"));
            // 
            // ecuECU
            // 
            this.ecuECU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.ecuECU, "ecuECU");
            this.ecuECU.Name = "ecuECU";
            this.ecuECU.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleDescription = null;
            this.groupBox3.AccessibleName = null;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackgroundImage = null;
            this.groupBox3.Controls.Add(this.tbHelp);
            this.groupBox3.Font = null;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // tbHelp
            // 
            this.tbHelp.AccessibleDescription = null;
            this.tbHelp.AccessibleName = null;
            resources.ApplyResources(this.tbHelp, "tbHelp");
            this.tbHelp.BackColor = System.Drawing.SystemColors.Window;
            this.tbHelp.BackgroundImage = null;
            this.tbHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHelp.Name = "tbHelp";
            this.tbHelp.ReadOnly = true;
            this.toolTip1.SetToolTip(this.tbHelp, resources.GetString("tbHelp.ToolTip"));
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleDescription = null;
            this.tabPage1.AccessibleName = null;
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.BackgroundImage = null;
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Font = null;
            this.tabPage1.Name = "tabPage1";
            this.toolTip1.SetToolTip(this.tabPage1, resources.GetString("tabPage1.ToolTip"));
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AccessibleDescription = null;
            this.tableLayoutPanel2.AccessibleName = null;
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.BackgroundImage = null;
            this.tableLayoutPanel2.Controls.Add(this.dgvParameters, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Font = null;
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.toolTip1.SetToolTip(this.tableLayoutPanel2, resources.GetString("tableLayoutPanel2.ToolTip"));
            // 
            // dgvParameters
            // 
            this.dgvParameters.AccessibleDescription = null;
            this.dgvParameters.AccessibleName = null;
            this.dgvParameters.AllowUserToAddRows = false;
            this.dgvParameters.AllowUserToDeleteRows = false;
            this.dgvParameters.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgvParameters, "dgvParameters");
            this.dgvParameters.BackgroundImage = null;
            this.dgvParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parChecked,
            this.parName,
            this.parValue,
            this.parUnit});
            this.dgvParameters.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvParameters.Font = null;
            this.dgvParameters.MultiSelect = false;
            this.dgvParameters.Name = "dgvParameters";
            this.dgvParameters.ReadOnly = true;
            this.dgvParameters.RowHeadersVisible = false;
            this.dgvParameters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.dgvParameters, resources.GetString("dgvParameters.ToolTip"));
            this.dgvParameters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParameters_CellClick);
            // 
            // parChecked
            // 
            resources.ApplyResources(this.parChecked, "parChecked");
            this.parChecked.Name = "parChecked";
            this.parChecked.ReadOnly = true;
            // 
            // parName
            // 
            this.parName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.parName, "parName");
            this.parName.Name = "parName";
            this.parName.ReadOnly = true;
            this.parName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // parValue
            // 
            resources.ApplyResources(this.parValue, "parValue");
            this.parValue.Name = "parValue";
            this.parValue.ReadOnly = true;
            this.parValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // parUnit
            // 
            resources.ApplyResources(this.parUnit, "parUnit");
            this.parUnit.Name = "parUnit";
            this.parUnit.ReadOnly = true;
            this.parUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel4
            // 
            this.panel4.AccessibleDescription = null;
            this.panel4.AccessibleName = null;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackgroundImage = null;
            this.panel4.Controls.Add(this.cbQueryErrors);
            this.panel4.Controls.Add(this.btnUncheckAll);
            this.panel4.Controls.Add(this.btnCheckAll);
            this.panel4.Font = null;
            this.panel4.Name = "panel4";
            this.toolTip1.SetToolTip(this.panel4, resources.GetString("panel4.ToolTip"));
            // 
            // cbQueryErrors
            // 
            this.cbQueryErrors.AccessibleDescription = null;
            this.cbQueryErrors.AccessibleName = null;
            resources.ApplyResources(this.cbQueryErrors, "cbQueryErrors");
            this.cbQueryErrors.BackgroundImage = null;
            this.cbQueryErrors.Font = null;
            this.cbQueryErrors.Name = "cbQueryErrors";
            this.toolTip1.SetToolTip(this.cbQueryErrors, resources.GetString("cbQueryErrors.ToolTip"));
            this.cbQueryErrors.UseVisualStyleBackColor = true;
            this.cbQueryErrors.CheckedChanged += new System.EventHandler(this.cbQueryErrors_CheckedChanged);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.AccessibleDescription = null;
            this.btnUncheckAll.AccessibleName = null;
            resources.ApplyResources(this.btnUncheckAll, "btnUncheckAll");
            this.btnUncheckAll.BackgroundImage = null;
            this.btnUncheckAll.Font = null;
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.toolTip1.SetToolTip(this.btnUncheckAll, resources.GetString("btnUncheckAll.ToolTip"));
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.AccessibleDescription = null;
            this.btnCheckAll.AccessibleName = null;
            resources.ApplyResources(this.btnCheckAll, "btnCheckAll");
            this.btnCheckAll.BackgroundImage = null;
            this.btnCheckAll.Font = null;
            this.btnCheckAll.Name = "btnCheckAll";
            this.toolTip1.SetToolTip(this.btnCheckAll, resources.GetString("btnCheckAll.ToolTip"));
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AccessibleDescription = null;
            this.tabPage2.AccessibleName = null;
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.BackgroundImage = null;
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Font = null;
            this.tabPage2.Name = "tabPage2";
            this.toolTip1.SetToolTip(this.tabPage2, resources.GetString("tabPage2.ToolTip"));
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AccessibleDescription = null;
            this.tableLayoutPanel3.AccessibleName = null;
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.BackgroundImage = null;
            this.tableLayoutPanel3.Controls.Add(this.dgvErrors, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel3.Font = null;
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.toolTip1.SetToolTip(this.tableLayoutPanel3, resources.GetString("tableLayoutPanel3.ToolTip"));
            // 
            // dgvErrors
            // 
            this.dgvErrors.AccessibleDescription = null;
            this.dgvErrors.AccessibleName = null;
            this.dgvErrors.AllowUserToAddRows = false;
            this.dgvErrors.AllowUserToDeleteRows = false;
            this.dgvErrors.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgvErrors, "dgvErrors");
            this.dgvErrors.BackgroundImage = null;
            this.dgvErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.errDescr,
            this.errReason,
            this.errState,
            this.errMIL});
            this.dgvErrors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvErrors.Font = null;
            this.dgvErrors.MultiSelect = false;
            this.dgvErrors.Name = "dgvErrors";
            this.dgvErrors.ReadOnly = true;
            this.dgvErrors.RowHeadersVisible = false;
            this.dgvErrors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.dgvErrors, resources.GetString("dgvErrors.ToolTip"));
            // 
            // errDescr
            // 
            this.errDescr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.errDescr.FillWeight = 65F;
            resources.ApplyResources(this.errDescr, "errDescr");
            this.errDescr.Name = "errDescr";
            this.errDescr.ReadOnly = true;
            this.errDescr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // errReason
            // 
            this.errReason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.errReason.FillWeight = 35F;
            resources.ApplyResources(this.errReason, "errReason");
            this.errReason.Name = "errReason";
            this.errReason.ReadOnly = true;
            this.errReason.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // errState
            // 
            resources.ApplyResources(this.errState, "errState");
            this.errState.Name = "errState";
            this.errState.ReadOnly = true;
            this.errState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // errMIL
            // 
            resources.ApplyResources(this.errMIL, "errMIL");
            this.errMIL.Name = "errMIL";
            this.errMIL.ReadOnly = true;
            this.errMIL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel5
            // 
            this.panel5.AccessibleDescription = null;
            this.panel5.AccessibleName = null;
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackgroundImage = null;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Font = null;
            this.panel5.Name = "panel5";
            this.toolTip1.SetToolTip(this.panel5, resources.GetString("panel5.ToolTip"));
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // btnClear
            // 
            this.btnClear.AccessibleDescription = null;
            this.btnClear.AccessibleName = null;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.BackgroundImage = null;
            this.btnClear.Font = null;
            this.btnClear.Name = "btnClear";
            this.toolTip1.SetToolTip(this.btnClear, resources.GetString("btnClear.ToolTip"));
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.AccessibleDescription = null;
            this.tabPage3.AccessibleName = null;
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.BackgroundImage = null;
            this.tabPage3.Controls.Add(this.tableLayoutPanel5);
            this.tabPage3.Font = null;
            this.tabPage3.Name = "tabPage3";
            this.toolTip1.SetToolTip(this.tabPage3, resources.GetString("tabPage3.ToolTip"));
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AccessibleDescription = null;
            this.tableLayoutPanel5.AccessibleName = null;
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.BackgroundImage = null;
            this.tableLayoutPanel5.Controls.Add(this.dgvTests, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel5.Font = null;
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.toolTip1.SetToolTip(this.tableLayoutPanel5, resources.GetString("tableLayoutPanel5.ToolTip"));
            // 
            // dgvTests
            // 
            this.dgvTests.AccessibleDescription = null;
            this.dgvTests.AccessibleName = null;
            this.dgvTests.AllowUserToAddRows = false;
            this.dgvTests.AllowUserToDeleteRows = false;
            this.dgvTests.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgvTests, "dgvTests");
            this.dgvTests.BackgroundImage = null;
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvTests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTests.Font = null;
            this.dgvTests.MultiSelect = false;
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.ReadOnly = true;
            this.dgvTests.RowHeadersVisible = false;
            this.dgvTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.dgvTests, resources.GetString("dgvTests.ToolTip"));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 65F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 35F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel3
            // 
            this.panel3.AccessibleDescription = null;
            this.panel3.AccessibleName = null;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackgroundImage = null;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnExecute);
            this.panel3.Font = null;
            this.panel3.Name = "panel3";
            this.toolTip1.SetToolTip(this.panel3, resources.GetString("panel3.ToolTip"));
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // btnExecute
            // 
            this.btnExecute.AccessibleDescription = null;
            this.btnExecute.AccessibleName = null;
            resources.ApplyResources(this.btnExecute, "btnExecute");
            this.btnExecute.BackgroundImage = null;
            this.btnExecute.Font = null;
            this.btnExecute.Name = "btnExecute";
            this.toolTip1.SetToolTip(this.btnExecute, resources.GetString("btnExecute.ToolTip"));
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.AccessibleDescription = null;
            this.tabPage4.AccessibleName = null;
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.BackgroundImage = null;
            this.tabPage4.Controls.Add(this.tableLayoutPanel6);
            this.tabPage4.Font = null;
            this.tabPage4.Name = "tabPage4";
            this.toolTip1.SetToolTip(this.tabPage4, resources.GetString("tabPage4.ToolTip"));
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AccessibleDescription = null;
            this.tableLayoutPanel6.AccessibleName = null;
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.BackgroundImage = null;
            this.tableLayoutPanel6.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.zedGraphControl1, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel6.Font = null;
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.toolTip1.SetToolTip(this.tableLayoutPanel6, resources.GetString("tableLayoutPanel6.ToolTip"));
            // 
            // groupBox4
            // 
            this.groupBox4.AccessibleDescription = null;
            this.groupBox4.AccessibleName = null;
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.BackgroundImage = null;
            this.groupBox4.Controls.Add(this.cblTraces);
            this.groupBox4.Font = null;
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox4, resources.GetString("groupBox4.ToolTip"));
            // 
            // cblTraces
            // 
            this.cblTraces.AccessibleDescription = null;
            this.cblTraces.AccessibleName = null;
            resources.ApplyResources(this.cblTraces, "cblTraces");
            this.cblTraces.BackgroundImage = null;
            this.cblTraces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblTraces.CheckOnClick = true;
            this.cblTraces.FormattingEnabled = true;
            this.cblTraces.Name = "cblTraces";
            this.toolTip1.SetToolTip(this.cblTraces, resources.GetString("cblTraces.ToolTip"));
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.AccessibleDescription = null;
            this.zedGraphControl1.AccessibleName = null;
            resources.ApplyResources(this.zedGraphControl1, "zedGraphControl1");
            this.zedGraphControl1.BackgroundImage = null;
            this.zedGraphControl1.Font = null;
            this.zedGraphControl1.IsAntiAlias = true;
            this.zedGraphControl1.IsAutoScrollRange = true;
            this.zedGraphControl1.IsShowHScrollBar = true;
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.tableLayoutPanel6.SetRowSpan(this.zedGraphControl1, 2);
            this.zedGraphControl1.ScrollGrace = 0;
            this.zedGraphControl1.ScrollMaxX = 0;
            this.zedGraphControl1.ScrollMaxY = 0;
            this.zedGraphControl1.ScrollMaxY2 = 0;
            this.zedGraphControl1.ScrollMinX = 0;
            this.zedGraphControl1.ScrollMinY = 0;
            this.zedGraphControl1.ScrollMinY2 = 0;
            this.toolTip1.SetToolTip(this.zedGraphControl1, resources.GetString("zedGraphControl1.ToolTip"));
            // 
            // panel6
            // 
            this.panel6.AccessibleDescription = null;
            this.panel6.AccessibleName = null;
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.BackgroundImage = null;
            this.panel6.Controls.Add(this.btnGraph);
            this.panel6.Font = null;
            this.panel6.Name = "panel6";
            this.toolTip1.SetToolTip(this.panel6, resources.GetString("panel6.ToolTip"));
            // 
            // btnGraph
            // 
            this.btnGraph.AccessibleDescription = null;
            this.btnGraph.AccessibleName = null;
            resources.ApplyResources(this.btnGraph, "btnGraph");
            this.btnGraph.BackgroundImage = null;
            this.btnGraph.Font = null;
            this.btnGraph.Name = "btnGraph";
            this.toolTip1.SetToolTip(this.btnGraph, resources.GetString("btnGraph.ToolTip"));
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.AccessibleDescription = null;
            this.tabPage5.AccessibleName = null;
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.BackgroundImage = null;
            this.tabPage5.Controls.Add(this.tableLayoutPanel8);
            this.tabPage5.Font = null;
            this.tabPage5.Name = "tabPage5";
            this.toolTip1.SetToolTip(this.tabPage5, resources.GetString("tabPage5.ToolTip"));
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.AccessibleDescription = null;
            this.tableLayoutPanel8.AccessibleName = null;
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.BackgroundImage = null;
            this.tableLayoutPanel8.Controls.Add(this.dgvAdjusts, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanel8.Font = null;
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.toolTip1.SetToolTip(this.tableLayoutPanel8, resources.GetString("tableLayoutPanel8.ToolTip"));
            // 
            // dgvAdjusts
            // 
            this.dgvAdjusts.AccessibleDescription = null;
            this.dgvAdjusts.AccessibleName = null;
            this.dgvAdjusts.AllowUserToAddRows = false;
            this.dgvAdjusts.AllowUserToDeleteRows = false;
            this.dgvAdjusts.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgvAdjusts, "dgvAdjusts");
            this.dgvAdjusts.BackgroundImage = null;
            this.dgvAdjusts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdjusts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvAdjusts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAdjusts.Font = null;
            this.dgvAdjusts.MultiSelect = false;
            this.dgvAdjusts.Name = "dgvAdjusts";
            this.dgvAdjusts.ReadOnly = true;
            this.dgvAdjusts.RowHeadersVisible = false;
            this.dgvAdjusts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.dgvAdjusts, resources.GetString("dgvAdjusts.ToolTip"));
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 65F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.FillWeight = 35F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel8
            // 
            this.panel8.AccessibleDescription = null;
            this.panel8.AccessibleName = null;
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.BackgroundImage = null;
            this.panel8.Controls.Add(this.btnAdj);
            this.panel8.Font = null;
            this.panel8.Name = "panel8";
            this.toolTip1.SetToolTip(this.panel8, resources.GetString("panel8.ToolTip"));
            // 
            // btnAdj
            // 
            this.btnAdj.AccessibleDescription = null;
            this.btnAdj.AccessibleName = null;
            resources.ApplyResources(this.btnAdj, "btnAdj");
            this.btnAdj.BackgroundImage = null;
            this.btnAdj.Font = null;
            this.btnAdj.Name = "btnAdj";
            this.toolTip1.SetToolTip(this.btnAdj, resources.GetString("btnAdj.ToolTip"));
            this.btnAdj.UseVisualStyleBackColor = true;
            this.btnAdj.Click += new System.EventHandler(this.btnAdj_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AccessibleDescription = null;
            this.tableLayoutPanel1.AccessibleName = null;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackgroundImage = null;
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Font = null;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.toolTip1.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            // 
            // statusStrip1
            // 
            this.statusStrip1.AccessibleDescription = null;
            this.statusStrip1.AccessibleName = null;
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.BackgroundImage = null;
            this.statusStrip1.Font = null;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.statusStrip1.Name = "statusStrip1";
            this.toolTip1.SetToolTip(this.statusStrip1, resources.GetString("statusStrip1.ToolTip"));
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AccessibleDescription = null;
            this.toolStripButton1.AccessibleName = null;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.BackgroundImage = null;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // bgwIsoWait
            // 
            this.bgwIsoWait.WorkerSupportsCancellation = true;
            this.bgwIsoWait.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwIsoWait_DoWork);
            this.bgwIsoWait.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwIsoWait_RunWorkerCompleted);
            // 
            // bgwParameters
            // 
            this.bgwParameters.WorkerReportsProgress = true;
            this.bgwParameters.WorkerSupportsCancellation = true;
            this.bgwParameters.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwParameters_DoWork);
            this.bgwParameters.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwParameters_RunWorkerCompleted);
            this.bgwParameters.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwParameters_ProgressChanged);
            // 
            // bgwTest
            // 
            this.bgwTest.WorkerSupportsCancellation = true;
            this.bgwTest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwTest_DoWork);
            this.bgwTest.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwTest_RunWorkerCompleted);
            // 
            // infoPanel
            // 
            this.infoPanel.AccessibleDescription = null;
            this.infoPanel.AccessibleName = null;
            resources.ApplyResources(this.infoPanel, "infoPanel");
            this.infoPanel.BackgroundImage = null;
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.infoOptions);
            this.infoPanel.Controls.Add(this.infoMessage);
            this.infoPanel.Font = null;
            this.infoPanel.Name = "infoPanel";
            this.toolTip1.SetToolTip(this.infoPanel, resources.GetString("infoPanel.ToolTip"));
            // 
            // infoOptions
            // 
            this.infoOptions.AccessibleDescription = null;
            this.infoOptions.AccessibleName = null;
            resources.ApplyResources(this.infoOptions, "infoOptions");
            this.infoOptions.Font = null;
            this.infoOptions.Name = "infoOptions";
            this.toolTip1.SetToolTip(this.infoOptions, resources.GetString("infoOptions.ToolTip"));
            // 
            // infoMessage
            // 
            this.infoMessage.AccessibleDescription = null;
            this.infoMessage.AccessibleName = null;
            resources.ApplyResources(this.infoMessage, "infoMessage");
            this.infoMessage.Name = "infoMessage";
            this.toolTip1.SetToolTip(this.infoMessage, resources.GetString("infoMessage.ToolTip"));
            // 
            // bgwDemo
            // 
            this.bgwDemo.WorkerReportsProgress = true;
            this.bgwDemo.WorkerSupportsCancellation = true;
            this.bgwDemo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDemo_DoWork);
            this.bgwDemo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDemo_RunWorkerCompleted);
            this.bgwDemo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwDemo_ProgressChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            this.toolTip1.IsBalloon = true;
            // 
            // frmMain
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = null;
            this.Name = "frmMain";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage0.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCOM)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvECU)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameters)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjusts)).EndInit();
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvParameters;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvErrors;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnConnect;
        private System.ComponentModel.BackgroundWorker bgwIsoWait;
        private System.ComponentModel.BackgroundWorker bgwParameters;
        private System.ComponentModel.BackgroundWorker bgwTest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabPage tabPage0;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCOM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvECU;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblEcuType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblRepCode;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblIsoCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn comCOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecuECU;
        private System.ComponentModel.BackgroundWorker bgwDemo;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label infoOptions;
        private System.Windows.Forms.Label infoMessage;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox cblTraces;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.CheckBox cbLOG;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.DataGridViewTextBoxColumn errDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn errReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn errState;
        private System.Windows.Forms.DataGridViewCheckBoxColumn errMIL;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox cbCompat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn parChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn parName;
        private System.Windows.Forms.DataGridViewTextBoxColumn parValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn parUnit;
        private System.Windows.Forms.TextBox tbHelp;
        private System.Windows.Forms.CheckBox cbQueryErrors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.DataGridView dgvAdjusts;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAdj;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

    }
}

