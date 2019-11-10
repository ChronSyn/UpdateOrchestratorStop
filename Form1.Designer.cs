namespace UpdateOrchestratorStop
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tmr_stop = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cb_ToggleTimer = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_MonitorSuspend = new System.Windows.Forms.CheckBox();
            this.tmr_suspendMonitor = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_disclaimer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_monitorScheduledTasks = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(7, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 73);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start UpdateOrchestrator";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(148, 8);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(125, 73);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop UpdateOrchestrator";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tmr_stop
            // 
            this.tmr_stop.Interval = 15000;
            this.tmr_stop.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "UODisabler";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // cb_ToggleTimer
            // 
            this.cb_ToggleTimer.AutoSize = true;
            this.cb_ToggleTimer.Checked = true;
            this.cb_ToggleTimer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ToggleTimer.Location = new System.Drawing.Point(7, 100);
            this.cb_ToggleTimer.Name = "cb_ToggleTimer";
            this.cb_ToggleTimer.Size = new System.Drawing.Size(100, 17);
            this.cb_ToggleTimer.TabIndex = 2;
            this.cb_ToggleTimer.Text = "Monitor Service";
            this.cb_ToggleTimer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "If checked, this app will continually attempt to stop the\r\nservice automatically." +
    " However, this monitoring will\r\nonly begin once you click the Stop button.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 52);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // cb_MonitorSuspend
            // 
            this.cb_MonitorSuspend.AutoSize = true;
            this.cb_MonitorSuspend.Checked = true;
            this.cb_MonitorSuspend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_MonitorSuspend.Location = new System.Drawing.Point(7, 292);
            this.cb_MonitorSuspend.Name = "cb_MonitorSuspend";
            this.cb_MonitorSuspend.Size = new System.Drawing.Size(118, 17);
            this.cb_MonitorSuspend.TabIndex = 5;
            this.cb_MonitorSuspend.Text = "Watch for Suspend";
            this.cb_MonitorSuspend.UseVisualStyleBackColor = true;
            this.cb_MonitorSuspend.CheckedChanged += new System.EventHandler(this.cb_MonitorSuspend_CheckedChanged);
            this.cb_MonitorSuspend.CheckStateChanged += new System.EventHandler(this.cb_MonitorSuspend_CheckStateChanged);
            // 
            // tmr_suspendMonitor
            // 
            this.tmr_suspendMonitor.Enabled = true;
            this.tmr_suspendMonitor.Interval = 250;
            this.tmr_suspendMonitor.Tick += new System.EventHandler(this.tmr_suspendMonitor_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(7, 514);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(266, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/ChronSyn/UpdateOrchestratorStop";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_disclaimer
            // 
            this.btn_disclaimer.Location = new System.Drawing.Point(7, 395);
            this.btn_disclaimer.Name = "btn_disclaimer";
            this.btn_disclaimer.Size = new System.Drawing.Size(271, 108);
            this.btn_disclaimer.TabIndex = 9;
            this.btn_disclaimer.Text = "Disclaimer\r\n\r\n(You agree to this if using, downloading, installing, compiling, de" +
    "compiling, reverse engineering, modifying, editing, copying or transferring this" +
    " software)";
            this.btn_disclaimer.UseVisualStyleBackColor = true;
            this.btn_disclaimer.Click += new System.EventHandler(this.btn_disclaimer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 52);
            this.label2.TabIndex = 11;
            this.label2.Text = "If checked, this app will continually attempt to disable\r\nall updateOrchestrator " +
    "scheduled tasks. However,\r\nthis monitoring will only begin once you click the\r\nS" +
    "top button.";
            // 
            // cb_monitorScheduledTasks
            // 
            this.cb_monitorScheduledTasks.AutoSize = true;
            this.cb_monitorScheduledTasks.Checked = true;
            this.cb_monitorScheduledTasks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_monitorScheduledTasks.Location = new System.Drawing.Point(7, 187);
            this.cb_monitorScheduledTasks.Name = "cb_monitorScheduledTasks";
            this.cb_monitorScheduledTasks.Size = new System.Drawing.Size(147, 17);
            this.cb_monitorScheduledTasks.TabIndex = 10;
            this.cb_monitorScheduledTasks.Text = "Monitor Scheduled Tasks";
            this.cb_monitorScheduledTasks.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_monitorScheduledTasks);
            this.Controls.Add(this.btn_disclaimer);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_MonitorSuspend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_ToggleTimer);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "UODisabler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer tmr_stop;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox cb_ToggleTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_MonitorSuspend;
        private System.Windows.Forms.Timer tmr_suspendMonitor;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_disclaimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_monitorScheduledTasks;
    }
}

