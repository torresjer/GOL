
namespace GOLStartUpTemplate_Lecture_examples
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridVeiwMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NeighborCountVeiwStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.FiniteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToroidalViewStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromCurrentSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartGenerations = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.StopGenerations = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeIntervalStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusAliveCells = new System.Windows.Forms.ToolStripStatusLabel();
            this.DeadCellsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentSeedStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.UniverseWidthandHeightStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resizeUniverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeByTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeBySeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsPanel1 = new GOLStartUpTemplate_Lecture_examples.GraphicsPanel();
            this.menuStrip1.SuspendLayout();
            this.StartGenerations.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ViewToolStripMenuItem,
            this.randomizeCellsToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(220, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GridVeiwMenuItem,
            this.NeighborCountVeiwStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.FiniteToolStripMenuItem,
            this.ToroidalViewStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.ViewToolStripMenuItem.Text = "&View";
            // 
            // GridVeiwMenuItem
            // 
            this.GridVeiwMenuItem.Checked = true;
            this.GridVeiwMenuItem.CheckOnClick = true;
            this.GridVeiwMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GridVeiwMenuItem.Name = "GridVeiwMenuItem";
            this.GridVeiwMenuItem.Size = new System.Drawing.Size(270, 34);
            this.GridVeiwMenuItem.Text = "&Grid";
            this.GridVeiwMenuItem.CheckStateChanged += new System.EventHandler(this.GridVeiwMenuItem_CheckStateChanged);
            // 
            // NeighborCountVeiwStripMenuItem
            // 
            this.NeighborCountVeiwStripMenuItem.Checked = true;
            this.NeighborCountVeiwStripMenuItem.CheckOnClick = true;
            this.NeighborCountVeiwStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NeighborCountVeiwStripMenuItem.Name = "NeighborCountVeiwStripMenuItem";
            this.NeighborCountVeiwStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.NeighborCountVeiwStripMenuItem.Text = "&Neighbor Count";
            this.NeighborCountVeiwStripMenuItem.CheckStateChanged += new System.EventHandler(this.NeighborCountVeiwStripMenuItem_CheckStateChanged);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.searchToolStripMenuItem.Text = "&Graphics Panel";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(267, 6);
            // 
            // FiniteToolStripMenuItem
            // 
            this.FiniteToolStripMenuItem.Checked = true;
            this.FiniteToolStripMenuItem.CheckOnClick = true;
            this.FiniteToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FiniteToolStripMenuItem.Name = "FiniteToolStripMenuItem";
            this.FiniteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.FiniteToolStripMenuItem.Text = "&Finite";
            this.FiniteToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.FiniteToolStripMenuItem_CheckStateChanged);
            // 
            // ToroidalViewStripMenuItem
            // 
            this.ToroidalViewStripMenuItem.CheckOnClick = true;
            this.ToroidalViewStripMenuItem.Name = "ToroidalViewStripMenuItem";
            this.ToroidalViewStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ToroidalViewStripMenuItem.Text = "&Toroidal";
            this.ToroidalViewStripMenuItem.CheckStateChanged += new System.EventHandler(this.ToroidalViewStripMenuItem_CheckStateChanged);
            // 
            // randomizeCellsToolStripMenuItem
            // 
            this.randomizeCellsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeToolStripMenuItem,
            this.fromCurrentSeedToolStripMenuItem,
            this.seedToolStripMenuItem});
            this.randomizeCellsToolStripMenuItem.Name = "randomizeCellsToolStripMenuItem";
            this.randomizeCellsToolStripMenuItem.Size = new System.Drawing.Size(158, 29);
            this.randomizeCellsToolStripMenuItem.Text = "&Randomize Cells";
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.timeToolStripMenuItem.Text = "From Time";
            this.timeToolStripMenuItem.Click += new System.EventHandler(this.timeToolStripMenuItem_Click);
            // 
            // fromCurrentSeedToolStripMenuItem
            // 
            this.fromCurrentSeedToolStripMenuItem.Name = "fromCurrentSeedToolStripMenuItem";
            this.fromCurrentSeedToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.fromCurrentSeedToolStripMenuItem.Text = "From Current Seed";
            this.fromCurrentSeedToolStripMenuItem.Click += new System.EventHandler(this.fromCurrentSeedToolStripMenuItem_Click);
            // 
            // seedToolStripMenuItem
            // 
            this.seedToolStripMenuItem.Name = "seedToolStripMenuItem";
            this.seedToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.seedToolStripMenuItem.Text = "From Seed";
            this.seedToolStripMenuItem.Click += new System.EventHandler(this.seedToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.gridColorToolStripMenuItem,
            this.cellColorToolStripMenuItem,
            this.gridColorToolStripMenuItem1,
            this.resetToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(164, 29);
            this.toolsToolStripMenuItem.Text = "&Universe Settings";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.customizeToolStripMenuItem.Text = "&Options";
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // gridColorToolStripMenuItem
            // 
            this.gridColorToolStripMenuItem.Name = "gridColorToolStripMenuItem";
            this.gridColorToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.gridColorToolStripMenuItem.Text = "&BackGround Color";
            this.gridColorToolStripMenuItem.Click += new System.EventHandler(this.BackGroundColorToolStripMenuItem_Click);
            // 
            // cellColorToolStripMenuItem
            // 
            this.cellColorToolStripMenuItem.Name = "cellColorToolStripMenuItem";
            this.cellColorToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.cellColorToolStripMenuItem.Text = "&Cell Color";
            this.cellColorToolStripMenuItem.Click += new System.EventHandler(this.cellColorToolStripMenuItem_Click);
            // 
            // gridColorToolStripMenuItem1
            // 
            this.gridColorToolStripMenuItem1.Name = "gridColorToolStripMenuItem1";
            this.gridColorToolStripMenuItem1.Size = new System.Drawing.Size(258, 34);
            this.gridColorToolStripMenuItem1.Text = "&Grid Color";
            this.gridColorToolStripMenuItem1.Click += new System.EventHandler(this.gridColorToolStripMenuItem1_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.resetToolStripMenuItem.Text = "&Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.reloadToolStripMenuItem.Text = "&Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // StartGenerations
            // 
            this.StartGenerations.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StartGenerations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.toolStripButton1,
            this.StopGenerations,
            this.toolStripButton2,
            this.toolStripSeparator7});
            this.StartGenerations.Location = new System.Drawing.Point(0, 33);
            this.StartGenerations.Name = "StartGenerations";
            this.StartGenerations.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.StartGenerations.Size = new System.Drawing.Size(1190, 33);
            this.StartGenerations.TabIndex = 1;
            this.StartGenerations.Text = "Start Generations";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::GOLStartUpTemplate_Lecture_examples.Properties.Resources.StartButton;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "Start Generations";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // StopGenerations
            // 
            this.StopGenerations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StopGenerations.Image = global::GOLStartUpTemplate_Lecture_examples.Properties.Resources.StopButton;
            this.StopGenerations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopGenerations.Name = "StopGenerations";
            this.StopGenerations.Size = new System.Drawing.Size(34, 28);
            this.StopGenerations.Text = "Stop Generations";
            this.StopGenerations.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::GOLStartUpTemplate_Lecture_examples.Properties.Resources.Next_button;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 33);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGenerations,
            this.TimeIntervalStatusLabel1,
            this.toolStripStatusAliveCells,
            this.DeadCellsStatusLabel,
            this.CurrentSeedStatusLabel1,
            this.UniverseWidthandHeightStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1190, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelGenerations
            // 
            this.toolStripStatusLabelGenerations.Name = "toolStripStatusLabelGenerations";
            this.toolStripStatusLabelGenerations.Size = new System.Drawing.Size(138, 25);
            this.toolStripStatusLabelGenerations.Text = "Generations = 0";
            // 
            // TimeIntervalStatusLabel1
            // 
            this.TimeIntervalStatusLabel1.Name = "TimeIntervalStatusLabel1";
            this.TimeIntervalStatusLabel1.Size = new System.Drawing.Size(145, 25);
            this.TimeIntervalStatusLabel1.Text = "Time Interval = 0";
            // 
            // toolStripStatusAliveCells
            // 
            this.toolStripStatusAliveCells.Name = "toolStripStatusAliveCells";
            this.toolStripStatusAliveCells.Size = new System.Drawing.Size(123, 25);
            this.toolStripStatusAliveCells.Text = "Alive Cells = 0";
            // 
            // DeadCellsStatusLabel
            // 
            this.DeadCellsStatusLabel.Name = "DeadCellsStatusLabel";
            this.DeadCellsStatusLabel.Size = new System.Drawing.Size(127, 25);
            this.DeadCellsStatusLabel.Text = "Dead Cells = 0";
            // 
            // CurrentSeedStatusLabel1
            // 
            this.CurrentSeedStatusLabel1.Name = "CurrentSeedStatusLabel1";
            this.CurrentSeedStatusLabel1.Size = new System.Drawing.Size(146, 25);
            this.CurrentSeedStatusLabel1.Text = "Current Seed = 0";
            // 
            // UniverseWidthandHeightStatusLabel1
            // 
            this.UniverseWidthandHeightStatusLabel1.Name = "UniverseWidthandHeightStatusLabel1";
            this.UniverseWidthandHeightStatusLabel1.Size = new System.Drawing.Size(322, 25);
            this.UniverseWidthandHeightStatusLabel1.Text = "Universe Size (width x height) = 10 x 10";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeUniverseToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.cellColorToolStripMenuItem1,
            this.gridColorToolStripMenuItem2,
            this.randomizeByTimeToolStripMenuItem,
            this.randomizeBySeedToolStripMenuItem,
            this.saveToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(243, 228);
            // 
            // resizeUniverseToolStripMenuItem
            // 
            this.resizeUniverseToolStripMenuItem.Name = "resizeUniverseToolStripMenuItem";
            this.resizeUniverseToolStripMenuItem.Size = new System.Drawing.Size(242, 32);
            this.resizeUniverseToolStripMenuItem.Text = "&Universe Options";
            this.resizeUniverseToolStripMenuItem.Click += new System.EventHandler(this.resizeUniverseToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(242, 32);
            this.colorToolStripMenuItem.Text = "&BackGround Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // cellColorToolStripMenuItem1
            // 
            this.cellColorToolStripMenuItem1.Name = "cellColorToolStripMenuItem1";
            this.cellColorToolStripMenuItem1.Size = new System.Drawing.Size(242, 32);
            this.cellColorToolStripMenuItem1.Text = "&Cell Color";
            this.cellColorToolStripMenuItem1.Click += new System.EventHandler(this.cellColorToolStripMenuItem1_Click);
            // 
            // gridColorToolStripMenuItem2
            // 
            this.gridColorToolStripMenuItem2.Name = "gridColorToolStripMenuItem2";
            this.gridColorToolStripMenuItem2.Size = new System.Drawing.Size(242, 32);
            this.gridColorToolStripMenuItem2.Text = "&Grid Color";
            this.gridColorToolStripMenuItem2.Click += new System.EventHandler(this.gridColorToolStripMenuItem2_Click);
            // 
            // randomizeByTimeToolStripMenuItem
            // 
            this.randomizeByTimeToolStripMenuItem.Name = "randomizeByTimeToolStripMenuItem";
            this.randomizeByTimeToolStripMenuItem.Size = new System.Drawing.Size(242, 32);
            this.randomizeByTimeToolStripMenuItem.Text = "&Randomize by Time";
            this.randomizeByTimeToolStripMenuItem.Click += new System.EventHandler(this.randomizeByTimeToolStripMenuItem_Click);
            // 
            // randomizeBySeedToolStripMenuItem
            // 
            this.randomizeBySeedToolStripMenuItem.Name = "randomizeBySeedToolStripMenuItem";
            this.randomizeBySeedToolStripMenuItem.Size = new System.Drawing.Size(242, 32);
            this.randomizeBySeedToolStripMenuItem.Text = "&Randomize by Seed";
            this.randomizeBySeedToolStripMenuItem.Click += new System.EventHandler(this.randomizeBySeedToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(242, 32);
            this.saveToolStripMenuItem1.Text = "&Save";
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel1.ContextMenuStrip = this.contextMenuStrip1;
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 66);
            this.graphicsPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(1190, 642);
            this.graphicsPanel1.TabIndex = 3;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 740);
            this.Controls.Add(this.graphicsPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.StartGenerations);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Game of Life";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StartGenerations.ResumeLayout(false);
            this.StartGenerations.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip StartGenerations;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GridVeiwMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NeighborCountVeiwStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem FiniteToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton StopGenerations;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeUniverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusAliveCells;
        private System.Windows.Forms.ToolStripMenuItem ToroidalViewStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromCurrentSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel TimeIntervalStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel DeadCellsStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel CurrentSeedStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel UniverseWidthandHeightStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem cellColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gridColorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem randomizeByTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeBySeedToolStripMenuItem;
    }
}

