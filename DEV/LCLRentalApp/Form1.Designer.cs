namespace LCLRentalApp
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
            this.grdJobSchedule = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unConfirmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grvwJobSchedule = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmdPullTerminalFiles = new DevExpress.XtraEditors.SimpleButton();
            this.cmdPullSoftware = new DevExpress.XtraEditors.SimpleButton();
            this.cmdLaunchWISDOM = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSendFilesToLCL = new DevExpress.XtraEditors.SimpleButton();
            this.cmdWrapUp = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cmdPostTagRange = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdJobSchedule)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvwJobSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdJobSchedule
            // 
            this.grdJobSchedule.ContextMenuStrip = this.contextMenuStrip1;
            this.grdJobSchedule.Location = new System.Drawing.Point(12, 12);
            this.grdJobSchedule.MainView = this.grvwJobSchedule;
            this.grdJobSchedule.Name = "grdJobSchedule";
            this.grdJobSchedule.Size = new System.Drawing.Size(1179, 327);
            this.grdJobSchedule.TabIndex = 0;
            this.grdJobSchedule.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvwJobSchedule});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectStoreToolStripMenuItem,
            this.unConfirmToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 70);
            this.contextMenuStrip1.Text = "Select Store";
            // 
            // selectStoreToolStripMenuItem
            // 
            this.selectStoreToolStripMenuItem.Name = "selectStoreToolStripMenuItem";
            this.selectStoreToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.selectStoreToolStripMenuItem.Text = "Select Store";
            this.selectStoreToolStripMenuItem.Click += new System.EventHandler(this.selectStoreToolStripMenuItem_Click);
            // 
            // unConfirmToolStripMenuItem
            // 
            this.unConfirmToolStripMenuItem.Name = "unConfirmToolStripMenuItem";
            this.unConfirmToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.unConfirmToolStripMenuItem.Text = "Un-Confirm ";
            this.unConfirmToolStripMenuItem.Click += new System.EventHandler(this.unConfirmToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // grvwJobSchedule
            // 
            this.grvwJobSchedule.GridControl = this.grdJobSchedule;
            this.grvwJobSchedule.Name = "grvwJobSchedule";
            this.grvwJobSchedule.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvwJobSchedule.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvwJobSchedule.OptionsBehavior.Editable = false;
            this.grvwJobSchedule.OptionsBehavior.ReadOnly = true;
            this.grvwJobSchedule.OptionsMenu.EnableGroupPanelMenu = false;
            this.grvwJobSchedule.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            this.grvwJobSchedule.OptionsView.ShowGroupPanel = false;
            // 
            // cmdPullTerminalFiles
            // 
            this.cmdPullTerminalFiles.Location = new System.Drawing.Point(434, 363);
            this.cmdPullTerminalFiles.Name = "cmdPullTerminalFiles";
            this.cmdPullTerminalFiles.Size = new System.Drawing.Size(163, 23);
            this.cmdPullTerminalFiles.TabIndex = 1;
            this.cmdPullTerminalFiles.Text = "Pull Terminal Files";
            this.cmdPullTerminalFiles.Click += new System.EventHandler(this.cmdPullTerminalFiles_Click);
            // 
            // cmdPullSoftware
            // 
            this.cmdPullSoftware.Location = new System.Drawing.Point(434, 426);
            this.cmdPullSoftware.Name = "cmdPullSoftware";
            this.cmdPullSoftware.Size = new System.Drawing.Size(163, 23);
            this.cmdPullSoftware.TabIndex = 2;
            this.cmdPullSoftware.Text = "Pull Software";
            this.cmdPullSoftware.Click += new System.EventHandler(this.cmdPullSoftware_Click);
            // 
            // cmdLaunchWISDOM
            // 
            this.cmdLaunchWISDOM.Location = new System.Drawing.Point(714, 363);
            this.cmdLaunchWISDOM.Name = "cmdLaunchWISDOM";
            this.cmdLaunchWISDOM.Size = new System.Drawing.Size(150, 23);
            this.cmdLaunchWISDOM.TabIndex = 3;
            this.cmdLaunchWISDOM.Text = "Launch WISDOM";
            this.cmdLaunchWISDOM.Click += new System.EventHandler(this.cmdLaunchWISDOM_Click);
            // 
            // cmdSendFilesToLCL
            // 
            this.cmdSendFilesToLCL.Location = new System.Drawing.Point(714, 426);
            this.cmdSendFilesToLCL.Name = "cmdSendFilesToLCL";
            this.cmdSendFilesToLCL.Size = new System.Drawing.Size(150, 23);
            this.cmdSendFilesToLCL.TabIndex = 4;
            this.cmdSendFilesToLCL.Text = "Send Files To LCL";
            this.cmdSendFilesToLCL.Click += new System.EventHandler(this.cmdSendFilesToLCL_Click);
            // 
            // cmdWrapUp
            // 
            this.cmdWrapUp.Location = new System.Drawing.Point(1023, 363);
            this.cmdWrapUp.Name = "cmdWrapUp";
            this.cmdWrapUp.Size = new System.Drawing.Size(168, 23);
            this.cmdWrapUp.TabIndex = 5;
            this.cmdWrapUp.Text = "Post Pre-Count File";
            this.cmdWrapUp.Click += new System.EventHandler(this.cmdWrapUp_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(26, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Job No:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl2.Location = new System.Drawing.Point(126, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 13);
            this.labelControl2.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(26, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Software ID:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl4.Location = new System.Drawing.Point(126, 53);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(0, 13);
            this.labelControl4.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(27, 88);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Include ID:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl6.Location = new System.Drawing.Point(126, 88);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(0, 13);
            this.labelControl6.TabIndex = 11;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl17);
            this.groupControl1.Controls.Add(this.labelControl16);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Location = new System.Drawing.Point(13, 345);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(333, 239);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Step 1: Select Store";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Location = new System.Drawing.Point(27, 203);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(84, 13);
            this.labelControl17.TabIndex = 17;
            this.labelControl17.Text = "DLPM Phone #:";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl16.Location = new System.Drawing.Point(126, 203);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(0, 13);
            this.labelControl16.TabIndex = 16;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Location = new System.Drawing.Point(26, 167);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(67, 13);
            this.labelControl15.TabIndex = 15;
            this.labelControl15.Text = "DLPM Email:";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl14.Location = new System.Drawing.Point(126, 167);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(0, 13);
            this.labelControl14.TabIndex = 14;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(27, 119);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(51, 13);
            this.labelControl13.TabIndex = 13;
            this.labelControl13.Text = "Store No:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl12.Location = new System.Drawing.Point(126, 119);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(0, 13);
            this.labelControl12.TabIndex = 12;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(365, 373);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(39, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Step 2:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(365, 436);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(39, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Step 3:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(646, 373);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(39, 13);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "Step 4:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(646, 436);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(39, 13);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "Step 5:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(949, 373);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(39, 13);
            this.labelControl11.TabIndex = 17;
            this.labelControl11.Text = "Step 6:";
            // 
            // cmdPostTagRange
            // 
            this.cmdPostTagRange.Location = new System.Drawing.Point(1023, 426);
            this.cmdPostTagRange.Name = "cmdPostTagRange";
            this.cmdPostTagRange.Size = new System.Drawing.Size(168, 23);
            this.cmdPostTagRange.TabIndex = 18;
            this.cmdPostTagRange.Text = "Post Tag Range File";
            this.cmdPostTagRange.Click += new System.EventHandler(this.cmdPostTagRange_Click);
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Location = new System.Drawing.Point(949, 436);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(39, 13);
            this.labelControl18.TabIndex = 19;
            this.labelControl18.Text = "Step 7:";
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelControl19.Location = new System.Drawing.Point(365, 479);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(32, 13);
            this.labelControl19.TabIndex = 20;
            this.labelControl19.Text = "Notes";
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl20.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl20.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl20.Location = new System.Drawing.Point(365, 499);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(0, 0);
            this.labelControl20.TabIndex = 21;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 596);
            this.Controls.Add(this.labelControl20);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.labelControl18);
            this.Controls.Add(this.cmdPostTagRange);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cmdWrapUp);
            this.Controls.Add(this.cmdSendFilesToLCL);
            this.Controls.Add(this.cmdLaunchWISDOM);
            this.Controls.Add(this.cmdPullSoftware);
            this.Controls.Add(this.cmdPullTerminalFiles);
            this.Controls.Add(this.grdJobSchedule);
            this.Name = "frmMain";
            this.Text = "LCL Rental App";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdJobSchedule)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvwJobSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdJobSchedule;
        private DevExpress.XtraGrid.Views.Grid.GridView grvwJobSchedule;
        private DevExpress.XtraEditors.SimpleButton cmdPullTerminalFiles;
        private DevExpress.XtraEditors.SimpleButton cmdPullSoftware;
        private DevExpress.XtraEditors.SimpleButton cmdLaunchWISDOM;
        private DevExpress.XtraEditors.SimpleButton cmdSendFilesToLCL;
        private DevExpress.XtraEditors.SimpleButton cmdWrapUp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectStoreToolStripMenuItem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.ToolStripMenuItem unConfirmToolStripMenuItem;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton cmdPostTagRange;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl20;
    }
}

