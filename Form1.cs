using System;
using System.ServiceProcess;
using System.Threading;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;


namespace UpdateOrchestratorStop
{
    public partial class Form1 : Form
    {
        String exePath = System.Reflection.Assembly.GetEntryAssembly().Location;
        ServiceInstaller SvcInstaller = new ServiceInstaller();
        String _SvcName = "UsoSvc";

        public Form1() {
            //SystemEvents.PowerModeChanged += OnPowerChange;
            InitializeComponent();
        }

        private void OnPowerChange(object s, PowerModeChangedEventArgs e) {
            switch (e.Mode) {
                case PowerModes.StatusChange:
                    break;
                case PowerModes.Resume:
                    break;
                case PowerModes.Suspend:
                    if (cb_MonitorSuspend.Checked) {
                        checkAndStopSvc(_SvcName);
                    }
                    break;
            }
        }

        public static bool serviceExists(string ServiceName) {
            return ServiceController.GetServices().Any(serviceController => serviceController.ServiceName.Equals(ServiceName));
        }

        public static String GetServiceStatus(string serviceName) {
            if (serviceExists(serviceName)) {
                ServiceController sc = new ServiceController(serviceName);

                sc.Refresh();
                switch (sc.Status) {
                    case ServiceControllerStatus.Running:
                        return "Running";
                    case ServiceControllerStatus.Stopped:
                        return "Stopped";
                    case ServiceControllerStatus.Paused:
                        return "Paused";
                    case ServiceControllerStatus.StopPending:
                        return "Stopping";
                    case ServiceControllerStatus.StartPending:
                        return "Starting";
                    default:
                        return "Status Changing";
                }
            } else {
                return "Service not installed";
            }
        }

        public static void StopService(string serviceName, int timeoutMilliseconds, Boolean bypassMsg = false) {
            if (serviceExists(serviceName)) {
                ServiceController service = new ServiceController(serviceName);
                try {
                    TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                } catch {
                    // ...
                }
            } else {
                if (!bypassMsg) {
                    MessageBox.Show("Service does not exist");
                }
            }
        }

        public static void StartService(string serviceName, int timeoutMilliseconds) {
            if (serviceExists(serviceName)) {
                ServiceController service = new ServiceController(serviceName);
                try {
                    TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                } catch {
                    // ...
                }
            } else {
                MessageBox.Show("Service does not exist");
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            tmr_stop.Enabled = false;
            if (serviceExists(_SvcName)) {
                StartService(_SvcName, 10000);
            }
        }

        private Boolean checkAndStopSvc(String svcName) {
            if (serviceExists(svcName) && GetServiceStatus(_SvcName) == "Running") {
                StopService(svcName, 10000);
            }
            return GetServiceStatus(_SvcName) == "Running";
        }

        private void timer1_Tick(object sender, EventArgs e) {
            String svcName = _SvcName;
            while (checkAndStopSvc(svcName)) {
                Thread.Sleep(500);
                checkAndStopSvc(svcName);
            };
        }

        private void btnStop_Click(object sender, EventArgs e) {
            if (cb_ToggleTimer.Checked) {
                tmr_stop.Enabled = true;
            }
            checkAndStopSvc(_SvcName);
        }

        private void button1_Click_1(object sender, EventArgs e) {

        }

        private void btn_svcInstall_Click(object sender, EventArgs e) {

        }

        private void Form1_Resize(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void cb_MonitorSuspend_CheckStateChanged(object sender, EventArgs e) {
            
        }

        private void cb_MonitorSuspend_CheckedChanged(object sender, EventArgs e) {
            if (cb_MonitorSuspend.Checked) {
                SystemEvents.PowerModeChanged -= OnPowerChange;
                SystemEvents.PowerModeChanged += OnPowerChange;
            } else {
                SystemEvents.PowerModeChanged -= OnPowerChange;
            }
        }

        private void tmr_suspendMonitor_Tick(object sender, EventArgs e) {
            if (cb_MonitorSuspend.Checked) {
                SystemEvents.PowerModeChanged -= OnPowerChange;
                SystemEvents.PowerModeChanged += OnPowerChange;
            } else {
                SystemEvents.PowerModeChanged -= OnPowerChange;
            }
        }
    }
}
