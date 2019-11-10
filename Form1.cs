using System;
using System.ServiceProcess;
using System.Threading;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

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
                    if (cb_monitorScheduledTasks.Checked) {
                        disableScheduledTasks();
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
            disableScheduledTasks();
        }

        private Boolean checkAndStopSvc(String svcName) {
            if (serviceExists(svcName) && GetServiceStatus(_SvcName) == "Running") {
                StopService(svcName, 10000);
            }
            return GetServiceStatus(_SvcName) == "Running";
        }

        private void disableScheduledTasks() {
            // psexec.exe -i -s "%SystemRoot%\system32\WindowsPowerShell\v1.0\powershell.exe" "Get-ScheduledTask -TaskPath "\Microsoft\Windows\UpdateOrchestrator\" | Disable-ScheduledTask"
            String args = "-i -s '%SystemRoot%\\system32\\WindowsPowerShell\\v1.0\\powershell.exe' 'Get-ScheduledTask -TaskPath '\\Microsoft\\Windows\\UpdateOrchestrator\\' | Disable-ScheduledTask'";
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "psexec.exe";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.RedirectStandardInput = true;
            psi.Arguments = args;
            Process proc = Process.Start(psi);
            //System.Diagnostics.Process.Start("psexec.exe", args);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            String svcName = _SvcName;
            while (checkAndStopSvc(svcName)) {
                Thread.Sleep(500);
                checkAndStopSvc(svcName);
            };
            disableScheduledTasks();
        }

        private void btnStop_Click(object sender, EventArgs e) {
            if (cb_ToggleTimer.Checked) {
                tmr_stop.Enabled = true;
            }
            checkAndStopSvc(_SvcName);
            disableScheduledTasks();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/ChronSyn/UpdateOrchestratorStop");
        }

        private void btn_disclaimer_Click(object sender, EventArgs e) {
            MessageBox.Show(
                "BY USING, DOWNLOADING, INSTALLING, COMPILING, DECOMPILING, COPYING, REVERSE ENGINEERING, MODIFYING, EXECUTING OR TRANSFERRING THIS SOFTWARE, YOU AGREE TO THE FOLLOWING DISCLAIMER. IF YOU DO NOT AGREE, YOU MUST CEASE ALL CURRENT AND FUTURE USAGE OF THIS SOFTWARE PRODUCT IMMEDIATELY UNTIL YOU DO AGREE TO THESE TERMS.\n\n\n" +


                "The use of this software is done at your own discretion and risk and with agreement that you will be solely responsible for any damage to your computer system or loss of data that results from such activities.You are solely responsible for adequate protection and backup of the data and equipment used in connection with any of the software linked to this project, and we will not be liable for any damages that you may suffer connection with downloading, installing, using, modifying or distributing such software. No advice or information, whether oral or written, obtained by you from us or from the project or other website shall create any warranty for the software.\n\n\n" +
                

                "Additionally, we make no warranty that:\n\n" +
                " - The software will meet your requirements.\n" +
                " - The software will be uninterrupted, timely, secure or error - free.\n" +
                " - The results from the use of the software will be effective, accurate or reliable.\n" +
                " - The quality of the software will meet your expectations.\n\n\n" +
                
                
                " The links to software, websites or other materials, and the related documentation made available in this product are subject to the following conditions:\n\n" +
                " - The software could include technical or other mistakes, inaccuracies or typographical errors.\n" +
                " - The software may be out of date, and we make no commitment to update such materials.\n" +
                " - We assume no responsibility for errors or omissions in the software or documentation available from this software. In no event shall we be liable to you or any third parties for any special, punitive, incidental, indirect or consequential damages of any kind, or any damages whatsoever, including, without limitation, those resulting from loss of use, lost data or profits, or any liability, arising out of or in connection with the use of this software or any material linked to from this software.");
        }
    }
}
