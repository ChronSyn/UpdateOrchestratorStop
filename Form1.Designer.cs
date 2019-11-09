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
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 73);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start UpdateOrchestrator";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(153, 8);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(125, 73);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop UpdateOrchestrator";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tmr_stop
            // 
            this.tmr_stop.Interval = 2500;
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
            this.cb_ToggleTimer.Location = new System.Drawing.Point(12, 100);
            this.cb_ToggleTimer.Name = "cb_ToggleTimer";
            this.cb_ToggleTimer.Size = new System.Drawing.Size(88, 17);
            this.cb_ToggleTimer.TabIndex = 2;
            this.cb_ToggleTimer.Text = "Enable Timer";
            this.cb_ToggleTimer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "If checked, the timer will attempt stop the service every 2\r\nminutes. This will o" +
    "nly activate after clicking the Stop\r\nbutton.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 52);
            this.label3.TabIndex = 6;
            this.label3.Text = "If you watch for suspend, this app will attempt to stop the\r\nservice just before " +
    "Windows suspends. This event\r\nlistener will be active or disabled as soon as you" +
    " check\r\nor uncheck this checkbox.";
            // 
            // cb_MonitorSuspend
            // 
            this.cb_MonitorSuspend.AutoSize = true;
            this.cb_MonitorSuspend.Checked = true;
            this.cb_MonitorSuspend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_MonitorSuspend.Location = new System.Drawing.Point(12, 178);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 266);
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
    }
}

