using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string resourseGroupName = "";
        string machineName = "";
        public Form1()
        {
            resourseGroupName = "";
            machineName = "";
            InitializeComponent();
        }

        private string RunCommand(string cmdLine)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine(cmdLine);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            return cmd.StandardOutput.ReadToEnd().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cmd = "az vm show -g {0} -n {1} -d";
            var response = RunCommand(string.Format(cmd, resourseGroupName, machineName));
            var statusIndex = response.IndexOf("\"powerState\": \"");
            var statusString = response.Substring(statusIndex + 15);
            var status = statusString.Substring(0, statusString.IndexOf("\""));

            MessageBox.Show(status);
        }

        private void btnStartVM_Click(object sender, EventArgs e)
        {
            var cmd = "az vm start -g {0} -n {1}";
            var response = RunCommand(string.Format(cmd, resourseGroupName, machineName));

            MessageBox.Show("Machine Started :" + response);
        }

        private void btnStopMachine_Click(object sender, EventArgs e)
        {
            var cmd = "az vm stop -g {0} -n {1}";
            var response = RunCommand(string.Format(cmd, resourseGroupName, machineName));
            MessageBox.Show("Machine Stopped :" + response);
        }

        private void btnGetIpAddress_Click(object sender, EventArgs e)
        {
            var cmd = "az vm show -g {0} -n {1} -d";
            var response = RunCommand(string.Format(cmd, resourseGroupName, machineName));
            var statusIndex = response.IndexOf("\"publicIps\": \"");
            var statusString = response.Substring(statusIndex + 14);
            var status = statusString.Substring(0, statusString.IndexOf("\""));

            MessageBox.Show(status);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cmd = "az vm list -g {0} --query \"[].{ Name: name }\"";
            var response = RunCommand(string.Format(cmd, resourseGroupName, machineName));

            try
            {
                var Machines = new List<string>();
                var machineIndex = response.IndexOf("\"Name\": \"");
                while (machineIndex >= 0)
                {
                    var getStrMachineName = response.Substring(machineIndex + 9);
                    var machineName = getStrMachineName.Substring(0, getStrMachineName.IndexOf("\""));
                    Machines.Add(machineName);
                    response = response.Substring(response.IndexOf(machineName));
                    machineIndex = response.IndexOf("\"Name\": \"");
                }

                MessageBox.Show("The available Name of VMs is : " + string.Join(", ", Machines));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error coming while handling the list response: "+ ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var cmd = "az vm deallocate -g {0} -n {1}";
            var response = RunCommand(string.Format(cmd, resourseGroupName, machineName));
            MessageBox.Show("Machine Deallocated :" + response);
        }
    }
}
